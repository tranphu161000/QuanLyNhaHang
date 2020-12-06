namespace QuanLyNhaHang
{
    partial class frm_dangnhap
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
            this.txt_tdn = new System.Windows.Forms.TextBox();
            this.btn_dn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txt_tdn
            // 
            this.txt_tdn.Location = new System.Drawing.Point(150, 38);
            this.txt_tdn.Name = "txt_tdn";
            this.txt_tdn.Size = new System.Drawing.Size(219, 20);
            this.txt_tdn.TabIndex = 0;
            // 
            // btn_dn
            // 
            this.btn_dn.Location = new System.Drawing.Point(213, 115);
            this.btn_dn.Name = "btn_dn";
            this.btn_dn.Size = new System.Drawing.Size(75, 35);
            this.btn_dn.TabIndex = 2;
            this.btn_dn.Text = "Đăng nhập";
            this.btn_dn.UseVisualStyleBackColor = true;
            this.btn_dn.Click += new System.EventHandler(this.btn_dn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(150, 77);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(219, 20);
            this.txt_mk.TabIndex = 1;
            this.txt_mk.UseSystemPasswordChar = true;
            // 
            // btn_huy
            // 
            this.btn_huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_huy.Location = new System.Drawing.Point(294, 115);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 35);
            this.btn_huy.TabIndex = 2;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // frm_dangnhap
            // 
            this.AcceptButton = this.btn_dn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_huy;
            this.ClientSize = new System.Drawing.Size(433, 162);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dn);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tdn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.Load += new System.EventHandler(this.frm_dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tdn;
        private System.Windows.Forms.Button btn_dn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Button btn_huy;
    }
}

