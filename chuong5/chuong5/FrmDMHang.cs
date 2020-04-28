using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace chuong5
{
    public partial class FrmDMHang : Form
    {
        SqlConnection con = new SqlConnection();
        public FrmDMHang()
        {
            InitializeComponent();
        }

        private void FrmDMHang_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Qly_Bhang;Integrated Security=True";
            con.ConnectionString = ConnectionString;
            con.Open();

            string sql = " select * from DMHang";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tableDMHang = new DataTable();
            adp.Fill(tableDMHang);
            
            dataGridView1.DataSource = tableDMHang;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGiaBan.Text = dataGridView1.CurrentRow.Cells["GiaBan"].Value.ToString();
            txtGiaNhap.Text = dataGridView1.CurrentRow.Cells["GiaNhap"].Value.ToString();
            txtMaHang.Text = dataGridView1.CurrentRow.Cells["MaHang"].Value.ToString();
            txtTenHang.Text = dataGridView1.CurrentRow.Cells["TenHang"].Value.ToString();
            txtSoLuong.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtMaHang.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //tao cau lenh xoa
            string sql = " Delete from DMHang where MaHang = '" + txtMaHang.Text + "'";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            loadDataGridView();
        }


        private void loadDataGridView()
        {
            string sql = " select * from DMHang";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tableDMHang = new DataTable();
            adp.Fill(tableDMHang);

            dataGridView1.DataSource = tableDMHang;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtMaHang.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Ban can nhap ma hang");
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text == "")
            {
                MessageBox.Show(" ban can nhap ten hang");
                txtTenHang.Focus();
            }
            else
            {
                // insert into DMHang (MaHang, TenHang, GiaNhap, GiaBan, soLuong) values()
                string sql = " insert into DMHang values('" + txtMaHang.Text + "','" + txtTenHang.Text + "'";
                if (txtGiaNhap.Text != "")
                {
                    sql = sql + "," + txtGiaNhap.Text.Trim();
                }
                if (txtGiaBan.Text != "")
                {
                    sql = sql + "," + txtGiaBan.Text.Trim();
                }
                if (txtSoLuong.Text != "")
                {
                    sql = sql + "," + txtSoLuong.Text.Trim();
                }
                sql = sql + ")";
                MessageBox.Show(sql);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                loadDataGridView();
            }
        }
        


        
    }
}
