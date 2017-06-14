using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.BLL
{
    class TrangThaiBLL
    {
        DAL.TrangThaiDAL dal;
        public TrangThaiBLL()
        {
            dal = new DAL.TrangThaiDAL();
        }
        public DataTable getAllTrangThai()
        {
            return dal.getAllTrangThai();
        }
        public DataTable getAllTrangThai(int id)
        {
            return dal.getAllTrangThai(id);
        }
        public bool insertTrangThai(Entities.tblTrangThai tt)
        {
            return dal.insertTrangThai(tt);
        }
        public bool updateTrangThai(Entities.tblTrangThai tt)
        {
            return dal.updateTrangThai(tt);
        }
        public bool deleteTrangThai(Entities.tblTrangThai tt)
        {
            return dal.deleteTrangThai(tt);
        }
    }
}
