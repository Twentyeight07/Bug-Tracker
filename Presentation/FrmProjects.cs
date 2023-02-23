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
    public partial class FrmProjects : Form
    {
        public FrmProjects()
        {
            InitializeComponent();
        }

        #region "Methods"
        private void FormatProjectsList()
        {

            this.dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 15F, FontStyle.Bold, GraphicsUnit.Pixel);
            this.dgvPrincipal.ColumnHeadersHeight = 50;
            this.dgvPrincipal.RowHeadersWidth = 50;

            dgvPrincipal.Columns[0].Width = 50;
            dgvPrincipal.Columns[0].HeaderText = "Code";
            /********************************************/
            dgvPrincipal.Columns[1].Width = 120;
            dgvPrincipal.Columns[1].HeaderText = "Created by";
            dgvPrincipal.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrincipal.Columns[1].FillWeight = 150;
            /********************************************/
            dgvPrincipal.Columns[2].Visible = false;
            /********************************************/
            dgvPrincipal.Columns[3].Width = 90;
            dgvPrincipal.Columns[3].HeaderText = "Title";
            dgvPrincipal.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrincipal.Columns[3].FillWeight = 100;
            /********************************************/
            dgvPrincipal.Columns[4].Width = 250;
            dgvPrincipal.Columns[4].HeaderText = "Description";
            dgvPrincipal.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrincipal.Columns[3].FillWeight = 270;
            /********************************************/
            dgvPrincipal.Columns[5].Width = 90;
            dgvPrincipal.Columns[5].HeaderText = "Start Date";
            /********************************************/
            dgvPrincipal.Columns[6].Width = 90;
            dgvPrincipal.Columns[6].HeaderText = "End Date";
            /********************************************/
            dgvPrincipal.Columns[7].Width = 100;
            dgvPrincipal.Columns[7].HeaderText = "Completed Date";
            /********************************************/
            dgvPrincipal.Columns[8].Width = 70;
            dgvPrincipal.Columns[8].HeaderText = "State";
            /********************************************/
                        
           
        }
        private void ListProjects()
        {
            try
            {
                dgvPrincipal.DataSource = dataSource;
                this.FormatProjectsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when try to show the Bugs list. Error: " + ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Variables"
        DataTable dataSource = ProjectModel.ListProjects();
        public static int parentX,parentY;
        #endregion

        private void FrmProjects_Load(object sender, EventArgs e)
        {
            ListProjects();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                TxtSearch.ForeColor = Color.DarkGray;
                TxtSearch.Text = "Search by Title";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearch.Text != "Search by Title") dataSource.DefaultView.RowFilter = $"Title LIKE '%{TxtSearch.Text.Trim()}%'";
        }

        private void BtnAddProject_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (MdlAddProject modal = new MdlAddProject())
            {
                modalBackground.StartPosition= FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = new Size(FrmMainMenu.msw, FrmMainMenu.msh);
                modalBackground.Location = new Point(FrmMainMenu.mlx, FrmMainMenu.mly);
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
                ListProjects();
            }
        }
    }
}
