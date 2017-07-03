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
            /*
            
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
            return base.ProcessDialogKey(keyData); 
             */
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
            }
        }
        //Encrypt password code
        /*
        public string HashPass(string password)
        {
            SHA256 sha = new SHA256CryptoServiceProvider();

            //compute hash from the bytes of text
            sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password + email));

            //get hash result after compute it
            byte[] result = sha.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
        */

        private void txtGioiThieu_TextChanged(object sender, EventArgs e)
        {


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
                    if (dt.Rows[0][0].ToString().Trim() != "0")
                    {
                        string nhom = dt.Rows[0][1].ToString().Trim();
                        if (nhom == "Admin")
                        {
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmQuanTri _frmQuanTri = new frmQuanTri();
                            _frmQuanTri.Show();
                        }
                        else if (nhom == "Manager")
                        {
                            this.Hide();
                            frmQuanLy _frmQuanLy = new frmQuanLy();
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _frmQuanLy.Show();
                        }
                        else if (nhom == "Teacher")
                        {
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmGiaoVien _frmGiaoVien = new frmGiaoVien();
                            _frmGiaoVien.Show();
                        }
                        else
                        {
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xin vui lòng kiểm tra lại: Tên tài khoản hoặc Mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
