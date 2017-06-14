using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.BLL
{
    class KhoaBLL
    {
        DAL.KhoaDAL dal;
        public KhoaBLL()
        {
            dal = new DAL.KhoaDAL();
        }
        public DataTable getAllKhoa()
        {
            return dal.getAllKhoa();
        }
        public DataTable getIDKhoa(int id)
        {
            return dal.getIDKhoa(id);
        }
        public bool insertKhoa(Entities.tblKhoa kh)
        {
            return dal.insertKhoa(kh);
        }
        public bool updateKhoa(Entities.tblKhoa kh)
        {
            return dal.updateKhoa(kh);
        }
        public bool deleteKhoa(Entities.tblKhoa kh)
        {
            return dal.deleteKhoa(kh);
        }
    }
}
