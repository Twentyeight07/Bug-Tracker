using Domain;
using Entities.Cache;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Xml.Linq;

namespace Presentation
{
    public partial class FrmEditProfile : Form
    {
        public FrmEditProfile()
        {
            InitializeComponent();
        }

        #region "Methods"
        private void LoadUserData()
        {
            lblName.Text = UserLoginCache.FirstName + " " + UserLoginCache.LastName;
            lblEmail.Text = UserLoginCache.Email;
            txtCompanyName.Text = UserLoginCache.CompanyName;
        }

        private void TxtState(bool state)
        {
            txtEmail.Visible= state;
            txtNewPass.Visible= state;
            txtRepeatPass.Visible= state;
            txtCurrentPass.Visible= state;

            txtEmail.Text = lblEmail.Text;
            txtNewPass.UseSystemPasswordChar = true;
            txtRepeatPass.UseSystemPasswordChar = true;
            txtCurrentPass.UseSystemPasswordChar= true;
        }

        private void LblState(bool state)
        {
            lblEmail.Visible= state;

            lblEditEmail.Visible= !state;
            lblEditPass.Visible = !state;
            linkEditPass.Visible = !state;
            lblEditRepeatPass.Visible = !state;
            lblCurrentPass.Visible = !state;
            lblMandatory.Visible = !state;
        }

        private void BtnState(bool state)
        {
            BtnEdit.Visible = state;

            BtnCancel.Visible = !state;
            BtnSave.Visible = !state;
        }

        private void UserPrivileges()
        {
            if (UserLoginCache.Admin == false)
            {
                pnlCompanyName.Visible= false;
                lblCompanyProfile.Visible= false;
                pnlAddMember.Visible = false;
            }
        }

        private void AddMemberState(bool state)
        {
            TxtNameMember.Enabled = state;
            TxtLastNameMember.Enabled = state;
            TxtEmailMember.Enabled = state;
            TxtPasswordMember.Enabled = state;

            BtnShowPass.Enabled = state;
            BtnHiddePass.Enabled = state;

            lblMandatoryMember.Visible = state;
            
            BtnAddMember.Visible= !state;
            BtnCancelMember.Visible = state;
            BtnSaveMember.Visible = state;

        }

        private void ResetAddMemberTxt()
        {
            TxtNameMember.Text = string.Empty;
            TxtLastNameMember.Text = string.Empty;
            TxtEmailMember.Text = string.Empty;
            TxtPasswordMember.Text = string.Empty;
        }

        private void MsgError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }

        #endregion

        private void FrmEditProfile_Load(object sender, EventArgs e)
        {
            LoadUserData();
            UserPrivileges();
        }

     

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            LoadUserData();
            this.BtnState(false);
            this.LblState(false);
            this.TxtState(true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            linkEditPass.Text = "Edit";
            txtNewPass.Enabled = false;
            txtRepeatPass.Enabled = false;
            txtNewPass.Text = "";
            txtRepeatPass.Text = "";
            txtCurrentPass.Text = "";
            this.BtnState(true);
            this.LblState(true);
            this.TxtState(false);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPass.TextLength >= 5 || txtNewPass.Text == "")
            {
                if (txtNewPass.Text == txtRepeatPass.Text)
                {
                    if (txtCurrentPass.Text == UserLoginCache.Password)
                    {
                        var userModel = new UserModel(id: UserLoginCache.IdUser,
                            email: txtEmail.Text.Trim(),
                            password: txtNewPass.Text == "" ? txtCurrentPass.Text.Trim() : txtNewPass.Text.Trim());
                        var res = userModel.EditUserProfile();
                        MessageBox.Show(res, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //We reset the state of the labels and txts to 0 again, no matter the result
                        linkEditPass.Text = "Edit";
                        txtNewPass.Enabled = false;
                        txtRepeatPass.Enabled = false;
                        txtNewPass.Text = "";
                        txtRepeatPass.Text = "";
                        txtCurrentPass.Text = "";
                        this.BtnState(true);
                        this.LblState(true);
                        this.TxtState(false);
                        LoadUserData();
                    }
                    else MessageBox.Show("Wrong current password, please try again", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("The password do not match, please try again", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("Password must be long than 5 characters", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditCompany_Click(object sender, EventArgs e)
        {
            BtnEditCompany.Visible = false;
            BtnCancelCompnay.Visible = true;
            BtnSaveCompany.Visible = true;

            lblPassCompany.Visible = true;
            txtCompanyName.Enabled = true;
            txtPassCompany.Visible = true;
            txtPassCompany.UseSystemPasswordChar = true;
        }

        private void BtnCancelCompnay_Click(object sender, EventArgs e)
        {
            txtCompanyName.Text = UserLoginCache.CompanyName;
            txtCompanyName.Enabled = false;
            BtnEditCompany.Visible = true;
            BtnCancelCompnay.Visible = false;
            BtnSaveCompany.Visible = false;

            lblPassCompany.Visible = false;
            txtPassCompany.Visible = false;
            txtPassCompany.Text = "";
        }

        private void BtnSaveCompany_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text != UserLoginCache.CompanyName)
            {
                if (txtPassCompany.Text == UserLoginCache.Password)
                {
                    var userModel = new UserModel(actual_company_name: UserLoginCache.CompanyName,
                        new_company_name: txtCompanyName.Text.Trim());
                    var res = userModel.EditCompanyName();
                    MessageBox.Show(res, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Reset all again to 0
                    txtCompanyName.Text = UserLoginCache.CompanyName;
                    txtCompanyName.Enabled = false;
                    BtnEditCompany.Visible = true;
                    BtnCancelCompnay.Visible = false;
                    BtnSaveCompany.Visible = false;

                    lblPassCompany.Visible = false;
                    txtPassCompany.Visible = false;
                    txtPassCompany.Text = "";
                }
                else MessageBox.Show("Wrong current password, please try again", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("The new company name must be different to the actual Company Name", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LinkEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkEditPass.Text == "Edit")
            {
                linkEditPass.Text = "Cancel";
                txtNewPass.Enabled = true;
                txtRepeatPass.Enabled = true;
            }
            else
            {
                txtNewPass.Text = "";
                txtRepeatPass.Text = "";
                linkEditPass.Text = "Edit";
                txtNewPass.Enabled = false;
                txtRepeatPass.Enabled = false;
            }
        }

        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            AddMemberState(true);
            TxtPasswordMember.UseSystemPasswordChar = true;
            pnlAddMember.Focus();
        }

        private void BtnCancelMember_Click(object sender, EventArgs e)
        {
            AddMemberState(false);
            BtnShowPass.Visible = true;
            BtnHiddePass.Visible = false;
            ResetAddMemberTxt();
        }

        private void BtnShowPass_Click(object sender, EventArgs e)
        {
            TxtPasswordMember.UseSystemPasswordChar = false;
            BtnShowPass.Visible = false;
            BtnHiddePass.Visible = true;
        }

        private void BtnHiddePass_Click(object sender, EventArgs e)
        {
            TxtPasswordMember.UseSystemPasswordChar = true;
            BtnShowPass.Visible = true;
            BtnHiddePass.Visible = false;
        }

        private void BtnSaveMember_Click(object sender, EventArgs e)
        {
            if (TxtNameMember.Text != String.Empty && TxtEmailMember.Text != String.Empty && TxtPasswordMember.Text != String.Empty)
            {

                UserModel user = new UserModel();
                var validSignin = user.SigninUser(
                    UserLoginCache.CompanyName,
                    false,
                    TxtNameMember.Text.Trim(),
                    TxtLastNameMember.Text == "Last Name" ? "" : TxtLastNameMember.Text.Trim(),
                    TxtEmailMember.Text.Trim(),
                    Encrypt.GetSHA256(TxtPasswordMember.Text.Trim()));
                if (validSignin == true)
                {
                    txtResEmail.Text = TxtEmailMember.Text;
                    TxtResPass.Text = TxtPasswordMember.Text;
                    pnlResMember.Location = new Point(305, 30);
                    pnlResMember.Visible = true;
                    AddMemberState(false);
                    BtnShowPass.Visible = true;
                    BtnHiddePass.Visible = false;
                    ResetAddMemberTxt();
                }
                else
                {
                    MessageBox.Show("Error registering the user", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else MsgError("The (*) fields are mandatory");

        }

        private void BtnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject("User Email: "+txtResEmail.Text+ " | " + "Password: "+TxtResPass.Text);

            lblSuccessMessage.Text = "     " + "Copied to Clipboard";
            lblSuccessMessage.Visible = true;

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            pnlResMember.Visible = false;
            pnlResMember.Location = new Point(842, 238);
        }
    }
}
