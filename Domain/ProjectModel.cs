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

        //Global Attributes
        private int _creator_code;
        private string _company_name;
        private Array _members_code;
        private string _title;
        private string _description;

        //Projects Attributes
        private DateTime _start_date;
        private DateTime _end_date;

        //Bugs Attributes
        private int _project_code;
        private DateTime _created_at;
        private DateTime _modified_at;
        private int _modified_by;
        private DateTime _deadline;
        private string _severe;


        //Constructor for Projects
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

        //Constructor for Bugs
        public ProjectModel(int project_code,string title, string description, int creator_code,Array members_code, DateTime created_at, DateTime modified_at, int modified_by, DateTime deadline, string severe)
        {
            _project_code = project_code;
            _title = title;
            _description = description;
            _creator_code = creator_code;
            _members_code = members_code;
            _created_at = created_at;
            _modified_at = modified_at;
            _modified_by = modified_by;
            _deadline = deadline;
            _severe = severe;
        }

        public static DataTable ListBugs()
        {
            bool admin = UserLoginCache.Admin;
            string memberCode = "%"+UserLoginCache.IdUser+"%";
            string companyName = UserLoginCache.CompanyName;
            ProjectDao Data = new ProjectDao();

            return Data.List_bugs(admin, memberCode, companyName);
        }

        public static DataTable ListProjectBugs()
        {
            bool admin = UserLoginCache.Admin;
            string memberCode = "%" + UserLoginCache.IdUser + "%";
            string companyName = UserLoginCache.CompanyName;
            int projectCode = ProjectCache.Project_code;
            ProjectDao Data = new ProjectDao();

            return Data.List_project_bugs(admin, memberCode, companyName, projectCode);
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

        public static DataTable LoadProjects()
        {
            string companyName = UserLoginCache.CompanyName;
            ProjectDao Data = new ProjectDao();

            return Data.Load_projects(companyName);
        }

        public bool CreateProject()
        {
            return projectDao.Create_Project(_creator_code,_company_name,_title,_description,_start_date,_end_date,_members_code);
          
        }

        public bool CreateBug()
        {
           
            return projectDao.Create_Bug(_project_code,_title,_description,_creator_code,_members_code,_created_at,_modified_at,_modified_by,_deadline,_severe);
           
          
        }
    }
}
