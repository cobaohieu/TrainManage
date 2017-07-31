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
        public frmQuanLy(string user, string id)
        {
            InitializeComponent();
            lblHello.Text = "Xin chào " + user;
            lblId.Text = id;
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

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucTTCaNhan uc = new GUI.ucTTCaNhan(lblId.Text);
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc); 

        }

        private void chươngTrìnhĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblChuongTrinh uc = new GUI.uctblChuongTrinh();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc); 

        }

        private void mônHọcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblMonHoc uc = new GUI.uctblMonHoc();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc);
        }

        private void clearControlPanel()
        {
            this.pnQuanLy.Controls.Clear();
        }

        private void trạngTháiCủaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucTrangThaiSinhVienCT uc = new GUI.ucTrangThaiSinhVienCT();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc); 
        }

        private void danhSáchCácMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clearControlPanel();
            GUI.ucTKDSMonHoc uc = new GUI.ucTKDSMonHoc();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc);

        }

        private void kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucTKKQSV uc = new GUI.ucTKKQSV();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc);

        }

        private void chiTiếtMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucRPBangTotNghiep uc = new GUI.ucRPBangTotNghiep();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc);

        }

        private void kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucRPKQCacMonHocCuaSV uc = new GUI.ucRPKQCacMonHocCuaSV();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc);
        }

        private void thoátToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
                frmLogin _frmLogin = new frmLogin();
                _frmLogin.Show();
            }
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            GUI.ucMain uc = new GUI.ucMain();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc);
            tmTime.Start();
        }

        private void mstquanly_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
            pnQuanLy.Controls.Add(uc);

        }

        private void họcKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblHocKy uc = new GUI.uctblHocKy();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc);

        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblKhoa uc = new GUI.uctblKhoa();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc);


        }

        private void niênKhóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clearControlPanel();
            GUI.uctblNienKhoa uc = new GUI.uctblNienKhoa();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc);
        }

        private void tínChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblTinChi uc = new GUI.uctblTinChi();
            uc.Dock = DockStyle.Fill;
            pnQuanLy.Controls.Add(uc);

        }
    }
}
