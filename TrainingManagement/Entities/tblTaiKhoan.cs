using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Entities
{
    class tblTaiKhoan
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _tentrangthai;

        public string Tentrangthai
        {
            get { return _tentrangthai; }
            set { _tentrangthai = value; }
        }
        int _idlop;

        public int Idlop
        {
            get { return _idlop; }
            set { _idlop = value; }
        }
        int _idtaikhoan;

        public int Idtaikhoan
        {
            get { return _idtaikhoan; }
            set { _idtaikhoan = value; }
        }
        int _idtrangthai;

        public int Idtrangthai
        {
            get { return _idtrangthai; }
            set { _idtrangthai = value; }
        }
        string _machuongtrinh;

        public string Machuongtrinh
        {
            get { return _machuongtrinh; }
            set { _machuongtrinh = value; }
        }
        string _tenchuongtrinh;

        public string Tenchuongtrinh
        {
            get { return _tenchuongtrinh; }
            set { _tenchuongtrinh = value; }
        }
        int _idsinhvien;

        public int Idsinhvien
        {
            get { return _idsinhvien; }
            set { _idsinhvien = value; }
        }
        int _idmonhoc;

        public int Idmonhoc
        {
            get { return _idmonhoc; }
            set { _idmonhoc = value; }
        }
        float _diemtrungbinh;

        public float Diemtrungbinh
        {
            get { return _diemtrungbinh; }
            set { _diemtrungbinh = value; }
        }
        float _diemthilan1;

        public float Diemthilan1
        {
            get { return _diemthilan1; }
            set { _diemthilan1 = value; }
        }
        float _diemthilan2;

        public float Diemthilan2
        {
            get { return _diemthilan2; }
            set { _diemthilan2 = value; }
        }
        float _diemtongket;

        public float Diemtongket
        {
            get { return _diemtongket; }
            set { _diemtongket = value; }
        }
        string _hanhkiem;

        public string Hanhkiem
        {
            get { return _hanhkiem; }
            set { _hanhkiem = value; }
        }
        string _ghichu;

        public string Ghichu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }
        int _idkhoa;

        public int Idkhoa
        {
            get { return _idkhoa; }
            set { _idkhoa = value; }
        }
        string _makhoa;

        public string Makhoa
        {
            get { return _makhoa; }
            set { _makhoa = value; }
        }
        string _tenkhoa;

        public string Tenkhoa
        {
            get { return _tenkhoa; }
            set { _tenkhoa = value; }
        }
        string _sodienthoai;

        public string Sodienthoai
        {
            get { return _sodienthoai; }
            set { _sodienthoai = value; }
        }
        int _idnienkhoa;

        public int Idnienkhoa
        {
            get { return _idnienkhoa; }
            set { _idnienkhoa = value; }
        }
        string _malop;

        public string Malop
        {
            get { return _malop; }
            set { _malop = value; }
        }
        string _tenlop;

        public string Tenlop
        {
            get { return _tenlop; }
            set { _tenlop = value; }
        }
        int _siso;

        public int Siso
        {
            get { return _siso; }
            set { _siso = value; }
        }
        int _idchuongtrinh;

        public int Idchuongtrinh
        {
            get { return _idchuongtrinh; }
            set { _idchuongtrinh = value; }
        }
        int _idhocky;

        public int Idhocky
        {
            get { return _idhocky; }
            set { _idhocky = value; }
        }
        int _idtinchi;

        public int Idtinchi
        {
            get { return _idtinchi; }
            set { _idtinchi = value; }
        }
        string _mamonhoc;

        public string Mamonhoc
        {
            get { return _mamonhoc; }
            set { _mamonhoc = value; }
        }
        string _tenmonhoc;

        public string Tenmonhoc
        {
            get { return _tenmonhoc; }
            set { _tenmonhoc = value; }
        }
        string _mahocky;

        public string Mahocky
        {
            get { return _mahocky; }
            set { _mahocky = value; }
        }
        string _tenhocky;

        public string Tenhocky
        {
            get { return _tenhocky; }
            set { _tenhocky = value; }
        }

        string _manhom;

        public string Manhom
        {
            get { return _manhom; }
            set { _manhom = value; }
        }
        string _tennhom;

        public string Tennhom
        {
            get { return _tennhom; }
            set { _tennhom = value; }
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
        int _idnhom;

        public int Idnhom
        {
            get { return _idnhom; }
            set { _idnhom = value; }
        }

        string _hoten;

        public string Hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
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
        string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        string _dienthoai;

        public string Dienthoai
        {
            get { return _dienthoai; }
            set { _dienthoai = value; }
        }
        string _matinchi;

        public string Matinchi
        {
            get { return _matinchi; }
            set { _matinchi = value; }
        }
        int _sotinchi;

        public int Sotinchi
        {
            get { return _sotinchi; }
            set { _sotinchi = value; }
        }
        int _idketqua;

        public int Idketqua
        {
            get { return _idketqua; }
            set { _idketqua = value; }
        }
    }
}
