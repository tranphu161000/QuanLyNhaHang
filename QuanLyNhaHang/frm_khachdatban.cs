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
    public partial class frm_khachdatban : Form
    {
        public frm_khachdatban()
        {
            InitializeComponent();
            grb_nhapthongtin.Enabled = false;
            ShowDLSP();
            HienThiDL();
            
            HienThiDLTextBox();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CSLQE7D;Initial Catalog=QuanLyNhaHang;User ID=sa;Password=123456");

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                grb_nhapthongtin.Enabled = true;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;

                txt_maban.Text = "";
                txt_tenban.Text = "";
                txt_khuvuc.Text = "";
                txt_maban.Focus();

                btn_them.Text = "Lưu";
            }
            else
            {
                conn.Open();
                string query = "INSERT INTO KhachDatBan (maban, tenban, khuvuc, tensp, soluong) values('" + txt_maban.Text + "', N'" + txt_tenban.Text + "', '" + txt_khuvuc.Text + "', N'" + cbb_tensp.Text+"', '"+txt_soluong.Text+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                HienThiDL();
                HienThiDLTextBox();

                btn_them.Text = "Thêm";
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                grb_nhapthongtin.Enabled = false;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE KhachDatBan WHERE maban = '" + txt_maban.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            HienThiDL();
            HienThiDLTextBox();
        }

        private void HienThiDL()
        {
            conn.Open();
            string query = "SELECT *FROM KhachDatBan";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            conn.Close();
            DataTable tb = new DataTable();

            adap.Fill(tb);
            dgv_dskdb.DataSource = tb;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_dskdb_SelectionChanged(object sender, EventArgs e)
        {
            { 
                
            }
        }

        private void HienThiDLTextBox()
        {
            txt_maban.DataBindings.Clear();
            txt_maban.DataBindings.Add("Text", dgv_dskdb.DataSource, "maban");

            txt_tenban.DataBindings.Clear();
            txt_tenban.DataBindings.Add("Text", dgv_dskdb.DataSource, "tenban");

            txt_khuvuc.DataBindings.Clear();
            txt_khuvuc.DataBindings.Add("Text", dgv_dskdb.DataSource, "khuvuc");

            cbb_tensp.DataBindings.Clear();
            cbb_tensp.DataBindings.Add("Text", dgv_dskdb.DataSource, "tensp");

            txt_soluong.DataBindings.Clear();
            txt_soluong.DataBindings.Add("Text", dgv_dskdb.DataSource, "soluong");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Sửa")
            {
                grb_nhapthongtin.Enabled = true;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;

                btn_sua.Text = "Lưu";
            }
            else
            {
                conn.Open();
                string query = "UPDATE KhachDatBan SET maban = '" + txt_maban.Text + "', tenban = N'" + txt_tenban.Text + "', khuvuc = N'" + txt_khuvuc.Text + "', tensp = N'" + cbb_tensp.Text + "', soluong = '" + txt_soluong.Text + "' WHERE maban = '" + txt_maban.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                HienThiDL();
                HienThiDLTextBox();

                btn_sua.Text = "Sửa";
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                grb_nhapthongtin.Enabled = false;
            }
        }

        private void ShowDLSP()
        {
            conn.Open();
            string query = "SELECT tensp FROM SanPham";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            conn.Close();
            DataTable tb = new DataTable();
            adap.Fill(tb);

            cbb_tensp.DataSource = tb;
            cbb_tensp.DisplayMember = "tensp";
        }

        private void frm_khachdatban_Load(object sender, EventArgs e)
        {

        }
    }
}
