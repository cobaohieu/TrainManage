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
    public partial class tblTinChi : UserControl
    {
        BLL.TinChiBLL bllTinChi;
        public tblTinChi()
        {
            InitializeComponent();
            bllTinChi = new BLL.TinChiBLL();
        }

        private void tblTinChi_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllTinChi.getAllTinChi();
            dgvTinChi.DataSource = dt;
        }
    }
}
