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
    public partial class uctblTinChi : UserControl
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
        public uctblTinChi()
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

        private void uctblTinChi_Load(object sender, EventArgs e)
        {
            ReLoad();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllTinChi.getAllTinChi();
            dgvTinChi.DataSource = dt;
        }
        public void SetNull()
        {
            txtMaTinChi.Text = "";
            txtSoTinChi.Text = "";
        }

        private void dgvTinChi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgvTinChi.CurrentRow.Index;
                lblID.Text = dgvTinChi.Rows[i].Cells["id"].Value.ToString();
                txtMaTinChi.Text = dgvTinChi.Rows[i].Cells["matinchi"].Value.ToString();
                txtSoTinChi.Text = dgvTinChi.Rows[i].Cells["sotinchi"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }

        }
        string flag;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvTinChi_SelectionChanged(sender, e);
            flag = "add";
            SetNull();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvTinChi_SelectionChanged(sender, e);
            flag = "update";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dgvTinChi_SelectionChanged(sender, e);
            flag = "delete";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        public bool CheckObject()
        {
            if (string.IsNullOrEmpty(txtMaTinChi.Text))
            {
                MessageBox.Show("Bạn chua nhập thông tin Mã Tín Chỉ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTinChi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoTinChi.Text))
            {

                MessageBox.Show("Bạn chua nhập thông tin Số Tín Chỉ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTinChi.Focus();
                return false;
            }
            return true;
        }
        int _ID = 0;
        int _stc = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblID.Text, out _ID))
            {

            }
            if (int.TryParse(txtSoTinChi.Text, out _stc))
            {

            }
            if (CheckObject())
            {
                Entities.tblTinChi kh = new Entities.tblTinChi();
                kh.Id = _ID;
                kh.Matinchi = txtMaTinChi.Text;
                kh.Sotinchi = _stc;
                if (flag == "add")
                {
                    bool check = bllTinChi.insertTinChi(kh);
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "update")
                {
                    bool check = bllTinChi.updateTinChi(kh);
                    if (check)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "delete")
                {
                    bool check = bllTinChi.deleteTinChi(kh);
                    if (check)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                ReLoad();
                dgvTinChi_SelectionChanged(sender, e);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetNull();
            ReLoad();

        }
    }
}
