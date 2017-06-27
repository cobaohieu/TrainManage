using System;
using System.Collections;
using System.Configuration;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace TrainManageWeb
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["idlogin"] = null;
            txtuser.Focus();

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            trainmanageDataContext db = new trainmanageDataContext();
            int id = db.tblTaiKhoan_SelectID(txtuser.Text.Trim(), txtpass.Text.Trim());
            int nhom = db.tblTaiKhoan_CheckAccountGroup(txtuser.Text.Trim(), txtpass.Text.Trim());
            if (id > 0)
            {
                Session["idlogin"] = id;
                if (nhom == 0)
                    Response.Redirect("quantri.aspx");
                else if (nhom == 1)
                {
                    int idgv = db.tblTaiKhoan_getIDQL(txtuser.Text.Trim());
                    Session["idquanly"] = idQL;
                    Response.Redirect("quanly.aspx");
                }
                else if (nhom == 2)
                {
                    int idgv = db.tblTaiKhoan_getIDGV(txtuser.Text.Trim());
                    Session["idgiaovien"] = idGV;
                    Response.Redirect("giangvien.aspx");
                }
                else
                {
                    int idsv = db.tblTaiKhoan_getIDSV(txtuser.Text.Trim());
                    Session["idsinhvien"] = idSV;
                    Response.Redirect("sinhvien.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('Đăng nhập thất bại');</script>");
            }
             * */
        }
    }
}