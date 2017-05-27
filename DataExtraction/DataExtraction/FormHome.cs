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

                    //cancello i database che non devono essere mostrati
                    for (int i = table.Rows.Count - 1; i >= 0; i--)
                    {
                        DataRow dr = table.Rows[i];
                        if (!doINeedThisRow(dr, DataIDontNeed.NomiDbIDONTNeed)) dr.Delete();
                    }

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

        private bool doINeedThisRow(DataRow _row, string[] _dbToRemove)
        {
            foreach (string nomeDb in _dbToRemove)
            {
                if (_row[0].ToString() == nomeDb) return false;
            }
            return true;
        }

        private void DoIHaveToDropThisColumn(DataTable _table, string[] _columnsToBeDropped)
        {
            foreach (string nomeColonna in _columnsToBeDropped)
            {
                if (_table.Columns.Contains(nomeColonna))
                {
                    _table.Columns.Remove(nomeColonna);
                }
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
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * from [{dbName}].[INFORMATION_SCHEMA].[TABLES]", connection))
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


        }

        private void listBoxTavole_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region  Scrittura Colonne
            try
            {
                string dbName = listBoxElencoDataBase.SelectedValue.ToString();
                string tableName = listBoxTavole.SelectedValue.ToString();
                using (SqlConnection connection = new SqlConnection(ConnectionInfo.ConnectToSelectedDB(dbName)))
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT COLUMN_NAME from [{dbName}].[INFORMATION_SCHEMA].[COLUMNS] WHERE TABLE_NAME = '{tableName}'", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);


                    //cancello le colonne che non devono essere mostrati
                    for (int i = table.Rows.Count - 1; i >= 0; i--)
                    {
                        DataRow dr = table.Rows[i];
                        if (!doINeedThisRow(dr, DataIDontNeed.NomiColonneIDONTNeed)) dr.Delete();
                    }

                    listBoxColonne.DisplayMember = "COLUMN_NAME";
                    listBoxColonne.ValueMember = "COLUMN_NAME";
                    listBoxColonne.DataSource = table;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            #region Popola la tabella


            //inserire le ultime 10 righe
            try
            {
                //aprire connessione 
                //aggiungere la lista dei database
                //visualizzare i nomi,
                //selezionare id del database
                //chiudere connessione
                string dbName = listBoxElencoDataBase.SelectedValue.ToString();
                string tableName = listBoxTavole.SelectedValue.ToString();
                using (SqlConnection connection = new SqlConnection(ConnectionInfo.ConnectToSelectedDB(dbName)))
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT TOP 10 * from [{dbName}].dbo.[{tableName}] ORDER BY LocalCol DESC", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    /// cancello le colonne che su richiesta del cliente non devono
                    /// essere piu mostrate perche creano confusione
                    DoIHaveToDropThisColumn(table,DataIDontNeed.NomiColonneIDONTNeedButLocalCol);

                    dataGridViewRisultatoRicerca.DataSource = table;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion
        }

        private void buttonFiltraColonna_Click(object sender, EventArgs e)
        {
            try
            {
                string dbName = listBoxElencoDataBase.SelectedValue.ToString();
                string tableName = listBoxTavole.SelectedValue.ToString();
                string columnName = listBoxColonne.SelectedValue.ToString();
                string inizioPeriodo = dateTimePickerPeriodoInizio.Value.ToString();
                string finePeriodo = dateTimePickerPeriodoFine.Value.ToString();

                using (SqlConnection connection = new SqlConnection(ConnectionInfo.ConnectToSelectedDB(dbName)))
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT LocalCol, [{columnName}] from [{dbName}].dbo.[{tableName}] WHERE LocalCol BETWEEN '{inizioPeriodo}' AND '{finePeriodo}' ORDER BY LocalCol DESC ", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewRisultatoRicerca.DataSource = table;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string dbName = listBoxElencoDataBase.SelectedValue.ToString();
                string tableName = listBoxTavole.SelectedValue.ToString();
                string columnName = listBoxColonne.SelectedValue.ToString();
                string inizioPeriodo = dateTimePickerPeriodoInizio.Value.ToString();
                string finePeriodo = dateTimePickerPeriodoFine.Value.ToString();

                using (SqlConnection connection = new SqlConnection(ConnectionInfo.ConnectToSelectedDB(dbName)))
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * from [{dbName}].dbo.[{tableName}] WHERE LocalCol BETWEEN '{inizioPeriodo}' AND '{finePeriodo}' ORDER BY LocalCol DESC ", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ///cancello le colonne su richiesta del cliente
                    DoIHaveToDropThisColumn(table, DataIDontNeed.NomiColonneIDONTNeedButLocalCol);
                    dataGridViewRisultatoRicerca.DataSource = table;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
