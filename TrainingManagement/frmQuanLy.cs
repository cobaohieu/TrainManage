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

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
                {
                    Dispose(true);
                    this.Hide();
                    frmMain _frmMain = new frmMain();
                    _frmMain.ShowDialog();
                }
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Hide();
                frmMain _frmMain = new frmMain();
                _frmMain.ShowDialog();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlThongTinQuanLy _frmqlThongTinQuanLy = new frmqlThongTinQuanLy();
            _frmqlThongTinQuanLy.ShowDialog();
        }

        private void chươngTrìnhĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlChuongTrinh _frmqlChuongTrinh = new frmqlChuongTrinh();
            _frmqlChuongTrinh.ShowDialog();
        }

        private void mônHọcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmtkdsMonHocql _frmtkdsMonHocql = new frmtkdsMonHocql();
            _frmtkdsMonHocql.ShowDialog();
        }


        private void trạngTháiCủaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlTrangThai _frmqlTrangThai = new frmqlTrangThai();
            _frmqlTrangThai.ShowDialog();
        }

        private void danhSáchCácChươngTrìnhĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtkdsChuongTrinhql _frmqltkdsChuongTrinhql = new frmtkdsChuongTrinhql();
            _frmqltkdsChuongTrinhql.ShowDialog();
        }

        private void danhSáchCácMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtkdsMonHocql _frmqltkdsMonHocql = new frmtkdsMonHocql();
            _frmqltkdsMonHocql.ShowDialog();
        }

        private void kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtkKetQuaql _frmqltkKetQuaql = new frmtkKetQuaql();
            _frmqltkKetQuaql.ShowDialog();
        }

        private void chiTiếtMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrpBangTotNghiep _frmrpBangTotNghiep = new frmrpBangTotNghiep();
            _frmrpBangTotNghiep.ShowDialog();
        }

        private void kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmrpKQSV _frmrpKQSV = new frmrpKQSV();
            _frmrpKQSV.ShowDialog();
        }

        private void thoátToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Hide();
                frmMain _frmMain = new frmMain();
                _frmMain.ShowDialog();
            }
        }
    }
}
