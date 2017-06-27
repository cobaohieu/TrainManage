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
    public partial class tblKetQua : UserControl
    {
        BLL.KetQuaBLL bllKetQua;
        public tblKetQua()
        {
            InitializeComponent();
            bllKetQua = new BLL.KetQuaBLL();
        }

        private void tblKetQua_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllKetQua.getAllKetQua();
            dgvKetQua.DataSource = dt;
        }
    }
}
