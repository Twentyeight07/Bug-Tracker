using Domain;
using Entities.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MdlAddBug : Form
    {
        public MdlAddBug()
        {
            InitializeComponent();
        }

        #region "Methods"
        private void LoadCrewMembers()
        {
            foreach (DataRow dr in crewSource.Rows)
            {
                chkMembers.Items.Add(Convert.ToString(dr[0]) + "     (" + Convert.ToString(dr[1]) + ")");
            }
        }

        private void LoadProjects()
        {
            foreach (DataRow dr in projectSource.Rows)
            {
                cmbProject.Items.Add(Convert.ToString(dr[0]) + "     (" + Convert.ToString(dr[1]) + ")");
            }
        }
        #endregion

        #region "Variables"
        DataTable crewSource = ProjectModel.LoadMembers();
        DataTable projectSource = ProjectModel.LoadProjects();
        int sliceStart = 0;
        int sliceLength = 5;
        List<int> codes = new List<int>();
        #endregion

        private void MdlAddBug_Load(object sender, EventArgs e)
        {
            int i = FrmBugsList.parentY + 220;
            this.Location = new Point(FrmBugsList.parentX + 380, FrmBugsList.parentY + 220);
            this.LoadCrewMembers();
            this.LoadProjects();
        }

        private void BtnCancelProject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect_timer.Stop();
            }
            else
            {
                Opacity += .03;
            }
        }

        private void chkDeadline_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDeadline.Checked)
            {
                Deadline.Enabled = true;
            }
            else
            {
                Deadline.Enabled = false;
            }
        }

        private void BtnSaveProject_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string item in chkMembers.CheckedItems)
                {
                    int code = Convert.ToInt32(item.Substring(sliceStart, sliceLength).Trim());
                    codes.Add(code);
                }

                int[] itemobj = codes.Cast<int>().ToArray();
                int projectCode = Convert.ToInt32(cmbProject.Text.Substring(sliceStart, sliceLength).Trim());
                DateTime bugDeadline;

                if (Deadline.Enabled == true)
                {
                    bugDeadline = Deadline.Value;
                }
                else bugDeadline = DateTime.Today;

                var projectModel = new ProjectModel(
                project_code: projectCode,
                title: txtBugTitle.Text,
                description: txtDescription.Text,
                creator_code: UserLoginCache.IdUser,
                members_code: itemobj,
                created_at: DateTime.Now,
                modified_at: DateTime.Now,
                modified_by: UserLoginCache.IdUser,
                deadline: bugDeadline,
                severe: cmbSevere.Text
                );
                var res = projectModel.CreateBug();
                MessageBox.Show("Bug created successfully", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
