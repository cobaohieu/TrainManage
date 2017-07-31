using System;
using System.Collections;
using System.Configuration;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TrainingManagement
{
    public partial class frmLogin : Form
    {
        BLL.TaiKhoanBLL bllTaiKhoan;
        public frmLogin()
        {
            InitializeComponent();
            bllTaiKhoan = new BLL.TaiKhoanBLL();
        }

        //X Close

        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát hay không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        //ESC Close
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
                {
                    Dispose(true);
                    this.Close();
                }
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        public bool checkObject()
        {
            string tendangnhap = txtUser.Text;
            string matkhau = txtPass.Text;
            if(string.IsNullOrWhiteSpace(tendangnhap))
            {
                MessageBox.Show("Vui lòng nhập vào Tên tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(matkhau)){
                MessageBox.Show("Vui lòng nhập vào Mật khẩu!","Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtUser.Text.Trim();
            string matkhau = txtPass.Text.Trim();
            try
            {
                DataTable dt = new DataTable();
                dt = bllTaiKhoan.checkTaiKhoan(tendangnhap, matkhau);
                if (checkObject())
                {
                    string s = dt.Rows[0][0].ToString().Trim();
                    int tmp = 0;
                    if (int.TryParse(s, out tmp))
                    {

                    }
                    if (tmp == 0 || tmp < 0)
                    {
                        MessageBox.Show("Xin vui lòng kiểm tra lại: Tên tài khoản hoặc Mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lblHello.Text = dt.Rows[0][3].ToString().Trim();
                        lblId.Text = dt.Rows[0][2].ToString().Trim();
                        string nhom = dt.Rows[0][1].ToString().Trim();
                        if (nhom == "Admin")
                        {
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công!" + "\n" + "Chào bạn: " + lblHello.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmQuanTri _frmQuanTri = new frmQuanTri(lblHello.Text, lblId.Text);
                            _frmQuanTri.Show();
                        }
                        else if (nhom == "Manager")
                        {
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công!" + "\n" + "Chào bạn: " + lblHello.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmQuanLy _frmQuanLy = new frmQuanLy(lblHello.Text, lblId.Text);
                            _frmQuanLy.Show();
                        }
                        else if (nhom == "Teacher")
                        {
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công!" + "\n" + "Chào bạn: " + lblHello.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmGiaoVien _frmGiaoVien = new frmGiaoVien(lblHello.Text, lblId.Text);
                            _frmGiaoVien.Show();
                        }
                        else
                        {
                            this.Hide();
                            MessageBox.Show("Bạn không có quyền truy cập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng." + "\n" + "Xin vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

    }
}
