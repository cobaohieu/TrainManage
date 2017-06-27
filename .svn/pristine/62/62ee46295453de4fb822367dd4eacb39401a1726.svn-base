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
    public partial class tblThongTin : UserControl
    {
        BLL.ThongTinBLL bllThongTin;
        public tblThongTin()
        {
            InitializeComponent();
            bllThongTin = new BLL.ThongTinBLL();
        }

        private void tblThongTin_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllThongTin.getAllThongTin();
            dgvThongTin.DataSource = dt;
        }
    }
}
