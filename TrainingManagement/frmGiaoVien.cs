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
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien(string user, string id)
        {
            InitializeComponent();
            lblHello.Text = "Xin chào " + user;
            lblId.Text = id;
        }

        //X Close

        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát hay không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
                frmLogin _frmLogin = new frmLogin();
                _frmLogin.Show();
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
                    this.Close();
                    frmLogin _frmLogin = new frmLogin();
                    _frmLogin.Show();
                }
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
                frmLogin _frmLogin = new frmLogin();
                _frmLogin.Show();
            }
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucTTCaNhan uc = new GUI.ucTTCaNhan(lblId.Text);
            uc.Dock = DockStyle.Fill;
            pnGiaoVien.Controls.Add(uc); 
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucQLKetQua uc = new GUI.ucQLKetQua();
            uc.Dock = DockStyle.Fill;
            pnGiaoVien.Controls.Add(uc); 

        }

        private void chiTiếtMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucRPCTCacMonHoc uc = new GUI.ucRPCTCacMonHoc();
            uc.Dock = DockStyle.Fill;
            pnGiaoVien.Controls.Add(uc);

        }


        private void kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucTKKQSV uc = new GUI.ucTKKQSV();
            uc.Dock = DockStyle.Fill;
            pnGiaoVien.Controls.Add(uc);

        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucRPDSSVCuaMotMonHoc uc = new GUI.ucRPDSSVCuaMotMonHoc();
            uc.Dock = DockStyle.Fill;
            pnGiaoVien.Controls.Add(uc);

        }

        private void danhSáchCácMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucTKDSMonHoc uc = new GUI.ucTKDSMonHoc();
            uc.Dock = DockStyle.Fill;
            pnGiaoVien.Controls.Add(uc);

        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            GUI.ucMain uc = new GUI.ucMain();
            uc.Dock = DockStyle.Fill;
            pnGiaoVien.Controls.Add(uc);
            tmTime.Start();
        }
        private void clearControlPanel()
        {
            this.pnGiaoVien.Controls.Clear();
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "Bây giờ là: " + DateTime.Now.ToLongTimeString();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucDoiMatKhau uc = new GUI.ucDoiMatKhau();
            uc.Dock = DockStyle.Fill;
            pnGiaoVien.Controls.Add(uc);

        }
    }
}
