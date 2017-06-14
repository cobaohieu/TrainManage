using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Entities
{
    class tblTaiKhoan
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _tentaikhoan;

        public string Tentaikhoan
        {
            get { return _tentaikhoan; }
            set { _tentaikhoan = value; }
        }
        string _matkhau;

        public string Matkhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }
        string _nhom;

        public string Nhom
        {
            get { return _nhom; }
            set { _nhom = value; }
        }
    }
}
