using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrainingManagement.GUI
{
    public partial class uctblMonHoc : UserControl
    {
        BLL.MonHocBLL bllMonHoc;
        public uctblMonHoc()
        {
            InitializeComponent();
            bllMonHoc = new BLL.MonHocBLL();
        }

        private void tblMonHoc_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllMonHoc.getAllMonHoc();
            dgvMonHoc.DataSource = dt;
        }
        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void SetNull()
        {
            txtMaMonHoc.Text = "";
            txtTenMonHoc.Text = "";
        }
        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgvMonHoc.CurrentRow.Index;
                lblID.Text = dgvMonHoc.Rows[i].Cells["id"].Value.ToString();
                lblIDChuongTrinh.Text = dgvMonHoc.Rows[i].Cells["idchuongtrinh"].Value.ToString();
                lblIDHocKy.Text = dgvMonHoc.Rows[i].Cells["idhocky"].Value.ToString();
                lblIDTinChi.Text = dgvMonHoc.Rows[i].Cells["idtinchi"].Value.ToString();
                txtMaMonHoc.Text = dgvMonHoc.Rows[i].Cells["mamonhoc"].Value.ToString();
                txtTenMonHoc.Text = dgvMonHoc.Rows[i].Cells["tenmonhoc"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }

        }
        string flag = "";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvMonHoc_SelectionChanged(sender, e);
            flag = "add";
            SetNull();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvMonHoc_SelectionChanged(sender, e);
            flag = "update";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dgvMonHoc_SelectionChanged(sender, e);
            flag = "delete";
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }
        public bool CheckObject()
        {
            if (string.IsNullOrEmpty(txtMaMonHoc.Text))
            {
                MessageBox.Show("Bạn chua nhập thông tin Mã Khoa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMonHoc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenMonHoc.Text))
            {
                MessageBox.Show("Bạn chua nhập thông tin Tên Khoa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMonHoc.Focus();
                return false;
            }
            return true;
        }

        int _ID = 0;
        int _idct = 0;
        int _idhk = 0;
        int _idtc = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblID.Text, out _ID))
            {

            }
            if (int.TryParse(lblIDChuongTrinh.Text, out _idct))
            {

            }
            if (int.TryParse(lblIDHocKy.Text, out _idhk))
            {

            }
            if (int.TryParse(lblIDTinChi.Text, out _idtc))
            {

            }
            if (CheckObject())
            {
                Entities.tblMonHoc ct = new Entities.tblMonHoc();
                ct.Id = _ID;
                ct.Idchuongtrinh = _idct;
                ct.Idhocky = _idhk;
                ct.Idtinchi = _idtc;
                ct.Mamonhoc = txtMaMonHoc.Text;
                ct.Tenmonhoc = txtTenMonHoc.Text;
                if (flag == "add")
                {
                    bool check = bllMonHoc.insertMonHoc(ct);
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "update")
                {
                    bool check = bllMonHoc.updateMonHoc(ct);
                    if (check)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                else if (flag == "delete")
                {
                    bool check = bllMonHoc.deleteMonHoc(ct);
                    if (check)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReLoad();
                }
                ReLoad();
                dgvMonHoc_SelectionChanged(sender, e);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetNull();
            ReLoad();

        }
    }
}
