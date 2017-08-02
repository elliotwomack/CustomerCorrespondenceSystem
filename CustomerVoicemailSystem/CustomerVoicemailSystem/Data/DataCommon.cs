using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CustomerVoicemailSystem
{
    public class DataCommon
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data\CustomerVoicemailDB.mdf;Integrated Security=True");

        public SqlCommand executeDatbaseQuery(String queryString)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = queryString;
            cmd.ExecuteNonQuery();
            connection.Close();
            return cmd;
        }

        public DataTable getDatatable(String queryString)
        {
            SqlCommand cmd = executeDatbaseQuery(queryString);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

    }
}
