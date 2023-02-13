using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentation
{
    public partial class FrmSignin : Form
    {
        public FrmSignin()
        {
            InitializeComponent();            
        }

        #region "Methods"
        private void Reset()
        {
            TxtCompanyName.Text = "Company Name *";
            TxtName.Text = "Name *";
            TxtLastName.Text = "Last Name";
            TxtEmail.Text = "Email *";
            TxtPass.Text = "Password *";
        }

        private void MsgError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }
        #endregion

        #region "Functionality"
        /**************************************************************/

        //To drag the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /***************************************************************/

        #endregion

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void TxtCompanyName_Enter(object sender, EventArgs e)
        {
            if (TxtCompanyName.Text == "Company Name *")
            {
                TxtCompanyName.Text = "";
            }
        }

        private void TxtCompanyName_Leave(object sender, EventArgs e)
        {
            if (TxtCompanyName.Text == "")
            {
                TxtCompanyName.Text = "Company Name *";
            }
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            if (TxtName.Text == "Name *")
            {
                TxtName.Text = "";
            }
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                TxtName.Text = "Name *";
            }
        }

        private void TxtLastName_Enter(object sender, EventArgs e)
        {
            if (TxtLastName.Text == "Last Name")
            {
                TxtLastName.Text = "";
            }
        }

        private void TxtLastName_Leave(object sender, EventArgs e)
        {
            if (TxtLastName.Text == "")
            {
                TxtLastName.Text = "Last Name";
            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            if (TxtEmail.Text == "Email *")
            {
                TxtEmail.Text = "";
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (TxtEmail.Text == "")
            {
                TxtEmail.Text = "Email *";
            }
        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (TxtPass.Text == "Password *")
            {
                TxtPass.Text = "";
                TxtPass.UseSystemPasswordChar = true;
            }
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (TxtLastName.Text == "")
            {
                TxtLastName.Text = "Password *";
                TxtPass.UseSystemPasswordChar = false;
            }
        }

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }


        private void BtnShowPass_Click(object sender, EventArgs e)
        {
            TxtPass.UseSystemPasswordChar = false;
            BtnShowPass.Visible = false;
            BtnHiddePass.Visible = true;
        }

        private void BtnHiddePass_Click(object sender, EventArgs e)
        {
            TxtPass.UseSystemPasswordChar = true;
            BtnShowPass.Visible = true;
            BtnHiddePass.Visible = false;
        }

        private void FrmSignin_MouseDown(object sender, MouseEventArgs e)
        {
            //This event is to make the form draggeable
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //This event is to make the form draggeable
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TxtCompanyName.Text != "Company Name *" && TxtName.Text != "Name *" && TxtEmail.Text != "Email *" && TxtPass.Text != "Password *")
            {
                
                    UserModel user = new UserModel();
                    var validSignin = user.SigninUser(TxtCompanyName.Text.Trim(),
                        Convert.ToBoolean(txtAdmin.Text),
                        TxtName.Text.Trim(),
                        TxtLastName.Text == "Last Name" ? "" : TxtLastName.Text.Trim(),
                        TxtEmail.Text.Trim(),
                        TxtPass.Text.Trim());
                    if (validSignin == true)
                    {
                        MessageBox.Show("User registered successfully, now you have access to the program with admin role, this mean you can now create your team, add projects and start to track progress. Good hacking", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error registering the user", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                

            }
            else MsgError("The (*) fields are mandatory");
            
        }


    }
}
