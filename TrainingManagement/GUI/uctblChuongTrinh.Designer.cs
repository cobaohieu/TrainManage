namespace TrainingManagement.GUI
{
    partial class uctblChuongTrinh
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvChuongTrinh = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machuongtrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchuongtrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdTrangThai = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtTenChuongTrinh = new System.Windows.Forms.TextBox();
            this.txtMaChuongTrinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongTrinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvChuongTrinh);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(843, 284);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Cá Nhân";
            // 
            // dgvChuongTrinh
            // 
            this.dgvChuongTrinh.AllowUserToAddRows = false;
            this.dgvChuongTrinh.AllowUserToDeleteRows = false;
            this.dgvChuongTrinh.AllowUserToOrderColumns = true;
            this.dgvChuongTrinh.AllowUserToResizeColumns = false;
            this.dgvChuongTrinh.AllowUserToResizeRows = false;
            this.dgvChuongTrinh.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvChuongTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuongTrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.machuongtrinh,
            this.tenchuongtrinh,
            this.idtrangthai});
            this.dgvChuongTrinh.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChuongTrinh.Location = new System.Drawing.Point(12, 21);
            this.dgvChuongTrinh.Name = "dgvChuongTrinh";
            this.dgvChuongTrinh.RowHeadersVisible = false;
            this.dgvChuongTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuongTrinh.Size = new System.Drawing.Size(818, 241);
            this.dgvChuongTrinh.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "STT";
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // machuongtrinh
            // 
            this.machuongtrinh.DataPropertyName = "machuongtrinh";
            this.machuongtrinh.HeaderText = "Mã chương trình";
            this.machuongtrinh.Name = "machuongtrinh";
            this.machuongtrinh.Width = 150;
            // 
            // tenchuongtrinh
            // 
            this.tenchuongtrinh.DataPropertyName = "tenchuongtrinh";
            this.tenchuongtrinh.HeaderText = "Tên chương trình";
            this.tenchuongtrinh.Name = "tenchuongtrinh";
            this.tenchuongtrinh.Width = 150;
            // 
            // idtrangthai
            // 
            this.idtrangthai.DataPropertyName = "idtrangthai";
            this.idtrangthai.HeaderText = "idtrangthai";
            this.idtrangthai.Name = "idtrangthai";
            this.idtrangthai.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 65);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(571, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(478, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(386, 21);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(86, 30);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(294, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(202, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIdTrangThai);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtTenChuongTrinh);
            this.groupBox1.Controls.Add(this.txtMaChuongTrinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // lblIdTrangThai
            // 
            this.lblIdTrangThai.AutoSize = true;
            this.lblIdTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblIdTrangThai.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIdTrangThai.Location = new System.Drawing.Point(166, 79);
            this.lblIdTrangThai.Name = "lblIdTrangThai";
            this.lblIdTrangThai.Size = new System.Drawing.Size(19, 16);
            this.lblIdTrangThai.TabIndex = 103;
            this.lblIdTrangThai.Text = "id";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.ForeColor = System.Drawing.SystemColors.Window;
            this.lblID.Location = new System.Drawing.Point(109, 79);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 16);
            this.lblID.TabIndex = 104;
            this.lblID.Text = "id";
            // 
            // txtTenChuongTrinh
            // 
            this.txtTenChuongTrinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChuongTrinh.Location = new System.Drawing.Point(547, 44);
            this.txtTenChuongTrinh.Name = "txtTenChuongTrinh";
            this.txtTenChuongTrinh.Size = new System.Drawing.Size(270, 22);
            this.txtTenChuongTrinh.TabIndex = 2;
            // 
            // txtMaChuongTrinh
            // 
            this.txtMaChuongTrinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChuongTrinh.Location = new System.Drawing.Point(146, 45);
            this.txtMaChuongTrinh.Name = "txtMaChuongTrinh";
            this.txtMaChuongTrinh.Size = new System.Drawing.Size(247, 22);
            this.txtMaChuongTrinh.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Chương Trình:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Chương Trình:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(853, 498);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " ";
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
            this.label1.Text = "QUẢN LÝ CHƯƠNG TRÌNH ĐÀO TẠO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uctblChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Name = "uctblChuongTrinh";
            this.Size = new System.Drawing.Size(853, 553);
            this.Load += new System.EventHandler(this.tblChuongTrinhDaoTao_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongTrinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvChuongTrinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIdTrangThai;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtTenChuongTrinh;
        private System.Windows.Forms.TextBox txtMaChuongTrinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn machuongtrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchuongtrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrangthai;
    }
}
