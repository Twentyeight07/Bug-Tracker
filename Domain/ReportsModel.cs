using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class ReportsModel
    {
        //Attributes
        public List<ListBugsReports> TotalBugsCreatedBy { get; private set; }
        public DataSet BugsReport { get; private set; }
        

        //Methods
        public void CreateBugReport(int projectCode)
        {
            var reportsDao = new ReportsDao();
            var res = reportsDao.GetBugsReport(projectCode);

            TotalBugsCreatedBy = new List<ListBugsReports>();
            BugsReport = new DataSet();

            BugsReport = res;
        }
    }
}
