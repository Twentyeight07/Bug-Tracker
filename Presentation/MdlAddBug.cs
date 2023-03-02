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
using System.Text.RegularExpressions;
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
                chkMembers.Items.Add(Convert.ToString(dr[0]) + "   (" + Convert.ToString(dr[1]) + ")");
            }
        }

        private void LoadProjects()
        {
            foreach (DataRow dr in projectSource.Rows)
            {
                cmbProject.Items.Add(Convert.ToString(dr[0]) + "   (" + Convert.ToString(dr[1]) + ")");
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
            this.Location = new Point(FrmBugsList.parentX + 380, FrmBugsList.parentY + 180);
            this.LoadCrewMembers();
            this.LoadProjects();
        }

        private void BtnCancelProject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
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

        private void ChkDeadline_CheckedChanged(object sender, EventArgs e)
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
            if(cmbProject.Text != String.Empty && txtBugTitle.Text != String.Empty)
            {
                try
                {
                    foreach (string item in chkMembers.CheckedItems)
                    {
                        int code = Convert.ToInt32(item.Substring(sliceStart, sliceLength).Trim());
                        codes.Add(code);
                    }

                    if(codes.Count != 0)
                    {
                        int[] itemobj = codes.Cast<int>().ToArray();
                        int projectCode = Convert.ToInt32(cmbProject.Text.Substring(sliceStart, sliceLength).Trim());
                        DateTime bugDeadline = Deadline.Enabled == true ? Deadline.Value : DateTime.Today;
                        string normalizeTitle = Regex.Replace(txtBugTitle.Text.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");

                        var projectModel = new ProjectModel(
                        project_code: projectCode,
                        title: normalizeTitle.Trim(),
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
                    }else MessageBox.Show("You must select at least one member to be assigned to this bug", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }else MessageBox.Show("The (*) fields are mandatory!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


    }
}
