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
    public partial class uctblTaiKhoan : UserControl
    {
        BLL.TaiKhoanBLL bllTaiKhoan;
        BLL.NhomBLL bllNhom;
        public uctblTaiKhoan()
        {
            InitializeComponent();
            bllTaiKhoan = new BLL.TaiKhoanBLL();
            bllNhom = new BLL.NhomBLL();
        }

        private void tblTaiKhoan_Load(object sender, EventArgs e)
        {
            ReLoad();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllTaiKhoan.getAllTaiKhoan();
            dgvTaiKhoan.DataSource = dt;
        }
        public void SetNull()
        {
            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            dtpNamSinh.ResetText();
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            cbQuyen.ResetText();
            cbGioiTinh.ResetText();
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgvTaiKhoan.CurrentRow.Index;
                lblID.Text = dgvTaiKhoan.Rows[i].Cells["id"].Value.ToString();
                lblIDNhom.Text = dgvTaiKhoan.Rows[i].Cells["idnhom"].Value.ToString();
                txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[i].Cells["tentaikhoan"].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.Rows[i].Cells["matkhau"].Value.ToString();
                cbQuyen.Text = dgvTaiKhoan.Rows[i].Cells["tennhom"].Value.ToString();
                txtHoTen.Text = dgvTaiKhoan.Rows[i].Cells["hoten"].Value.ToString();
                dtpNamSinh.Text = dgvTaiKhoan.Rows[i].Cells["namsinh"].Value.ToString();
                cbGioiTinh.Text = dgvTaiKhoan.Rows[i].Cells["gioitinh"].Value.ToString();
                txtDiaChi.Text = dgvTaiKhoan.Rows[i].Cells["diachi"].Value.ToString();
                txtEmail.Text = dgvTaiKhoan.Rows[i].Cells["email"].Value.ToString(); 
                txtDienThoai.Text = dgvTaiKhoan.Rows[i].Cells["dienthoai"].Value.ToString();
                lblMaNhom.Text = dgvTaiKhoan.Rows[i].Cells["manhom"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }
        
        string flag = "";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan_SelectionChanged(sender, e);
            flag = "add";
            SetNull();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            DataTable ds = new DataTable();
            ds = bllNhom.getAllNhom();
            cbQuyen.DisplayMember = "tennhom";
            cbQuyen.ValueMember = "tennhom";
            cbQuyen.DataSource = ds;
            cbGioiTinh.DisplayMember = "Text";
            cbGioiTinh.ValueMember = "Value";
            var items = new[] 
            { 
                new { Text = "Nam", Value = "Nam" }, 
                new { Text = "Nữ", Value = "Nữ" }
            };
            cbGioiTinh.DataSource = items;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan_SelectionChanged(sender, e);
            flag = "update";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            DataTable ds = new DataTable();
            ds = bllNhom.getAllNhom();
            cbQuyen.DisplayMember = "tennhom";
            cbQuyen.ValueMember = "tennhom";
            cbQuyen.DataSource = ds;
            cbGioiTinh.DisplayMember = "Text";
            cbGioiTinh.ValueMember = "Value";
            var items = new[] 
            { 
                new { Text = "Nam", Value = "Nam" }, 
                new { Text = "Nữ", Value = "Nữ" }
            };
            cbGioiTinh.DataSource = items;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan_SelectionChanged(sender, e);
            flag = "delete";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            DataTable ds = new DataTable();
            ds = bllNhom.getAllNhom();
            cbQuyen.DisplayMember = "tennhom";
            cbQuyen.ValueMember = "tennhom";
            cbQuyen.DataSource = ds;
            cbGioiTinh.DisplayMember = "Text";
            cbGioiTinh.ValueMember = "Value";
            var items = new[] 
            { 
                new { Text = "Nam", Value = "Nam" }, 
                new { Text = "Nữ", Value = "Nữ" }
            };
            cbGioiTinh.DataSource = items;
        }
        string _tmp;
        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvTaiKhoan.Rows[e.RowIndex];
                _tmp = dgvRow.Cells[0].Value.ToString();
            }
        }

        int _ID = 0;
        int _id = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblID.Text, out _ID)) 
            { 

            }
            if (int.TryParse(lblIDNhom.Text, out _id)) 
            {

            }
            if (CheckObject())
            {
                Entities.tblTaiKhoan kh = new Entities.tblTaiKhoan();
                kh.Id = _ID;
                kh.Idnhom = _id;
                kh.Tentaikhoan = txtTenTaiKhoan.Text;
                kh.Matkhau = txtMatKhau.Text;
                kh.Hoten = txtHoTen.Text;
                kh.Namsinh = dtpNamSinh.Value;
                kh.Gioitinh = cbGioiTinh.Text;
                kh.Diachi = txtDiaChi.Text;
                kh.Email = txtEmail.Text;
                kh.Dienthoai = txtDienThoai.Text;
                Entities.tblNhom nh = new Entities.tblNhom();
                nh.Id = _id;
                nh.Manhom = lblMaNhom.Text;
                nh.Tennhom = cbQuyen.Text;
                if (flag == "add")
                {
                    bool check = bllTaiKhoan.insertTaiKhoan(kh);
                    bllNhom.insertNhom(nh);
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "update")
                {
                    bool check = bllTaiKhoan.updateTaiKhoan(kh);
                    bllNhom.updateNhom(nh);
                    if (check)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "delete")
                {
                    bool check = bllTaiKhoan.deleteTaiKhoan(kh);
                    if (check)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                ReLoad();
                dgvTaiKhoan_SelectionChanged(sender, e);
            }

        }
        public bool CheckObject()
        {
            if (string.IsNullOrEmpty(txtTenTaiKhoan.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin Tên đăng nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTaiKhoan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {

                MessageBox.Show("Bạn chưa nhập thông tin Mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbQuyen.Text))
            {

                MessageBox.Show("Bạn chưa chọn thông tin Quyền", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbQuyen.Focus();
                return false;
            }
            return true;
        }


    }
}
