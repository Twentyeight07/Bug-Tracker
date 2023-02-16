using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.PostgreSQL
{
    public class ProjectDao : Connection
    {
        public DataTable List_bugs()
        {
            NpgsqlDataReader res;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    try
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = @"SELECT * FROM list_bugs()";
                        res = cmd.ExecuteReader();
                        dt.Load(res);
                        return dt;
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                }
            }
        }
    }
}
