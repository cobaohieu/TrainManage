using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrainingManagement
{
    public partial class frmQuanTri : Form
    {
        public frmQuanTri()
        {
            InitializeComponent();
        }


        //X Close
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát hay không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        //ESC Close
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
                {
                    Dispose(true);
                    Close();
                    return true;
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
            }
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmMain _frmMain = new frmMain();
                _frmMain.ShowDialog();
            }
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlThongTinQuanTri _frmqlThongTinQuanTri = new frmqlThongTinQuanTri();
            _frmqlThongTinQuanTri.ShowDialog();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlNguoiDungGV _frmqlNguoiDungGV = new frmqlNguoiDungGV();
            _frmqlNguoiDungGV.ShowDialog();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlNguoiDungSV _frmqlNguoiDungSV = new frmqlNguoiDungSV();
            _frmqlNguoiDungSV.ShowDialog();
        }

        private void quảnLýChấtLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlNguoiDungQL _frmqlNguoiDungQL = new frmqlNguoiDungQL();
            _frmqlNguoiDungQL.ShowDialog();
        }

        private void quảnTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlNguoiDungQT _frmqlNguoiDungQT = new frmqlNguoiDungQT();
            _frmqlNguoiDungQT.ShowDialog();
        }
    }
}
