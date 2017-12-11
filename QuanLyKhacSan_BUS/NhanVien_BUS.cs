using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DTO;
using QuanLyKhacSan_DAO;
using System.Windows.Forms;

namespace QuanLyKhacSan_BUS
{
    public class NhanVien_BUS
    {
        private static NhanVien_BUS instances;

        public static NhanVien_BUS Instances
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
        private NhanVien_BUS() { }
        public void LoadNhanVien(DataGridView data)
        {
            data.DataSource = NhanVien.Instances.LoadNhanVien();
        }
    }
}
