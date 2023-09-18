using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DAL.Soporte;
using System.Data.SQLite;
using Models;
using System.Windows.Forms;

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

        public bool EndTask(int idTask, Context context)
        {
            bool deleted = false;
            if(DBConnectionOK())
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connString))
                {
                    connection.Open();

                    if (context == Context.Normal)
                    {
                        string query = "INSERT INTO TasksFinished(Context,Created_At) Values(@Context,DATETIME());";
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        command.CommandType = CommandType.Text;
                        command.Parameters.Add(new SQLiteParameter("@Context", 1));
                        try { command.ExecuteNonQuery(); } catch (Exception e) { MessageBox.Show(e.Message); }



                        //Update Table AllTasks
                        query = "SELECT last_insert_rowid();";
                        int Id_TaskFinished = GetLastInsertedId(new SQLiteCommand(query, connection));

                        if (Id_TaskFinished > 0)
                        {
                            query = "UPDATE AllTasks SET Id_TaskFinished = @Id_TaskFinished WHERE Id = @Id;";
                            command = new SQLiteCommand(query, connection);
                            SQLiteParameter IdTF = new SQLiteParameter("@Id_TaskFinished", Id_TaskFinished);
                            SQLiteParameter Id = new SQLiteParameter("@Id", idTask);
                            command.CommandType = CommandType.Text;

                            command.Parameters.Add(IdTF);
                            command.Parameters.Add(Id);

                            deleted = command.ExecuteNonQuery() > 0 ? true : false;
                        }
                    }

                    if (context == Context.Update)
                    {
                        string query = "INSERT INTO TasksFinished(Context,Created_At) Values(@Context,DATETIME());";
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        command.CommandType = CommandType.Text;
                        command.Parameters.Add(new SQLiteParameter("@Context", 2));
                        try { command.ExecuteNonQuery(); } catch (Exception e) { MessageBox.Show(e.Message); }



                        //Update Table AllTasks
                        query = "SELECT last_insert_rowid();";
                        int Id_TaskFinished = GetLastInsertedId(new SQLiteCommand(query, connection));

                        if (Id_TaskFinished > 0)
                        {
                            query = "UPDATE AllTasks SET Id_TaskFinished = @Id_TaskFinished WHERE Id = @Id;";
                            command = new SQLiteCommand(query, connection);
                            SQLiteParameter IdTF = new SQLiteParameter("@Id_TaskFinished", Id_TaskFinished);
                            SQLiteParameter Id = new SQLiteParameter("@Id", idTask);
                            command.CommandType = CommandType.Text;

                            command.Parameters.Add(IdTF);
                            command.Parameters.Add(Id);

                            deleted = command.ExecuteNonQuery() > 0 ? true : false;
                        }
                    }
                    
                    connection.Close();
                }
            }
            return deleted;
        }

        public int GetLastInsertedId(SQLiteCommand cmd)
        {
            int Id_TaskFinished = 0;
            cmd.CommandType = CommandType.Text;
            try
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) { Id_TaskFinished = reader.GetInt32(0); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return Id_TaskFinished;
        }

        /// <summary>
        /// Return TRUE if connection to database is successfull
        /// </summary>
        /// <returns></returns>
        public bool DBConnectionOK() { return new SoporteMainFormDAL(_connString).TryDBConnection(); }
    }
}
