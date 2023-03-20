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
        public List<KeyValuePair<string,int>> TotalBugsCreatedBy { get; private set; }
        

        //Methods
        public void CreateBugReport(int projectCode)
        {
            var reportsDao = new ReportsDao();
            reportsDao.GetBugsReport(projectCode);

            TotalBugsCreatedBy = new List<KeyValuePair<string, int>>();

            foreach(KeyValuePair<string,int> item in reportsDao.ProjectBugsCreated)
            {
                TotalBugsCreatedBy.Add(new KeyValuePair<string, int>(item.Key, item.Value));
            }
            
        }
    }
}
