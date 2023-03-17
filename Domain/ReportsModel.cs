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
        

        //Methods
        public void CreateBugReport(int projectCode)
        {
            var reportsDao = new ReportsDao();
            var res = reportsDao.GetBugsReport(projectCode);

            TotalBugsCreatedBy = new List<ListBugsReports>();

            foreach (DataRow rows in res.Rows)
            {
                var reportsModel = new ListBugsReports()
                {
                    Name = rows[0].ToString(),
                    Count = Convert.ToInt32(rows[1])
                };
                TotalBugsCreatedBy.Add(reportsModel);
            }
        }
    }
}
