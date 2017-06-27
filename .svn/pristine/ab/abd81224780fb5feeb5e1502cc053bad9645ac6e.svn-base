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
    public partial class tblHocKy : UserControl
    {
        BLL.HocKyBLL bllHocKy;
        public tblHocKy()
        {
            InitializeComponent();
            bllHocKy = new BLL.HocKyBLL();
        }

        private void tblHocKy_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllHocKy.getAllHocKy();
            dgvHocKy.DataSource = dt;
        }

    }
}
