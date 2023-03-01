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
    public partial class FrmProjectPage : Form
    {
        public FrmProjectPage()
        {
            InitializeComponent();
        }

        #region "Methods"
        private void FormatBugsList()
        {

            this.dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 13.50F, FontStyle.Bold, GraphicsUnit.Pixel);
            this.dgvPrincipal.ColumnHeadersHeight = 50;
            this.dgvPrincipal.RowHeadersWidth = 50;

            dgvPrincipal.Columns[0].Width = 50;
            dgvPrincipal.Columns[0].HeaderText = "Code";
            /********************************************/
            dgvPrincipal.Columns[1].Visible = false;
            /********************************************/
            dgvPrincipal.Columns[2].Width = 120;
            dgvPrincipal.Columns[2].HeaderText = "Title";
            dgvPrincipal.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrincipal.Columns[2].FillWeight = 200;
            /********************************************/
            dgvPrincipal.Columns[3].Width = 250;
            dgvPrincipal.Columns[3].HeaderText = "Description";
            dgvPrincipal.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrincipal.Columns[3].FillWeight = 250;
            /********************************************/
            dgvPrincipal.Columns[4].Width = 100;
            dgvPrincipal.Columns[4].HeaderText = "Created by";
            /********************************************/
            dgvPrincipal.Columns[5].Width = 85;
            dgvPrincipal.Columns[5].HeaderText = "Created at";
            /********************************************/
            dgvPrincipal.Columns[6].Width = 90;
            dgvPrincipal.Columns[6].HeaderText = "Modified at";
            /********************************************/
            dgvPrincipal.Columns[7].Width = 100;
            dgvPrincipal.Columns[7].HeaderText = "Modified by";
            /********************************************/
            dgvPrincipal.Columns[8].Width = 80;
            dgvPrincipal.Columns[8].HeaderText = "Deadline";
            /********************************************/
            dgvPrincipal.Columns[9].Width = 60;
            dgvPrincipal.Columns[9].HeaderText = "Severe";
            /********************************************/
            dgvPrincipal.Columns[10].Width = 60;
            dgvPrincipal.Columns[10].HeaderText = "State";
            /********************************************/
        }
        private void List_Bugs()
        {
            try
            {
                dgvPrincipal.DataSource = data;
                this.FormatBugsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when try to show the Bugs list. Error: " + ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadData()
        {
            DataTable dataSource = ProjectModel.ListProjectBugs();

            data = dataSource;
        }
        #endregion

        #region "Variables"
        DataTable data;
        #endregion

        private void FrmProjectPage_Load(object sender, EventArgs e)
        {
            LoadData();
            List_Bugs();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearch.Text != "Search by Title")
            {
                data.DefaultView.RowFilter = $"Title LIKE '%{Regex.Replace(TxtSearch.Text.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ,]+", "")}%'";
            }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "Search by Title")
            {
                TxtSearch.ForeColor = ColorTranslator.FromHtml("#4A1F21");
                TxtSearch.Text = "";
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "")
            {
                TxtSearch.ForeColor = ColorTranslator.FromHtml("#4A1F21");
                TxtSearch.Text = "Search by Title";
            }
        }
    }
}
