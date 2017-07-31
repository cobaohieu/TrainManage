using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.DAL
{
    class ChuongTrinhDAL
    {
        DataServices ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public ChuongTrinhDAL()
        {
            ds = new DataServices();
        }
        public DataTable getAllChuongTrinh()
        {
            string sql = "sp_tblChuongTrinh_SelectAll";
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

        public DataTable getViewDanhSachMonHocName()
        {
            string sql = "sp_tblChuongTrinh_ViewTenDanhSachMonHoc";
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
        public DataTable getIDChuongTrinh(int id)
        {
            string sql = "sp_tblChuongTrinh_SelectID";
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
        public bool insertChuongTrinh(Entities.tblChuongTrinh ctdt)
        {
            bool check = false;
            string sql = "sp_tblChuongTrinh_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@idtrangthai", SqlDbType.Int).Value = ctdt.Id;
                cmd.Parameters.Add("@machuongtrinh", SqlDbType.NVarChar).Value = ctdt.Machuongtrinh;
                cmd.Parameters.Add("@tenchuongtrinh", SqlDbType.NVarChar).Value = ctdt.Tenchuongtrinh;
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
        public bool updateChuongTrinh(Entities.tblChuongTrinh ctdt)
        {
            bool check = false;
            string sql = "sp_tblChuongTrinh_Update";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = ctdt.Id;
                cmd.Parameters.Add("@idtrangthai", SqlDbType.Int).Value = ctdt.Id;
                cmd.Parameters.Add("@machuongtrinh", SqlDbType.NVarChar).Value = ctdt.Machuongtrinh;
                cmd.Parameters.Add("@tenchuongtrinh", SqlDbType.NVarChar).Value = ctdt.Tenchuongtrinh;
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
        public bool deleteChuongTrinh(Entities.tblChuongTrinh ctdt)
        {
            bool check = false;
            string sql = "sp_tblChuongTrinh_Delete";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = ctdt.Id;
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
        public DataTable findTenChuongTrinh(string tenchuongtrinh)
        {
            string sql = "sp_tblChuongTrinh_FindDanhSachMonHocName";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tenchuongtrinh", SqlDbType.NVarChar).Value = tenchuongtrinh;
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
                cmd.Dispose();
                con.Close();
            }
            return dt;
        }

    }
}
