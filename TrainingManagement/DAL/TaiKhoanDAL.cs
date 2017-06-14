using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.DAL
{
    class TaiKhoanDAL
    {
        DataServices ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public TaiKhoanDAL()
        {
            ds = new DataServices();
        }
        public DataTable getAllTaiKhoan()
        {
            string sql = "sp_tblTaiKhoan_SelectAll";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable getAllTaiKhoan(int id)
        {
            string sql = "sp_tblTaiKhoan_SelectID";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public bool insertTaiKhoan(Entities.tblTaiKhoan tk)
        {
            bool check = false;
            string sql = "sp_tblTaiKhoan_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@tentaikhoan", SqlDbType.NVarChar).Value = tk.Tentaikhoan;
                cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = tk.Matkhau;
                cmd.Parameters.Add("@nhom", SqlDbType.NVarChar).Value = tk.Nhom;
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return check;
        }
        public bool updateTaiKhoan(Entities.tblTaiKhoan tk)
        {
            bool check = false;
            string sql = "sp_tblTaiKhoan_Update";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tk.Id;
                cmd.Parameters.Add("@tentaikhoan", SqlDbType.NVarChar).Value = tk.Tentaikhoan;
                cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = tk.Matkhau;
                cmd.Parameters.Add("@nhom", SqlDbType.NVarChar).Value = tk.Nhom;
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return check;
        }
        public bool deleteTaiKhoan(Entities.tblTaiKhoan tk)
        {
            bool check = false;
            string sql = "sp_tblTaiKhoan_Delete";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tk.Id;
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return check;
        }
    }
}
