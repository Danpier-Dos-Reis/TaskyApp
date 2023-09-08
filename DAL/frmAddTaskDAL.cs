using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using Models;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class frmAddTaskDAL
    {
        private string _connString;
        private MainFormDAL _mainFormDAL;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connString"></param>
        public frmAddTaskDAL(string connString)
        {
            _connString = connString;
        }

        public void SaveArea(string nameArea)
        {
            _mainFormDAL = new MainFormDAL(_connString);
            
            if (_mainFormDAL.DBConnectionOK())
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connString))
                {
                    connection.Open();

                    string query = "INSERT INTO Area(Name,Created_At) VALUES(@Name, @Created_At)";
                    SQLiteParameter Name = new SQLiteParameter("@Name", nameArea);
                    SQLiteParameter NowDate = new SQLiteParameter("@Created_At", DateTime.Now.ToString("dd/MMMM/yyyy"));
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add(Name);
                    command.Parameters.Add(NowDate);

                    try { command.ExecuteNonQuery(); }
                    catch(Exception e){ MessageBox.Show(e.Message,"Error"); }
                }
            }
        }
    }
}
