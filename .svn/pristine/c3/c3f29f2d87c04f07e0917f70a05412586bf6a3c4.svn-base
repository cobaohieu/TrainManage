using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.BLL
{
    class SinhVienBLL
    {
        DAL.SinhVienDAL dal;
        public SinhVienBLL()
        {
            dal = new DAL.SinhVienDAL();
        }
        public DataTable getAllSinhVien()
        {
            return dal.getAllSinhVien();
        }
        public DataTable getViewSinhVien()
        {
            return dal.getViewSinhVien();
        }

        public DataTable getIDSinhVien(int id)
        {
            return dal.getIDSinhVien(id);
        }
        public bool insertSinhVien(Entities.tblSinhVien sv)
        {
            return dal.insertSinhVien(sv);
        }
        public bool updateSinhVien(Entities.tblSinhVien sv)
        {
            return dal.updateSinhVien(sv);
        }
        public bool deleteSinhVien(Entities.tblSinhVien sv)
        {
            return dal.deleteSinhVien(sv);
        }
    }
}
