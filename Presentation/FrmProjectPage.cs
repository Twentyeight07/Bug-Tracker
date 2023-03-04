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

        private void LoadCrewMembers()
        {
            foreach (DataRow dr in crewSource.Rows)
            {
                chkMembers.Items.Add(Convert.ToString(dr[0]) + "   (" + Convert.ToString(dr[1]) + ")");
            }
        }

        private void SaveListBoxState()
        {
            members.Clear();
            membersAssigned.Clear();

            foreach (DataRow item in crewSource.Rows)
            {
                members.Add(item[0].ToString() + "   "+ item[1]);
            }

            foreach (DataRow item in bugMembers.Rows)
            {
                membersAssigned.Add(item[0].ToString() + "   "+ item[1]);
            }
        }

        private void RestoreListBoxState()
        {
            lstbxMembers.Items.Clear();
            lstbxUsersAssigned.Items.Clear();

            foreach (var item in members)
            {
                lstbxMembers.Items.Add(item);
            }

            foreach(var item in membersAssigned)
            {
                lstbxUsersAssigned.Items.Add(item);
            }
        }

        private void LoadBugmembers()
        {
            DataTable dataSource = ProjectModel.GetBugMembers();

            bugMembers = dataSource;
        }

        #endregion

        #region "Variables"
        DataTable crewSource = ProjectModel.LoadMembers();
        DataTable bugMembers = ProjectModel.GetBugMembers();
        DataTable data;
        readonly int sliceStart = 0;
        readonly int sliceLength = 5;
        List<int> codes = new List<int>();
        List<string> members = new List<string>();
        List<string> membersAssigned = new List<string>();
        #endregion

        private void FrmProjectPage_Load(object sender, EventArgs e)
        {
            lblProjectName.Text = ProjectCache.Project_title + " Bugs";
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

        private void ChkDeadline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeadline.Checked)
            {
                Deadline.Enabled = true;
            }
            else Deadline.Enabled = false;
        }

        private void BtnAddBug_Click(object sender, EventArgs e)
        {
            PnlNewBug.Location = new Point(this.Location.X + 130, this.Location.Y + 80);
            this.LoadCrewMembers();
            PnlNewBug.BringToFront();
            PnlNewBug.Visible = true;
        }

        private void BtnCancelProject_Click(object sender, EventArgs e)
        {
            PnlNewBug.Visible = false;
            PnlNewBug.SendToBack();
        }

        private void BtnSaveProject_Click(object sender, EventArgs e)
        {
            if (txtBugTitle.Text != String.Empty)
            {
                try
                {
                    foreach (string item in chkMembers.CheckedItems)
                    {
                        int code = Convert.ToInt32(item.Substring(sliceStart, sliceLength).Trim());
                        codes.Add(code);
                    }

                    if (codes.Count != 0)
                    {
                        int[] itemobj = codes.Cast<int>().ToArray();
                        DateTime bugDeadline = Deadline.Enabled == true ? Deadline.Value : DateTime.Today;
                        string normalizeTitle = Regex.Replace(txtBugTitle.Text.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");

                        var projectModel = new ProjectModel(
                        project_code: ProjectCache.Project_code,
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
                        LoadData();
                        List_Bugs();
                        PnlNewBug.Visible= false;
                        PnlNewBug.SendToBack();
                    }
                    else MessageBox.Show("You must select at least one member to be assigned to this bug", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else MessageBox.Show("The (*) fields are mandatory!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void CmbBugState_DropDown(object sender, EventArgs e)
        {
            //We only can select a limited options to be updated on the DB
            //depending of the actual state of the Bug, there's going to be some states to update
            if (cmbBugState.Text == "Open")
            {
                cmbBugState.Items.Clear();
                cmbBugState.Items.Add("Ongoin");
                cmbBugState.Items.Add("To be approved");
                cmbBugState.Items.Add("Closed");
            } 
            else if(cmbBugState.Text == "Ongoin")
            {
                cmbBugState.Items.Clear();
                cmbBugState.Items.Add("Reopen");
                cmbBugState.Items.Add("To be approved");
                cmbBugState.Items.Add("Closed");
            }
            else if(cmbBugState.Text == "To be approved")
            {
                cmbBugState.Items.Clear();
                cmbBugState.Items.Add("Reopen");
                cmbBugState.Items.Add("Ongoin");
                cmbBugState.Items.Add("Closed");
            }
            else if (cmbBugState.Text == "Reopen")
            {
                cmbBugState.Items.Clear();
                cmbBugState.Items.Add("Ongoin");
                cmbBugState.Items.Add("To be approved");
                cmbBugState.Items.Add("Closed");
            }
            else if (cmbBugState.Text == "Closed")
            {
                cmbBugState.Items.Clear();
                cmbBugState.Items.Add("Reopen");
            }

        }

        private void DgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                lstbxMembers.Items.Clear();
                lstbxUsersAssigned.Items.Clear();
                int selectedRow = e.RowIndex;
                string createdAt = dgvPrincipal[5, selectedRow].Value.ToString().Substring(0,10); 
                string modifiedAt = dgvPrincipal[6, selectedRow].Value.ToString().Substring(0,10);


                ProjectCache.Bug_code = Convert.ToInt32(dgvPrincipal[0, selectedRow].Value);
                lblBugTitle.Text = dgvPrincipal[2, selectedRow].Value.ToString();
                lblProjectForBugPnl.Text = "     " + dgvPrincipal[1,selectedRow].Value.ToString();
                lblCreatedBy.Text = "By "+dgvPrincipal[4, selectedRow].Value.ToString();
                cmbBugState.Text = dgvPrincipal[10, selectedRow].Value.ToString();
                txtBugDescription.Text = dgvPrincipal[3, selectedRow].Value.ToString();
                ProjectCache.Bug_description = dgvPrincipal[3, selectedRow].Value.ToString();
                txtCreatedBy.Text = dgvPrincipal[4, selectedRow].Value.ToString();
                txtModifiedBy.Text = dgvPrincipal[7, selectedRow].Value.ToString();
                txtCreatedAt.Text = createdAt;
                txtModifiedAt.Text = modifiedAt;
                cmbUpdateSevere.Text = dgvPrincipal[9, selectedRow].Value.ToString();
                LoadBugmembers();

                foreach (DataRow item in bugMembers.Rows)
                {
                    lstbxUsersAssigned.Items.Add(item[0].ToString() + "   " + item[1]);
                }

                foreach (DataRow item in crewSource.Rows)
                {
                    lstbxMembers.Items.Add(item[0].ToString() + "   " + item[1]);
                    
                }

                SaveListBoxState();

                pnlBugDetails.Location = new Point(this.Location.X + 90, this.Location.Y + 20);
                pnlBugDetails.BringToFront();
                pnlBugDetails.Visible = true;
            }
        }

        private void BtnCloseBugDetails_Click(object sender, EventArgs e)
        {
            pnlBugDetails.Visible= false;
            pnlBugDetails.SendToBack();

            cmbBugState.Items.Clear();
            txtBugDescription.Text = "";
            lstbxMembers.Items.Clear();
            lstbxUsersAssigned.Items.Clear();
            cmbSevere.Items.Clear();
        }

        private void CmbBugState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //We update the Bug State
            try
            {
                ProjectModel projectModel = new ProjectModel();
                var res = projectModel.UpdateBugState(cmbBugState.Text, ProjectCache.Bug_code);
                LoadData();
                List_Bugs();
                MessageBox.Show("State updated succesfully", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred updating state. Error:"+ ex.Message);

            }
        }

        private void BtnEditBugDescription_Click(object sender, EventArgs e)
        {
            BtnEditBugDescription.Visible = false;

            BtnCnlUptDescpBug.Visible = true;
            BtnUpdateBugDescp.Visible = true;
            txtBugDescription.ReadOnly = false;
            txtBugDescription.Focus();
        }

        private void BtnCnlUptDescpBug_Click(object sender, EventArgs e)
        {
            BtnEditBugDescription.Visible = true;

            BtnCnlUptDescpBug.Visible = false;
            BtnUpdateBugDescp.Visible = false;
            txtBugDescription.ReadOnly = true;
            txtBugDescription.Text = ProjectCache.Bug_description;
        }

        private void BtnUpdateBugDescp_Click(object sender, EventArgs e)
        {
            if(txtBugDescription.Text != ProjectCache.Bug_description)
            {
                try
                {
                    ProjectModel projectModel = new ProjectModel();
                    var res = projectModel.UpdateBugDescription(txtBugDescription.Text, ProjectCache.Bug_code);
                    txtBugDescription.ReadOnly = true;
                    BtnEditBugDescription.Visible = true;
                    BtnCnlUptDescpBug.Visible = false;
                    BtnUpdateBugDescp.Visible = false;
                    LoadData();
                    List_Bugs();
                    MessageBox.Show("Description updated succesfully", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error ocurred updating description. Error:"+ ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbUpdateSevere_DropDown(object sender, EventArgs e)
        {
            if (cmbUpdateSevere.Text == "None")
            {
                cmbUpdateSevere.Items.Clear();
                cmbUpdateSevere.Items.Add("Critical");
                cmbUpdateSevere.Items.Add("Major");
                cmbUpdateSevere.Items.Add("Minor");
            }
            else if (cmbUpdateSevere.Text == "Critical")
            {
                cmbUpdateSevere.Items.Clear();
                cmbUpdateSevere.Items.Add("Major");
                cmbUpdateSevere.Items.Add("Minor");
                cmbUpdateSevere.Items.Add("None");
            }
            else if (cmbUpdateSevere.Text == "Major")
            {
                cmbUpdateSevere.Items.Clear();
                cmbUpdateSevere.Items.Add("Critical");
                cmbUpdateSevere.Items.Add("Minor");
                cmbUpdateSevere.Items.Add("None");
            }
            else if (cmbUpdateSevere.Text == "Minor")
            {
                cmbUpdateSevere.Items.Clear();
                cmbUpdateSevere.Items.Add("Critical");
                cmbUpdateSevere.Items.Add("major");
                cmbUpdateSevere.Items.Add("None");
            }

        }

        private void CmbUpdateSevere_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update the Bug severity
            try
            {
                ProjectModel projectModel = new ProjectModel();
                var res = projectModel.UpdateBugSevere(cmbUpdateSevere.Text, ProjectCache.Bug_code);
                LoadData();
                List_Bugs();
                MessageBox.Show("Severity of the bug updated successfully", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred when updating Severity of the bug. Error:"+ ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoveMember_Click(object sender, EventArgs e)
        {
            if(lstbxUsersAssigned.SelectedIndex >= 0)
            {
                
                if(lstbxMembers.Items.Contains(lstbxUsersAssigned.SelectedItem.ToString()))
                {
                    lstbxUsersAssigned.Items.Remove(lstbxUsersAssigned.SelectedItem);
                }
                else
                {
                    lstbxMembers.Items.Add(lstbxUsersAssigned.SelectedItem);
                    lstbxUsersAssigned.Items.Remove(lstbxUsersAssigned.SelectedItem);
                }
                

                BtnCnlEditMembers.Visible = true;
                BtnUpdateMembers.Visible = true;
            }

        }

        private void BtnAddMemberToBug_Click(object sender, EventArgs e)
        {
            if(lstbxMembers.SelectedIndex >= 0)
            {
                if(lstbxUsersAssigned.Items.Contains(lstbxMembers.SelectedItem.ToString()))
                {
                    lstbxMembers.Items.Remove(lstbxMembers.SelectedItem);

                }
                else
                {
                    lstbxUsersAssigned.Items.Add(lstbxMembers.SelectedItem);
                    lstbxMembers.Items.Remove(lstbxMembers.SelectedItem);
                }


                BtnCnlEditMembers.Visible = true;
                BtnUpdateMembers.Visible = true;
            }
        }

        private void BtnCnlEditMembers_Click(object sender, EventArgs e)
        {
            RestoreListBoxState();
            BtnCnlEditMembers.Visible = false;
            BtnUpdateMembers.Visible = false;
        }

        private void BtnUpdateMembers_Click(object sender, EventArgs e)
        {

        }


    }
}
