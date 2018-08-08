using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2;

namespace FinalSanitariumMIS.Helpers
{
    public class DatabaseHelper
    {
        private DB2Connection Connection;

        public DatabaseHelper(String ip, String port, String password, String user, String schema)
        {
            if (String.IsNullOrEmpty(ip) || String.IsNullOrEmpty(port) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(user) || String.IsNullOrEmpty(schema))
            {
                MessageBox.Show(null, "Error: no connection initialization parameters have been provided or is lacking", "Database Helper");
            }
            else
            {
                Connection = new DB2Connection("Database=" + schema + ";UserID=" + user + ";Password=" + password + ";Server=" + ip + ":" + port);

                try
                {
                    Connection.Open();
                    Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, "Error: no connection initialization parameters might be incorrect : " + ex.Message, "Database Helper");
                }
            }
        }

        public DB2ResultSet QueryWithResultSet(String sql_query)
        {
            DB2ResultSet rs = null;

            try
            {
                if (!Connection.IsOpen)
                {
                    Connection.Open();
                }

                DB2Command command = new DB2Command(sql_query, Connection);
                rs = command.ExecuteResultSet(DB2ResultSetOptions.None);

                return rs;
            }
            catch (DB2Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Database Helper");
            }

            return rs;
        }

        public bool Query(String sql_query)
        {
            try
            {
                if (!Connection.IsOpen)
                {
                    Connection.Open();
                }

                DB2Command command = new DB2Command(sql_query, Connection);
                command.ExecuteNonQuery();

                Connection.Close();

                return true;
            }
            catch (DB2Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Database Helper");
            }

            return false;
        }
    }
}
