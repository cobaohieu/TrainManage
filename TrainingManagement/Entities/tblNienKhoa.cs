using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Entities
{
    class tblNienKhoa
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _manienkhoa;

        public string Manienkhoa
        {
            get { return _manienkhoa; }
            set { _manienkhoa = value; }
        }
        string _tennienkhoa;

        public string Tennienkhoa
        {
            get { return _tennienkhoa; }
            set { _tennienkhoa = value; }
        }
        DateTime _nambatdau;

        public DateTime Nambatdau
        {
            get { return _nambatdau; }
            set { _nambatdau = value; }
        }
        DateTime _namketthuc;

        public DateTime Namketthuc
        {
            get { return _namketthuc; }
            set { _namketthuc = value; }
        }
    }
}
