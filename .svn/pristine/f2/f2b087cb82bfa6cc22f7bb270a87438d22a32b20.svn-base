using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.DAL
{
    class ClassDAL
    {
        DataServices ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public ClassDAL()
        {
            ds = new DataServices();
        }
        public DataTable getAllLop()
        {
            string sql = "sp_tblLop_SelectAll";
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
        public DataTable getAllLop(int id)
        {
            string sql = "sp_tblLop_SelectID";
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
        public bool insertLop(Entities.tblLop lp)
        {
            bool check = false;
            string sql = "sp_tblLop_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idkhoa",SqlDbType.Int).Value = lp.Idkhoa;
                cmd.Parameters.Add("@idnienkhoa", SqlDbType.Int).Value = lp.Idnienkhoa;
                cmd.Parameters.Add("@malop", SqlDbType.NVarChar).Value = lp.Malop;
                cmd.Parameters.Add("@tenlop", SqlDbType.NVarChar).Value = lp.Tenlop;
                cmd.Parameters.Add("@siso", SqlDbType.Int).Value = lp.Siso;
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
        public bool updateLop(Entities.tblLop lp)
        {
            bool check = false;
            string sql = "sp_tblLop_Update";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = lp.Id;
                cmd.Parameters.Add("@idkhoa", SqlDbType.Int).Value = lp.Idkhoa;
                cmd.Parameters.Add("@idnienkhoa", SqlDbType.Int).Value = lp.Idnienkhoa;
                cmd.Parameters.Add("@malop", SqlDbType.NVarChar).Value = lp.Malop;
                cmd.Parameters.Add("@tenlop", SqlDbType.NVarChar).Value = lp.Tenlop;
                cmd.Parameters.Add("@siso", SqlDbType.Int).Value = lp.Siso;
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
        public bool deleteLop(Entities.tblLop lp)
        {
            bool check = false;
            string sql = "sp_tblLop_Delete";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = lp.Id;
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
