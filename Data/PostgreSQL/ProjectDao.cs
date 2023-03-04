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

        public DataTable List_project_bugs(bool admin, string memberCode, string companyName, int projectCode)
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
                        cmd.CommandText = @"SELECT * FROM list_project_bugs(:_admin, :_member_code,:_company_name,:_project_code)";
                        cmd.Parameters.AddWithValue("_admin", admin);
                        cmd.Parameters.AddWithValue("_member_code", memberCode);
                        cmd.Parameters.AddWithValue("_company_name", companyName);
                        cmd.Parameters.AddWithValue("_project_code", projectCode);
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

        public DataTable Load_projects(string companyName)
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
                        cmd.CommandText = "SELECT code, title FROM projects WHERE company_name = @company_name";
                        cmd.Parameters.AddWithValue("@company_name", companyName);
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
                    if(DateTime.Compare(DateTime.Today, end_date) != 0)
                    {
                    cmd.CommandText = @"SELECT * FROM create_new_project(
	                :_creator_code,
	                :_company_name,
	                :_title,
	                :_description,
	                :_start_date,
	                :_end_date,
	                :_members_code)";
                    }
                    else
                    {
                    cmd.CommandText = @"SELECT * FROM create_new_project(
	                :_creator_code,
	                :_company_name,
	                :_title,
	                :_description,
	                :_start_date,
	                :_members_code)";
                    }
                    cmd.Parameters.AddWithValue("_creator_code", creator_code);
                    cmd.Parameters.AddWithValue("_company_name", company_name);
                    cmd.Parameters.AddWithValue("_title", title);
                    cmd.Parameters.AddWithValue("_description", description);
                    cmd.Parameters.AddWithValue("_start_date", start_date);
                    if(DateTime.Compare(DateTime.Today, end_date) != 0) cmd.Parameters.AddWithValue("_end_date", end_date);
                    cmd.Parameters.AddWithValue("_members_code", members_code);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                    {
                        return true;
                    }
                    else return false;

                }
            }
        }

        public bool Create_Bug(int project_code, string title, string description, int creator_code, Array members_code, DateTime created_at, DateTime modified_at, int modified_by, DateTime deadline, string severe)
        {
            
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    if(DateTime.Compare(DateTime.Today, deadline) != 0)
                    {
                    cmd.CommandText = @"SELECT * FROM create_bug(
	                :_project_code,
	                :_title,
	                :_description,
	                :_created_by,
	                :_users_assigned,
	                :_created_at,
	                :_modified_at,
	                :_modified_by,
	                :_severe,
	                :_deadline)";
                    }
                    else
                    {
                        cmd.CommandText = @"SELECT * FROM create_bug(
	                :_project_code,
	                :_title,
	                :_description,
	                :_created_by,
	                :_users_assigned,
	                :_created_at,
	                :_modified_at,
	                :_modified_by,
	                :_severe)";
                    }
                    cmd.Parameters.AddWithValue("_project_code", project_code);
                    cmd.Parameters.AddWithValue("_title", title);
                    cmd.Parameters.AddWithValue("_description", description);
                    cmd.Parameters.AddWithValue("_created_by", creator_code);
                    cmd.Parameters.AddWithValue("_users_assigned", members_code);
                    cmd.Parameters.AddWithValue("_created_at", created_at);
                    cmd.Parameters.AddWithValue("_modified_at", modified_at);
                    cmd.Parameters.AddWithValue("_modified_by", modified_by);
                    cmd.Parameters.AddWithValue("_severe", severe);
                    if (DateTime.Compare(DateTime.Today, deadline) != 0) cmd.Parameters.AddWithValue("_deadline", deadline);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }

        public bool UpdateBugState(string state, int bug_code, int modified_by)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE bugs SET state = @state, modified_at = @modified_at, modified_by = @modified_by WHERE code = @code";
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.Parameters.AddWithValue("@code", bug_code);
                    cmd.Parameters.AddWithValue("@modified_at", DateTime.Today);
                    cmd.Parameters.AddWithValue("@modified_by", modified_by);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }

        public bool UpdateBugDescription(string description, int bug_code, int modified_by)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE bugs SET description = @description, modified_at = @modified_at, modified_by = @modified_by WHERE code = @code";
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@code", bug_code);
                    cmd.Parameters.AddWithValue("@modified_at", DateTime.Today);
                    cmd.Parameters.AddWithValue("@modified_by", modified_by);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }

        public bool UpdateBugSevere(string severe, int bug_code, int modified_by)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = @"UPDATE bugs SET severe = @severe, modified_at = @modified_at, modified_by = @modified_by WHERE code = @code";
                    cmd.Parameters.AddWithValue("@severe", severe);
                    cmd.Parameters.AddWithValue("@code", bug_code);
                    cmd.Parameters.AddWithValue("@modified_at", DateTime.Today);
                    cmd.Parameters.AddWithValue("@modified_by", modified_by);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }

        public DataTable GetBugMembers(string company_name, int bug_code)
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
                    cmd.CommandText = @"select * from get_bug_members(:_company_name,:_bug_code)";
                    cmd.Parameters.AddWithValue("_company_name", company_name);
                    cmd.Parameters.AddWithValue("_bug_code", bug_code);
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
