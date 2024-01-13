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
using Models;

namespace FrontEnd
{
    public partial class frmAddTask : Form
    {
        private Context _context;
        private DataGridViewRow _row;
        private string _connString;
        public frmAddTask(Context context, DataGridViewRow row = null)
        {
            InitializeComponent();
            _context = context;
            _row = row;
        }
        private void frmAddTask_Load(object sender, EventArgs e)
        {
                _connString = new SoporteMainForm().GetConnectionString();
                LoadComboBox();
        }

        #region Events

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmAddTaskController controller = new frmAddTaskController(_connString);
            List<AllTasks> tasks = controller.GetTaskRelated(cbArea.Text);

            foreach (var t in tasks) { cbDescription.Items.Add(t.Description); }
        }
        private void btnExit_Click(object sender, EventArgs e) { this.Close(); }
        private void btnMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void btnAddArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbDescription.Text)) 
            {
                if (!string.IsNullOrEmpty(cbArea.Text)) { _SaveArea(cbArea.Text); }
                else { MessageBox.Show("The field AREA are empty", "No adding Area"); }
            }
            else { MessageBox.Show("To add an area, DESCRIPTION need to be empty.", "No adding Area"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmAddTaskController frmAddTask = new frmAddTaskController(_connString);

            if (_context == Context.Normal)
            {
                if (!string.IsNullOrEmpty(cbDescription.Text) && !string.IsNullOrEmpty(cbArea.Text))
                {
                    frmAddTaskController controller = new frmAddTaskController(_connString);
                    if (!controller.ExistsTask(cbDescription.Text, cbArea.Text))
                    {
                        frmAddTask.SaveTask(cbDescription.Text, cbArea.Text);
                        cbDescription.Text = string.Empty;
                        cbArea.Text = string.Empty;
                        ((MainForm)this.Owner).StartGrid(_connString);
                    }
                    else
                    {
                        //If exist the task so we need put this task just in the grid
                        ((MainForm)this.Owner).AddCells(1,cbDescription.Text, cbArea.Text);
                        //((MainForm)this.Owner).StartGrid(_connString);
                    }
                }
                else { MessageBox.Show("The field Area or Description are empties", "Error"); }
            }
            if (_context == Context.Update)
            {
                frmAddTaskController controller = new frmAddTaskController(_connString);

                if (controller.ExistsTask(cbDescription.Text, cbArea.Text))
                {
                    MessageBox.Show("You don't modified the task", "Error");
                }  else if(!string.IsNullOrEmpty(cbDescription.Text))
                    {
                        frmAddTask.SaveTask(cbDescription.Text, cbArea.Text);
                    //if (_row != null) { ((MainForm)this.Owner).UpdateCell(_row.Index, cbDescription.Text); }
                    //if (_row != null) { ((MainForm)this.Owner).EndTask(,); }


                    cbDescription.Text = string.Empty;
                        cbArea.Text = string.Empty;
                        //((MainForm)this.Owner).StartGrid(_connString);
                    } else { MessageBox.Show("The field Area or Description are empties", "Error"); }
            }
        }

        #endregion

        #region Private Methods
        public void LoadComboBox(string[] values = null)
        {
            if (_context == Context.Normal && values == null)
            {
                frmAddTaskController controller = new frmAddTaskController(_connString);
                List<Area> areas = controller.GetAreas();

                foreach (Area area in areas) { cbArea.Items.Add(area.Name); }
            }
            if ( _context == Context.Update && values != null)
            {
                cbArea.Enabled = false;
                cbDescription.Text = values[0]; cbArea.Text = values[1];
            }
        }
        private void _SaveArea(string nameArea)
        {
            frmAddTaskController ctr = new frmAddTaskController(_connString);
            ctr.SaveArea(nameArea);
        }
        #endregion
    }
}
