using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrainingManagement.BLL
{
    class ChuongTrinhBLL
    {
        DAL.ChuongTrinhDAL dal;
        public ChuongTrinhBLL()
        {
            dal = new DAL.ChuongTrinhDAL();
        }
        public DataTable getAllChuongTrinh()
        {
            return dal.getAllChuongTrinh();
        }
        public DataTable getViewDanhSachMonHocName()
        {
            return dal.getViewDanhSachMonHocName();
        }
        public DataTable getIDChuongTrinh(int id)
        {
            return dal.getIDChuongTrinh(id);
        }
        public DataTable findTenChuongTrinh(string tenchuongtrinh)
        {
            return dal.findTenChuongTrinh(tenchuongtrinh);
        }
        public bool insertChuongTrinh(Entities.tblChuongTrinh ctdt)
        {
            return dal.insertChuongTrinh(ctdt);
        }
        public bool updateChuongTrinh(Entities.tblChuongTrinh ctdt)
        {
            return dal.updateChuongTrinh(ctdt);
        }
        public bool deleteChuongTrinh(Entities.tblChuongTrinh ctdt)
        {
            return dal.deleteChuongTrinh(ctdt);
        }
    }
}
