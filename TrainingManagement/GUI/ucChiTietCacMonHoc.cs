using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingManagement.GUI
{
    public partial class ucChiTietCacMonHoc : UserControl
    {
        BLL.MonHocBLL bllMonHoc;
        public ucChiTietCacMonHoc()
        {
            InitializeComponent();
            bllMonHoc = new BLL.MonHocBLL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
