using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Entities
{
    class tblThongTin
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        int _idtaikhoan;

        public int Idtaikhoan
        {
            get { return _idtaikhoan; }
            set { _idtaikhoan = value; }
        }
        string _hoten;

        public string Hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        string _chucvu;

        public string Chucvu
        {
            get { return _chucvu; }
            set { _chucvu = value; }
        }
        DateTime _namsinh;

        public DateTime Namsinh
        {
            get { return _namsinh; }
            set { _namsinh = value; }
        }
        string _gioitinh;

        public string Gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        string _diachi;

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        string _tentaikhoan;

        public string Tentaikhoan
        {
            get { return _tentaikhoan; }
            set { _tentaikhoan = value; }
        }
        string _matkhau;

        public string Matkhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }
        string _nhom;

        public string Nhom
        {
            get { return _nhom; }
            set { _nhom = value; }
        }
    }
}
