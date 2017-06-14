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
    public partial class frmMain : Form
    {
        public frmMain()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
            }
        }

        private void txtGioiThieu_TextChanged(object sender, EventArgs e)
        {


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.txtUser.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            foreach (Control c in this.Controls)
            {
                this.Controls.Add(c);
            }
            frmGiaoVien _frmGiaoVien = new frmGiaoVien();
            _frmGiaoVien.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmQuanLy _frmQuanLy = new frmQuanLy();
            _frmQuanLy.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmQuanLy _frmQuanLy = new frmQuanLy();
            _frmQuanLy.ShowDialog();
        }
    }
}
