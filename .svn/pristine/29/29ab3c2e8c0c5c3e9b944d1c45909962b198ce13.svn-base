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
    public partial class tblMonHoc : UserControl
    {
        BLL.MonHocBLL bllMonHoc;
        public tblMonHoc()
        {
            InitializeComponent();
            bllMonHoc = new BLL.MonHocBLL();
        }

        private void tblMonHoc_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllMonHoc.getAllMonHoc();
            dgvMonHoc.DataSource = dt;
        }
    }
}
