using Data.PostgreSQL;
using Entities.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProjectModel
    {
        ProjectDao projectDao = new ProjectDao();

        //Attributes
        private int _creator_code;
        private string _company_name;
        private string _title;
        private string _description;
        private DateTime _start_date;
        private DateTime _end_date;
        private Array _members_code;


        public ProjectModel(int creator_code, string company_name, string title, string description, DateTime start_date, DateTime end_date, Array members_code)
        {
            _creator_code = creator_code;
            _company_name = company_name;
            _title = title;
            _description = description;
            _start_date = start_date;
            _end_date = end_date;
            _members_code = members_code;
        }

        public ProjectModel() 
        {
        }

        public static DataTable ListBugs()
        {
            bool admin = UserLoginCache.Admin;
            string memberCode = "%"+UserLoginCache.IdUser+"%";
            string companyName = UserLoginCache.CompanyName;
            ProjectDao Data = new ProjectDao();

            return Data.List_bugs(admin, memberCode, companyName);
        }

        public static DataTable ListProjects()
        {
            string companyName = UserLoginCache.CompanyName;
            bool admin = UserLoginCache.Admin;
            string memberCode = "%"+UserLoginCache.IdUser+"%";
            ProjectDao Data = new ProjectDao();

            return Data.List_projects(companyName, admin,memberCode);
        }

        public static DataTable LoadMembers() 
        {
            string companyName = UserLoginCache.CompanyName;
            ProjectDao Data = new ProjectDao();

            return Data.Load_members(companyName);
        }

        public bool CreateProject()
        {
            return projectDao.Create_Project(_creator_code,_company_name,_title,_description,_start_date,_end_date,_members_code);
          
        }
    }
}
