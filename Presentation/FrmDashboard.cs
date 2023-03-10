using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmDashboard : Form
    {
        //Constructor
        public FrmDashboard()
        {
            InitializeComponent();

            model = new DashboardModel();
            LoadData();
        }

        #region "Methods"
        private void LoadData()
        {
            model.LoadData();

            chtStateOfBugs.DataSource = model.TotalBugState;
            chtStateOfBugs.Series[0].XValueMember = "Key";
            chtStateOfBugs.Series[0].YValueMembers = "Value";
            chtStateOfBugs.DataBind();

            chtWeekSummary.DataSource = model.WeekSummary;
            chtWeekSummary.Series[0].XValueMember = "Key";
            chtWeekSummary.Series[0].YValueMembers="Value";
            chtWeekSummary.DataBind();

        }
        
        #endregion

        #region "Variables"
        private DashboardModel model;
        #endregion

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
