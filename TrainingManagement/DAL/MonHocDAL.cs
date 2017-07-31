using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.DAL
{
    class MonHocDAL
    {
        DataServices ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public MonHocDAL()
        {
            ds = new DataServices();
        }
        public DataTable getAllMonHoc()
        {
            string sql = "sp_tblMonHoc_SelectAll";
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
        public DataTable getViewMonHoc(string mamonhoc)
        {
            string sql = "sp_tblMonHoc_View";
            try
            {
                con = ds.getConnect();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mamonhoc", SqlDbType.NVarChar).Value = mamonhoc;
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
        public DataTable getIDMonHoc(int id)
        {
            string sql = "sp_tblMonHoc_SelectID";
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
        public DataTable findDSSVCuaMonHoc(string tenmonhoc)
        {
            string sql = "sp_tblTaiKhoan_FindDSSVCuaMonHoc";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand();
                da = new SqlDataAdapter(sql, con);
                con.Open();
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tenmonhoc", SqlDbType.NVarChar).Value = tenmonhoc;
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
        public bool insertMonHoc(Entities.tblMonHoc mh)
        {
            bool check = false;
            string sql = "sp_tblMonHoc_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@idchuongtrinh", SqlDbType.Int).Value = mh.Idchuongtrinh;
                cmd.Parameters.Add("@idhocky", SqlDbType.Int).Value = mh.Idhocky;
                cmd.Parameters.Add("@idtinchi", SqlDbType.Int).Value = mh.Idtinchi;
                cmd.Parameters.Add("@mamonhoc", SqlDbType.NVarChar).Value = mh.Mamonhoc;
                cmd.Parameters.Add("@tenmonhoc", SqlDbType.NVarChar).Value = mh.Tenmonhoc;
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
        public bool updateMonHoc(Entities.tblMonHoc mh)
        {
            bool check = false;
            string sql = "sp_tblMonHoc_Update";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = mh.Id;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idchuongtrinh", SqlDbType.Int).Value = mh.Idchuongtrinh;
                cmd.Parameters.Add("@idhocky", SqlDbType.Int).Value = mh.Idhocky;
                cmd.Parameters.Add("@idtinchi", SqlDbType.Int).Value = mh.Idtinchi;
                cmd.Parameters.Add("@mamonhoc", SqlDbType.NVarChar).Value = mh.Mamonhoc;
                cmd.Parameters.Add("@tenmonhoc", SqlDbType.NVarChar).Value = mh.Tenmonhoc;
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
        public bool deleteMonHoc(Entities.tblMonHoc mh)
        {
            bool check = false;
            string sql = "sp_tblMonHoc_Delete";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = mh.Id;
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
    }
}
