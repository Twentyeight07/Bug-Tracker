using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;



namespace Presentation
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region "Methods"
        public static string GetSHA256(string pass)
        {
            SHA256 sha256= SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(Encoding.ASCII.GetBytes(pass));
            for(int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        private void MsgError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            TxtPass.Text = "Password";
            TxtPass.UseSystemPasswordChar = false;
            TxtUser.Text = "Email";
            lblErrorMessage.Visible = false;
            this.Show();
            TxtUser.Focus();
        }

        private void LoginAction()
        {
            if (TxtUser.Text != "Email")
            {
                if (TxtPass.Text != "Password")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(TxtUser.Text, TxtPass.Text);
                    if (validLogin == true)
                    {
                        FrmDashboard mainMenu = new FrmDashboard();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        MsgError("Email or Password incorrect. \n     Please try again.");
                        TxtPass.Text = "Password";
                        TxtPass.Focus();
                    }
                }
                else MsgError("Please enter Password");
            }
            else MsgError("Please enter Email");
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
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if(TxtUser.Text == "Email")
            {
                TxtUser.Text = "";
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if(TxtUser.Text == "")
            {
                TxtUser.Text = "Email";
            }
        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (TxtPass.Text == "Password")
            {
                TxtPass.Text = "";
                TxtPass.UseSystemPasswordChar = true;
            }
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if(TxtPass.Text == "")
            {
                TxtPass.Text = "Password";
                TxtPass.UseSystemPasswordChar = false;

            }
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
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

        private void BtnAccess_Click(object sender, EventArgs e)
        {
            LoginAction();
        }

        private void linkAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignin signin= new FrmSignin();
            signin.ShowDialog();
        }


        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                LoginAction();
            }
        }

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new FrmRecoverPassword();
            recoverPassword.ShowDialog();
        }
    }
}
