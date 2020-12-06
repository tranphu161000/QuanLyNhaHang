using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaHang
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CSLQE7D;Initial Catalog=QuanLyNhaHang;User ID=sa;Password=123456");

        private void btn_dn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = "SELECT * FROM NhanVien WHERE tendangnhap = '" + txt_tdn.Text + "' and matkhau = '" + txt_mk.Text + "'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    this.Hide();
                    frm_chinh main = new frm_chinh();
                    main.Show();
                    
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Hãy nhập lại", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo");
            }

            conn.Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
