using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.BLL
{
    class ChuongTrinhDaoTaoBLL
    {
        DAL.ChuongTrinhDaoTaoDAL dal;
        public ChuongTrinhDaoTaoBLL()
        {
            dal = new DAL.ChuongTrinhDaoTaoDAL();
        }
        public DataTable getAllChuongTrinhDaoTao()
        {
            return dal.getAllChuongTrinhDaoTao();
        }
        public DataTable getAllChuongTrinhDaoTao(int id)
        {
            return dal.getAllChuongTrinhDaoTao(id);
        }
        public bool insertChuongTrinhDaoTao(Entities.tblChuongTrinhDaoTao ctdt)
        {
            return dal.insertChuongTrinhDaoTao(ctdt);
        }
        public bool updateChuongTrinhDaoTao(Entities.tblChuongTrinhDaoTao ctdt)
        {
            return dal.updateChuongTrinhDaoTao(ctdt);
        }
        public bool deleteChuongTrinhDaoTao(Entities.tblChuongTrinhDaoTao ctdt)
        {
            return dal.deleteChuongTrinhDaoTao(ctdt);
        }
    }
}
