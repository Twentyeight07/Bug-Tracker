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
        public List<KeyValuePair<string,int>> ProjectBugsAssigned { get; private set; }
        public List<KeyValuePair<string,int>> ProjectBugsByState { get; private set; }
        public List<KeyValuePair<string,int>> ProjectBugsSeverity { get; private set; }
        
        public void LoadBugsCreated(int projectCode)
        {
            NpgsqlDataReader res;
            ProjectBugsCreated = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
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

        public void LoadBugsAssigned(int projectCode)
        {
            NpgsqlDataReader res;
            ProjectBugsAssigned = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    try
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = @"select u.name, count(b.users_assigned)
                                            from projects as p
                                            inner join bugs b on b.project_code = p.code
                                            inner join users u on u.code = ANY(b.users_assigned)
                                            where p.code = @project_code and p.company_name = @company_name and u.code = ANY(b.users_assigned)
                                            group by u.name";
                        cmd.Parameters.AddWithValue("@company_name", UserLoginCache.CompanyName);
                        cmd.Parameters.AddWithValue("@project_code", projectCode);

                        res = cmd.ExecuteReader();
                        while (res.Read())
                        {
                            ProjectBugsAssigned.Add(new KeyValuePair<string, int>(res[0].ToString(), Convert.ToInt32(res[1])));
                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
        }

        public void LoadTotalBugs(int projectCode)
        {
            NpgsqlDataReader res;
            ProjectBugsByState = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    try
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = @"SELECT b.state, count(b.state)
                                            FROM projects as p
                                            inner join bugs b on b.project_code = p.code
                                            where p.code = @project_code and p.company_name = @company_name
                                            group by b.state";
                        cmd.Parameters.AddWithValue("@company_name", UserLoginCache.CompanyName);
                        cmd.Parameters.AddWithValue("@project_code", projectCode);

                        res = cmd.ExecuteReader();
                        while (res.Read())
                        {
                            ProjectBugsByState.Add(new KeyValuePair<string, int>(res[0].ToString(), Convert.ToInt32(res[1])));
                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
        }

        public void LoadSeverityOfBugs(int projectCode)
        {
            NpgsqlDataReader res;
            ProjectBugsSeverity = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    try
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = @"SELECT b.severe, count(b.severe)
                                            FROM projects as p
                                            inner join bugs b on b.project_code = p.code
                                            where p.code = @project_code and p.company_name = @company_name
                                            group by b.severe";
                        cmd.Parameters.AddWithValue("@company_name", UserLoginCache.CompanyName);
                        cmd.Parameters.AddWithValue("@project_code", projectCode);

                        res = cmd.ExecuteReader();
                        while (res.Read())
                        {
                            ProjectBugsSeverity.Add(new KeyValuePair<string, int>(res[0].ToString(), Convert.ToInt32(res[1])));
                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
        }

        public void GetBugsReport(int projectCode)
        {
            LoadBugsCreated(projectCode);
            LoadBugsAssigned(projectCode);
            LoadTotalBugs(projectCode);
        }



    }
}
