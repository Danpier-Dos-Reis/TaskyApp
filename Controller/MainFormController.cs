using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using DAL.Soporte;
using DAL;
using System.Data;

namespace Controller
{
    public class MainFormController
    {
        public List<CurrentView> GetCurrentTasks(string connString)
        {
            MainFormDAL mainFormDAL = new MainFormDAL(connString);

            return mainFormDAL.GetCurrentTasks();
        }

        public bool DeleteCell(string connString, int idTasks)
        {
            bool deleted = false;
            MainFormDAL mainFormDAL = new MainFormDAL(connString);
            mainFormDAL.DeleteCell(idTasks, out deleted);

            return deleted;
        }

        public bool TryDBConnection(string connString)
        {
            SoporteMainFormDAL soporteMainFormDAL = new SoporteMainFormDAL(connString);
            return soporteMainFormDAL.TryDBConnection();
        }
    }
}
