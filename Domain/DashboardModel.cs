using Data.DashboarModel;
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
    public class DashboardModel
    {
        DashboardDao dashModel = new DashboardDao();
        //Attributes
        public string CompanyName { get; private set; }
        public List<KeyValuePair<string, int>> TotalBugState { get; private set; }
        public List<KeyValuePair<string, int>> WeekSummary { get; private set; }
        public DataTable ExpiredBugs { get; private set; }

        public void LoadData()
        {
            dashModel.LoadData();
            TotalBugState = new List<KeyValuePair<string, int>>();
            WeekSummary = new List<KeyValuePair<string, int>>();
            ExpiredBugs = new DataTable();

            foreach(KeyValuePair<string, int> item in dashModel.TotalBugState)
            {
                TotalBugState.Add(new KeyValuePair<string, int>(item.Key, item.Value));
            }

            foreach (KeyValuePair<string, int> item in dashModel.WeekSummary)
            {
                WeekSummary.Add(new KeyValuePair<string, int>(item.Key, item.Value));
            }

            ExpiredBugs = dashModel.ExpiredBugs;
            
        }

    }
}
