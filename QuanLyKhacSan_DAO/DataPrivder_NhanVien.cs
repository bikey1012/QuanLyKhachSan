using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DTO;
namespace QuanLyKhacSan_DAO
{
    public  class DataPrivder_NhanVien
    {
        private static DataPrivder_NhanVien instances;
        string connect = @"Data Source=HOANGBAO\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";

        public static DataPrivder_NhanVien Instances
        {
            get
            {
                return instances;
            }

            set
            {
                instances = value;
            }
        }
        /// <summary>
        /// truy vấn trả về danh sách
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public DataTable ExcuteQuery(string query, object[] parameter =null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                conn.Close();
            }
            return data;
        }

        //public bool 
    }
}
