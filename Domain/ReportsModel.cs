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
        ReportsDao reportsDao = new ReportsDao();
        //Attributes
        public List<KeyValuePair<string,int>> TotalBugsCreatedBy { get; private set; }
        public List<KeyValuePair<string,int>> TotalBugsAssignedTo { get; private set; }
        public List<KeyValuePair<string,int>> TotalBugsByState { get; private set; }
        public List<KeyValuePair<string,int>> TotalBugsBySeverity { get; private set; }
        

        //Methods
        public void CreateBugReport(int projectCode)
        {
            reportsDao.GetBugsReport(projectCode);
            TotalBugsCreatedBy = new List<KeyValuePair<string, int>>();
            TotalBugsAssignedTo = new List<KeyValuePair<string, int>>();
            TotalBugsByState = new List<KeyValuePair<string, int>>();
            TotalBugsBySeverity = new List<KeyValuePair<string, int>>();

            foreach(KeyValuePair<string,int> item in reportsDao.ProjectBugsCreated)
            {
                TotalBugsCreatedBy.Add(new KeyValuePair<string, int>(item.Key, item.Value));
            }

            foreach (KeyValuePair<string, int> item in reportsDao.ProjectBugsAssigned)
            {
                TotalBugsAssignedTo.Add(new KeyValuePair<string, int>(item.Key, item.Value));
            }

            foreach (KeyValuePair<string, int> item in reportsDao.ProjectBugsByState)
            {
                TotalBugsByState.Add(new KeyValuePair<string, int>(item.Key, item.Value));
            }

            foreach (KeyValuePair<string, int> item in reportsDao.ProjectBugsByState)
            {
                TotalBugsBySeverity.Add(new KeyValuePair<string, int>(item.Key, item.Value));
            }
        }
    }
}
