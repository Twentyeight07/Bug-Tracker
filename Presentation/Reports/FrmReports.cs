using Domain;
using Microsoft.Reporting.WinForms;
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
            try
            {
                ReportsModel reportModel = new ReportsModel();
                reportModel.CreateBugReport(projectCode);
                //Binding
                var binding = new BindingSource();
                binding.DataSource = reportModel;
                //
                this.reportViewer1.Reset();
                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                this.reportViewer1.LocalReport.ReportPath = "E:\\source\\repos\\BugTracker\\BugTracker\\Presentation\\Reports\\ProjectReport.rdlc";
                //
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportsModel", binding));
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ListBugs", reportModel.TotalBugsCreatedBy));

                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region "Variables"
        DataTable projectSource = ProjectModel.LoadProjects();
        #endregion

        private void FrmReports_Load(object sender, EventArgs e)
        {
            this.Load_Projects();
            GetProjectReport(2);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var projectCode = Convert.ToInt32(cmbProject.Text.Substring(0, cmbProject.Text.IndexOf(" ")).Trim());
            GetProjectReport(projectCode);
        }
    }
}
