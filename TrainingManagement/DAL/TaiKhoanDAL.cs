using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

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
                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = con;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.ToString();

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }

        public DataTable getAllGetSV()
        {
            string sql = "sp_tblTaiKhoan_GetSV";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = con;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.ToString();

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable getKQTaiKhoan()
        {
            string sql = "sp_tblKetQua_MonHocSinhVien";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = con;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.ToString();

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable findKetQuaTaiKhoan(string hoten)
        {
            string sql = "sp_tblSinhVien_FindKetQuaMonHocSinhVienName";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.ToString();

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }

        public DataTable viewKetQuaTaiKhoan()
        {
            string sql = "sp_tblSinhVien_ViewKetQuaMonHocSinhVien";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = con;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.ToString();

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable getBangTotNghiep(string hoten)
        {
            string sql = "sp_tblKetQua_BangtotNghiepSinhVien";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = hoten;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.ToString();

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable getIDTaiKhoan(int id)
        {
            string sql = "sp_tblTaiKhoan_SelectID";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.ToString();

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
                cmd.Parameters.Add("@idnhom", SqlDbType.Int).Value = tk.Idnhom;
                cmd.Parameters.Add("@tentaikhoan", SqlDbType.NVarChar).Value = tk.Tentaikhoan;
                cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = tk.Matkhau;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = tk.Hoten;
                cmd.Parameters.Add("@namsinh", SqlDbType.Date).Value = tk.Namsinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = tk.Gioitinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = tk.Diachi;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = tk.Email;
                cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar).Value = tk.Dienthoai;
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {
                ex.ToString();

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
                cmd.Parameters.Add("@idnhom", SqlDbType.Int).Value = tk.Idnhom;
                cmd.Parameters.Add("@tentaikhoan", SqlDbType.NVarChar).Value = tk.Tentaikhoan;
                cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = tk.Matkhau;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = tk.Hoten;
                cmd.Parameters.Add("@namsinh", SqlDbType.Date).Value = tk.Namsinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = tk.Gioitinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = tk.Diachi;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = tk.Email;
                cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar).Value = tk.Dienthoai;
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {
                ex.ToString();

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
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tk.Id;
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {
                ex.ToString();

            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return check;
        }
        public DataTable checkTaiKhoan(string tentaikhoan, string matkhau)
        {
            string sql = "sp_tblTaiKhoan_Check";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tentaikhoan", SqlDbType.NVarChar).Value = tentaikhoan;
                cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = matkhau;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.ToString();

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable checkGroupTaiKhoan(string tentaikhoan, string matkhau)
        {
            string sql = "sp_tblTaiKhoan_CheckGroup";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tentaikhoan", SqlDbType.NVarChar).Value = tentaikhoan;
                cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = matkhau;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.ToString();

            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return dt;
        }

    }
}
