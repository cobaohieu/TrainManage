namespace TrainingManagement
{
    partial class frmtkKetQuaql
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
            this.txtGioiThieu = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbxIDMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxIDSinhVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtGioiThieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiThieu.ForeColor = System.Drawing.Color.White;
            this.txtGioiThieu.Location = new System.Drawing.Point(-8, 398);
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.Size = new System.Drawing.Size(769, 20);
            this.txtGioiThieu.TabIndex = 5;
            this.txtGioiThieu.Text = "     Khoa công nghệ thông tin và truyền thông                                    " +
    "                                                                           Giảng" +
    " viên: Trần Văn Hoàng";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(659, 42);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 30);
            this.btnClose.TabIndex = 87;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbxIDMonHoc
            // 
            this.cbxIDMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxIDMonHoc.FormattingEnabled = true;
            this.cbxIDMonHoc.Location = new System.Drawing.Point(373, 47);
            this.cbxIDMonHoc.Name = "cbxIDMonHoc";
            this.cbxIDMonHoc.Size = new System.Drawing.Size(159, 24);
            this.cbxIDMonHoc.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "ID Môn Học:";
            // 
            // cbxIDSinhVien
            // 
            this.cbxIDSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxIDSinhVien.FormattingEnabled = true;
            this.cbxIDSinhVien.Location = new System.Drawing.Point(102, 47);
            this.cbxIDSinhVien.Name = "cbxIDSinhVien";
            this.cbxIDSinhVien.Size = new System.Drawing.Size(159, 24);
            this.cbxIDSinhVien.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "ID Sinh Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(111, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 37);
            this.label1.TabIndex = 82;
            this.label1.Text = "KẾT QUẢ CÁC MÔN HỌC CỦA SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(556, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 30);
            this.btnSearch.TabIndex = 81;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 302);
            this.dataGridView1.TabIndex = 80;
            // 
            // frmtkKetQuaql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(756, 418);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbxIDMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxIDSinhVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGioiThieu);
            this.MaximizeBox = false;
            this.Name = "frmtkKetQuaql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmqltkketqua";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGioiThieu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbxIDMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxIDSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}