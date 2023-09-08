using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using Models;
using System.Data;
using System.Windows.Forms;
using System.Data.Entity.Core.Common;

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

        /// <summary>
        /// Return TRUE if the name of an Area exists in the database
        /// </summary>
        /// <param name="nameArea"></param>
        /// <returns></returns>
        public bool ExistsArea(string nameArea, out int idArea)
        {
            idArea = 0;
            _mainFormDAL = new MainFormDAL(_connString);
            List<Area> list = new List<Area>();

            if (_mainFormDAL.DBConnectionOK())
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connString))
                {
                    connection.Open();
                    string query = "SELECT Id,Name,Created_At FROM Area";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.CommandType = CommandType.Text;

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Area area = new Area()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Created_At = reader.GetString(2),
                            };

                            list.Add(area);
                        }

                        connection.Close();
                    }
                }
            }
            bool result = list.Any(ar => ar.Name == nameArea);
            if (result)
            {
                var select = list.FirstOrDefault(ar => ar.Name == nameArea);
                idArea = select.Id;
            }

            return result;
        }

        public void SaveTask(string description, string nameArea)
        {
            _mainFormDAL = new MainFormDAL(_connString);
            int idArea;

            if (_mainFormDAL.DBConnectionOK())
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connString))
                {
                    connection.Open();
                    if (ExistsArea(nameArea, out idArea))
                    {

                        string query = "INSERT INTO AllTasks(Description, Id_Area, Created_At) VALUES(@Description,@Id_Area, @Created_At)";
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        SQLiteParameter Description = new SQLiteParameter("@Description", description);
                        SQLiteParameter Id_Area = new SQLiteParameter("@Id_Area", idArea);
                        SQLiteParameter Created_At = new SQLiteParameter("@Created_At", DateTime.Now.ToString("dd/MMMM/yyyy"));
                        
                        command.CommandType = CommandType.Text;
                        command.Parameters.Add(Description);
                        command.Parameters.Add(Id_Area);
                        command.Parameters.Add(Created_At);

                        try { command.ExecuteNonQuery(); }
                        catch (Exception e) { MessageBox.Show(e.Message, "Error"); }
                    }
                    else { MessageBox.Show("The 'AREA' indicated don't exists","No exists Area"); }

                    connection.Close();
                }
            }
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
                    connection.Close();
                }
            }
        }
    }
}
