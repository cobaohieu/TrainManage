using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace TrainingManagement.GUI
{
    public partial class ucRPKQCacMonHocCuaSV : UserControl
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
        public ucRPKQCacMonHocCuaSV()
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

        private void ucRPKQCacMonHocCuaSV_Load(object sender, EventArgs e)
        {
            LoadComboSV();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string rs = cbHoTen.Text.Trim();
            DataTable dt = new DataTable();
            dt = bllMonHoc.findDSSVCuaMonHoc(rs);
            Reports.rpKQCacMonHocCuaSV rp = new Reports.rpKQCacMonHocCuaSV();
            rp.SetDataSource(dt);
            ctrvKQCacMonHoc.ReportSource = rp;
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
