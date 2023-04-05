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
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
            
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            lblProgramVersion.Text = "Bug Tracker v" + ProgramCache.ProgramVersion;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LnkIntroduction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlIntroduction.Focus();
        }

        private void LnkAddNewMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlAddNewMember.Focus();
        }

        private void LnkCreateProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlCreateNewProject.Focus();
        }

        private void LnkAddBug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlAddBug.Focus();
        }

        private void LnkManageBug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlManageBug.Focus();
        }
    }
}
