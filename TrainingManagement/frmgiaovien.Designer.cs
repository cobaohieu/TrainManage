namespace TrainingManagement
{
    partial class frmGiaoVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.mstgiaovien = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchCácMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnGiaoVien = new System.Windows.Forms.Panel();
            this.lblHello = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.lblId = new System.Windows.Forms.Label();
            this.mstgiaovien.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstgiaovien
            // 
            this.mstgiaovien.BackColor = System.Drawing.Color.Transparent;
            this.mstgiaovien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstgiaovien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.thoátToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.lậpBáoCáoToolStripMenuItem});
            this.mstgiaovien.Location = new System.Drawing.Point(0, 0);
            this.mstgiaovien.Name = "mstgiaovien";
            this.mstgiaovien.Size = new System.Drawing.Size(853, 25);
            this.mstgiaovien.TabIndex = 7;
            this.mstgiaovien.Text = "mstgiaovien";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.mônHọcToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.quảnLýToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mônHọcToolStripMenuItem.Text = "Đăng xuất";
            this.mônHọcToolStripMenuItem.Click += new System.EventHandler(this.ThoátToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mônHọcToolStripMenuItem1});
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.thoátToolStripMenuItem.Text = "Quản lý";
            // 
            // mônHọcToolStripMenuItem1
            // 
            this.mônHọcToolStripMenuItem1.Name = "mônHọcToolStripMenuItem1";
            this.mônHọcToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.mônHọcToolStripMenuItem1.Text = "Kết quả các môn học";
            this.mônHọcToolStripMenuItem1.Click += new System.EventHandler(this.mônHọcToolStripMenuItem1_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchCácMônHọcToolStripMenuItem,
            this.kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // danhSáchCácMônHọcToolStripMenuItem
            // 
            this.danhSáchCácMônHọcToolStripMenuItem.Name = "danhSáchCácMônHọcToolStripMenuItem";
            this.danhSáchCácMônHọcToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.danhSáchCácMônHọcToolStripMenuItem.Text = "Danh sách các môn học";
            this.danhSáchCácMônHọcToolStripMenuItem.Click += new System.EventHandler(this.danhSáchCácMônHọcToolStripMenuItem_Click);
            // 
            // kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem
            // 
            this.kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem.Name = "kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem";
            this.kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem.Text = "Kết quả các môn học của Sinh viên";
            this.kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem.Click += new System.EventHandler(this.kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem_Click);
            // 
            // lậpBáoCáoToolStripMenuItem
            // 
            this.lậpBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtMônHọcToolStripMenuItem,
            this.danhSáchSinhViênToolStripMenuItem});
            this.lậpBáoCáoToolStripMenuItem.Name = "lậpBáoCáoToolStripMenuItem";
            this.lậpBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(93, 21);
            this.lậpBáoCáoToolStripMenuItem.Text = "Lập báo cáo";
            // 
            // chiTiếtMônHọcToolStripMenuItem
            // 
            this.chiTiếtMônHọcToolStripMenuItem.Name = "chiTiếtMônHọcToolStripMenuItem";
            this.chiTiếtMônHọcToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.chiTiếtMônHọcToolStripMenuItem.Text = "Chi tiết môn học";
            this.chiTiếtMônHọcToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtMônHọcToolStripMenuItem_Click);
            // 
            // danhSáchSinhViênToolStripMenuItem
            // 
            this.danhSáchSinhViênToolStripMenuItem.Name = "danhSáchSinhViênToolStripMenuItem";
            this.danhSáchSinhViênToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.danhSáchSinhViênToolStripMenuItem.Text = "Danh sách sinh viên";
            this.danhSáchSinhViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchSinhViênToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 579);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(853, 51);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "TRƯỜNG ĐẠI HỌC CẦN THƠ\r\nKHOA CÔNG NGHỆ THÔNG TIN VÀ TRUYỀN THÔNG\r\nLỚP LIÊN THÔNG " +
    "DC15V7K2\r\nNhóm 5 © 2017";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnGiaoVien
            // 
            this.pnGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGiaoVien.Location = new System.Drawing.Point(0, 25);
            this.pnGiaoVien.Name = "pnGiaoVien";
            this.pnGiaoVien.Size = new System.Drawing.Size(853, 553);
            this.pnGiaoVien.TabIndex = 13;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.Gray;
            this.lblHello.Location = new System.Drawing.Point(532, 4);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(66, 17);
            this.lblHello.TabIndex = 14;
            this.lblHello.Text = "Xin chào:";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Gray;
            this.lbltime.Location = new System.Drawing.Point(700, 4);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(73, 17);
            this.lbltime.TabIndex = 15;
            this.lbltime.Text = "Bây giờ là:";
            // 
            // tmTime
            // 
            this.tmTime.Tick += new System.EventHandler(this.tmTime_Tick);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.Window;
            this.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblId.Location = new System.Drawing.Point(450, 4);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(10, 13);
            this.lblId.TabIndex = 16;
            this.lblId.Text = " ";
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(853, 630);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.pnGiaoVien);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mstgiaovien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstgiaovien;
            this.MaximizeBox = false;
            this.Name = "frmGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN QUẢN LÝ DÀNH CHO GIÁO VIÊN";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.mstgiaovien.ResumeLayout(false);
            this.mstgiaovien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstgiaovien;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảCácMônHọcCủaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchCácMônHọcToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnGiaoVien;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer tmTime;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}