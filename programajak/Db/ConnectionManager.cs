using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace programajak.Db
{
    class ConnectionManager
    {
        public MySqlConnection ConnectionDb;

        public ConnectionManager()
        {
            string server = "192.168.1.12";
            string port = "3306";
            string user = "root";
            string pass = "@Qwert!123";
            string db = "sgsprod";
            string constring = "datasource = " + server + "; port = " + port + "; username = " + user + "; password = " + pass + "; database = " + db + "; SslMode=None";
            //con = new MySqlConnection(ConfigurationManager.ConnectionStrings["accounting.Properties.Settings.sgsprodConnectionString"].ConnectionString);
            ConnectionDb = new MySqlConnection(constring);
        }
    }
}
