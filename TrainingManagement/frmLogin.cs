using System;
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
using Microsoft;

namespace TrainingManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
            this.txtUser.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            this.Controls.Clear();
            foreach (Control c in this.Controls)
            {
                this.Controls.Add(c);
            }
            frmGiaoVien _frmGiaoVien = new frmGiaoVien();
            _frmGiaoVien.ShowDialog();
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            SqlConnection con = new SqlConnection();  
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";  
            con.Open();  
            string userid = txtUser.Text;  
            string password = txtPass.Text;  
            SqlCommand cmd = new SqlCommand("select userid,password from login where userid='" + txtUser.Text + "'and password='" + txtPass.Text + "'", con);  
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataTable dt = new DataTable();  
            da.Fill(dt);   
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Homepage http://krishnasinghprogramming.nlogspot.com");
                System.Diagnostics.Process.Start("http://krishnasinghprogramming.blogspot.com");
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();   
            /*
             *
            DataTable dt = SqlHelper.ExecuteDatabaset(ConnectString.text, "tblTaiKhoan", username, password).Tables[12];
            if(dt.Rows.Count > 0)
            {
                string permission = dt.Rows[0][2].ToString;

            }
             * */
        }
    }
}
