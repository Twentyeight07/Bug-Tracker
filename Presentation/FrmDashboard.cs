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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();

            model = new DashboardModel();
            LoadBugState();
        }

        #region "Methods"
        private void LoadBugState()
        {

        }
        #endregion

        #region "Variables"
        private DashboardModel model;
        #endregion

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
