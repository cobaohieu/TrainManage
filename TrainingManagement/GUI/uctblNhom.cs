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
    public partial class uctblNhom : UserControl
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
        public uctblNhom()
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

        private void dgvNhom_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgvNhom.CurrentRow.Index;
                lblID.Text = dgvNhom.Rows[i].Cells["id"].Value.ToString();
                txtMaNhom.Text = dgvNhom.Rows[i].Cells["manhom"].Value.ToString();
                txtTenNhom.Text = dgvNhom.Rows[i].Cells["tennhom"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }

        }

        private void uctblNhom_Load(object sender, EventArgs e)
        {
            ReLoad();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllNhom.getAllNhom();
            dgvNhom.DataSource = dt;
        }

        public void SetNull()
        {
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";
        }
        string flag;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvNhom_SelectionChanged(sender, e);
            flag = "add";
            SetNull();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvNhom_SelectionChanged(sender, e);
            flag = "update";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dgvNhom_SelectionChanged(sender, e);
            flag = "delete";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        public bool CheckObject()
        {
            if (string.IsNullOrEmpty(txtMaNhom.Text))
            {
                MessageBox.Show("Bạn chua nhập thông tin Mã Nhóm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhom.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenNhom.Text))
            {

                MessageBox.Show("Bạn chua nhập thông tin Tên Nhóm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhom.Focus();
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
                Entities.tblNhom kh = new Entities.tblNhom();
                kh.Id = _ID;
                kh.Manhom = txtMaNhom.Text;
                kh.Tennhom = txtTenNhom.Text;
                if (flag == "add")
                {
                    bool check = bllNhom.insertNhom(kh);
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "update")
                {
                    bool check = bllNhom.updateNhom(kh);
                    if (check)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "delete")
                {
                    bool check = bllNhom.deleteNhom(kh);
                    if (check)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                ReLoad();
                dgvNhom_SelectionChanged(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetNull();
            ReLoad();

        }
    }
}
