﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Entities
{
    class tblLop
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        int _idkhoa;

        public int Idkhoa
        {
            get { return _idkhoa; }
            set { _idkhoa = value; }
        }
        int _idnienkhoa;

        public int Idnienkhoa
        {
            get { return _idnienkhoa; }
            set { _idnienkhoa = value; }
        }
        string _malop;

        public string Malop
        {
            get { return _malop; }
            set { _malop = value; }
        }
        string _tenlop;

        public string Tenlop
        {
            get { return _tenlop; }
            set { _tenlop = value; }
        }
        int _siso;

        public int Siso
        {
            get { return _siso; }
            set { _siso = value; }
        }
    }
}
