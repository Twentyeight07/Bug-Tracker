using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Data
{
    public abstract class Connection
    {
        //NpgsqlConnection conn = new NpgsqlConnection();

        static string server = "localhost";
        static string port = "5432";
        static string username = "postgres";
        static string pass = "Luzy*028";
        static string db = "Bug Tracker";

        string conStr = "server="+server+"; port="+port+"; user id="+username+"; password="+pass+"; database="+db+";";

        public NpgsqlConnection GetConnection()
        {
            try
            {
               return new NpgsqlConnection(conStr);

            }
            catch (NpgsqlException e)
            {
                throw e;

            }
            
        }
    }
}
