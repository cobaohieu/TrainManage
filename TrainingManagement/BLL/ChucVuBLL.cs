using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.BLL
{
    class ChucVuBLL
    {
        DAL.ChucVuDAL dal;
        public ChucVuBLL()
        {
            dal = new DAL.ChucVuDAL();
        }
        public DataTable getAllChucVu()
        {
            return dal.getAllChucVu();
        }
        public DataTable getIDChucVu(int id)
        {
            return dal.getIDChucVu(id);
        }
        public bool insertChucVu(Entities.tblChucVu kh)
        {
            return dal.insertChucVu(kh);
        }
        public bool updateChucVu(Entities.tblChucVu kh)
        {
            return dal.updateChucVu(kh);
        }
        public bool deleteChucVu(Entities.tblChucVu kh)
        {
            return dal.deleteChucVu(kh);
        }

    }
}
