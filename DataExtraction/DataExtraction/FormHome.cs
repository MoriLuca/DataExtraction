using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataExtraction
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            CaricaDB();
        }

        private void CaricaDB()
        {
            try
            {
                //aprire connessione 
                //aggiungere la lista dei database
                //visualizzare i nomi,
                //selezionare id del database
                //chiudere connessione

                using (SqlConnection connection = new SqlConnection(ConnectionInfo.MasterDBConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter("EXEC sp_databases;", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    listBoxElencoDataBase.DisplayMember = "DATABASE_NAME";
                    listBoxElencoDataBase.ValueMember = "DATABASE_NAME";
                    listBoxElencoDataBase.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxElencoDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {

            #region  Scrittura Tavole
            try
            {
                //aprire connessione 
                //aggiungere la lista dei database
                //visualizzare i nomi,
                //selezionare id del database
                //chiudere connessione
                string dbName = listBoxElencoDataBase.SelectedValue.ToString();
                using (SqlConnection connection = new SqlConnection(ConnectionInfo.ConnectToSelectedDB(dbName)))
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT COLUMN_NAME,DATA_TYPE from [{dbName}].[INFORMATION_SCHEMA].[TABLES]", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    listBoxTavole.DisplayMember = "TABLE_NAME";
                    listBoxTavole.ValueMember = "TABLE_NAME";
                    listBoxTavole.DataSource = table;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion



            #region  Scrittura Colonne
            //try
            //{
            //    //aprire connessione 
            //    //aggiungere la lista dei database
            //    //visualizzare i nomi,
            //    //selezionare id del database
            //    //chiudere connessione
            //    string dbName = listBoxElencoDataBase.SelectedValue.ToString();
            //    using (SqlConnection connection = new SqlConnection(ConnectionInfo.ConnectToSelectedDB(dbName)))
            //    using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT COLUMN_NAME,DATA_TYPE from [{dbName}].[INFORMATION_SCHEMA].[COLUMNS]", connection))
            //    {
            //        DataTable table = new DataTable();
            //        adapter.Fill(table);
            //        listBoxColonne.DisplayMember = "COLUMN_NAME";
            //        listBoxColonne.ValueMember = "COLUMN_NAME";
            //        listBoxColonne.DataSource = table;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //} 
            #endregion




            ////inserire le ultime 100 righe
            //try
            //{
            //    //aprire connessione 
            //    //aggiungere la lista dei database
            //    //visualizzare i nomi,
            //    //selezionare id del database
            //    //chiudere connessione
            //    string dbName = listBoxElencoDataBase.SelectedValue.ToString();
            //    using (SqlConnection connection = new SqlConnection(ConnectionInfo.ConnectToSelectedDB(dbName)))
            //    using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT TOP 10 * from [{dbName}] ORDER BY LocalCol DESC", connection))
            //    {
            //        DataTable table = new DataTable();
            //        adapter.Fill(table);
            //        dataGridViewRisultatoRicerca.DataSource = table;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void listBoxColonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region ScriveCommentoColonnaNelBox

            try
            {
                //aprire connessione 
                //aggiungere la lista dei database
                //visualizzare i nomi,
                //selezionare id del database
                //chiudere connessione
                string dbName = listBoxElencoDataBase.SelectedValue.ToString();
                string columnName = listBoxColonne.SelectedValue.ToString();

                using (SqlConnection connection = new SqlConnection(ConnectionInfo.ConnectToSelectedDB(dbName)))
                using (SqlCommand command = new SqlCommand(QueryCollection.getColumnDescription(dbName, columnName), connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            richTextBoxCommentoColonna.Text = reader["Description"].ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            #region Popola la tabella

            //try
            //{
            //    //aprire connessione 
            //    //aggiungere la lista dei database
            //    //visualizzare i nomi,
            //    //selezionare id del database
            //    //chiudere connessione
            //    string dbName = listBoxElencoDataBase.SelectedValue.ToString();
            //    using (SqlConnection connection = new SqlConnection(ConnectionInfo.ConnectToSelectedDB(dbName)))
            //    using (SqlDataAdapter adapter = new SqlDataAdapter(, connection))
            //    {
            //        DataTable table = new DataTable();
            //        adapter.Fill(table);
            //        listBoxColonne.DisplayMember = "COLUMN_NAME";
            //        listBoxColonne.ValueMember = "COLUMN_NAME";
            //        listBoxColonne.DataSource = table;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            #endregion
        }
    }
}
