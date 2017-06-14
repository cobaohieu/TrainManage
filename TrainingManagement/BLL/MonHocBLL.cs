using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.BLL
{
    class MonHocBLL
    {
        DAL.MonHocDAL dal;
        public MonHocBLL()
        {
            dal = new DAL.MonHocDAL();
        }
        public DataTable getAllMonHoc()
        {
            return dal.getAllMonHoc();
        }
        public DataTable getAllMonHoc(int id)
        {
            return dal.getAllMonHoc(id);
        }
        public bool insertMonHoc(Entities.tblMonHoc mh)
        {
            return dal.insertMonHoc(mh);
        }
        public bool updateMonHoc(Entities.tblMonHoc mh)
        {
            return dal.updateMonHoc(mh);
        }
        public bool deleteMonHoc(Entities.tblMonHoc mh)
        {
            return dal.deleteMonHoc(mh);
        }
    }
}
