using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Entities;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Cache;

namespace Presentation
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
            ProgramCache.ProgramVersion = "1.0";
        }

        #region "Methods"
        //Method to open Forms into the panel
        private void OpenForm<MyForm>() where MyForm : Form, new()
        {
            Form form;
            //This search into the collection if the form we want to open exists or not
            form = PnlForms.Controls.OfType<MyForm>().FirstOrDefault();

            //If the form is not in the controls collection (doesn't exist) we create a new one and add to the panel controls
            if (form == null)
            {
                form = new MyForm
                {
                TopLevel = false,
                FormBorderStyle= FormBorderStyle.None,
                Dock= DockStyle.Fill,
                };
                PnlForms.Controls.Add(form);
                PnlForms.Tag = form;
                form.Show();
                form.BringToFront();
                form.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                //if exists, just bringt it to front
                form.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e) {
            //When close the form the btn returns to his original color
            if (Application.OpenForms["FrmDashboard"] == null)
            {
                BtnDashboard.BackColor = Color.FromArgb(216, 104, 70);
            }

            if (Application.OpenForms["FrmBugsList"] == null)
            {
                BtnBugs.BackColor = Color.FromArgb(216, 104, 70);
            }

            if (Application.OpenForms["FrmProjects"] == null)
            {
                BtnProjects.BackColor = Color.FromArgb(216, 104, 70);
            }

            if (Application.OpenForms["FrmReports"] == null)
            {
                BtnReports.BackColor = Color.FromArgb(216, 104, 70);
            }
        }

        private void LoadUserData()
        {
            lblName.Text = "Welcome back "+UserLoginCache.FirstName+"!";
        }

        private void UserPrivileges()
        {
            if(UserLoginCache.Admin == false)
            {
                BtnReports.Visible = false;
            }
        }

        #endregion

        #region "Variables"
        int lx, ly;
        int sw, sh;
        /************************/
        //This variables is for export the location and size of the Main Menu for modal Background 
        public static int Mlx { get; private set; }
        public static int Mly { get; private set; }
        public static int Msw { get; private set; }
        public static int Msh { get; private set; }

        #endregion

        #region "Functionality"
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.PnlContainer.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }





        /**************************************************************/

        //To drag the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /***************************************************************/
        #endregion


        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LoadUserData();
            UserPrivileges();
            Mlx = this.Location.X;
            Mly = this.Location.Y;
            Msw = this.Size.Width;
            Msh = this.Size.Height;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to exit?", "System Message",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(DialogResult == DialogResult.OK)
            {
            Application.Exit();
            }
        }

        private void PnlTittleBar_MouseMove(object sender, MouseEventArgs e)
        {
            //This event is to make the form draggeable
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            Mlx = this.Location.X;
            Mly = this.Location.Y;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //When push the btn whe call the function "OpenForm" and pass the form name
            OpenForm<FrmDashboard>();
            BtnDashboard.BackColor= Color.FromArgb(165, 79, 53);
        }

        private void BtnBugs_Click(object sender, EventArgs e)
        {
            //When push the btn whe call the function "OpenForm" and pass the form name
            OpenForm<FrmBugsList>();
            BtnBugs.BackColor = Color.FromArgb(165, 79, 53);
        }

        private void BtnProjects_Click(object sender, EventArgs e)
        {
            //When push the btn whe call the function "OpenForm" and pass the form name
            OpenForm<FrmProjects>();
            BtnProjects.BackColor = Color.FromArgb(165, 79, 53);
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            //When push the btn whe call the function "OpenForm" and pass the form name
            OpenForm<FrmReports>();
            BtnReports.BackColor = Color.FromArgb(165, 79, 53);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to LogOut", "System Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            OpenForm<FrmEditProfile>();
        }

        private void BtnDocs_Click(object sender, EventArgs e)
        {
            //When push the btn whe call the function "OpenForm" and pass the form name
            OpenForm<FrmAbout>();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            //We capture the size and location of the form at the start, so we can get back to it when we don't want the window maximized
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            

            //Alter the visibility of the buttons Maximize and Restore
            BtnMaximize.Visible = false;
            BtnRestore.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            //If we change the window Size and Maximize or something I'm going to update the exported variables
            Mlx = this.Location.X;
            Mly = this.Location.Y;
            Msw = this.Size.Width;
            Msh = this.Size.Height;

        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            BtnMaximize.Visible = true;
            BtnRestore.Visible = false;

            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);

            //If we change the window Size and Maximize or something I'm going to update the exported variables
            Mlx = this.Location.X;
            Mly = this.Location.Y;
            Msw = this.Size.Width;
            Msh = this.Size.Height;
        }


    }
}
