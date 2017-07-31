namespace TrainingManagement.GUI
{
    partial class ucRPCTCacMonHoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbTenChuongTrinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ctrvChiTietCacMonHoc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(853, 37);
            this.label1.TabIndex = 112;
            this.label1.Text = "CHI TIẾT CÁC MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTenChuongTrinh
            // 
            this.cbTenChuongTrinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTenChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbTenChuongTrinh.FormattingEnabled = true;
            this.cbTenChuongTrinh.Location = new System.Drawing.Point(355, 15);
            this.cbTenChuongTrinh.Name = "cbTenChuongTrinh";
            this.cbTenChuongTrinh.Size = new System.Drawing.Size(274, 24);
            this.cbTenChuongTrinh.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 106;
            this.label2.Text = "Chương Trình:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.cbTenChuongTrinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 95);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Cần Tìm";
            // 
            // btnView
            // 
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(355, 51);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(86, 30);
            this.btnView.TabIndex = 108;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(853, 510);
            this.groupBox3.TabIndex = 113;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ctrvChiTietCacMonHoc);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(4, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(844, 395);
            this.groupBox4.TabIndex = 111;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Hiển Thị";
            // 
            // ctrvChiTietCacMonHoc
            // 
            this.ctrvChiTietCacMonHoc.ActiveViewIndex = -1;
            this.ctrvChiTietCacMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrvChiTietCacMonHoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctrvChiTietCacMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrvChiTietCacMonHoc.Location = new System.Drawing.Point(3, 18);
            this.ctrvChiTietCacMonHoc.Name = "ctrvChiTietCacMonHoc";
            this.ctrvChiTietCacMonHoc.Size = new System.Drawing.Size(838, 374);
            this.ctrvChiTietCacMonHoc.TabIndex = 0;
            // 
            // ucRPCTCacMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Name = "ucRPCTCacMonHoc";
            this.Size = new System.Drawing.Size(853, 553);
            this.Load += new System.EventHandler(this.ucRPCTCacMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenChuongTrinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnView;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ctrvChiTietCacMonHoc;
    }
}
