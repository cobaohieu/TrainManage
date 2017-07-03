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
using TrainingManagement.GUI;


namespace TrainingManagement.GUI
{
    public partial class ucQLNguoiDung : UserControl
    {
        BLL.ThongTinBLL bllThongTin;
        public ucQLNguoiDung()
        {
            InitializeComponent();
            bllThongTin = new BLL.ThongTinBLL();
        }

        private void ucQLNguoiDung_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllThongTin.getViewThongTin();
            dgvQLNguoiDung.DataSource = dt;
        }

        public bool CheckObject()
        {
            if (string.IsNullOrEmpty(txtTenTaiKhoan.Text))
            {
                MessageBox.Show("Bạn chua nhập thông tin mã lớp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTaiKhoan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenLop.Text))
            {

                MessageBox.Show("Bạn chua nhập thông tin tên lớp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            GUI.ucMain uc = new GUI.ucMain();
            uc.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
