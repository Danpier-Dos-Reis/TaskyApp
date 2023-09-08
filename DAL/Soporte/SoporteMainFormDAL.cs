using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.Soporte
{
    public class SoporteMainFormDAL
    {
        private string _connString;
        public SoporteMainFormDAL(string connString) { _connString = connString; }

        /// <summary>
        /// Return true when conection is sucessfull
        /// </summary>
        /// <returns></returns>
        public bool TryDBConnection()
        {
            SQLiteConnection connection = new SQLiteConnection(_connString);
            bool result = false;
            try
            {
                connection.Open();
                result = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message,"Error"); }
            finally { connection.Close(); }

            return result;
        }
    }
}
