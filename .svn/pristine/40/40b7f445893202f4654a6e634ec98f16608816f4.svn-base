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
    public partial class tblSinhVien : UserControl
    {
        BLL.SinhVienBLL bllSinhVien;
        public tblSinhVien()
        {
            InitializeComponent();
            bllSinhVien = new BLL.SinhVienBLL();
        }

        private void tblSinhVien_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllSinhVien.getAllSinhVien();
            dgvSinhVien.DataSource = dt;
        }
    }
}
