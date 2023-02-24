using Domain;
using Entities.Cache;
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
                chkMembers.Items.Add(Convert.ToString(dr[0]) + "     (" +Convert.ToString(dr[1])+")");
            }
        }
        #endregion

        #region "Variables"
        DataTable dataSource = ProjectModel.LoadMembers();
        int sliceStart = 0;
        int sliceLength = 5;
        List<int> codes = new List<int>();
        #endregion

        private void MdlAddProject_Load(object sender, EventArgs e)
        {
            int i = FrmProjects.parentY + 220;
            this.Location = new Point(FrmProjects.parentX + 380, FrmProjects.parentY + 220);
            LoadCrewMembers();
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

        private void BtnCancelProject_Click(object sender, EventArgs e)
        {
            this.Close();
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

                var projectModel = new ProjectModel(
                creator_code: UserLoginCache.IdUser,
                company_name: UserLoginCache.CompanyName,
                title: txtProjectTitle.Text.Trim(),
                description: txtDescription.Text,
                start_date: StartDate.Value,
                end_date: EndDate.Value,
                members_code: itemobj
                );
                var res = projectModel.CreateProject();
                MessageBox.Show("Project created successfully", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
