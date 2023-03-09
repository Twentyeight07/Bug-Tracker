using Entities.Cache;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.PostgreSQL
{
    public class DashboardDao : Connection
    {
        //Attributes
        public string CompanyName {  get; private set; }
        public List<KeyValuePair<string, int>> TotalBugState { get; private set; }
        public List<KeyValuePair<string, int>> WeekSummary { get; private set; }
        public DataTable ExpiredBugs { get; private set; }

        //Private Methods
        private void GetTotalBugState(string companyName)
        {
            NpgsqlDataReader res;
            TotalBugState = new List<KeyValuePair<string, int>>();
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    try
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = @"SELECT b.state, count(b.state) as SUM
                                            FROM projects as p
                                            inner join bugs b on b.project_code = p.code
                                            where p.company_name = @company_name
                                            group by b.state";
                        cmd.Parameters.AddWithValue("@company_name", companyName);
                        res = cmd.ExecuteReader();
                        while(res.Read())
                        {
                            TotalBugState.Add(new KeyValuePair<string, int>(res[0].ToString(), (int)res[1]));
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
        public void LoadData(string companyName)
        {
            this.CompanyName = UserLoginCache.CompanyName;

            GetTotalBugState(CompanyName);
        }


    }
}
