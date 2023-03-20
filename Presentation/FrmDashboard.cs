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
            Load_Data();
        }

        #region "Methods"
        private void FormatExpiredBugs()
        {
            this.dgvExpiredBugs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExpiredBugs.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 13.50F, FontStyle.Bold, GraphicsUnit.Pixel);
            this.dgvExpiredBugs.ColumnHeadersHeight = 50;
            this.dgvExpiredBugs.RowHeadersWidth = 50;

            dgvExpiredBugs.Columns[0].Width = 50;
            dgvExpiredBugs.Columns[0].HeaderText = "Code";
            /********************************************/
            dgvExpiredBugs.Columns[1].Width = 150;
            dgvExpiredBugs.Columns[1].HeaderText = "Project";
            dgvExpiredBugs.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvExpiredBugs.Columns[1].FillWeight = 170;
            /********************************************/
            dgvExpiredBugs.Columns[2].Width = 120;
            dgvExpiredBugs.Columns[2].HeaderText = "Title";
            dgvExpiredBugs.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvExpiredBugs.Columns[2].FillWeight = 200;
            /********************************************/
            dgvExpiredBugs.Columns[3].Width = 250;
            dgvExpiredBugs.Columns[3].HeaderText = "Description";
            dgvExpiredBugs.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvExpiredBugs.Columns[3].FillWeight = 250;
            /********************************************/
            dgvExpiredBugs.Columns[4].Width = 100;
            dgvExpiredBugs.Columns[4].HeaderText = "Modified at";
            /********************************************/
            dgvExpiredBugs.Columns[5].Width = 85;
            dgvExpiredBugs.Columns[5].HeaderText = "Deadline";
            /********************************************/
            dgvExpiredBugs.Columns[6].Width = 90;
            dgvExpiredBugs.Columns[6].HeaderText = "Severe";
            /********************************************/
            dgvExpiredBugs.Columns[7].Width = 90;
            dgvExpiredBugs.Columns[7].HeaderText = "State";
            /********************************************/

        }
        private void Load_Data()
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

            dgvExpiredBugs.DataSource = model.ExpiredBugs;
            FormatExpiredBugs();
        }
        
        #endregion

        #region "Variables"
        private DashboardModel model;
        #endregion

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
