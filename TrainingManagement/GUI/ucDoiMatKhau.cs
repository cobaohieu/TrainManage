using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingManagement.GUI;

namespace TrainingManagement.GUI
{
    public partial class ucDoiMatKhau : UserControl
    {
        BLL.ChuongTrinhBLL bllChuongTrinh;
        BLL.HocKyBLL bllHocKy;
        BLL.KetQuaBLL bllKetQua;
        BLL.KhoaBLL bllKhoa;
        BLL.LopBLL bllLop;
        BLL.MonHocBLL bllMonHoc;
        BLL.NhomBLL bllNhom;
        BLL.NienKhoaBLL bllNienKhoa;
        BLL.SinhVienBLL bllSinhVien;
        BLL.TaiKhoanBLL bllTaiKhoan;
        BLL.TrangThaiBLL bllTrangThai;
        BLL.ChucVuBLL bllChucVu;
        BLL.GiaoVienBLL bllGiaoVien;
        BLL.QuanTriBLL bllQuanTri;
        BLL.TinChiBLL bllTinChi;
        public ucDoiMatKhau()
        {
            InitializeComponent();
            bllChucVu = new BLL.ChucVuBLL();
            bllChuongTrinh = new BLL.ChuongTrinhBLL();
            bllGiaoVien = new BLL.GiaoVienBLL();
            bllHocKy = new BLL.HocKyBLL();
            bllKetQua = new BLL.KetQuaBLL();
            bllKhoa = new BLL.KhoaBLL();
            bllLop = new BLL.LopBLL();
            bllMonHoc = new BLL.MonHocBLL();
            bllNhom = new BLL.NhomBLL();
            bllNienKhoa = new BLL.NienKhoaBLL();
            bllQuanTri = new BLL.QuanTriBLL();
            bllSinhVien = new BLL.SinhVienBLL();
            bllTaiKhoan = new BLL.TaiKhoanBLL();
            bllTinChi = new BLL.TinChiBLL();
            bllTrangThai = new BLL.TrangThaiBLL();
        }
        public bool CheckObject()
        {
            string matkhaucu = txtMatKhauCu.Text;
            string matkhaumoi = txtMatKhauMoi.Text;
            string matkhaumoi_ = TxtMatKhauMoi_.Text;
            if(string.IsNullOrWhiteSpace(matkhaucu))
            {
                MessageBox.Show("Vui lòng nhập vào Mật khẩu cũ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauCu.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(matkhaumoi))
            {
                MessageBox.Show("Vui lòng nhập vào Mật khẩu mới!","Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrWhiteSpace(matkhaumoi_))
            {
                MessageBox.Show("Vui lòng nhập vào Nhập vào mật khẩu mới!","Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        int _ID = 0;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string matkhaucu = txtMatKhauCu.Text;
            string matkhaumoi = txtMatKhauMoi.Text;
            string matkhaumoi_ = TxtMatKhauMoi_.Text;
            if (int.TryParse(lblID.Text, out _ID)) 
            { 

            }
            //DataTable ds = new DataTable();
            //ds = bllTaiKhoan.getAllTaiKhoan();
            //lblMatKhau.Text = "matkhau";
            //lblMatKhau.DataSource = ds;
            if (CheckObject())
            {
                if (matkhaumoi == matkhaumoi_)
                {
                    Entities.tblTaiKhoan kh = new Entities.tblTaiKhoan();
                    kh.Id = _ID;
                    kh.Idnhom = kh.Idnhom;
                    kh.Tentaikhoan = lblTenTaiKhoan.Text;
                    kh.Matkhau = matkhaumoi;
                    kh.Hoten = kh.Hoten;
                    kh.Namsinh = kh.Namsinh;
                    kh.Gioitinh = kh.Gioitinh;
                    kh.Diachi = kh.Diachi;
                    kh.Email = kh.Email;
                    kh.Dienthoai = kh.Dienthoai;
                    bool check = bllTaiKhoan.updateTaiKhoan(kh);
                    if (check)
                    {
                        MessageBox.Show("Cập nhật mật khẩu mới thành công." + "\n" + "Xin vui lòng đăng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form tmp = this.FindForm();
                        tmp.Close();
                        tmp.Dispose();
                        frmLogin _frmLogin = new frmLogin();
                        _frmLogin.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại." + "\n" + "Mật khẩu mới không trùng khớp với Nhập lại mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void ucDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhauCu.Focus();
        }
    }
}
