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
        // Written By : Bill-Lawrence Samar

        private DB2Connection Connection;

        // Default credentials used to auto initialize DB2 Connection
        private String SCHEMA = "sanita";
        private String USERID = "BILL-LAWRENCE";
        private String PASSWORD = "Rheamaesabas12";
        private String SERVERIP = "127.0.0.1";
        private String PORT = "50000";

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

        public DatabaseHelper()
        {
            Connection = new DB2Connection("Database=" + SCHEMA + ";UserID=" + USERID + ";Password=" + PASSWORD + ";Server=" + SERVERIP + ":" + PORT);
            
            try
            {
                Connection.Open();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Error (Using Default Credentials): no connection initialization parameters might be incorrect : " + ex.Message, "Database Helper");
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
                MessageBox.Show("Error: " + ex.Message.ToString(), "Database Helper ResultSet");
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
                MessageBox.Show("Error: " + ex.Message.ToString(), "Database Helper Query");
            }

            return false;
        }
    }
}
