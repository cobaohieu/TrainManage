using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingManagement.GUI;

namespace TrainingManagement
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }
        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát hay không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        //X Close
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                frmLogin _frmGiaoVien = new frmLogin();
                this.Hide();
                _frmGiaoVien.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        //ESC Close
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
                {
                    Dispose(true);
                    frmLogin _frmGiaoVien = new frmLogin();
                    this.Hide();
                    _frmGiaoVien.Show();
                }
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucTTCaNhan uc = new GUI.ucTTCaNhan();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc); 

        }

        private void chươngTrìnhĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mônHọcToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void clearControlPanel()
        {
            this.pnQuanLy.Controls.Clear();
        }

        private void trạngTháiCủaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucQLTrangThai uc = new GUI.ucQLTrangThai();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc); 
        }

        private void danhSáchCácChươngTrìnhĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchCácMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chiTiếtMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                frmLogin _frmGiaoVien = new frmLogin();
                this.Hide();
                _frmGiaoVien.Show();
            }
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            GUI.ucMain uc = new GUI.ucMain();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc); 

        }
    }
}
