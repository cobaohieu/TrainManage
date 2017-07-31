using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.BLL
{
    class TaiKhoanBLL
    {
        DAL.TaiKhoanDAL dal;
        public TaiKhoanBLL()
        {
            dal = new DAL.TaiKhoanDAL();
        }
        public DataTable getAllGetSV()
        {
            return dal.getKQTaiKhoan();
        }
        public DataTable getKQTaiKhoan()
        {
            return dal.getKQTaiKhoan();
        }
        public DataTable getAllTaiKhoan()
        {
            return dal.getAllTaiKhoan();
        }
        public DataTable getIDTaiKhoan(int id)
        {
            return dal.getIDTaiKhoan(id);
        }
        public DataTable viewKetQuaTaiKhoan()
        {
            return dal.viewKetQuaTaiKhoan();
        }
        public DataTable findKetQuaTaiKhoan(string hoten)
        {
            return dal.findKetQuaTaiKhoan(hoten);
        }
        
        public DataTable getBangTotNghiep(string hoten)
        {
            return dal.getBangTotNghiep(hoten);
        }
        public bool insertTaiKhoan(Entities.tblTaiKhoan tk)
        {
            return dal.insertTaiKhoan(tk);
        }
        public bool updateTaiKhoan(Entities.tblTaiKhoan tk)
        {
            return dal.updateTaiKhoan(tk);
        }
        public bool deleteTaiKhoan(Entities.tblTaiKhoan tk)
        {
            return dal.deleteTaiKhoan(tk);
        }
        public DataTable checkTaiKhoan(string tentaikhoan, string matkhau)
        {
            return dal.checkTaiKhoan(tentaikhoan, matkhau);
        }
        public DataTable checkGroupTaiKhoan(string tentaikhoan, string matkhau)
        {
            return dal.checkGroupTaiKhoan(tentaikhoan, matkhau);
        }
    }
}
