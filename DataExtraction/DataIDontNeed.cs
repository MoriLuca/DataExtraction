using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtraction
{
    class DataIDontNeed
    {
        public static string[] NomiDbIDONTNeed { get; } =
        {
           "master", "tempe", "msdb", "model", "tempdb", "soudane",
        };

        public static string[] NomiColonneIDONTNeed { get; } =
        {
           "TimeCol", "MSecCol", "UserCol", "ReasonCol", "LocalCol"
        };

        public static string[] NomiColonneIDONTNeedButLocalCol { get; } =
        {
           "TimeCol", "MSecCol", "UserCol", "ReasonCol",
        };
    }
}
