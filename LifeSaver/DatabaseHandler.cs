using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LifeSaver
{
    public class DatabaseHandler
    {
        private static string conString = @"data source = (local);database = Bloodbank;integrated security = SSPI";
        private static SqlConnection con = new SqlConnection(conString);

        // Gets variable from DB
        public static string getvarfromDB(string query, string wantedcol)
        {
            SqlDataAdapter com = new SqlDataAdapter(query, con);

            con.Open();
            if (con.State == ConnectionState.Broken)
            {
                MessageBox.Show("DataBase is unreachable please check your connection");
                con.Close();
                return "";
            }
            else
            {
                DataTable dt = new DataTable();
                com.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    DataRow row = dt.Rows[0];
                    con.Close();
                    return row[wantedcol].ToString();
                }
                else
                {
                    MessageBox.Show("Error Data not found");
                    con.Close();
                    return "";
                }
            }
        }

        //Gets variables from Database
        public static string[] getvarfromDB(string query, string[] wantedcols)
        {
            SqlDataAdapter com = new SqlDataAdapter(query, con);
            string[] values = new string[wantedcols.Length];
            con.Open();
            if (con.State == ConnectionState.Broken)
            {
                MessageBox.Show("DataBase is unreachable please check your connection");
                return null;
            }
            else
            {
                DataTable dt = new DataTable();
                com.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    DataRow row = dt.Rows[0];
                    int index = 0;
                    foreach (var item in wantedcols) {
                        values[index] = row[item].ToString();
                        index++;
                    }
                    con.Close();
                    return values;
                }
                else
                {
                    MessageBox.Show("Error Data not found");
                    con.Close();
                    return null;
                }
            }
        }

        //get table to gridview
        public static DataGridView gettabletoGridView(string query) {
            DataGridView gv = new DataGridView();
            SqlDataAdapter com = new SqlDataAdapter(query, con);
            con.Open();
            if (con.State == ConnectionState.Broken)
            {
                MessageBox.Show("DataBase is unreachable please check your connection");
                con.Close();
                return null;
            }
            else
            {
                DataTable dt = new DataTable();
                com.Fill(dt);
                gv.DataSource = dt;
            }
            con.Close();
            return gv;
        }

        //Insert into Database with query
        public static bool insertdatatodatabase(string query) {
            SqlCommand com = new SqlCommand(query,con);
            con.Open();
            if (con.State == ConnectionState.Broken)
            {
                con.Close();
                MessageBox.Show("DataBase is unreachable please check your connection");
                return false;
            }
            else {
                com.ExecuteNonQuery();
                return true;
            }


        }

    }
}
