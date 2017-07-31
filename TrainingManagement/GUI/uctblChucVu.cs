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
    public partial class uctblChucVu : UserControl
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
        public uctblChucVu()
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

        private void dgvChucVu_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgvChucVu.CurrentRow.Index;
                lblID.Text = dgvChucVu.Rows[i].Cells["id"].Value.ToString();
                txtMaChucVu.Text = dgvChucVu.Rows[i].Cells["machucvu"].Value.ToString();
                txtTenChucVu.Text = dgvChucVu.Rows[i].Cells["tenchucvu"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }

        }

        private void uctblChucVu_Load(object sender, EventArgs e)
        {
            ReLoad();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllChucVu.getAllChucVu();
            dgvChucVu.DataSource = dt;
        }

        public void SetNull()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
        }
        string flag;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvChucVu_SelectionChanged(sender, e);
            flag = "add";
            SetNull();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvChucVu_SelectionChanged(sender, e);
            flag = "update";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dgvChucVu_SelectionChanged(sender, e);
            flag = "delete";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        public bool CheckObject()
        {
            if (string.IsNullOrEmpty(txtMaChucVu.Text))
            {
                MessageBox.Show("Bạn chua nhập thông tin Mã Chức Vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChucVu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenChucVu.Text))
            {

                MessageBox.Show("Bạn chua nhập thông tin Tên Chức Vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChucVu.Focus();
                return false;
            }
            return true;
        }
        int _ID = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblID.Text, out _ID))
            {

            }
            if (CheckObject())
            {
                Entities.tblChucVu kh = new Entities.tblChucVu();
                kh.Id = _ID;
                kh.Machucvu = txtMaChucVu.Text;
                kh.Tenchucvu = txtTenChucVu.Text;
                if (flag == "add")
                {
                    bool check = bllChucVu.insertChucVu(kh);
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "update")
                {
                    bool check = bllChucVu.updateChucVu(kh);
                    if (check)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "delete")
                {
                    bool check = bllChucVu.deleteChucVu(kh);
                    if (check)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                ReLoad();
                dgvChucVu_SelectionChanged(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetNull();
            ReLoad();

        }
    }
}
