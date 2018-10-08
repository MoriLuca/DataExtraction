using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace DataExtraction
{
    class ConnV
    {
        public string IpAddress { get; set; }
        public string SqlAddress { get; set; }
        public string SqlServerName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool WindowsAU { get; set; }
    }

    class Connection
    {
        static public void Serializer(string IP,string SqlAD, string SQL, string US, string PS, bool WAU)
        {
            ConnV connV = new ConnV { IpAddress = IP, SqlAddress = SqlAD, SqlServerName = SQL, Username = US, Password = PS, WindowsAU = WAU };
            string result = JsonConvert.SerializeObject(connV);

            try
            {
                string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
                path += "\\IPAdress.txt";
                File.WriteAllText(path, result);
            }
            catch (Exception xe)
            {
                Console.WriteLine("Exception: " + xe.Message);
                MessageBox.Show(xe.Message);
            }
        }

        static public ConnV Deserializer()
        {
            string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
            string fileName = Path.Combine(path, "IPAdress.txt");
            string ST = File.ReadAllText(fileName);

            ConnV newconnv = JsonConvert.DeserializeObject<ConnV>(ST);
            return newconnv;
        }
    }
}