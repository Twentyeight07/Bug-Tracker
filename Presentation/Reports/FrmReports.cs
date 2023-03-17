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
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        #region "Methods"
        private void Load_Projects()
        {
            foreach (DataRow dr in projectSource.Rows)
            {
                cmbProject.Items.Add(Convert.ToString(dr[0]) + "   (" + Convert.ToString(dr[1]) + ")");
            }
        }

        private void GetProjectReport(int projectCode)
        {
            ReportsModel reportModel = new ReportsModel();

            reportModel.CreateBugReport(projectCode);
            this.reportsModelBindingSource.DataSource = reportModel;
            this.listBugsReportsBindingSource1.DataSource = reportModel;
            this.reportViewer1.RefreshReport();

        }
        #endregion

        #region "Variables"
        DataTable projectSource = ProjectModel.LoadProjects();
        #endregion

        private void FrmReports_Load(object sender, EventArgs e)
        {
            this.Load_Projects();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            int projectCode = Convert.ToInt32(cmbProject.Text.Substring(0, cmbProject.Text.IndexOf(" ")).Trim());
            GetProjectReport(projectCode);
        }
    }
}
