using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CNPM_QuanLyThuVien
{
    class connectsql
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;

        public SqlConnection OpenDB()
        {
            conn = new SqlConnection(@"Data Source=BINGO-SAN\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True");
            return conn;
        }

        public static void OpenConnection()
        {
            string sql = @"Data Source=BINGO-SAN\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True";
            try
            {
                conn = new SqlConnection(sql);
                conn.Open();
            }catch(SqlException Ex)
            {

            }
        }
        public static void Disconnection()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }

        // tạo bảng để lưu cơ sở dữ liệu
        public static DataTable GetDataTable(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            // tạo datatable
            DataTable table = new DataTable();

            // đổ dữ liệu
            da.Fill(table);

            da.Dispose();
            cmd.Dispose();

            return table;
        }

        public static void Excute(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            // gọi hàm ExcuteNonQuery để có thể thực hiện các thao tác
            cmd.ExecuteNonQuery();
        }
    }
}
