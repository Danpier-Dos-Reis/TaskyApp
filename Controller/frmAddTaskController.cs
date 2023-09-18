using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Models;

namespace Controller
{
    public class frmAddTaskController
    {
        private string _connString;

        public frmAddTaskController(string connString)
        {
            _connString = connString;
        }

        public void SaveArea(string nameArea)
        {
            frmAddTaskDAL frmAddTaskDAL = new frmAddTaskDAL(_connString);
            frmAddTaskDAL.SaveArea(nameArea);
        }

        public void SaveTask(string description, string nameArea)
        {
            frmAddTaskDAL frmAddTaskDAL = new frmAddTaskDAL(_connString);
            frmAddTaskDAL.SaveTask(description, nameArea);
        }

        public List<AllTasks> GetTaskRelated(string areaName)
        {
            frmAddTaskDAL frmAddTaskDAL = new frmAddTaskDAL(_connString);
            return frmAddTaskDAL.GetTaskRelated(areaName);
        }

        public List<Area> GetAreas()
        {
            frmAddTaskDAL frmAddTaskDAL = new frmAddTaskDAL(_connString);
            return frmAddTaskDAL.GetAreas();
        }

        public bool ExistsTask(string Description, string nameArea)
        {
            frmAddTaskDAL frmAddTask = new frmAddTaskDAL(_connString);
            return frmAddTask.ExistsTask(Description,nameArea);
        }
    }
}
