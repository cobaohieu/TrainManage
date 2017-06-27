using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrainingManagement.GUI
{
    public partial class tblNienKhoa : UserControl
    {
        BLL.NienKhoaBLL bllNienKhoa;
        public tblNienKhoa()
        {
            InitializeComponent();
            bllNienKhoa = new BLL.NienKhoaBLL();
        }

        private void tblNienKhoa_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllNienKhoa.getAllNienKhoa();
            dgvNienKhoa.DataSource = dt;
        }
    }
}
