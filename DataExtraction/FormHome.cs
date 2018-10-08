using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DataExtraction
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            CaricaDB();
            dateTimePickerPeriodoInizio.Value = DateTime.Now;
            dateTimePickerPeriodoFine.Value = DateTime.Now;
            ResizeScreen();
        }

        void ResizeScreen()
        {
            if (Screen.PrimaryScreen.Bounds.Width < 1141)
            {
                this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, this.Size.Height);
            }
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
                

                // WRITE ON DISPLAY

                ConnV CONVM = Connection.Deserializer();

                textBox1.Text = CONVM.IpAddress;
                textBox2.Text = CONVM.SqlAddress;
                textBox4.Text = CONVM.Username;
                textBox5.Text = CONVM.Password;
                textBox5.Text = CONVM.Password;
                checkBox1.Checked = CONVM.WindowsAU;

                label12.Visible = !checkBox1.Checked;
                textBox4.Visible = !checkBox1.Checked;
                label13.Visible = !checkBox1.Checked;
                textBox5.Visible = !checkBox1.Checked;

                string ServerConnection = "";
                if (CONVM.WindowsAU == false)
                {
                    ServerConnection = "server=" + CONVM.IpAddress + "\\" + CONVM.SqlAddress + "; " + " UID=" + CONVM.Username + ";password=" + CONVM.Password;
                } else
                {
                    ServerConnection = "server= .\\" + CONVM.SqlAddress +"; Integrated Security=True;";
                }

                using (SqlConnection connection = new SqlConnection(ServerConnection))
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
                    table.AcceptChanges();
                    table.Columns.Add("DISPLAY_NAME");
                    //cambioNome(table, DizionarioCambioNomeDb.dbToDeleteFromView);
                    listBoxElencoDataBase.DisplayMember = "DATABASE_NAME";
                    listBoxElencoDataBase.ValueMember = "DATABASE_NAME";
                    listBoxElencoDataBase.DataSource = table;
                    listBoxElencoDataBase.Refresh();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool doINeedThisRow(DataRow _row, string[] _dbToRemove)
        {
            try
            {
                foreach (string nomeDb in _dbToRemove)
                {
                    if (_row[0].ToString() == nomeDb) return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore nel processo di mascheramento righe non utili");
                return false;
            }

        }

        private void DoIHaveToDropThisColumn(DataTable _table, string[] _columnsToBeDropped)
        {
            try
            {
                foreach (string nomeColonna in _columnsToBeDropped)
                {
                    if (_table.Columns.Contains(nomeColonna))
                    {
                        _table.Columns.Remove(nomeColonna);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore eliminazione colonna inutile.");
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
                int numeroColonneAnteprima = 10;
                string dbName = listBoxElencoDataBase.SelectedValue.ToString();
                string tableName = listBoxTavole.SelectedValue.ToString();
                using (SqlConnection connection = new SqlConnection(ConnectionInfo.ConnectToSelectedDB(dbName)))
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT TOP {numeroColonneAnteprima} * from [{dbName}].dbo.[{tableName}] --ORDER BY LocalCol DESC", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    /// cancello le colonne che su richiesta del cliente non devono
                    /// essere piu mostrate perche creano confusione
                    //DoIHaveToDropThisColumn(table,DataIDontNeed.NomiColonneIDONTNeedButLocalCol);

                    dataGridViewRisultatoRicerca.DataSource = table;
                    //labelInfoTabella.Text = $"[ Anteprima ] : Ultimi {numeroColonneAnteprima} salvataggi contenuti nella tabella [{tableName}]";
                    labelInfoTabella.ForeColor = Color.Purple;
                    panelInfoTabella.BackColor = Color.LightSalmon;
                    

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
                    //labelInfoTabella.Text = $"Singola Colonna : Visualizzata la colonna [{columnName}] , della tabella [{tableName}]";
                    labelInfoTabella.ForeColor = Color.White;
                    panelInfoTabella.BackColor = Color.FromArgb(128, 128, 255);
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
                    //labelInfoTabella.Text = $"Tavola Completa : Visualizzati i dati della tabella [{tableName}], contenuti nel range delle date selezionate";
                    labelInfoTabella.ForeColor = Color.White;
                    panelInfoTabella.BackColor = Color.FromArgb(128, 128, 255);

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

        private void cambioNome(DataTable dt, Dictionary<string,string> dictionary)
        {
            //Alla posizione 0 dell array row, è presente il nome del database
            foreach (DataRow row in dt.Rows)
            {

                KeyValuePair<string,string> newColumnName = dictionary.FirstOrDefault(x => x.Key == row.ItemArray[0].ToString());
                if (newColumnName.Value != null)
                {
                    row[3] = newColumnName.Value;
                }
                else
                {
                    row[3] = row[0];
                }
            }
        }

        private void ExportCSV_Click(object sender, EventArgs e)
        {
            string csv = "";
            foreach (DataGridViewColumn col in dataGridViewRisultatoRicerca.Columns)
            {
                csv += col.HeaderText.Trim() + ",";
            }
            csv = csv.Substring(0, csv.Length - 1);
            csv += "\n";

            foreach (DataGridViewRow row in dataGridViewRisultatoRicerca.Rows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    try
                    {
                        csv += cell.Value.ToString().Trim()+",";
                    }
                    catch (Exception) // <- null exception altrimenti erroe
                    {
                        csv += ",";
                    }
                    
                }
                csv = csv.Substring(0, csv.Length - 1);
                csv += "\n";
            }
            /*
            string path = "";
            
            System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = dlg.SelectedPath+"\\export.csv";
                System.IO.File.WriteAllText(path, csv);
            }
            else
            {
                // This prevents a crash when you close out of the window with nothing
            }

            */

            string datetx = dateTimePickerPeriodoInizio.Value.ToString();
            datetx = datetx.Replace("/", "_");
            datetx = datetx.Replace(":", "_");

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = listBoxElencoDataBase.SelectedValue.ToString() + "_" + listBoxTavole.SelectedValue.ToString() +"_" + datetx + ".csv";
            savefile.Filter = "Text files (*.csv)|*.csv|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    sw.WriteLine(csv);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection.Serializer(textBox1.Text, textBox2.Text, "", textBox4.Text, textBox5.Text, checkBox1.Checked);

            Restart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Connection.Serializer("127.0.0.1", textBox2.Text, "", textBox4.Text, textBox5.Text, true);

            Restart();
        }

        public void Restart()
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label12.Visible = !checkBox1.Checked;
            textBox4.Visible = !checkBox1.Checked;
            label13.Visible = !checkBox1.Checked;
            textBox5.Visible = !checkBox1.Checked;
        }
    }
}