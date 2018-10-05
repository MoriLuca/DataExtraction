using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

/* INFO IpDetector
 *************************************************************
 * 
 * Scansione dell ip personale, e della modalità attuale.
 * 
 * 
 * ***********************************************************/


namespace IpGuruConsole
{
    class IpDetector
    {
        #region Proprietà

        public IPAddress MyIp  { get; }
        public string HostName { get; } 
        public IPHostEntry ipHostEntry { get; }
        public List<IPAddress> IpList { get; }

        #endregion

        #region Metodi

        public IpDetector()
        {
            HostName = Dns.GetHostName();
            ipHostEntry = Dns.GetHostEntry(HostName);
            IpList = new List<IPAddress>();
            foreach (IPAddress ipAddress in ipHostEntry.AddressList)
            {
                IpList.Add(ipAddress);
            }

            foreach (IPAddress ipAddress in ipHostEntry.AddressList)
            {
                if (ipAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    Console.WriteLine(ipAddress.ToString());
                }
            }

                

        }

        public void writeIpOnConsole(string _string)
        {
            Console.WriteLine(_string);
        }

        #endregion
    }
}
