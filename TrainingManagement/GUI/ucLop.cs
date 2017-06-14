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
    public partial class ucLop : UserControl
    {
        BLL.LopBLL bllLop;
        public ucLop()
        {
            InitializeComponent();
            bllLop = new BLL.LopBLL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucLop_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bllLop.getAllLop();
            dgvLop.DataSource = dt;
        }
        public void LockObject()
        {

        }
        string flag;
        /*
        public bool CheckObject();
        {

        }
        public void Fill Data(string id)
        {
            
        }
        */ 
    }
}
