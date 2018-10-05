using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtraction
{
    class ConnectionInfo
    {
        #region Propreità

        //static public string MasterDBConnection { get; } = @"Data Source =.\SQLEXPRESS; Integrated Security = SSPI;";
        static public string MasterDBConnection { get; } = @"Data Source =.\SQLEXPRESS; Integrated Security=True;";

        #endregion

        #region Metodi

        static public string ConnectToSelectedDB(string _dbName)
        {
            return $"Data Source =.\\SQLEXPRESS;Initial Catalog = {_dbName};  Integrated Security=True;";
        }

        #endregion
    }
}
