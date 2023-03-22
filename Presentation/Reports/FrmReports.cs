using Domain;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
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
            model = new ReportsModel();
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
                model.CreateBugReport(projectCode);

                chtBugsReportedBy.DataSource = model.TotalBugsCreatedBy;
                chtBugsReportedBy.Series[0].XValueMember = "Key";
                chtBugsReportedBy.Series[0].YValueMembers = "Value";
                chtBugsReportedBy.DataBind();

                chtBugsAssignedTo.DataSource = model.TotalBugsAssignedTo;
                chtBugsAssignedTo.Series[0].XValueMember = "Key";
                chtBugsAssignedTo.Series[0].YValueMembers = "Value";
                chtBugsAssignedTo.DataBind();

                chtTotalBugsInProjects.DataSource = model.TotalBugsByState;
                chtTotalBugsInProjects.Series[0].XValueMember = "Key";
                chtTotalBugsInProjects.Series[0].YValueMembers = "Value";
                chtTotalBugsInProjects.DataBind();

                chtBugsSeverity.DataSource = model.TotalBugsBySeverity;
                chtBugsSeverity.Series[0].XValueMember = "Key";
                chtBugsSeverity.Series[0].YValueMembers = "Value";
                chtBugsSeverity.DataBind();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region "Variables"
        private ReportsModel model;
        DataTable projectSource = ProjectModel.LoadProjects();
        Bitmap bmp;
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
            var projectCode = Convert.ToInt32(cmbProject.Text.Substring(0, cmbProject.Text.IndexOf(" ")).Trim());
            GetProjectReport(projectCode);
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bmp = new Bitmap(panel1.Size.Width, panel1.Size.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Size.Width, panel1.Size.Height + 50));
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.CompositingMode = CompositingMode.SourceCopy;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
        }
    }
}
