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
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
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
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Hide();
                frmMain _frmMain = new frmMain();
                _frmMain.ShowDialog();
            }
        }

        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát hay không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqlThongTinGiaoVien _frmqlThongTinGiaoVien = new frmqlThongTinGiaoVien();
            _frmqlThongTinGiaoVien.ShowDialog();
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmqlkqMonHoc _frmqlkqMonHoc = new frmqlkqMonHoc();
            _frmqlkqMonHoc.ShowDialog();
        }

        private void chiTiếtMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrpChiTietCacMonHoc _frmrpChiTietCacMonHoc = new frmrpChiTietCacMonHoc();
            _frmrpChiTietCacMonHoc.ShowDialog();
        }

        private void danhSáchCácChươngTrìnhĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtkdsChuongTrinhgv _frmqltkdsChuongTrinhgv = new frmtkdsChuongTrinhgv();
            _frmqltkdsChuongTrinhgv.ShowDialog();
        }

        private void kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtkKetQuagv _frmqltkKetQuagv = new frmtkKetQuagv();
            _frmqltkKetQuagv.ShowDialog();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrpDSSVCuaMotMonHoc _frmrpDSSVCuaMotMonHoc = new frmrpDSSVCuaMotMonHoc();
            _frmrpDSSVCuaMotMonHoc.ShowDialog();
        }

        private void danhSáchCácMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtkdsMonHocgv _frmqltkdsMonHocgv = new frmtkdsMonHocgv();
            _frmqltkdsMonHocgv.ShowDialog();
        }
    }
}
