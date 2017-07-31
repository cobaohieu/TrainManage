using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingManagement
{
    class conect
    {
        public SqlConnection con = new SqlConnection();
        public void Connect()
        {
            string conn = "Data Source=KHDT-HIEU; Initial Catalog=trainmanage;Persist Security Info=True;User ID=sa;Password=123456789";

            con.ConnectionString = conn;
            con.Open();
        }
        public string getValues(string sql)
        {
            string result = "";
            try
            {
                Connect();

                SqlCommand sqlComm = new SqlCommand(sql, con);
                SqlDataReader r = sqlComm.ExecuteReader();
                if (r.Read())
                {
                    result = r["tong"].ToString();
                }
            }
            catch
            { }
            return result;
        }


        public void CloseConnect()
        {
            if (con.State == ConnectionState.Open)
            { 
                con.Close(); 
            }
        }
        public DataTable dt = new DataTable();
        public DataTable getTable(string cmd)
        {
            try
            {
                Connect();
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd, con);
                DataSet ds = new DataSet();

                Adapter.Fill(dt);
            }
            catch (System.Exception)
            {
                dt = null;
            }
            finally
            {
                CloseConnect();
            }

            return dt;
        }

        public int dataProcess(string cmd)
        {
            int result = 0;
            try
            {
                Connect();
                SqlCommand lenh = new SqlCommand(cmd, con);
                result = lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Thông báo lỗi ra!

                result = 0;
            }
            finally
            {
                CloseConnect();
            }
            return result;
        }
    }
}
