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
        public DataTable List_bugs(bool admin, string memberCode, string companyName)
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
                        cmd.CommandText = @"SELECT * FROM list_bugs(:_admin, :_member_code,:_company_name)";
                        cmd.Parameters.AddWithValue("_admin", admin);
                        cmd.Parameters.AddWithValue("_member_code", memberCode);
                        cmd.Parameters.AddWithValue("_company_name", companyName);
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

        public DataTable List_projects(string companyName,bool admin, string memberCode)
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
                        cmd.CommandText = @"SELECT * FROM list_projects(:_company_name,:_admin,:_member_code)";
                        cmd.Parameters.AddWithValue("_company_name", companyName);
                        cmd.Parameters.AddWithValue("_admin", admin);
                        cmd.Parameters.AddWithValue("_member_code", memberCode);
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

        public DataTable Load_members(string companyName)
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
                        cmd.CommandText = @"SELECT * FROM load_company_members(:_company_name)";
                        cmd.Parameters.AddWithValue("_company_name", companyName);
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

        public bool Create_Project(int creator_code,string company_name,string title,string description, DateTime start_date, DateTime end_date, Array members_code)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = @"SELECT * FROM create_new_project(
	                :_creator_code,
	                :_company_name,
	                :_title,
	                :_description,
	                :_start_date,
	                :_end_date,
	                :_members_code)";
                    cmd.Parameters.AddWithValue("_creator_code", creator_code);
                    cmd.Parameters.AddWithValue("_company_name", company_name);
                    cmd.Parameters.AddWithValue("_title", title);
                    cmd.Parameters.AddWithValue("_description", description);
                    cmd.Parameters.AddWithValue("_start_date", start_date);
                    cmd.Parameters.AddWithValue("_end_date", end_date);
                    cmd.Parameters.AddWithValue("_members_code", members_code);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                    {
                        return true;
                    }
                    else return false;

                }
            }
        }


    }
}
