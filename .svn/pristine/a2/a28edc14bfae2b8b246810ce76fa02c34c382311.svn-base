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
    public partial class tblTrangThai : UserControl
    {
        BLL.TrangThaiBLL bllTrangThai;
        public tblTrangThai()
        {
            InitializeComponent();
            bllTrangThai = new BLL.TrangThaiBLL();
        }

        private void tblTrangThai_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllTrangThai.getAllTrangThai();
            dgvTrangThai.DataSource = dt;
        }
    }
}
