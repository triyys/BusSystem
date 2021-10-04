using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BusLibrary.Data_Access_Layer
{
    public class DataProviderDAO
    {
        // Kiến trúc SingleTon -- Một lần chỉ có duy nhất một connection tới database
        private static DataProviderDAO instance;
        public static DataProviderDAO Instance
        {
            get { if (instance == null) instance = new DataProviderDAO(); return instance; }
            private set { instance = value; }
        }
        private DataProviderDAO() { }
        // ------------------------------------------------------------------------------
        // Lấy chuỗi kết nối từ database


        #region Thực thi lệnh
        public DataTable ExecuteQuery(string query, object[] paramList = null)
        {
            // Tạo datatable để đổ dữ liệu từ câu lệnh truy vấn vào
            DataTable data = new DataTable();
            // Tạo kết nối với database sử dụng chuỗi kết nối
            using (MySqlConnection connection = DataEstablishment.Instance.connection)
            {
                // Mở kết nối trước khi truy vấn tới kết nối
                connection.Open();
                // Tạo object để thực thi chuỗi truy vấn dựa trên kết nối phía trên
                MySqlCommand command = new MySqlCommand(query, connection);

                // Này code chạy procedure trong sql sever
                // h mình dùng mysql nên phải sửa khúc này lại
                //string[] SplitedQuery = query.Split(' ');
                //if (paramList != null)
                //{
                //    int i = 0;
                //    foreach (var item in SplitedQuery)
                //    {
                //        if (item.Contains('@'))
                //        {
                //            command.Parameters.AddWithValue(item, paramList[i]);
                //            i++;
                //        }
                //    }
                //}

                // Tạo một adapter để làm trung gian xử lí dữ liệu
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Đổ dữ liệu từ adapter vào data
                adapter.Fill(data);
                // Đóng kết nối
                connection.Close();
            }
            return data;
        }
        #endregion

        #region Trả về số dòng được thực thi (INSERT, UPDATE, REMOVE, DROP)
        public int ExecuteNonQuery(string query, object[] paramList = null)
        {
            // Tạo data chứa số dòng insert thành công
            int data = 0;
            // Tạo kết nối với database sử dụng chuỗi kết nối
            using (MySqlConnection connection = DataEstablishment.Instance.connection)
            {
                // Mở kết nối trước khi truy vấn tới kết nối
                connection.Open();
                // Tạo object để thực thi chuỗi truy vấn dựa trên kết nối phía trên
                MySqlCommand command = new MySqlCommand(query, connection);

                string[] SplitedQuery = query.Split(' ');
                //if (paramList != null)
                //{
                //    int i = 0;
                //    foreach (var item in SplitedQuery)
                //    {
                //        if (item.Contains('@'))
                //        {
                //            command.Parameters.AddWithValue(item, paramList[i]);
                //            i++;
                //        }
                //    }
                //}

                data = command.ExecuteNonQuery();
                // Đóng kết nối
                connection.Close();
            }
            return data;
        }
        #endregion

        #region Lệnh SELECT trong database 
        public object ExecuteScalar(string query, object[] paramList = null)
        {
            // Tạo object trả về
            object data = 0;
            // Tạo kết nối với database sử dụng chuỗi kết nối
            using (MySqlConnection connection = DataEstablishment.Instance.connection)
            {
                // Mở kết nối trước khi truy vấn tới kết nối
                connection.Open();
                // Tạo object để thực thi chuỗi truy vấn dựa trên kết nối phía trên
                MySqlCommand command = new MySqlCommand(query, connection);

                string[] SplitedQuery = query.Split(' ');
                //if (paramList != null)
                //{
                //    int i = 0;
                //    foreach (var item in SplitedQuery)
                //    {
                //        if (item.Contains('@'))
                //        {
                //            command.Parameters.AddWithValue(item, paramList[i]);
                //            i++;
                //        }
                //    }
                //}

                data = command.ExecuteScalar();
                // Đóng kết nối
                connection.Close();
            }
            return data;
        }
        #endregion
    }
}
