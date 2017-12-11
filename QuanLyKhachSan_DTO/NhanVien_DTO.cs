using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DTO
{
    public class NhanVien_DTO
    {
        private string manhanvien;
        private string hoten;
        private string chucvu;
        private string gioitinh;
        private DateTime? namsinh;


        public string Manhanvien
        {
            get
            {
                return manhanvien;
            }

            set
            {
                manhanvien = value;
            }
        }

        public string Hoten
        {
            get
            {
                return hoten;
            }

            set
            {
                hoten = value;
            }
        }

        public string Chucvu
        {
            get
            {
                return chucvu;
            }

            set
            {
                chucvu = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public DateTime? Namsinh
        {
            get
            {
                return namsinh;
            }

            set
            {
                namsinh = value;
            }
        }

        /// <summary>
        /// tạo hàm dựng cho nhân viên DTO
        /// </summary>
        /// <param name="manhanvien">mã nhân viên</param>
        /// <param name="hoten">họ tên</param>
        /// <param name="chucvu">chức vụ</param>
        /// <param name="gioitinh">giới tính</param>
        /// <param name="namsinh">nam sinh</param>
        public NhanVien_DTO (string manhanvien, string hoten, string chucvu, string gioitinh, DateTime? namsinh)
        {
            this.manhanvien = manhanvien;
            this.hoten = hoten;
            this.chucvu = chucvu;
            this.gioitinh = gioitinh;
            this.namsinh = namsinh;
        }
    }
}
