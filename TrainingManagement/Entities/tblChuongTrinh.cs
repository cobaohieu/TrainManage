using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Entities
{
    class tblChuongTrinh
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        int _idtrangthai;

        public int Idtrangthai
        {
            get { return _idtrangthai; }
            set { _idtrangthai = value; }
        }
        string _machuongtrinh;

        public string Machuongtrinh
        {
            get { return _machuongtrinh; }
            set { _machuongtrinh = value; }
        }
        string _tenchuongtrinh;

        public string Tenchuongtrinh
        {
            get { return _tenchuongtrinh; }
            set { _tenchuongtrinh = value; }
        }
        int _sotinchi;

        public int Sotinchi
        {
            get { return _sotinchi; }
            set { _sotinchi = value; }
        }
        string _tenmonhoc;

        public string Tenmonhoc
        {
            get { return _tenmonhoc; }
            set { _tenmonhoc = value; }
        }
        string _matinchi;

        public string Matinchi
        {
            get { return _matinchi; }
            set { _matinchi = value; }
        }
        int _idtinchi;

        public int Idtinchi
        {
            get { return _idtinchi; }
            set { _idtinchi = value; }
        }
        int _idhocky;

        public int Idhocky
        {
            get { return _idhocky; }
            set { _idhocky = value; }
        }
        string _mamonhoc;

        public string Mamonhoc
        {
            get { return _mamonhoc; }
            set { _mamonhoc = value; }
        }
    }
}
