using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_DTO;
namespace QuanLyKhacSan_DAO
{
    public class NhanVien
    {
        private static NhanVien instances;

        public static NhanVien Instances
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
        private NhanVien() { }

        public List<NhanVien_DTO> LoadNhanVien()
        {
            List<NhanVien_DTO> nhanvien = new List<NhanVien_DTO>();
            string query = "exec usp_LoadNV";
            DataTable data = DataPrivder_NhanVien.Instances.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string manhanvien = item["MA_NHAN_VIEN"].ToString();
                string hoten = item["HO_TEN"].ToString();
                string chucvu = item["CHUC_VU"].ToString();
                string gioitinh = item["GIOI_TINH"].ToString();
                DateTime? namsinh = item["NAM_SINH"].ToString() == string.Empty ? null : (DateTime?)item["NAM_SINH"];
                NhanVien_DTO nv = new NhanVien_DTO(manhanvien, hoten, chucvu, gioitinh, namsinh);
                nhanvien.Add(nv);
            }
            return nhanvien;
        }
    }
}
