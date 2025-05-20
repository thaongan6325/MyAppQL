namespace MyAppQL
{
    partial class frmGIABANSI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGIABANSI));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGBSI = new System.Windows.Forms.TextBox();
            this.dtNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.txtPtramLN = new System.Windows.Forms.TextBox();
            this.txtSLAD = new System.Windows.Forms.TextBox();
            this.txtGBS = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.checkNgayKT = new System.Windows.Forms.CheckBox();
            this.checkNgayBD = new System.Windows.Forms.CheckBox();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.lblTongSoTrang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 405);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1221, 150);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Thông tin chi tiết giá bán sỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mã giá bán sỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mã hàng hóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Giá bán sỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Số lượng áp dụng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(516, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Phần trăm lợi nhuận";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(516, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Ngày bắt đầu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(516, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Ngày kết thúc";
            // 
            // txtGBSI
            // 
            this.txtGBSI.Location = new System.Drawing.Point(206, 51);
            this.txtGBSI.Name = "txtGBSI";
            this.txtGBSI.Size = new System.Drawing.Size(283, 26);
            this.txtGBSI.TabIndex = 1;
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.Location = new System.Drawing.Point(721, 94);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(310, 26);
            this.dtNgayBD.TabIndex = 6;
            // 
            // dtNgayKT
            // 
            this.dtNgayKT.Location = new System.Drawing.Point(721, 141);
            this.dtNgayKT.Name = "dtNgayKT";
            this.dtNgayKT.Size = new System.Drawing.Size(310, 26);
            this.dtNgayKT.TabIndex = 8;
            // 
            // txtPtramLN
            // 
            this.txtPtramLN.Location = new System.Drawing.Point(721, 51);
            this.txtPtramLN.Name = "txtPtramLN";
            this.txtPtramLN.Size = new System.Drawing.Size(310, 26);
            this.txtPtramLN.TabIndex = 5;
            // 
            // txtSLAD
            // 
            this.txtSLAD.Location = new System.Drawing.Point(206, 186);
            this.txtSLAD.Name = "txtSLAD";
            this.txtSLAD.Size = new System.Drawing.Size(283, 26);
            this.txtSLAD.TabIndex = 4;
            // 
            // txtGBS
            // 
            this.txtGBS.Location = new System.Drawing.Point(206, 143);
            this.txtGBS.Name = "txtGBS";
            this.txtGBS.Size = new System.Drawing.Size(283, 26);
            this.txtGBS.TabIndex = 3;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(206, 94);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(283, 26);
            this.txtMaHH.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 22);
            this.label10.TabIndex = 52;
            this.label10.Text = "Thông tin giá bán sỉ";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(206, 293);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 45);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.White;
            this.btnCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(570, 293);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(96, 49);
            this.btnCapnhat.TabIndex = 12;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(389, 293);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 45);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(754, 293);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 49);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(911, 293);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(102, 49);
            this.btnTimkiem.TabIndex = 14;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(955, 579);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 86;
            this.label12.Text = "Trang";
            // 
            // btnTruoc
            // 
            this.btnTruoc.BackColor = System.Drawing.Color.White;
            this.btnTruoc.Location = new System.Drawing.Point(823, 569);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(100, 40);
            this.btnTruoc.TabIndex = 15;
            this.btnTruoc.Text = "<< Trước";
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnSau
            // 
            this.btnSau.BackColor = System.Drawing.Color.White;
            this.btnSau.Location = new System.Drawing.Point(1131, 569);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(100, 40);
            this.btnSau.TabIndex = 16;
            this.btnSau.Text = "Sau >>";
            this.btnSau.UseVisualStyleBackColor = false;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // checkNgayKT
            // 
            this.checkNgayKT.AutoSize = true;
            this.checkNgayKT.Location = new System.Drawing.Point(1062, 145);
            this.checkNgayKT.Name = "checkNgayKT";
            this.checkNgayKT.Size = new System.Drawing.Size(172, 24);
            this.checkNgayKT.TabIndex = 9;
            this.checkNgayKT.Text = "Chọn ngày kết thúc";
            this.checkNgayKT.UseVisualStyleBackColor = true;
            // 
            // checkNgayBD
            // 
            this.checkNgayBD.AutoSize = true;
            this.checkNgayBD.Location = new System.Drawing.Point(1062, 96);
            this.checkNgayBD.Name = "checkNgayBD";
            this.checkNgayBD.Size = new System.Drawing.Size(169, 24);
            this.checkNgayBD.TabIndex = 7;
            this.checkNgayBD.Text = "Chọn ngày bắt đầu";
            this.checkNgayBD.UseVisualStyleBackColor = true;
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Location = new System.Drawing.Point(1020, 573);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(40, 26);
            this.txtSoTrang.TabIndex = 87;
            this.txtSoTrang.Click += new System.EventHandler(this.txtSoTrang_Click);
            // 
            // lblTongSoTrang
            // 
            this.lblTongSoTrang.AutoSize = true;
            this.lblTongSoTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoTrang.Location = new System.Drawing.Point(1075, 576);
            this.lblTongSoTrang.Name = "lblTongSoTrang";
            this.lblTongSoTrang.Size = new System.Drawing.Size(22, 20);
            this.lblTongSoTrang.TabIndex = 88;
            this.lblTongSoTrang.Text = "/1";
            // 
            // frmGIABANSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1247, 621);
            this.Controls.Add(this.lblTongSoTrang);
            this.Controls.Add(this.txtSoTrang);
            this.Controls.Add(this.checkNgayBD);
            this.Controls.Add(this.checkNgayKT);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.txtGBS);
            this.Controls.Add(this.txtSLAD);
            this.Controls.Add(this.txtPtramLN);
            this.Controls.Add(this.dtNgayKT);
            this.Controls.Add(this.dtNgayBD);
            this.Controls.Add(this.txtGBSI);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGIABANSI";
            this.Text = "Quản lý giá bán sỉ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGBSI;
        private System.Windows.Forms.DateTimePicker dtNgayBD;
        private System.Windows.Forms.DateTimePicker dtNgayKT;
        private System.Windows.Forms.TextBox txtPtramLN;
        private System.Windows.Forms.TextBox txtSLAD;
        private System.Windows.Forms.TextBox txtGBS;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.CheckBox checkNgayKT;
        private System.Windows.Forms.CheckBox checkNgayBD;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.Label lblTongSoTrang;
    }
}