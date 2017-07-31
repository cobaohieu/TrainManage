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

    public partial class frmQuanTri : Form
    {
        public frmQuanTri(string user, string id)
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

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                this.Close();
                frmLogin _frmLogin = new frmLogin();
                _frmLogin.Show();
            }
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblTaiKhoan uc = new GUI.uctblTaiKhoan();
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc); 
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucTTCaNhan uc = new GUI.ucTTCaNhan(lblId.Text);
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc); 
        }

        private void clearControlPanel()
        {
            this.pnQuanTri.Controls.Clear();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblKhoa uc = new GUI.uctblKhoa();
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc); 
        }

        private void pnQuanTri_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mstquantri_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmQuanTri_Load(object sender, EventArgs e)
        {
            GUI.ucMain uc = new GUI.ucMain();
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc);
            tmTime.Start();
        }

        private void niênKhóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblChuongTrinh uc = new GUI.uctblChuongTrinh();
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc); 

        }

        private void họcKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblHocKy uc = new GUI.uctblHocKy();
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc); 
        }

        private void mônHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblMonHoc uc = new GUI.uctblMonHoc();
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc); 
        }

        private void niênKhóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblNienKhoa uc = new GUI.uctblNienKhoa();
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc); 
        }

        private void tínChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblTinChi uc = new GUI.uctblTinChi();
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc); 
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            lbltime.Text ="Bây giờ là: " + DateTime.Now.ToLongTimeString();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.ucDoiMatKhau uc = new GUI.ucDoiMatKhau();
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc);
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblChucVu uc = new GUI.uctblChucVu();
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc);

        }

        private void nhómNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblNhom uc = new GUI.uctblNhom();
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc);

        }

        private void trạngTháiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlPanel();
            GUI.uctblTrangThai uc = new GUI.uctblTrangThai();
            uc.Dock = DockStyle.Fill;
            pnQuanTri.Controls.Add(uc);

        }
    }
}
