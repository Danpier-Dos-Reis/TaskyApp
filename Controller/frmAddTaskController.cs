using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

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
    }
}
