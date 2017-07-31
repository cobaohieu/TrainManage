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
    public partial class ucTrangThaiSinhVienCT : UserControl
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
        public ucTrangThaiSinhVienCT()
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
        public void LoadComboKhoa()
        {
            DataTable ds = new DataTable();
            ds = bllKhoa.getAllKhoa();
            cbTenKhoa.DisplayMember = "tenkhoa";
            cbTenKhoa.ValueMember = "tenkhoa";
            cbTenKhoa.DataSource = ds;
        }
        public void LoadComboLop()
        {
            DataTable ds = new DataTable();
            ds = bllLop.getAllLop();
            cbTenLop.DisplayMember = "tenlop";
            cbTenLop.ValueMember = "tenlop";
            cbTenLop.DataSource = ds;
        }
        public void LoadComboHocKy()
        {
            DataTable ds = new DataTable();
            ds = bllHocKy.getAllHocKy();
            cbTenHocKy.DisplayMember = "tenhocky";
            cbTenHocKy.ValueMember = "tenhocky";
            cbTenHocKy.DataSource = ds;
        }
        public void LoadComboChuongTrinh()
        {
            DataTable ds = new DataTable();
            ds = bllChuongTrinh.getAllChuongTrinh();
            cbTenChuongTrinh.DisplayMember = "tenchuongtrinh";
            cbTenChuongTrinh.ValueMember = "tenchuongtrinh";
            cbTenChuongTrinh.DataSource = ds;
        }
        public void LoadComboTrangThai()
        {
            DataTable ds = new DataTable();
            ds = bllTrangThai.getAllTrangThai();
            cbTenTrangThai.DisplayMember = "tentrangthai";
            cbTenTrangThai.ValueMember = "tentrangthai";
            cbTenTrangThai.DataSource = ds;
        }
        public void LoadComboSinhVien()
        {
            DataTable ds = new DataTable();
            ds = bllTaiKhoan.getAllGetSV();
            cbHoTen.DisplayMember = "hoten";
            cbHoTen.ValueMember = "hoten";
            cbHoTen.DataSource = ds;
        }
        private void ucTrangThaiSinhVienCT_Load(object sender, EventArgs e)
        {
            ReLoad();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            LoadComboKhoa();
            LoadComboLop();
            LoadComboHocKy();
            LoadComboChuongTrinh();
            LoadComboTrangThai();
            //LoadComboSinhVien();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllTrangThai.getViewTrangThai();
            dgvTrangThaiSV.DataSource = dt;
        }

        public void SetNull()
        {
            cbHoTen.ResetText();
            cbTenHocKy.ResetText();
            cbTenKhoa.ResetText();
            cbTenLop.ResetText();
            cbTenChuongTrinh.ResetText();
            cbTenTrangThai.ResetText();
        }

        private void dgvTrangThaiSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTrangThaiSV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgvTrangThaiSV.CurrentRow.Index;
                //Khoa
                lblIdKhoa.Text = dgvTrangThaiSV.Rows[i].Cells["idkhoa"].Value.ToString();
                lblmakhoa.Text = dgvTrangThaiSV.Rows[i].Cells["makhoa"].Value.ToString();
                cbTenKhoa.Text = dgvTrangThaiSV.Rows[i].Cells["tenkhoa"].Value.ToString();
                lblsodienthoai.Text = dgvTrangThaiSV.Rows[i].Cells["sodienthoai"].Value.ToString();
                //chuong trinh
                lblidchuongtrinh.Text = dgvTrangThaiSV.Rows[i].Cells["idchuongtrinh"].Value.ToString();
                lblmachuongtrinh.Text = dgvTrangThaiSV.Rows[i].Cells["machuongtrinh"].Value.ToString();
                cbTenChuongTrinh.Text = dgvTrangThaiSV.Rows[i].Cells["tenchuongtrinh"].Value.ToString();
                //trang thai
                lblIdTrangThai.Text = dgvTrangThaiSV.Rows[i].Cells["id"].Value.ToString();
                lblmatrangthai.Text = dgvTrangThaiSV.Rows[i].Cells["matrangthai"].Value.ToString();
                cbTenTrangThai.Text = dgvTrangThaiSV.Rows[i].Cells["tentrangthai"].Value.ToString();
                //hocky
                lblIdHocKy.Text = dgvTrangThaiSV.Rows[i].Cells["idhocky"].Value.ToString();
                lblmahocky.Text = dgvTrangThaiSV.Rows[i].Cells["mahocky"].Value.ToString();
                cbTenHocKy.Text = dgvTrangThaiSV.Rows[i].Cells["tenhocky"].Value.ToString();
                //sinhvien
                lblidnienkhoa.Text = dgvTrangThaiSV.Rows[i].Cells["idnienkhoa"].Value.ToString();
                lblidsinhvien.Text = dgvTrangThaiSV.Rows[i].Cells["idsinhvien"].Value.ToString();
                lblidtinchi.Text = dgvTrangThaiSV.Rows[i].Cells["idtinchi"].Value.ToString();
                //mon hoc
                lblidmonhoc.Text = dgvTrangThaiSV.Rows[i].Cells["idmonhoc"].Value.ToString();
                lblmamonhoc.Text = dgvTrangThaiSV.Rows[i].Cells["mamonhoc"].Value.ToString();
                lbltenmonhoc.Text = dgvTrangThaiSV.Rows[i].Cells["tenmonhoc"].Value.ToString();
                //lop
                lblIdLop.Text = dgvTrangThaiSV.Rows[i].Cells["idlop"].Value.ToString();
                lblmalop.Text = dgvTrangThaiSV.Rows[i].Cells["malop"].Value.ToString();
                cbTenLop.Text = dgvTrangThaiSV.Rows[i].Cells["tenlop"].Value.ToString();
                lblsiso.Text = dgvTrangThaiSV.Rows[i].Cells["siso"].Value.ToString();
                //ket qua
                lblidketqua.Text = dgvTrangThaiSV.Rows[i].Cells["idketqua"].Value.ToString();
                lbldiemtrungbinh.Text = dgvTrangThaiSV.Rows[i].Cells["diemtrungbinh"].Value.ToString();
                lbldiemthilan1.Text = dgvTrangThaiSV.Rows[i].Cells["diemthilan1"].Value.ToString();
                lbldiemthilan2.Text = dgvTrangThaiSV.Rows[i].Cells["diemthilan2"].Value.ToString();
                lbldiemtongket.Text = dgvTrangThaiSV.Rows[i].Cells["diemtongket"].Value.ToString();
                lblhanhkiem.Text = dgvTrangThaiSV.Rows[i].Cells["hanhkiem"].Value.ToString();
                lblghichu.Text = dgvTrangThaiSV.Rows[i].Cells["ghichu"].Value.ToString();
                //tai khoan
                lblidtaikhoan.Text = dgvTrangThaiSV.Rows[i].Cells["idtaikhoan"].Value.ToString();
                lblidnhom.Text = dgvTrangThaiSV.Rows[i].Cells["idnhom"].Value.ToString();
                lbltentaikhoan.Text = dgvTrangThaiSV.Rows[i].Cells["tentaikhoan"].Value.ToString();
                lblmatkhau.Text = dgvTrangThaiSV.Rows[i].Cells["matkhau"].Value.ToString();
                cbHoTen.Text = dgvTrangThaiSV.Rows[i].Cells["hoten"].Value.ToString();
                lblnamsinh.Text = dgvTrangThaiSV.Rows[i].Cells["namsinh"].Value.ToString();
                lblgioitinh.Text = dgvTrangThaiSV.Rows[i].Cells["gioitinh"].Value.ToString();
                lbldiachi.Text = dgvTrangThaiSV.Rows[i].Cells["diachi"].Value.ToString();
                lblemail.Text = dgvTrangThaiSV.Rows[i].Cells["email"].Value.ToString();
                lbldienthoai.Text = dgvTrangThaiSV.Rows[i].Cells["dienthoai"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }

        }
        string flag;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvTrangThaiSV_SelectionChanged(sender, e);
            flag = "update";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }
        int _Idtk = 0;
        int _Idtt = 0;
        int _Idct = 0;
        int _Idkh = 0;
        int _Idtc = 0;
        int _Idsv = 0;
        int _Idmh = 0;
        int _Idkq = 0;
        int _Idnk = 0;
        int _Idlp = 0;
        int _Idhk = 0;
        int _Idnh = 0;
        int _ss = 0;
        float dtl1 = 0;
        float dtl2 = 0;
        float dtb = 0;
        float dtk = 0;
        DateTime _ns;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblIdTrangThai.Text, out _Idtt))
            {

            }
            if (int.TryParse(lblsiso.Text, out _ss))
            {

            }
            if (int.TryParse(lblidtaikhoan.Text, out _Idtk))
            {

            }
            if (int.TryParse(lblidchuongtrinh.Text, out _Idct))
            {

            }
            if (int.TryParse(lblmakhoa.Text, out _Idkh))
            {

            }
            if (int.TryParse(lblidtinchi.Text, out _Idtc))
            {

            }
            if (int.TryParse(lblidsinhvien.Text, out _Idsv))
            {

            }
            if (int.TryParse(lblidnienkhoa.Text, out _Idnk))
            {

            }
            if (int.TryParse(lblidmonhoc.Text, out _Idmh))
            {

            }
            if (int.TryParse(lblidketqua.Text, out _Idkq))
            {

            }
            if (int.TryParse(lblIdLop.Text, out _Idlp))
            {

            }
            if (int.TryParse(lblIdHocKy.Text, out _Idhk))
            {

            }
            if (int.TryParse(lblidnhom.Text, out _Idnh))
            {

            }
            if (float.TryParse(lbldiemthilan1.Text, out dtl1))
            {

            }
            if (float.TryParse(lbldiemthilan2.Text, out dtl2))
            {

            }
            if (float.TryParse(lbldiemtongket.Text, out dtk))
            {

            }
            if (float.TryParse(lbldiemtrungbinh.Text, out dtb))
            {

            }
            if (DateTime.TryParse(lblnamsinh.Text, out _ns))
            {

            }
            Entities.tblTrangThai tt = new Entities.tblTrangThai();
            tt.Id = _Idtt;
            tt.Matrangthai = lblmatrangthai.Text;
            tt.Tentrangthai = cbTenTrangThai.Text;
            Entities.tblChuongTrinh ct = new Entities.tblChuongTrinh();
            ct.Id = _Idct;
            ct.Idtrangthai = _Idtt;
            ct.Machuongtrinh = lblmachuongtrinh.Text;
            ct.Tenchuongtrinh = cbTenChuongTrinh.Text;
            Entities.tblMonHoc mh = new Entities.tblMonHoc();
            mh.Id = _Idmh;
            mh.Idchuongtrinh = _Idct;
            mh.Idhocky = _Idhk;
            mh.Idtinchi = _Idtc;
            mh.Mamonhoc = lblmamonhoc.Text;
            mh.Tenmonhoc = lbltenmonhoc.Text;
            Entities.tblLop lp = new Entities.tblLop();
            lp.Id = _Idlp;
            lp.Idkhoa = _Idkh;
            lp.Malop = lblmalop.Text;
            lp.Tenlop = cbTenLop.Text;
            lp.Siso = _ss;
            Entities.tblSinhVien sv = new Entities.tblSinhVien();
            sv.Id = _Idsv;
            sv.Idlop = _Idlp;
            sv.Idtaikhoan = _Idtk;
            sv.Idtrangthai = _Idtt;
            Entities.tblKetQua kq = new Entities.tblKetQua();
            kq.Id = _Idkq;
            kq.Idsinhvien = _Idsv;
            kq.Idmonhoc = _Idmh;
            kq.Diemthilan1 = dtl1;
            kq.Diemthilan2 = dtl2;
            kq.Diemtrungbinh = dtb;
            kq.Diemtongket = dtk;
            kq.Hanhkiem = lblhanhkiem.Text;
            kq.Ghichu = lblghichu.Text;
            Entities.tblTaiKhoan tk = new Entities.tblTaiKhoan();
            tk.Id = _Idtk;
            tk.Idnhom = _Idnh;
            tk.Tentaikhoan = lbltentaikhoan.Text;
            tk.Matkhau = lblmatkhau.Text;
            tk.Hoten = cbHoTen.Text;
            tk.Namsinh = _ns;
            tk.Gioitinh = lblgioitinh.Text;
            tk.Diachi = lbldiachi.Text;
            tk.Email = lblemail.Text;
            tk.Dienthoai = lbldienthoai.Text;
            Entities.tblHocKy hk = new Entities.tblHocKy();
            hk.Id = _Idhk;
            hk.Mahocky = lblmahocky.Text;
            hk.Tenhocky = cbTenHocKy.Text;
            Entities.tblKhoa kh = new Entities.tblKhoa();
            kh.Id = _Idkh;
            kh.Makhoa = lblmakhoa.Text;
            kh.Tenkhoa = cbTenKhoa.Text;
            if (flag == "update")
            {
                bool check = bllTaiKhoan.updateTaiKhoan(tk);
                bllSinhVien.updateSinhVien(sv);
                bllChuongTrinh.updateChuongTrinh(ct);
                bllTrangThai.updateTrangThai(tt);
                //bllLop.updateLop(lp);
                //bllKhoa.updateKhoa(kh);
                //bllKetQua.updateKetQua(kq);
                //bllMonHoc.updateMonHoc(mh);
                //bllHocKy.updateHocKy(hk);
                if (check)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ReLoad();
            }
            ReLoad();
            dgvTrangThaiSV_SelectionChanged(sender, e);

        }
    }
}
