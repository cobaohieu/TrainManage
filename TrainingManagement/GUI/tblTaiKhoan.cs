using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TrainingManagement.GUI
{
    public partial class tblTaiKhoan : UserControl
    {
        BLL.TaiKhoanBLL bllTaiKhoan;
        public tblTaiKhoan()
        {
            InitializeComponent();
            bllTaiKhoan = new BLL.TaiKhoanBLL();
        }

        private void tblTaiKhoan_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllTaiKhoan.getAllTaiKhoan();
            dgvTaiKhoan.DataSource = dt;
        }
    }
}
