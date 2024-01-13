using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using Controller;
using Models;

namespace FrontEnd
{
    public partial class MainForm : Form
    {
        private string _connString;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            _connString = new SoporteMainForm().GetConnectionString();
            lblDateNow.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
            StartGrid();

            //-----------------------Tests----------------------------------------//
            //bool r = new SoporteMainForm().TryDBConnection(soporte.GetConnectionString()); //everythig it's OK
        }

        private void btnExit_Click(object sender, EventArgs e) { this.Close(); }
        private void btnMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Context context = Context.Normal;
            frmAddTask frmAddTask = new frmAddTask(context);
            frmAddTask.ShowDialog(this);
        }

        private void gMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)gMain.Rows[e.RowIndex];
            int column = e.ColumnIndex;
            string cellValue = row.Cells[column].Value.ToString();

            if (cellValue == "finish") { EndTask((int)row.Cells[0].Value, Context.Normal); }
            if (cellValue == "update") { _UpdateCell(row); }

        }

        #endregion

        #region Private Methods

        public void AddCells(int IdTask, string description, string nameArea)
        {
            // Creo que lo que debo hacer es covertir los datos del grid en una lista de tareas
            //añadir la nueva tarea y asignar la lista como el Data Source
            List<CurrentView> list = new List<CurrentView>();
            foreach (DataGridViewRow row in gMain.Rows)
            {
                CurrentView task = new CurrentView()
                {
                    Id_Task = (int)row.Cells[0].Value,
                    Description = (string)row.Cells[1].Value,
                    Area = (string)row.Cells[2].Value
                };
                list.Add(task);
            }

            list.Add(new CurrentView() { Id_Task = IdTask, Description = description, Area = nameArea });
            gMain.DataSource = list;
            gMain.Refresh();
        }

        /// <summary>
        /// Method that queries for current tasks and paste these tasks in the Grid
        /// </summary>
        /// <param name="connString"></param>
        public void StartGrid(string connString = null)
        {
            MainFormController mainFormController = new MainFormController();
            gMain.DataSource = mainFormController.GetCurrentTasks(_connString);
        }

        private void _UpdateCell(DataGridViewRow row)
        {
            Context context = Context.Update;
            string[] values = { row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString() };
            frmAddTask frmaddtask = new frmAddTask(context , row);

            frmaddtask.LoadComboBox(values);
            frmaddtask.ShowDialog(this);
        }

        /// <summary>
        /// Update the Description of one row
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="newValue"></param>
        public void UpdateCell(int rowIndex, string newValue, Context context)
        {
            gMain.Rows[rowIndex].Cells[1].Value = newValue;
        }
        public void EndTask(int idTask, Context context)
        { 
            MainFormController mainFormController = new MainFormController();

            //Refresh Grid
            if (mainFormController.EndTask(_connString, idTask, context)) { StartGrid(); }
        }

        #endregion
    }
}
