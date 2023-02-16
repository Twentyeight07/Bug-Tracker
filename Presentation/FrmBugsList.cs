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
    public partial class FrmBugsList : Form
    {
        public FrmBugsList()
        {
            InitializeComponent();
        }

        #region "Methods"
        private void FormatBugsList()
        {

            this.dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrincipal.ColumnHeadersHeight = 50;
            this.dgvPrincipal.RowHeadersWidth= 50;

            dgvPrincipal.Columns[0].Width = 50;
            dgvPrincipal.Columns[0].HeaderText = "Code";
            /********************************************/
            dgvPrincipal.Columns[1].Width = 120;
            dgvPrincipal.Columns[1].HeaderText = "Project";
            dgvPrincipal.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrincipal.Columns[1].FillWeight = 120;
            /********************************************/
            dgvPrincipal.Columns[2].Width = 250;
            dgvPrincipal.Columns[2].HeaderText = "Description";
            dgvPrincipal.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrincipal.Columns[2].FillWeight = 250;
            /********************************************/
            dgvPrincipal.Columns[3].Width = 100;
            dgvPrincipal.Columns[3].HeaderText = "Created by";
            /********************************************/
            dgvPrincipal.Columns[4].Width = 85;
            dgvPrincipal.Columns[4].HeaderText = "Created at";
            /********************************************/
            dgvPrincipal.Columns[5].Width = 90;
            dgvPrincipal.Columns[5].HeaderText = "Modified at";
            /********************************************/
            dgvPrincipal.Columns[6].Width = 100;
            dgvPrincipal.Columns[6].HeaderText = "Modified by";
            /********************************************/
            dgvPrincipal.Columns[7].Width = 80;
            dgvPrincipal.Columns[7].HeaderText = "Deadline";
            /********************************************/
            dgvPrincipal.Columns[8].Width = 60;
            dgvPrincipal.Columns[8].HeaderText = "Severe";
            /********************************************/
            dgvPrincipal.Columns[9].Width = 60;
            dgvPrincipal.Columns[9].HeaderText = "State";
            /********************************************/
        }
        private void ListBugs()
        {
            try
            {
                dgvPrincipal.DataSource = ProjectModel.ListBugs();
                this.FormatBugsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when try to show the Bugs list. Error: " + ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        #endregion

        #region "Variables"
     
        #endregion

        #region "Functionality"
        
        #endregion

        private void FrmBugsList_Load(object sender, EventArgs e)
        {
            ListBugs();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddBug_Click(object sender, EventArgs e)
        {
           
        }

      

        
    }
}
