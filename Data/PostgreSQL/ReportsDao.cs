using Entities.Cache;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ReportsDao : Connection
    {
        //Attributes
        public List<KeyValuePair<string,int>> ProjectBugsCreated { get; private set; }
        
        public void GetBugsReport(int projectCode)
        {
            NpgsqlDataReader res;
            ProjectBugsCreated = new List<KeyValuePair<string, int>>();
            using (var connection  = GetConnection())
            {
                connection.Open();
                using(var cmd = connection.CreateCommand())
                {
                    try
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = @"select u.name, count(b.created_by)
                                        from projects as p
                                        inner join bugs b on b.project_code = p.code
                                        inner join users u on u.code = b.created_by
                                        where p.code = @project_code and p.company_name = @company_name and u.code = b.created_by
                                        group by u.name";
                        cmd.Parameters.AddWithValue("@company_name", UserLoginCache.CompanyName);
                        cmd.Parameters.AddWithValue("@project_code", projectCode);

                        res = cmd.ExecuteReader();
                        while (res.Read())
                        {
                            ProjectBugsCreated.Add(new KeyValuePair<string, int>(res[0].ToString(), Convert.ToInt32(res[1])));
                        }
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
