using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Cache;

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
                        }
                        return true;
                    }
                    else return false;
                    
                }
            }
        }
        //Method to recover the password
        public string RecoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection= connection;
                    cmd.CommandText= "SELECT * FROM users WHERE email=@email";
                    cmd.Parameters.AddWithValue("@email", userRequesting);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3);
                        string userEmail = reader.GetString(5);
                        string accountPass = reader.GetString(6);

                        //We make an instance of the support service
                        var mailService = new MailServices.SystemSupportMail();
                        mailService.SendEmail(subject: "SYSTEM: Password recovery request.", body: "Hi " + userName + "\n You requested to recover your password\n" +
                            "Your current password is: " + accountPass +
                            "\nHowever, we ask that you change your password inmediately once you enter the system!",
                            recipientMail: new List<string> { userEmail }
                            );
                        return "Hi " + userName + "\nYou requested to recover your password\n" +
                            "Please check your Email " + userEmail +
                            "\nHowever, we ask that you change your password inmediately once you enter the system!"+
                            "\nIf you don't find the email, check the spam folder";
                    }
                    else return "Sorry, you don't have an account with that email";
                }
            }
        }
        
    }
}
