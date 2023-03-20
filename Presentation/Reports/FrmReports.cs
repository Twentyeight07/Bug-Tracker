using Domain;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

                paychart.DataSource = model.TotalBugsCreatedBy;
                paychart.Series[0].XValueMember = "Key";
                paychart.Series[0].YValueMembers = "Value";
                paychart.DataBind();
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
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Size.Width + 30, panel1.Size.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
        }
    }
}
