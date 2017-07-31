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
    public partial class ucRPCTCacMonHoc : UserControl
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
        public ucRPCTCacMonHoc()
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

        private void ucRPCTCacMonHoc_Load(object sender, EventArgs e)
        {
            LoadCombobox();
        }
        public void LoadCombobox()
        {
            DataTable ds = new DataTable();
            ds = bllChuongTrinh.getAllChuongTrinh();
            cbTenChuongTrinh.DisplayMember = "tenchuongtrinh";
            cbTenChuongTrinh.ValueMember = "tenchuongtrinh";
            cbTenChuongTrinh.DataSource = ds;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string rs = cbTenChuongTrinh.Text.Trim();
            DataTable dt = new DataTable();
            dt = bllChuongTrinh.findTenChuongTrinh(rs);
            Reports.rpChiTietCacMonHoc rp = new Reports.rpChiTietCacMonHoc();
            rp.SetDataSource(dt);
            ctrvChiTietCacMonHoc.ReportSource = rp;
        }
    }
}
