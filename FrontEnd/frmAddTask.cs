using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controller;

namespace FrontEnd
{
    public partial class frmAddTask : Form
    {
        private string _connString;
        public frmAddTask()
        {
            InitializeComponent();
        }
        private void frmAddTask_Load(object sender, EventArgs e)
        {
            _connString = new SoporteMainForm().GetConnectionString();
        }

        #region Events
        private void btnExit_Click(object sender, EventArgs e) { this.Close(); }
        private void btnMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void btnAddArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbDescription.Text)) { _SaveArea(txtbArea.Text); }
            else { MessageBox.Show("You don't be adding an area", "No adding Area"); }
        }

        #endregion

        #region Private Methods
        private void _SaveArea(string nameArea)
        {
            frmAddTaskController ctr = new frmAddTaskController(_connString);
            ctr.SaveArea(nameArea);
        }
        #endregion
    }
}
