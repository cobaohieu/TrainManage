namespace TrainingManagement.GUI
{
    partial class uctblMonHoc
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.lblIDChuongTrinh = new System.Windows.Forms.Label();
            this.lblIDTinChi = new System.Windows.Forms.Label();
            this.lblIDHocKy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idchuongtrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idhocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtinchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.label1.TabIndex = 91;
            this.label1.Text = "QUẢN LÝ MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(567, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.TabIndex = 89;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(475, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 88;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(380, 21);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(86, 30);
            this.btnDel.TabIndex = 87;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(288, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 30);
            this.btnUpdate.TabIndex = 86;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(196, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 30);
            this.btnAdd.TabIndex = 85;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.ForeColor = System.Drawing.SystemColors.Window;
            this.lblID.Location = new System.Drawing.Point(319, 75);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 16);
            this.lblID.TabIndex = 108;
            this.lblID.Text = "id";
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc.Location = new System.Drawing.Point(524, 34);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(270, 22);
            this.txtTenMonHoc.TabIndex = 105;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc.Location = new System.Drawing.Point(123, 35);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(247, 22);
            this.txtMaMonHoc.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 107;
            this.label4.Text = "Tên Môn Học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 106;
            this.label3.Text = "Mã Môn Học:";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AllowUserToAddRows = false;
            this.dgvMonHoc.AllowUserToDeleteRows = false;
            this.dgvMonHoc.AllowUserToOrderColumns = true;
            this.dgvMonHoc.AllowUserToResizeColumns = false;
            this.dgvMonHoc.AllowUserToResizeRows = false;
            this.dgvMonHoc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idchuongtrinh,
            this.idhocky,
            this.idtinchi,
            this.mamonhoc,
            this.tenmonhoc});
            this.dgvMonHoc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMonHoc.Location = new System.Drawing.Point(7, 19);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersVisible = false;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(818, 264);
            this.dgvMonHoc.TabIndex = 109;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            this.dgvMonHoc.SelectionChanged += new System.EventHandler(this.dgvMonHoc_SelectionChanged);
            // 
            // lblIDChuongTrinh
            // 
            this.lblIDChuongTrinh.AutoSize = true;
            this.lblIDChuongTrinh.BackColor = System.Drawing.Color.Transparent;
            this.lblIDChuongTrinh.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIDChuongTrinh.Location = new System.Drawing.Point(380, 63);
            this.lblIDChuongTrinh.Name = "lblIDChuongTrinh";
            this.lblIDChuongTrinh.Size = new System.Drawing.Size(19, 16);
            this.lblIDChuongTrinh.TabIndex = 108;
            this.lblIDChuongTrinh.Text = "id";
            // 
            // lblIDTinChi
            // 
            this.lblIDTinChi.AutoSize = true;
            this.lblIDTinChi.BackColor = System.Drawing.Color.Transparent;
            this.lblIDTinChi.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIDTinChi.Location = new System.Drawing.Point(521, 75);
            this.lblIDTinChi.Name = "lblIDTinChi";
            this.lblIDTinChi.Size = new System.Drawing.Size(19, 16);
            this.lblIDTinChi.TabIndex = 108;
            this.lblIDTinChi.Text = "id";
            // 
            // lblIDHocKy
            // 
            this.lblIDHocKy.AutoSize = true;
            this.lblIDHocKy.BackColor = System.Drawing.Color.Transparent;
            this.lblIDHocKy.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIDHocKy.Location = new System.Drawing.Point(450, 63);
            this.lblIDHocKy.Name = "lblIDHocKy";
            this.lblIDHocKy.Size = new System.Drawing.Size(19, 16);
            this.lblIDHocKy.TabIndex = 108;
            this.lblIDHocKy.Text = "id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIDHocKy);
            this.groupBox1.Controls.Add(this.lblIDTinChi);
            this.groupBox1.Controls.Add(this.lblIDChuongTrinh);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtTenMonHoc);
            this.groupBox1.Controls.Add(this.txtMaMonHoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 94);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMonHoc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 289);
            this.groupBox2.TabIndex = 111;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chung";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 76);
            this.groupBox3.TabIndex = 112;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(853, 488);
            this.groupBox4.TabIndex = 113;
            this.groupBox4.TabStop = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "STT";
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // idchuongtrinh
            // 
            this.idchuongtrinh.DataPropertyName = "idchuongtrinh";
            this.idchuongtrinh.HeaderText = "idchuongtrinh";
            this.idchuongtrinh.Name = "idchuongtrinh";
            this.idchuongtrinh.Visible = false;
            // 
            // idhocky
            // 
            this.idhocky.DataPropertyName = "idhocky";
            this.idhocky.HeaderText = "idhocky";
            this.idhocky.Name = "idhocky";
            this.idhocky.Visible = false;
            // 
            // idtinchi
            // 
            this.idtinchi.DataPropertyName = "idtinchi";
            this.idtinchi.HeaderText = "idtinchi";
            this.idtinchi.Name = "idtinchi";
            this.idtinchi.Visible = false;
            // 
            // mamonhoc
            // 
            this.mamonhoc.DataPropertyName = "mamonhoc";
            this.mamonhoc.HeaderText = "Mã môn học";
            this.mamonhoc.Name = "mamonhoc";
            this.mamonhoc.Width = 150;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.Width = 250;
            // 
            // tblMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Name = "tblMonHoc";
            this.Size = new System.Drawing.Size(853, 553);
            this.Load += new System.EventHandler(this.tblMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Label lblIDChuongTrinh;
        private System.Windows.Forms.Label lblIDTinChi;
        private System.Windows.Forms.Label lblIDHocKy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idchuongtrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtinchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
    }
}
