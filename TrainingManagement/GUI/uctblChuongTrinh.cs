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
    public partial class uctblChuongTrinh : UserControl
    {
        BLL.ChuongTrinhBLL bllChuongTrinh;
        public uctblChuongTrinh()
        {
            InitializeComponent();
            bllChuongTrinh = new BLL.ChuongTrinhBLL();
        }

        private void tblChuongTrinhDaoTao_Load(object sender, EventArgs e)
        {
            ReLoad();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllChuongTrinh.getAllChuongTrinh();
            dgvChuongTrinh.DataSource = dt;
        }

        private void dgvChuongTrinh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgvChuongTrinh.CurrentRow.Index;
                lblID.Text = dgvChuongTrinh.Rows[i].Cells["id"].Value.ToString();
                lblIdTrangThai.Text = dgvChuongTrinh.Rows[i].Cells["idtrangthai"].Value.ToString();
                txtMaChuongTrinh.Text = dgvChuongTrinh.Rows[i].Cells["machuongtrinh"].Value.ToString();
                txtTenChuongTrinh.Text = dgvChuongTrinh.Rows[i].Cells["tenchuongtrinh"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }

        private void dgvChuongTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvChuongTrinh.Rows[e.RowIndex];
                _id = dgvRow.Cells[0].Value.ToString();
            }

        }
        public void SetNull()
        {
            txtMaChuongTrinh.Text = "";
            txtTenChuongTrinh.Text = "";
        }
        string flag = "";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvChuongTrinh_SelectionChanged(sender, e);
            flag = "add";
            SetNull();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvChuongTrinh_SelectionChanged(sender, e);
            flag = "update";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dgvChuongTrinh_SelectionChanged(sender, e);
            flag = "delete";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetNull();
            ReLoad();
        }

        public bool CheckObject()
        {
            if (string.IsNullOrEmpty(txtMaChuongTrinh.Text))
            {
                MessageBox.Show("Bạn chua nhập thông tin Mã Khoa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChuongTrinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenChuongTrinh.Text))
            {

                MessageBox.Show("Bạn chua nhập thông tin Tên Khoa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChuongTrinh.Focus();
                return false;
            }
            return true;
        }
        string _id;
        int _ID = 0;
        int _Id = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblID.Text, out _ID))
            {

            }
            if (int.TryParse(lblIdTrangThai.Text, out _Id))
            {

            }
            if (CheckObject())
            {
                Entities.tblChuongTrinh ct = new Entities.tblChuongTrinh();
                ct.Id = _ID;
                ct.Idtrangthai = _Id;
                ct.Machuongtrinh = txtMaChuongTrinh.Text;
                ct.Tenchuongtrinh = txtTenChuongTrinh.Text;
                if (flag == "add")
                {
                    bool check = bllChuongTrinh.insertChuongTrinh(ct);
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "update")
                {
                    bool check = bllChuongTrinh.updateChuongTrinh(ct);
                    if (check)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "delete")
                {
                    bool check = bllChuongTrinh.deleteChuongTrinh(ct);
                    if (check)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                ReLoad();
                dgvChuongTrinh_SelectionChanged(sender, e);
            }

        }
    }
}
