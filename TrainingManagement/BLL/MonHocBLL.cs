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
        public DataTable getViewMonHoc(string mamonhoc)
        {
            return dal.getViewMonHoc(mamonhoc);
        }
        public DataTable findDSSVCuaMonHoc(string tenmonhoc)
        {
            return dal.findDSSVCuaMonHoc(tenmonhoc);
        }
        public DataTable getIDMonHoc(int id)
        {
            return dal.getIDMonHoc(id);
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
