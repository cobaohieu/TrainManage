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

namespace TrainingManagement.GUI
{
    public partial class ucTKKQSV : UserControl
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
        public ucTKKQSV()
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

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {

        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllTaiKhoan.viewKetQuaTaiKhoan();
            dgvKetQua.DataSource = dt;
        }
        string rs;
        public void ViewCombobox()
        {
            DataTable ds = new DataTable();
            ds = bllTaiKhoan.getAllGetSV();
            cbHoTen.DisplayMember = "hoten";
            cbHoTen.ValueMember = "hoten";
            cbHoTen.DataSource = ds;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            rs = cbHoTen.Text.Trim();
            DataTable dt = new DataTable();
            dt = bllTaiKhoan.findKetQuaTaiKhoan(rs);
            if (dt.Rows.Count > 0)
            {
                dgvKetQua.DataSource = dt;
            }
        }

        private void ucKQSV_Load(object sender, EventArgs e)
        {
            ReLoad();
            ViewCombobox();
        }
    }
}
