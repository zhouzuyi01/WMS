using System.Data.SqlClient;
namespace WmsDemo
{
    public class SqlBase
    {
        const string sql = "Data Source=127.0.0.1;Initial Catalog=WMS;Integrated Security=True";

        public static SqlConnection Create()
        {
            var conn = new SqlConnection(sql);
            conn.Open();
            return conn;
        }
    }
}
