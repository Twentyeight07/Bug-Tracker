using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Cache;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace Data
{
    public class UserDao:Connection
    {
        public bool EditProfile(int id, string email, string password)
        {
            
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                        cmd.Connection = connection;
                        cmd.CommandText = @"SELECT * FROM update_email_pass(:_code,:_email,:_password)";
                        cmd.Parameters.AddWithValue("_code", id);
                        cmd.Parameters.AddWithValue("_email", email);
                        cmd.Parameters.AddWithValue("_password", password);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                    {
                        return true;
                    }
                    else return false;

                }
            }
        }

        public bool EditCompanyName(string actualCompanyName, string newCompanyName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = @"SELECT * FROM update_company_name(:_actual_company_name,:_new_company_name)";
                    cmd.Parameters.AddWithValue("_actual_company_name", actualCompanyName);
                    cmd.Parameters.AddWithValue("_new_company_name", newCompanyName);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }

        public bool Login(string email, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var cmd = new NpgsqlCommand())
                {
                    cmd.Connection= connection;
                    cmd.CommandText = "SELECT * FROM users WHERE email=@email and password=@pass";
                    cmd.Parameters.AddWithValue("@email",email);
                    cmd.Parameters.AddWithValue("@pass",pass);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //With this we put in cache all the data about the User
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.CompanyName = reader.GetString(1);
                            UserLoginCache.FirstName= reader.GetString(3);
                            UserLoginCache.LastName= reader.GetString(4);
                            UserLoginCache.Admin= reader.GetBoolean(2);
                            UserLoginCache.Email= reader.GetString(5);
                            UserLoginCache.Password = reader.GetString(6);
                        }
                        return true;
                    }
                    else return false;
                    
                }
            }
        }

        public bool Signin(string company_name, bool admin, string name, string last_name, string email, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    try
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = @"SELECT * FROM signin_new_member(:_company_name,:_admin,:_name,:_last_name,:_email,:_password)";
                        cmd.Parameters.AddWithValue("_company_name", company_name);
                        cmd.Parameters.AddWithValue("_admin", admin);
                        cmd.Parameters.AddWithValue("_name", name);
                        cmd.Parameters.AddWithValue("_last_name", last_name);
                        cmd.Parameters.AddWithValue("_email", email);
                        cmd.Parameters.AddWithValue("_password", password);
                        if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                        {
                            return true;
                        }
                        else return false;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                }
            }
        }
        
        public bool RecoverPassword(string userRequesting, string randomPass, string encryptedPass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection= connection;
                    cmd.CommandText= @"SELECT * FROM recover_password(:_email,:_pass)";
                    cmd.Parameters.AddWithValue("_email", userRequesting);
                    cmd.Parameters.AddWithValue("_pass", encryptedPass);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                    {

                        //We make an instance of the support service
                        var mailService = new MailServices.SystemSupportMail();
                        mailService.SendEmail(subject: "SYSTEM: Password recovery request.", body: "Hi " +
                            "\nYou requested to recover your password.\n" +
                            "Your current password is: " + randomPass +
                            "\nHowever, we ask that you change your password inmediately once you enter the system!",
                            recipientMail: new List<string> { userRequesting }
                            );
                        return true;
                    }
                    else return false;
                }
            }
        }

        public bool DeleteUser(int user_code)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = @"SELECT * FROM delete_user(:_code)";
                    cmd.Parameters.AddWithValue("_code", user_code);
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
