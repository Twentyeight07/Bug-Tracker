using Entities.Cache;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DashboarModel
{
    public class DashboardDao : Connection
    {
        //Attributes
        public string CompanyName { get; private set; }
        public List<KeyValuePair<string, int>> TotalBugState { get; private set; }
        public List<KeyValuePair<string, int>> WeekSummary { get; private set; }

        //Private Methods
        private void GetTotalBugState()
        {
            TotalBugState = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    try
                    {
                        NpgsqlDataReader res;
                        cmd.Connection = connection;
                        cmd.CommandText = @"SELECT b.state, count(b.state) as SUM
                                            FROM projects as p
                                            inner join bugs b on b.project_code = p.code
                                            where p.company_name = @company_name
                                            group by b.state";
                        cmd.Parameters.AddWithValue("@company_name", this.CompanyName);
                        res = cmd.ExecuteReader();
                        while(res.Read())
                        {
                        TotalBugState.Add(new KeyValuePair<string, int>(res[0].ToString(),Convert.ToInt32(res[1])));
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
            }
        }

        private void GetWeekSummary()
        {
            WeekSummary = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    try
                    {
                        NpgsqlDataReader res;
                        cmd.Connection = connection;
                        cmd.CommandText = @"SELECT b.state, count(b.state) as SUM
                                            FROM projects as p
                                            inner join bugs b on b.project_code = p.code
                                            where p.company_name = @company_name and
                                            b.created_at between (NOW() - interval '7 day') and NOW() or
                                            b.modified_at between (NOW() - interval '7 day') and NOW()
                                            group by b.state";
                        cmd.Parameters.AddWithValue("@company_name", this.CompanyName);
                        res = cmd.ExecuteReader();
                        while (res.Read())
                        {
                            WeekSummary.Add(new KeyValuePair<string, int>(res[0].ToString(), Convert.ToInt32(res[1])));
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
            }
        }

        //Public Methods
        public void LoadData()
        {
            this.CompanyName = UserLoginCache.CompanyName;

            GetTotalBugState();
            GetWeekSummary();
        }

    }

}
