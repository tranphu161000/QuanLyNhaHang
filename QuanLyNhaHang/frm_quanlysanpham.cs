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
    public partial class frm_quanlysanpham : Form
    {
        public frm_quanlysanpham()
        {
            InitializeComponent();
            grb_ttsp.Enabled = false;
            HienThiDLDataGridView();
            HienThiDLTextBox();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CSLQE7D;Initial Catalog=QuanLyNhaHang;User ID=sa;Password=123456");



        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                grb_ttsp.Enabled = true;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;

                txt_masp.Text = "";
                txt_dongia.Text = "";
                txt_tensp.Text = "";
                txt_masp.Focus();

                btn_them.Text = "Lưu";
            }
            else
            {
                conn.Open();
                string query = "INSERT INTO SanPham (masp, tensp, dongia) VALUES ('" + txt_masp.Text + "', N'" + txt_tensp.Text + "', '" + txt_dongia.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                btn_them.Text = "Thêm";
                grb_ttsp.Enabled = false;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                HienThiDLDataGridView();
                HienThiDLTextBox();

            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Sửa")
            {
                grb_ttsp.Enabled = true;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;

                btn_sua.Text = "Lưu";
            }

            else
            {
                conn.Open();
                string query = "UPDATE SanPham SET masp = '" + txt_masp.Text + "' , tensp = N'" + txt_tensp.Text + "' , dongia = '" + txt_dongia.Text + "' WHERE masp = '" + txt_masp.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                btn_sua.Text = "Sửa";
                grb_ttsp.Enabled = false;
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;

                HienThiDLDataGridView();
                HienThiDLTextBox();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE SanPham WHERE masp = '" + txt_masp.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            HienThiDLDataGridView();
            HienThiDLTextBox();
        }

        private void HienThiDLDataGridView()
        {
            conn.Open();
            string query = "SELECT *FROM SanPham";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            conn.Close();
            DataTable tb = new DataTable();
            adap.Fill(tb);

            dgv_dssp.DataSource = tb;
        }

        private void dgv_dssp_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void HienThiDLTextBox()
        {
            txt_masp.DataBindings.Clear();
            txt_masp.DataBindings.Add("Text", dgv_dssp.DataSource, "masp");

            txt_tensp.DataBindings.Clear();
            txt_tensp.DataBindings.Add("Text", dgv_dssp.DataSource, "tensp");

            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", dgv_dssp.DataSource, "dongia");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_quanlysanpham_Load(object sender, EventArgs e)
        {

        }
    }
}
