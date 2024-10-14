namespace De02
{
    partial class frmSanpham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.dtNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.btKLuu = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại SP";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(69, 87);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(55, 406);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(168, 406);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(293, 406);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(568, 177);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(100, 22);
            this.txtTenSP.TabIndex = 10;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(568, 111);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(100, 22);
            this.txtMaSP.TabIndex = 11;
            // 
            // dtNgaynhap
            // 
            this.dtNgaynhap.Location = new System.Drawing.Point(568, 231);
            this.dtNgaynhap.Name = "dtNgaynhap";
            this.dtNgaynhap.Size = new System.Drawing.Size(200, 22);
            this.dtNgaynhap.TabIndex = 12;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(568, 316);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(121, 24);
            this.cbLoaiSP.TabIndex = 13;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(410, 406);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 14;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
           
            // 
            // btKLuu
            // 
            this.btKLuu.Location = new System.Drawing.Point(546, 406);
            this.btKLuu.Name = "btKLuu";
            this.btKLuu.Size = new System.Drawing.Size(75, 23);
            this.btKLuu.TabIndex = 15;
            this.btKLuu.Text = "K Lưu";
            this.btKLuu.UseVisualStyleBackColor = true;
         
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(201, 86);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 16;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(681, 406);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 17;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvSanpham.Location = new System.Drawing.Point(12, 129);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersWidth = 51;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(450, 226);
            this.dgvSanpham.TabIndex = 18;
            this.dgvSanpham.SelectionChanged += new System.EventHandler(this.dgvSanpham_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SP";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày nhập";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Loại sản phẩm ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSanpham);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.btKLuu);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.cbLoaiSP);
            this.Controls.Add(this.dtNgaynhap);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSanpham";
            this.Text = "QUAN LY SAN PHAM";
            this.Load += new System.EventHandler(this.frmSanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.DateTimePicker dtNgaynhap;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btKLuu;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

