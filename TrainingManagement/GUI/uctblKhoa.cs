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
    public partial class uctblKhoa : UserControl
    {
        BLL.KhoaBLL bllKhoa;
        public uctblKhoa()
        {
            InitializeComponent();
            bllKhoa = new BLL.KhoaBLL();
        }

        private void tblKhoa_Load(object sender, EventArgs e)
        {
            ReLoad();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllKhoa.getAllKhoa();
            dgvKhoa.DataSource = dt;
        }
        public void SetNull()
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtSoDienThoai.Text = "";
        }
        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgvKhoa.CurrentRow.Index;
                lblID.Text = dgvKhoa.Rows[i].Cells["id"].Value.ToString();
                txtMaKhoa.Text = dgvKhoa.Rows[i].Cells["makhoa"].Value.ToString();
                txtTenKhoa.Text = dgvKhoa.Rows[i].Cells["tenkhoa"].Value.ToString();
                txtSoDienThoai.Text = dgvKhoa.Rows[i].Cells["sodienthoai"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }

        }
        string flag;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvKhoa_SelectionChanged(sender, e);
            flag = "add";
            SetNull();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvKhoa_SelectionChanged(sender, e);
            flag = "update";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dgvKhoa_SelectionChanged(sender, e);
            flag = "delete";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetNull();
            ReLoad();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

        }
        public bool CheckObject()
        {
            if (string.IsNullOrEmpty(txtMaKhoa.Text))
            {
                MessageBox.Show("Bạn chua nhập thông tin Mã Khoa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhoa.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenKhoa.Text))
            {

                MessageBox.Show("Bạn chua nhập thông tin Tên Khoa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhoa.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoDienThoai.Text))
            {

                MessageBox.Show("Bạn chua nhập thông tin Số Điện Thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }
            return true;
        }
        string _id;
        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int _ID = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblID.Text, out _ID)) 
            { 

            }
            if (CheckObject())
            {
                Entities.tblKhoa kh = new Entities.tblKhoa();
                kh.Id = _ID;
                kh.Makhoa = txtMaKhoa.Text;
                kh.Tenkhoa = txtTenKhoa.Text;
                kh.Sodienthoai = txtSoDienThoai.Text;
                if (flag == "add")
                {
                    bool check = bllKhoa.insertKhoa(kh);
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "update")
                {
                    bool check = bllKhoa.updateKhoa(kh);
                    if (check)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "delete")
                {
                    bool check = bllKhoa.deleteKhoa(kh);
                    if (check)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                ReLoad();
                dgvKhoa_SelectionChanged(sender, e);
            }
        }
    }
}
