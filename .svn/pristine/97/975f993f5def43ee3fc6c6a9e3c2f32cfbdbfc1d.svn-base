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
    public partial class tblKhoa : UserControl
    {
        BLL.KhoaBLL bllKhoa;
        public tblKhoa()
        {
            InitializeComponent();
            bllKhoa = new BLL.KhoaBLL();
        }

        private void tblKhoa_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllKhoa.getAllKhoa();
            dgvKhoa.DataSource = dt;
        }
    }
}
