using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyNhaHang
{
    public partial class frm_nhanvien : Form
    {
        public frm_nhanvien()
        {
            InitializeComponent();
            LayDuLieuLenDataGridView();
            LayDuLieuLenTextBox();
            LayDuLieuQuyen();
            pnl_ttnd.Enabled = false;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CSLQE7D;Initial Catalog=QuanLyNhaHang;User ID=sa;Password=123456");

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LayDuLieuLenDataGridView()
        {
            conn.Open();

            string query = "SELECT manv, tennv, tendangnhap, ngaysinh, diachi, dienthoai, matkhau, pq.tenquyen FROM NhanVien nv, PhanQuyen pq WHERE nv.maquyen = pq.maquyen";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);

            dgv_dsnd.DataSource = table;
        }

        private void LayDuLieuQuyen()
        {
            conn.Open();
            string query = "SELECT *FROM PhanQuyen";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            conn.Close();
            DataTable tb = new DataTable();
            adap.Fill(tb);

            cbb_quyen.DataSource = tb;
            cbb_quyen.DisplayMember = "tenquyen";
            cbb_quyen.ValueMember = "maquyen";
        }

        private void dgv_dsnd_SelectionChanged(object sender, EventArgs e)
        {
            
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                pnl_ttnd.Enabled = true;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;

                txt_manv.Text = "";
                txt_tnv.Text = "";
                txt_tdn.Text = "";
                txt_mk.Text = "";
                txt_ngaysinh.Text = "";
                txt_diachi.Text = "";
                txt_dienthoai.Text = "";
                cbb_quyen.Text = "";

                btn_them.Text = "Lưu";
            }
            else
            {
                conn.Open();

                string query = "INSERT INTO NhanVien (manv, tennv, tendangnhap, ngaysinh, diachi, dienthoai, matkhau, maquyen) values ('" + txt_manv.Text + "', N'" + txt_tnv.Text + "', '" + txt_tdn.Text + "', '" + txt_ngaysinh.Text + "', N'" + txt_diachi.Text + "', '" + txt_dienthoai.Text + "', '" + txt_mk.Text + "', N'" + cbb_quyen.SelectedValue + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LayDuLieuLenDataGridView();

                btn_them.Text = "Thêm";
                pnl_ttnd.Enabled = false;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                LayDuLieuQuyen();
                LayDuLieuLenTextBox();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "DELETE NhanVien WHERE manv = '" + txt_manv.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LayDuLieuLenDataGridView();
            LayDuLieuLenTextBox();
            //MessageBox.Show("Xóa thành công.");
        }

        private void LayDuLieuLenTextBox()
        {
            txt_manv.DataBindings.Clear();
            txt_manv.DataBindings.Add("Text", dgv_dsnd.DataSource, "manv");

            txt_tnv.DataBindings.Clear();
            txt_tnv.DataBindings.Add("Text", dgv_dsnd.DataSource, "tennv");

            txt_tdn.DataBindings.Clear();
            txt_tdn.DataBindings.Add("Text", dgv_dsnd.DataSource, "tendangnhap");

            txt_mk.DataBindings.Clear();
            txt_mk.DataBindings.Add("Text", dgv_dsnd.DataSource, "matkhau");

            txt_ngaysinh.DataBindings.Clear();
            txt_ngaysinh.DataBindings.Add("Text", dgv_dsnd.DataSource, "ngaysinh");

            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", dgv_dsnd.DataSource, "diachi");

            txt_dienthoai.DataBindings.Clear();
            txt_dienthoai.DataBindings.Add("Text", dgv_dsnd.DataSource, "dienthoai");

            cbb_quyen.DataBindings.Clear();
            cbb_quyen.DataBindings.Add("Text", dgv_dsnd.DataSource, "tenquyen");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Sửa")
            {
                pnl_ttnd.Enabled = true;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_sua.Text = "Lưu";
            }
            else
            {
                conn.Open();

                string query = "UPDATE NhanVien SET manv = '" + txt_manv.Text + "', tennv = N'" + txt_tnv.Text + "',tendangnhap = '"+txt_tdn.Text+"', ngaysinh = '" + txt_ngaysinh.Text + "', diachi = N'" + txt_diachi.Text + "', dienthoai = '" + txt_dienthoai.Text + "', matkhau = '" + txt_mk.Text + "', maquyen = N'" + cbb_quyen.SelectedValue + "' WHERE manv = '" + txt_manv.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LayDuLieuLenDataGridView();
                LayDuLieuLenTextBox();

                //MessageBox.Show("Sửa thành công.");

                btn_sua.Text = "Sửa";
                pnl_ttnd.Enabled = false;
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                LayDuLieuLenTextBox();
            }
        }

        private void dgv_dsnd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
