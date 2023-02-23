using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        //Attributes
        private int _id;
        private string _email;
        private string _password;
        private string _actual_company_name;
        private string _new_company_name;

        //this constructor with params is especific to update info or any process that need params
        public UserModel(int id, string email, string password)
        {
            _id = id;
            _email = email;
            _password = password;
        }

        //this constructor without params is for Login 
        public UserModel()
        {

        }


        //this constructor is for Company Name update
        public UserModel(string actual_company_name, string new_company_name)
        {
            _actual_company_name = actual_company_name;
            _new_company_name = new_company_name;
        }

        public string EditUserProfile()
        {
            try
            {
                userDao.EditProfile(_id, _email, _password);
                LoginUser(_email, _password);
                return "Profile updated successfully";
            }
            catch (Exception ex)
            {

                return "Error updating profile. Error: " + ex.Message;
            }
        }

        public string EditCompanyName()
        {
            try
            {
                userDao.EditCompanyName(_actual_company_name, _new_company_name);
                LoginUser(UserLoginCache.Email, UserLoginCache.Password);
                return "Company Name updated successfully";
            }
            catch (Exception ex)
            {

                return "Error updating Company Name. Error: "+ ex.Message;
            }
        }

        public bool LoginUser(string email, string pass)
        {
            return userDao.Login(email, pass);
        }

        public bool SigninUser(string company_name, bool admin, string name, string last_name, string email, string password)
        {
            return userDao.Signin(company_name, admin, name, last_name, email, password);
        }

        public string RecoverPassword(string userRequesting)
        {
            Random rdm = new Random();
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int length = characters.Length;
            char letter;
            int passLength = 10;
            string randomPass = string.Empty;
            for (int i = 0; i < passLength; i++)
            {
                letter = characters[rdm.Next(length)];
                randomPass += letter.ToString();
            }
            string encryptedPass = Encrypt.GetSHA256(randomPass);

            var res = userDao.RecoverPassword(userRequesting, randomPass, encryptedPass);

            if(res == true)
            {
                return "Hi," +
                       "\nYou requested to recover your password\n" +
                       "Please check your Email. " +
                       "\nHowever, we ask that you change your password inmediately once you enter the system!" +
                       "\nIf you don't find the mail, check the spam folder";
            }
            else
            {
                return "Sorry, you don't have an account with that email";
            }
        }
    }
}
