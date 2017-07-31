using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Entities
{
    class tblKhoa
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _makhoa;

        public string Makhoa
        {
            get { return _makhoa; }
            set { _makhoa = value; }
        }
        string _tenkhoa;

        public string Tenkhoa
        {
            get { return _tenkhoa; }
            set { _tenkhoa = value; }
        }
        string _sodienthoai;

        public string Sodienthoai
        {
            get { return _sodienthoai; }
            set { _sodienthoai = value; }
        }
        
    }
}
