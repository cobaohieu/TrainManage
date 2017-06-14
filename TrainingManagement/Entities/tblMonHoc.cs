using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Entities
{
    class tblMonHoc
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        int _idchuongtrinh;

        public int Idchuongtrinh
        {
            get { return _idchuongtrinh; }
            set { _idchuongtrinh = value; }
        }
        int _idhocky;

        public int Idhocky
        {
            get { return _idhocky; }
            set { _idhocky = value; }
        }
        int _idtinchi;

        public int Idtinchi
        {
            get { return _idtinchi; }
            set { _idtinchi = value; }
        }
        string _mamonhoc;

        public string Mamonhoc
        {
            get { return _mamonhoc; }
            set { _mamonhoc = value; }
        }
        string _tenmonhoc;

        public string Tenmonhoc
        {
            get { return _tenmonhoc; }
            set { _tenmonhoc = value; }
        }
    }
}
