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
    public partial class ucKhoa : UserControl
    {
        BLL.KhoaBLL bllKhoa;
        public ucKhoa()
        {
            InitializeComponent();
            bllKhoa = new BLL.KhoaBLL();
        }

        private void ucKhoa_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bllKhoa.getAllKhoa();
            dgvKhoa.DataSource = dt;
        }
    }
}
