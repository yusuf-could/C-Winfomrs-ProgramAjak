using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace programajak.Db
{
    class DbConnection
    {

        public MySqlConnection con;
        string constring = "server=192.168.1.12; port=3306; uid=root; pwd=@Qwert!123; database=sgsprod;";

        public void connectionOpen()
        {
            con = new MySqlConnection(constring);
            con.Close();
        }

        public void connectionClose()
        {
            con = new MySqlConnection(constring);
            con.Close();
        }
    }
}
