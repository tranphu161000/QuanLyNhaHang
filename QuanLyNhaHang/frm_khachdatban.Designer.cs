namespace QuanLyNhaHang
{
    partial class frm_khachdatban
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dskdb = new System.Windows.Forms.DataGridView();
            this.maban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khuvuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.grb_nhapthongtin = new System.Windows.Forms.GroupBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_khuvuc = new System.Windows.Forms.TextBox();
            this.txt_tenban = new System.Windows.Forms.TextBox();
            this.txt_maban = new System.Windows.Forms.TextBox();
            this.cbb_tensp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskdb)).BeginInit();
            this.grb_nhapthongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dskdb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 171);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng đã đặt bàn";
            // 
            // dgv_dskdb
            // 
            this.dgv_dskdb.AllowUserToAddRows = false;
            this.dgv_dskdb.AllowUserToDeleteRows = false;
            this.dgv_dskdb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dskdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dskdb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maban,
            this.tenban,
            this.khuvuc,
            this.tensp,
            this.soluong});
            this.dgv_dskdb.Location = new System.Drawing.Point(3, 20);
            this.dgv_dskdb.Name = "dgv_dskdb";
            this.dgv_dskdb.ReadOnly = true;
            this.dgv_dskdb.Size = new System.Drawing.Size(678, 145);
            this.dgv_dskdb.TabIndex = 0;
            this.dgv_dskdb.SelectionChanged += new System.EventHandler(this.dgv_dskdb_SelectionChanged);
            // 
            // maban
            // 
            this.maban.DataPropertyName = "maban";
            this.maban.HeaderText = "Mã bàn";
            this.maban.Name = "maban";
            this.maban.ReadOnly = true;
            // 
            // tenban
            // 
            this.tenban.DataPropertyName = "tenban";
            this.tenban.HeaderText = "Tên bàn";
            this.tenban.Name = "tenban";
            this.tenban.ReadOnly = true;
            // 
            // khuvuc
            // 
            this.khuvuc.DataPropertyName = "khuvuc";
            this.khuvuc.HeaderText = "Khu vực";
            this.khuvuc.Name = "khuvuc";
            this.khuvuc.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Blue;
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(595, 358);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(89, 32);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // grb_nhapthongtin
            // 
            this.grb_nhapthongtin.Controls.Add(this.txt_soluong);
            this.grb_nhapthongtin.Controls.Add(this.txt_khuvuc);
            this.grb_nhapthongtin.Controls.Add(this.txt_tenban);
            this.grb_nhapthongtin.Controls.Add(this.txt_maban);
            this.grb_nhapthongtin.Controls.Add(this.cbb_tensp);
            this.grb_nhapthongtin.Controls.Add(this.label5);
            this.grb_nhapthongtin.Controls.Add(this.label3);
            this.grb_nhapthongtin.Controls.Add(this.label4);
            this.grb_nhapthongtin.Controls.Add(this.label1);
            this.grb_nhapthongtin.Controls.Add(this.label2);
            this.grb_nhapthongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_nhapthongtin.Location = new System.Drawing.Point(3, 1);
            this.grb_nhapthongtin.Name = "grb_nhapthongtin";
            this.grb_nhapthongtin.Size = new System.Drawing.Size(681, 114);
            this.grb_nhapthongtin.TabIndex = 6;
            this.grb_nhapthongtin.TabStop = false;
            this.grb_nhapthongtin.Text = "Nhập thông tin";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(507, 68);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(112, 21);
            this.txt_soluong.TabIndex = 17;
            // 
            // txt_khuvuc
            // 
            this.txt_khuvuc.Location = new System.Drawing.Point(507, 29);
            this.txt_khuvuc.Name = "txt_khuvuc";
            this.txt_khuvuc.Size = new System.Drawing.Size(112, 21);
            this.txt_khuvuc.TabIndex = 17;
            // 
            // txt_tenban
            // 
            this.txt_tenban.Location = new System.Drawing.Point(265, 29);
            this.txt_tenban.Name = "txt_tenban";
            this.txt_tenban.Size = new System.Drawing.Size(112, 21);
            this.txt_tenban.TabIndex = 17;
            // 
            // txt_maban
            // 
            this.txt_maban.Location = new System.Drawing.Point(78, 29);
            this.txt_maban.Name = "txt_maban";
            this.txt_maban.Size = new System.Drawing.Size(112, 21);
            this.txt_maban.TabIndex = 17;
            // 
            // cbb_tensp
            // 
            this.cbb_tensp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_tensp.FormattingEnabled = true;
            this.cbb_tensp.Location = new System.Drawing.Point(78, 68);
            this.cbb_tensp.Name = "cbb_tensp";
            this.cbb_tensp.Size = new System.Drawing.Size(299, 23);
            this.cbb_tensp.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khu vực";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên bàn";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(575, 121);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(103, 41);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(457, 121);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(103, 41);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(338, 121);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(103, 41);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // frm_khachdatban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 402);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.grb_nhapthongtin);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_khachdatban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁCH ĐẶT BÀN";
            this.Load += new System.EventHandler(this.frm_khachdatban_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskdb)).EndInit();
            this.grb_nhapthongtin.ResumeLayout(false);
            this.grb_nhapthongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dskdb;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.GroupBox grb_nhapthongtin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cbb_tensp;
        private System.Windows.Forms.TextBox txt_maban;
        private System.Windows.Forms.TextBox txt_khuvuc;
        private System.Windows.Forms.TextBox txt_tenban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenban;
        private System.Windows.Forms.DataGridViewTextBoxColumn khuvuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}