using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace programajak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection cn;
        MySqlCommand cmd;
        

        private void ClearData()
        {
            lblID.Text = "";
            txtCIF.Text = "";
            txtNama.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection(@"server=192.168.1.12; user id=root; password=@Qwert!123; persistsecurityinfo=True; database=sgsprod");
            cn.Open();

            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            //this.reportViewer3.RefreshReport();

            this.tblcustomer_tmTableAdapter.FillBy(this.ajak.tblcustomer_tm);
            this.dataGridView1.Refresh();

            this.tbldebiturTableAdapter.FillBy(this.ajak.tbldebitur);
            this.dataGridView2.Refresh();

            dataGridView2.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //this.tblcustomer_tmTableAdapter.Fill(this.ajak.tblcustomer_tm, txtCIF.Text);
            this.tbldebiturTableAdapter.Fill(this.ajak.tbldebitur, int.Parse(lblID.Text));

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblID.Text != string.Empty &&  txtCIF.Text != string.Empty && txtNama.Text != string.Empty)
            {
                cmd = new MySqlCommand("ApproveDebiturNew", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_IdDebitur", 0);
                cmd.Parameters.AddWithValue("_CIF", txtCIF.Text);
                cmd.Parameters.AddWithValue("_NameDebitur", txtNama.Text);
                cmd.Parameters.AddWithValue("_ActionType", "1");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan !!", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //GetAllSatelliteRecord();
                ClearData();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan data !!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tblcustomer_tmTableAdapter.Fill(this.ajak.tblcustomer_tm, textBox2.Text);
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCIF.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNama.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Refresh();
            dataGridView2.Update();
        }
    }
}
