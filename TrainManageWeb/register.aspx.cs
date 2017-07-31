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
    public partial class register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=KHDT-HIEU;Initial Catalog=trainmanage; User Id=sa; Password=123456789");
        protected void Page_Load(object sender, EventArgs e)
        {
            //con.Open();

        }

        int _Id = 4;

        public void InsertSQL()
        {
            con.Open();
            string ns;
            string gt;
            ns = clNamSinh.ToString().Trim();
            gt = ddlGioiTinh.SelectedItem.Value.Trim();
            //string qr = "sp_tblTaiKhoan_Insert";
            SqlCommand cmd = new SqlCommand("insert into tblTaiKhoan" + "(idnhom, tentaikhoan, matkhau, hoten, namsinh, gioitinh, diachi, email, dienthoai)values(@idnhom, @tentaikhoan, @matkhau, @hoten, @namsinh, @gioitinh, @diachi, @email, @dienthoai)", con);
            //SqlCommand cmd = new SqlCommand(qr, con);
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idnhom", _Id);
            cmd.Parameters.AddWithValue("@tentaikhoan", txtTenTaiKhoan.Text.Trim());
            cmd.Parameters.AddWithValue("@matkhau", txtMatKhau.Text.Trim());
            cmd.Parameters.AddWithValue("@hoten", txtHoTen.Text.Trim());
            cmd.Parameters.AddWithValue("@namsinh", ns);
            cmd.Parameters.AddWithValue("@gioitinh", gt);
            cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text.Trim());
            cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@dienthoai", txtDienThoai.Text.Trim());
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool CheckObject()
        {
            if (String.IsNullOrWhiteSpace(txtTenTaiKhoan.Text.Trim()))
            {
                Response.Write("<script>alert('Xin vui lòng nhập vào tên đăng nhập.')</script>");
                txtTenTaiKhoan.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtMatKhau.Text.Trim()))
            {
                Response.Write("<script>alert('Xin vui lòng nhập vào mật khẩu.')</script>");
                txtMatKhau.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtHoTen.Text.Trim()))
            {
                Response.Write("<script>alert('Xin vui lòng nhập vào họ tên.')</script>");
                txtHoTen.Focus();
                return false;
            }
            //if (String.IsNullOrWhiteSpace(clNamSinh.ToString().Trim()))
            //{
            //    Response.Write("<script>alert('Xin vui lòng chọn năm sinh.');</script>");
            //    clNamSinh.Focus();
            //    return false;
            //}
            //if (String.IsNullOrWhiteSpace(ddlGioiTinh.SelectedItem.Value.Trim()))
            //{
            //    Response.Write("<script>alert('Xin vui lòng chọn giới tính.');</script>");
            //    ddlGioiTinh.Focus();
            //    return false;
            //}
            //if (String.IsNullOrWhiteSpace(txtDiaChi.Text.Trim()))
            //{
            //    Response.Write("<script>alert('Xin vui lòng nhập vào địa chỉ.');</script>");
            //    txtDiaChi.Focus();
            //    return false;
            //}
            //if (String.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
            //{
            //    Response.Write("<script>alert('Xin vui lòng nhập vào email.');</script>");
            //    txtEmail.Focus();
            //    return false;
            //}
            //if (String.IsNullOrWhiteSpace(txtDienThoai.Text.Trim()))
            //{
            //    Response.Write("<script>alert('Xin vui lòng nhập vào số điện thoại.');</script>");
            //    txtDienThoai.Focus();
            //    return false;
            //}
            return true;

        }

        protected void btnRegistry_Click(object sender, EventArgs e)
        {
            //con.Open();
            if (CheckObject())
            {
                InsertSQL();
                Response.Write("<script>alert('Đăng ký thông tin thành công.')</script>");
            }
            else
            {
                con.Close();
                Response.Write("<script>alert('Đã xảy ra lỗi. Xin vui lòng kiểm tra thông tin vừa nhập')</script>");
            }
        }

    }
}