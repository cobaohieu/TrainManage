using System;
using System.Collections;
using System.Configuration;
using System.Data.Entity;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using TrainManageWeb.GUI;

namespace TrainManageWeb
{
    public partial class login1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=KHDT-HIEU;Initial Catalog=trainmanage; User Id=sa; Password=123456789");
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["idlogin"] = null;
            txtuser.Focus();

        }

        int _ID = 0;
        int _id = 0;
        int _Id = 0;

        public void CheckID()
        {
            string query = "sp_tblTaiKhoan_CheckID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tentaikhoan", txtuser.Text.Trim());
            cmd.Parameters.AddWithValue("@matkhau", txtpass.Text.Trim());
            string output = cmd.ExecuteScalar().ToString();
            if (int.TryParse(output, out _Id))
            {

            }
        }

        public void CheckIDGroup()
        {
            string qr = "sp_tblTaiKhoan_CheckGroup";
            SqlCommand comd = new SqlCommand(qr, con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.AddWithValue("@tentaikhoan", txtuser.Text.Trim());
            comd.Parameters.AddWithValue("@matkhau", txtpass.Text.Trim());
            string s = comd.ExecuteScalar().ToString();
            if (int.TryParse(s, out _id))
            {

            }
        }
        public void CheckAccount()
        {
            string query = "sp_tblTaiKhoan_CheckCount";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tentaikhoan", txtuser.Text.Trim());
            cmd.Parameters.AddWithValue("@matkhau", txtpass.Text.Trim());
            string output = cmd.ExecuteScalar().ToString();
            if (int.TryParse(output, out _ID))
            {

            }
        }
        public bool CheckObject()
        {
            if (String.IsNullOrWhiteSpace(txtuser.Text.Trim()))
            {
                Response.Write("<script>alert('Xin vui lòng nhập vào tên đăng nhập.')</script>");
                txtuser.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtpass.Text.Trim()))
            {
                Response.Write("<script>alert('Xin vui lòng nhập vào mật khẩu.')</script>");
                txtpass.Focus();
                return false;
            }
            return true;
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                CheckAccount();
                if (CheckObject())
                {
                    if (_ID == 1)
                    {
                        CheckIDGroup();
                        Session["idlogin"] = _id;
                        if (_id == 1)
                        {
                            CheckID();
                            Session["idquantri"] = _Id;
                            Response.Redirect("~/quantri.aspx");
                        }
                        else if (_id == 2)
                        {
                            CheckID();
                            Session["idquanly"] = _Id;
                            Response.Redirect("~/quanly.aspx");
                        }
                        else if (_id == 3)
                        {
                            CheckID();
                            Session["idgiaovien"] = _Id;
                            Response.Redirect("~/giaovien.aspx");
                        }
                        else if (_id == 4)
                        {
                            CheckID();
                            Session["idsinhvien"] = _Id;
                            Response.Redirect("~/sinhvien.aspx");
                        }
                        else
                        {
                            con.Close();
                            Response.Write("<script>alert('Xin vui lòng kiểm tra lại tên tài khoản hoặc mật khẩu.')</script>");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                Response.Write("<script>alert('Xin vui lòng kiểm tra lại tên tài khoản hoặc mật khẩu.')</script>");
            }
        }
    }
}