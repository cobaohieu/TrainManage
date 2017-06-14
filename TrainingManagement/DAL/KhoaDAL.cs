using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.DAL
{
    class KhoaDAL
    {
        DataServices ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public KhoaDAL()
        {
            ds = new DataServices();
        }
        public DataTable getAllKhoa()
        {
            string sql = "sp_tblKhoa_SelectAll";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                dt = new DataTable();
                da.Fill(dt);
                cmd.ExecuteNonQuery();
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
        public DataTable getIDKhoa(int id)
        {
            string sql = "sp_tblKhoa_SelectID";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                dt = new DataTable();
                da.Fill(dt);
                cmd.ExecuteNonQuery();
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
        public bool insertKhoa(Entities.tblKhoa kh)
        {
            bool check = false;
            string sql = "sp_tblKhoa_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = kh.Makhoa;
                cmd.Parameters.Add("@tenkhoa", SqlDbType.NVarChar).Value = kh.Tenkhoa;
                cmd.Parameters.Add("@sodienthoai", SqlDbType.Int).Value = kh.Sodienthoai;
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
        public bool updateKhoa(Entities.tblKhoa kh)
        {
            bool check = false;
            string sql = "sp_tblKhoa_Update";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = kh.Id;
                cmd.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = kh.Makhoa;
                cmd.Parameters.Add("@tenkhoa", SqlDbType.NVarChar).Value = kh.Tenkhoa;
                cmd.Parameters.Add("@sodienthoai", SqlDbType.Int).Value = kh.Sodienthoai;
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
        public bool deleteKhoa(Entities.tblKhoa kh)
        {
            bool check = false;
            string sql = "sp_tblKhoa_Delete";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = kh.Id;
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
