﻿using System;
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
        private void btnMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized;  }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddTask frmAddTask = new frmAddTask();
            frmAddTask.ShowDialog(this);
        }

        private void gMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)gMain.Rows[e.RowIndex];
            DeleteCell((int)row.Cells[0].Value);

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Method that queries for current tasks and paste these tasks in the Grid
        /// </summary>
        /// <param name="connString"></param>
        public void StartGrid(string connString = null)
        {
            MainFormController mainFormController = new MainFormController();
            gMain.DataSource = mainFormController.GetCurrentTasks(_connString);
        }

        private void DeleteCell(int idTask)
        { 
            MainFormController mainFormController = new MainFormController();

            //Refresh Grid
            if (mainFormController.DeleteCell(_connString, idTask)) { StartGrid(); }
        }

        #endregion
    }
}
