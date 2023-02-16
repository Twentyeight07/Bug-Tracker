using Data.PostgreSQL;
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

        public static DataTable ListBugs()
        {
            ProjectDao Data = new ProjectDao();
            return Data.List_bugs();
        }
    }
}
