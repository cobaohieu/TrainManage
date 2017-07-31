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
    public partial class ucQLKetQua : UserControl
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
        public ucQLKetQua()
        {
            InitializeComponent();
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

        private void ucTKKetQua_Load(object sender, EventArgs e)
        {
            ReLoad();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            LoadComboMonHoc();
        }
        public void LoadComboSinhVien()
        {
            DataTable ds = new DataTable();
            ds = bllTaiKhoan.getAllGetSV();
            cbxTenSinhVien.DisplayMember = "hoten";
            cbxTenSinhVien.ValueMember = "hoten";
            cbxTenSinhVien.DataSource = ds;
        }
        public void LoadComboMonHoc()
        {
            DataTable ds = new DataTable();
            ds = bllMonHoc.getAllMonHoc();
            cbxTenMonHoc.DisplayMember = "tenmonhoc";
            cbxTenMonHoc.ValueMember = "tenmonhoc";
            cbxTenMonHoc.DataSource = ds;
        }
        public void SetNull()
        {
            cbxTenSinhVien.ResetText();
            cbxTenMonHoc.ResetText();
            txtDiemThiLan1.Text = "";
            txtDiemThiLan2.Text = "";
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllKetQua.getViewKetQuaMonHocSV();
            dgvKetQua.DataSource = dt;
        }
        private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgvKetQua.CurrentRow.Index;
                //Khoa
                lblIdKhoa.Text = dgvKetQua.Rows[i].Cells["idkhoa"].Value.ToString();
                lblmakhoa.Text = dgvKetQua.Rows[i].Cells["makhoa"].Value.ToString();
                lblTenKhoa.Text = dgvKetQua.Rows[i].Cells["tenkhoa"].Value.ToString();
                lblsodienthoai.Text = dgvKetQua.Rows[i].Cells["sodienthoai"].Value.ToString();
                //hocky
                lblIdHocKy.Text = dgvKetQua.Rows[i].Cells["idhocky"].Value.ToString();
                lblmahocky.Text = dgvKetQua.Rows[i].Cells["mahocky"].Value.ToString();
                label5.Text = dgvKetQua.Rows[i].Cells["tenhocky"].Value.ToString();
                //chuong trinh
                lblidchuongtrinh.Text = dgvKetQua.Rows[i].Cells["idchuongtrinh"].Value.ToString();
                lblmachuongtrinh.Text = dgvKetQua.Rows[i].Cells["machuongtrinh"].Value.ToString();
                label5.Text = dgvKetQua.Rows[i].Cells["tenchuongtrinh"].Value.ToString();
                //sinhvien
                lblidnienkhoa.Text = dgvKetQua.Rows[i].Cells["idnienkhoa"].Value.ToString();
                lblidsinhvien.Text = dgvKetQua.Rows[i].Cells["idsinhvien"].Value.ToString();
                lblidtinchi.Text = dgvKetQua.Rows[i].Cells["idtinchi"].Value.ToString();
                //mon hoc
                lblidmonhoc.Text = dgvKetQua.Rows[i].Cells["idmonhoc"].Value.ToString();
                lblmamonhoc.Text = dgvKetQua.Rows[i].Cells["mamonhoc"].Value.ToString();
                cbxTenMonHoc.Text = dgvKetQua.Rows[i].Cells["tenmonhoc"].Value.ToString();
                //lop
                lblIdLop.Text = dgvKetQua.Rows[i].Cells["idlop"].Value.ToString();
                lblmalop.Text = dgvKetQua.Rows[i].Cells["malop"].Value.ToString();
                label5.Text = dgvKetQua.Rows[i].Cells["tenlop"].Value.ToString();
                lblsiso.Text = dgvKetQua.Rows[i].Cells["siso"].Value.ToString();
                //ket qua
                lblidketqua.Text = dgvKetQua.Rows[i].Cells["idketqua"].Value.ToString();
                txtDiemThiLan1.Text = dgvKetQua.Rows[i].Cells["diemthilan1"].Value.ToString();
                txtDiemThiLan2.Text = dgvKetQua.Rows[i].Cells["diemthilan2"].Value.ToString();
                lbldiemtrungbinh.Text = dgvKetQua.Rows[i].Cells["diemtrungbinh"].Value.ToString();
                lbldiemtongket.Text = dgvKetQua.Rows[i].Cells["diemtongket"].Value.ToString();
                lblhanhkiem.Text = dgvKetQua.Rows[i].Cells["hanhkiem"].Value.ToString();
                lblghichu.Text = dgvKetQua.Rows[i].Cells["ghichu"].Value.ToString();
                //tai khoan
                lblidtaikhoan.Text = dgvKetQua.Rows[i].Cells["id"].Value.ToString();
                lblidnhom.Text = dgvKetQua.Rows[i].Cells["idnhom"].Value.ToString();
                lbltentaikhoan.Text = dgvKetQua.Rows[i].Cells["tentaikhoan"].Value.ToString();
                lblmatkhau.Text = dgvKetQua.Rows[i].Cells["matkhau"].Value.ToString();
                cbxTenSinhVien.Text = dgvKetQua.Rows[i].Cells["_hoten"].Value.ToString();
                lblnamsinh.Text = dgvKetQua.Rows[i].Cells["namsinh"].Value.ToString();
                lblgioitinh.Text = dgvKetQua.Rows[i].Cells["gioitinh"].Value.ToString();
                lbldiachi.Text = dgvKetQua.Rows[i].Cells["diachi"].Value.ToString();
                lblemail.Text = dgvKetQua.Rows[i].Cells["email"].Value.ToString();
                lbldienthoai.Text = dgvKetQua.Rows[i].Cells["dienthoai"].Value.ToString();
                
            }
            catch
            {
                e.ToString();
            }

        }
        string flag;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flag = "update";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            dgvKetQua_SelectionChanged(sender, e);
        }
        public float DiemTrungBinh(float a, float b)
        {
            float result;
            result = (a + b) / 2;
            return result;
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
            if (float.TryParse(txtDiemThiLan1.Text, out dtl1))
            {

            }
            if (float.TryParse(txtDiemThiLan2.Text, out dtl2))
            {

            }
            if (float.TryParse(lbldiemtongket.Text, out dtk))
            {

            }
            if (DateTime.TryParse(lblnamsinh.Text, out _ns))
            {

            }
            if (float.TryParse(txtDiemThiLan1.Text, out dtl1))
            {

            } if (float.TryParse(txtDiemThiLan2.Text, out dtl2))
            {

            }
            dtb = DiemTrungBinh(dtl1, dtl2);
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
            lp.Tenlop = label5.Text;
            lp.Siso = _ss;
            Entities.tblSinhVien sv = new Entities.tblSinhVien();
            sv.Id = _Idsv;
            sv.Idlop = _Idlp;
            sv.Idtaikhoan = _Idtk;
            sv.Idtrangthai = _Idtt;
            Entities.tblTaiKhoan tk = new Entities.tblTaiKhoan();
            tk.Id = _Idtk;
            tk.Idnhom = _Idnh;
            tk.Tentaikhoan = lbltentaikhoan.Text;
            tk.Matkhau = lblmatkhau.Text;
            tk.Hoten = cbxTenSinhVien.Text;
            tk.Namsinh = _ns;
            tk.Gioitinh = lblgioitinh.Text;
            tk.Diachi = lbldiachi.Text;
            tk.Email = lblemail.Text;
            tk.Dienthoai = lbldienthoai.Text;
            Entities.tblHocKy hk = new Entities.tblHocKy();
            hk.Id = _Idhk;
            hk.Mahocky = lblmahocky.Text;
            hk.Tenhocky = label5.Text;
            Entities.tblKhoa kh = new Entities.tblKhoa();
            kh.Id = _Idkh;
            kh.Makhoa = lblmakhoa.Text;
            kh.Tenkhoa = lblTenKhoa.Text;

            if (flag == "update")
            {

                bool check = bllKetQua.updateKetQua(kq);
                bllMonHoc.updateMonHoc(mh);
                bllSinhVien.updateSinhVien(sv);
                bllTaiKhoan.updateTaiKhoan(tk);
                if (check)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ReLoad();
            }
            ReLoad();
            dgvKetQua_SelectionChanged(sender, e);
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

    }
}
