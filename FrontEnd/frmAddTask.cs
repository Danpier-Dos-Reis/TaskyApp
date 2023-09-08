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
            if (string.IsNullOrEmpty(txtbDescription.Text)) 
            {
                if (!string.IsNullOrEmpty(txtbArea.Text)) { _SaveArea(txtbArea.Text); }
                else { MessageBox.Show("The field AREA are empty", "No adding Area"); }
            }
            else { MessageBox.Show("To add an area, DESCRIPTION need to be empty.", "No adding Area"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmAddTaskController frmAddTask = new frmAddTaskController(_connString);

            if (!string.IsNullOrEmpty(txtbDescription.Text) && !string.IsNullOrEmpty(txtbArea.Text))
            {
                frmAddTask.SaveTask(txtbDescription.Text, txtbArea.Text);
                txtbDescription.Text = string.Empty;
                txtbArea.Text = string.Empty;
                ((MainForm)this.Owner).StartGrid(_connString);
            }
            else { MessageBox.Show("The field Area or Description are empties", "Error"); }
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
