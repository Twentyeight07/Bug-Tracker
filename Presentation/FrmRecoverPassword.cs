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
using Domain;

namespace Presentation
{
    public partial class FrmRecoverPassword : Form
    {
        public FrmRecoverPassword()
        {
            InitializeComponent();
        }

        #region "Functionality"
        /**************************************************************/

        //To drag the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /***************************************************************/

        #endregion

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Email")
            {
                TxtUser.Text = "";
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUser.Text == "")
            {
                TxtUser.Text = "Email";
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.RecoverPassword(TxtUser.Text);
            MessageBox.Show(result,"System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmRecoverPassword_MouseDown(object sender, MouseEventArgs e)
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
