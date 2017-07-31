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
using CrystalDecisions.CrystalReports.Engine;

namespace TrainingManagement.GUI
{
    public partial class ucRPBangTotNghiep : UserControl
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
        public ucRPBangTotNghiep()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string rs = cbHoTen.Text.Trim();
            DataTable dt = new DataTable();
            dt = bllTaiKhoan.getBangTotNghiep(rs);
            Reports.rpBangTotNghiep rp = new Reports.rpBangTotNghiep();
            rp.SetDataSource(dt);
            ctrvBangTotNghiep.ReportSource = rp;
        }

        private void ucBangTotNghiep_Load(object sender, EventArgs e)
        {
            LoadComboSV();
        }
        public void LoadComboSV()
        {
            DataTable ds = new DataTable();
            ds = bllTaiKhoan.getAllGetSV();
            cbHoTen.DisplayMember = "hoten";
            cbHoTen.ValueMember = "hoten";
            cbHoTen.DataSource = ds;

        }
    }
}
