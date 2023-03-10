using Domain;
using Entities.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MdlAddProject : Form
    {
        public MdlAddProject()
        {
            InitializeComponent();
        }

        #region "Methods"
        private void LoadCrewMembers()
        {
            foreach (DataRow dr in dataSource.Rows)
            {
                chkMembers.Items.Add(Convert.ToString(dr[0]) + "   (" +Convert.ToString(dr[1])+")");
            }
        }
        #endregion

        #region "Variables"
        DataTable dataSource = ProjectModel.LoadMembers();
        List<int> codes = new List<int>();
        #endregion

        private void MdlAddProject_Load(object sender, EventArgs e)
        {
            int i = FrmProjects.parentY + 220;
            this.Location = new Point(FrmProjects.parentX + 380, FrmProjects.parentY + 220);
            this.LoadCrewMembers();
        }

        private void modalEffect_timer_Tick(object sender, EventArgs e)
        {
            if(Opacity >= 1)
            {
                modalEffect_timer.Stop();
            }
            else
            {
                Opacity += .03;
            }
        }

        private void chkEndDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEndDate.Checked)
            {
                EndDate.Enabled = true;
            }
            else EndDate.Enabled = false;
        }

        private void BtnCancelProject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaveProject_Click(object sender, EventArgs e)
        {
            if(txtProjectTitle.Text != String.Empty)
            {
                try
                {
                    foreach (string item in chkMembers.CheckedItems)
                    {
                        int code = Convert.ToInt32(item.Substring(0, item.IndexOf(" ")).Trim());
                        codes.Add(code);
                    }

                    if(codes.Count != 0)
                    {
                        int[] itemobj = codes.Cast<int>().ToArray();
                        DateTime endDate = EndDate.Enabled == true ? EndDate.Value : DateTime.Today;
                        string normalizeTitle = Regex.Replace(txtProjectTitle.Text.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");

                        var projectModel = new ProjectModel(
                        creator_code: UserLoginCache.IdUser,
                        company_name: UserLoginCache.CompanyName,
                        title: normalizeTitle.Trim(),
                        description: txtDescription.Text,
                        start_date: StartDate.Value,
                        end_date: endDate,
                        members_code: itemobj
                        );
                        var res = projectModel.CreateProject();
                        MessageBox.Show("Project created successfully", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }else MessageBox.Show("You should select at least one member to be part of the project", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }else MessageBox.Show("The (*) fields are mandatory!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        
    }
}
