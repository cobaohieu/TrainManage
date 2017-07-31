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
    public partial class uctblHocKy : UserControl
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
        public uctblHocKy()
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

        private void dgvHocKy_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgvHocKy.CurrentRow.Index;
                lblID.Text = dgvHocKy.Rows[i].Cells["id"].Value.ToString();
                txtMaHocKy.Text = dgvHocKy.Rows[i].Cells["mahocky"].Value.ToString();
                txtTenHocKy.Text = dgvHocKy.Rows[i].Cells["tenhocky"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }

        }

        private void uctblHocKy_Load(object sender, EventArgs e)
        {
            ReLoad();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllHocKy.getAllHocKy();
            dgvHocKy.DataSource = dt;
        }

        public void SetNull()
        {
            txtMaHocKy.Text = "";
            txtTenHocKy.Text = "";
        }
        string flag;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvHocKy_SelectionChanged(sender, e);
            flag = "add";
            SetNull();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvHocKy_SelectionChanged(sender, e);
            flag = "update";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dgvHocKy_SelectionChanged(sender, e);
            flag = "delete";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        public bool CheckObject()
        {
            if (string.IsNullOrEmpty(txtMaHocKy.Text))
            {
                MessageBox.Show("Bạn chua nhập thông tin Mã Học Kỳ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHocKy.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenHocKy.Text))
            {

                MessageBox.Show("Bạn chua nhập thông tin Tên Học Kỳ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHocKy.Focus();
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
                Entities.tblHocKy kh = new Entities.tblHocKy();
                kh.Id = _ID;
                kh.Mahocky = txtMaHocKy.Text;
                kh.Tenhocky = txtTenHocKy.Text;
                if (flag == "add")
                {
                    bool check = bllHocKy.insertHocKy(kh);
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "update")
                {
                    bool check = bllHocKy.updateHocKy(kh);
                    if (check)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "delete")
                {
                    bool check = bllHocKy.deleteHocKy(kh);
                    if (check)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                ReLoad();
                dgvHocKy_SelectionChanged(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetNull();
            ReLoad();

        }
    }
}
