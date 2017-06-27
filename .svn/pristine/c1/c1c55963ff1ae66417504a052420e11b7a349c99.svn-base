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
    public partial class tblChuongTrinhDaoTao : UserControl
    {
        BLL.ChuongTrinhDaoTaoBLL bllChuongTrinhDaoTao;
        public tblChuongTrinhDaoTao()
        {
            InitializeComponent();
            bllChuongTrinhDaoTao = new BLL.ChuongTrinhDaoTaoBLL();
        }

        private void tblChuongTrinhDaoTao_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            DataTable dt = new DataTable();
            dt = bllChuongTrinhDaoTao.getAllChuongTrinhDaoTao();
            dgvChuongTrinhDaoTao.DataSource = dt;
        }
    }
}
