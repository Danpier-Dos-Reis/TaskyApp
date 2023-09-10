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
            List<CurrentView> view = new List<CurrentView>();

            if (DBConnectionOK())
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connString))
                {
                    connection.Open();
                    string query = @"SELECT T.Id,T.Description,A.Name
                                                       FROM AllTasks T
                                                       INNER JOIN Area A on T.Id_Area = A.Id
                                                       WHERE Id_TaskFinished IS NULL;";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.CommandType = CommandType.Text;

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CurrentView t = new CurrentView()
                            {
                                Id_Task = reader.GetInt32(0),
                                Description = reader.GetString(1),
                                Area = reader.GetString(2)
                            };
                            view.Add(t);
                        }
                    }
                    connection.Close();
                }
            }
            return view;
        }

        public void DeleteCell(int idTask, out bool deleted)
        {
            deleted = false;
            if(DBConnectionOK())
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connString))
                {
                    connection.Open();
                    string query = "DELETE FROM AllTasks WHERE Id = @Id";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.CommandType = CommandType.Text;

                    SQLiteParameter Id = new SQLiteParameter("@Id" , idTask);
                    command.Parameters.Add(Id);



                    deleted = command.ExecuteNonQuery() > 0 ? true : false;

                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Return TRUE if connection to database is successfull
        /// </summary>
        /// <returns></returns>
        public bool DBConnectionOK() { return new SoporteMainFormDAL(_connString).TryDBConnection(); }
    }
}
