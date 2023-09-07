using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Controller;

namespace FrontEnd
{
    public class SoporteMainForm
    {
        public string GetConnectionString()
        {
            string conn = ConfigurationManager.ConnectionStrings["Tasky"].ConnectionString;
            string result = conn.ToString();
            return result;
        }

        #region Tests
        public bool TryDBConnection(string connString)
        {
            MainFormController mainFormController = new MainFormController();
            return mainFormController.TryDBConnection( GetConnectionString() );
        }
        #endregion
    }
}
