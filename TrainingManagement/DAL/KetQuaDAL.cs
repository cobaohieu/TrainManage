using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.DAL
{
    class KetQuaDAL
    {
        DataServices ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public KetQuaDAL()
        {
            ds = new DataServices();
        }
        public DataTable getAllKetQua()
        {
            string sql = "sp_tblKetQua_SelectAll";
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
        public DataTable getIDKetQua(int id)
        {
            string sql = "sp_tblKetQua_SelectID";
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
        public bool insertKetQua(Entities.tblKetQua kq)
        {
            bool check = false;
            string sql = "sp_tblKetQua_Insert";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@idsinhvien", SqlDbType.Int).Value = kq.Idsinhvien;
                cmd.Parameters.Add("@idmonhoc", SqlDbType.Int).Value = kq.Idmonhoc;
                cmd.Parameters.Add("@diemtrungbinh", SqlDbType.Float).Value = kq.Diemtrungbinh;
                cmd.Parameters.Add("@diemthilan1", SqlDbType.Float).Value = kq.Diemthilan1;
                cmd.Parameters.Add("@diemthilan2", SqlDbType.Float).Value = kq.Diemthilan2;
                cmd.Parameters.Add("@diemtongket", SqlDbType.Float).Value = kq.Diemtongket;
                cmd.Parameters.Add("@hanhkiem", SqlDbType.NVarChar).Value = kq.Hanhkiem;
                cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = kq.Ghichu;
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
        public bool updateKetQua(Entities.tblKetQua kq)
        {
            bool check = false;
            string sql = "sp_tblKetQua_Update";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = kq.Id;
                cmd.Parameters.Add("@idsinhvien", SqlDbType.Int).Value = kq.Idsinhvien;
                cmd.Parameters.Add("@idmonhoc", SqlDbType.Int).Value = kq.Idmonhoc;
                cmd.Parameters.Add("@diemtrungbinh", SqlDbType.Float).Value = kq.Diemtrungbinh;
                cmd.Parameters.Add("@diemthilan1", SqlDbType.Float).Value = kq.Diemthilan1;
                cmd.Parameters.Add("@diemthilan2", SqlDbType.Float).Value = kq.Diemthilan2;
                cmd.Parameters.Add("@diemtongket", SqlDbType.Float).Value = kq.Diemtongket;
                cmd.Parameters.Add("@hanhkiem", SqlDbType.NVarChar).Value = kq.Hanhkiem;
                cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = kq.Ghichu;
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
        public bool deleteKetQua(Entities.tblKetQua kq)
        {
            bool check = false;
            string sql = "sp_tblKetQua_Delete";
            try
            {
                con = ds.getConnect();
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = kq.Id;
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
        public DataTable getViewKetQuaMonHocSV()
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
    }
}
