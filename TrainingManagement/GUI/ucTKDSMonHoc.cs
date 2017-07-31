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
    public partial class ucTKDSMonHoc : UserControl
    {
        BLL.ChuongTrinhBLL bllChuongTrinh;
        public ucTKDSMonHoc()
        {
            InitializeComponent();
            bllChuongTrinh = new BLL.ChuongTrinhBLL();
        }
        string rs;
        public void ComboLoad()
        {
            
            DataTable ds = new DataTable();
            ds = bllChuongTrinh.getAllChuongTrinh();
            cbTenChuongTrinh.DisplayMember = "tenchuongtrinh";
            cbTenChuongTrinh.ValueMember = "tenchuongtrinh";
            cbTenChuongTrinh.DataSource = ds;
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            rs = cbTenChuongTrinh.Text.Trim();
            DataTable dt = new DataTable();
            dt = bllChuongTrinh.findTenChuongTrinh(rs);
            if (dt.Rows.Count > 0)
            {
                dgvDSCacMonHoc.DataSource = dt;
            }
        }

        private void ucTKDSMonHoc_Load(object sender, EventArgs e)
        {
            ReLoad();
            ComboLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllChuongTrinh.getViewDanhSachMonHocName();
            dgvDSCacMonHoc.DataSource = dt;
        }
    }
}
