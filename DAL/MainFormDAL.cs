using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DAL.Soporte;
using System.Data.SQLite;
using Models;

namespace DAL
{
    public class MainFormDAL
    {
        private string _connString;

        public MainFormDAL(string connString) { _connString = connString; }

        public List<CurrentView> GetCurrentTasks()
        {
            List < CurrentView > list = new List < CurrentView >();
            if (DBConnectionOK())
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connString))
                {
                    connection.Open();
                    string query = "SELECT Description FROM AllTasks WHERE Id_TaskFinished = null";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.CommandType = CommandType.Text;

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CurrentView view = new CurrentView() { Description = reader.GetString(0)};
                            list.Add(view);
                        }
                    }
                }
            }

            return list;
        }

        public bool DBConnectionOK() { return new SoporteMainFormDAL(_connString).TryDBConnection(); }
    }
}
