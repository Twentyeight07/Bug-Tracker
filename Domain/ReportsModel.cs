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
        public List<KeyValuePair<string, int>> TotalBugsCreatedBy { get; private set; }
        

        //Methods
        public void CreateBugReport(int projectCode)
        {
            var reportsDao = new ReportsDao();
            var res = reportsDao.GetBugsReport(projectCode);

            TotalBugsCreatedBy = new List<KeyValuePair<string, int>>();

            foreach (DataRow rows in res.Rows)
            {
                TotalBugsCreatedBy.Add(new KeyValuePair<string, int>(rows[0].ToString(), Convert.ToInt32(rows[1])));
            }
        }
    }
}
