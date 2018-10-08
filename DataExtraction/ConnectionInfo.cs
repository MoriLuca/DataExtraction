using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataExtraction
{
    class ConnectionInfo
    {
        #region Propreità

        static public string AV()
        {
            String line = "";
            try
            {
                string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
                string fileName = Path.Combine(path, "IPAdress.txt");
                StreamReader sr = new StreamReader(fileName);
                line = sr.ReadLine();
                sr.Close();
                if(line == null)
                {
                    //MessageBox.Show("Connessione a LOCALHOST");
                    line = ".";
                } else
                {
                    //MessageBox.Show("Connessione a " + line + "\\SQLEXPRESS");
                }
                
            }
            catch (Exception e)
            {
                string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
                path += "\\IPAdress.txt";
                System.IO.File.WriteAllText(path, "");
                line = ".";
            }
            
            return line;
        }
        //static public string MasterDBConnection { get; } = @"Data Source =127.0.0.1\SQLEXPRESS; Integrated Security = SSPI;";
        static public string MasterDBConnection { get; } = @"Data Source ="+ AV()+ "\\SQLEXPRESS; Integrated Security=SSPI;";

        #endregion

        #region Metodi

        static public string ConnectToSelectedDB(string _dbName)
        {
            return $"Data Source =.\\SQLEXPRESS;Initial Catalog = {_dbName};  Integrated Security=True;";
        }

        #endregion
    }
}