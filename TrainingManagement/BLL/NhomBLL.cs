using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.BLL
{
    class NhomBLL
    {
        DAL.NhomDAL dal;
        public NhomBLL()
        {
            dal = new DAL.NhomDAL();
        }
        public DataTable getAllNhom()
        {
            return dal.getAllNhom();
        }
        public DataTable getIDNhom(int id)
        {
            return dal.getIDNhom(id);
        }
        public bool insertNhom(Entities.tblNhom nh)
        {
            return dal.insertNhom(nh);
        }
        public bool updateNhom(Entities.tblNhom nh)
        {
            return dal.updateNhom(nh);
        }
        public bool deleteNhom(Entities.tblNhom nh)
        {
            return dal.deleteNhom(nh);
        }
    }
}
