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
    public partial class ucTTCaNhan : UserControl
    {
        BLL.ThongTinBLL bllThongTin;
        public ucTTCaNhan()
        {
            InitializeComponent();
            bllThongTin = new BLL.ThongTinBLL();
        }

        private void ucTTCaNhan_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllThongTin.getViewThongTin();
            dgvTTCaNhan.DataSource = dt;
        }
    }
}
