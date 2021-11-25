using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace LoginSystem
{
    public class Config
    {
        string ConnectionString = "";
        public MySqlConnection connection = null;
        public string server = "localhost";
        public string user = "root";
        public string password = "";
        DataSet ds;
        DataTable dt;
        public string Table = "user_info";
        public string ConnectionType = "";
        string RecordSource = "";

        DataGridView tempdata;

        public Config()
        {

        }

        //fucntion untuk connect database
        public void Connect(string database_name)
        {
            try
            {
                ConnectionString = "SERVER =" + server + ";" +"DATABASE=" + database_name + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";

                connection = new MySqlConnection(ConnectionString);
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public void ExecuteSql(string Sql_command)
        {
            nowquiee(Sql_command);
        }

        public void nowquiee(string sql_comm)
        {
            try
            {
                MySqlConnection cs = new MySqlConnection(ConnectionString);
                cs.Open();
                MySqlCommand myc = new MySqlCommand(sql_comm, cs);
                myc.ExecuteNonQuery();

                cs.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void Execute(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;
            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();

                MySqlDataAdapter da2 = new MySqlDataAdapter(RecordSource, connection);

                DataSet tempds = new DataSet();
                da2.Fill(tempds, ConnectionType);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public string Result(int ROW, string COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
        }

        public void ExecuteSelect(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;

            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();
                MySqlDataAdapter da = new MySqlDataAdapter(RecordSource, connection);

                ds = new DataSet();
                da.Fill(ds, ConnectionType);
                da.Fill(dt);
                tempdata = new DataGridView();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public int Count()
        {
            return dt.Rows.Count;
        }

    }
}
