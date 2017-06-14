using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.DAL
{
    class ThongTinDAL
    {
        DataServices ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public ThongTinDAL()
        {
            ds = new DataServices();
        }
        public DataTable getAllThongTin()
        {
            string sql = "sp_tblThongTin_SelectAll";
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
        public DataTable getAllThongTin(int id)
        {
            string sql = "sp_tblThongTin_SelectID";
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
        public bool insertThongTin(Entities.tblThongTin tt)
        {
            bool check = false;
            string sql = "sp_tblThongTin_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@idtaikhoan", SqlDbType.Int).Value = tt.Idtaikhoan;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = tt.Hoten;
                cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = tt.Chucvu;
                cmd.Parameters.Add("@namsinh", SqlDbType.Date).Value = tt.Namsinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = tt.Gioitinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = tt.Diachi;
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
        public bool updateThongTin(Entities.tblThongTin tt)
        {
            bool check = false;
            string sql = "sp_tblThongTin_Update";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tt.Id;
                cmd.Parameters.Add("@idtaikhoan", SqlDbType.Int).Value = tt.Idtaikhoan;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = tt.Hoten;
                cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = tt.Chucvu;
                cmd.Parameters.Add("@namsinh", SqlDbType.Date).Value = tt.Namsinh;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = tt.Gioitinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = tt.Diachi;
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
        public bool deleteThongTin(Entities.tblThongTin tt)
        {
            bool check = false;
            string sql = "sp_tblThongTin_Delete";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tt.Id;
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
