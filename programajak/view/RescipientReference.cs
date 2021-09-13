﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using programajak.Db;

namespace programajak
{
    public partial class RescipientReference : Form
    {
        public RescipientReference()
        {
            InitializeComponent();
            
        }

        private void ClearData()
        {
            lblId.Text = "";
            txtNama.Text = "";
            txtToken.Text = "";
            txtReference.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnSearchNasabah_Click(object sender, EventArgs e)
        {
            this.tblcustomer_tmTableAdapter.Fill(this.ajak.tblcustomer_tm, txtSearchNasabah.Text);
            this.dataGridView1.Refresh();
        }

        private void RescipientReference_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ajak.tbldebitur_tk' table. You can move, or remove it, as needed.
            this.tblcustomer_tmTableAdapter.FillBy(this.ajak.tblcustomer_tm);
            this.dataGridView1.Refresh();

            getAllDebitur();
            dataGridView2.Refresh();

            dataGridView2.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private DataTable getAllDebitur()
        {
            ConnectionManager Mycon = new ConnectionManager();
            try
            {
                using (MySqlConnection con = Mycon.ConnectionDb)
                {
                    con.Open();
                    using (DataTable dt = new DataTable())
                    {
                        string query = "SELECT * FROM tbldebitur_tk";
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                            sda.Fill(dt);
                            dataGridView2.DataSource = dt;
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Mycon = null;
            }
        }

        private DataTable getNameDebitur()
        {
            ConnectionManager Mycon = new ConnectionManager();
            try
            {
                using (MySqlConnection con = Mycon.ConnectionDb)
                {
                    con.Open();
                    using (DataTable dt = new DataTable())
                    {
                        string query = "SELECT * FROM tbldebitur_tk WHERE name_debitur = @name";
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@name", txtSearch2.Text);

                            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                            sda.Fill(dt);
                            dataGridView2.DataSource = dt;
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Mycon = null;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnClear.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Id Voucer Belum Di Isi !!!");
                txtNama.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtToken.Text))
            {
                MessageBox.Show("CIF Belum Di Isi !!!");
                txtToken.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtReference.Text))
            {
                MessageBox.Show("Nama Belum Di Isi !!!");
                txtReference.Select();
            }
            else
            {
                try
                {
                    ConnectionManager Mycon = new ConnectionManager();

                    using (MySqlConnection conn = Mycon.ConnectionDb)
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand("ApproveDebitur", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("_IdDebitur", 0);
                            cmd.Parameters.AddWithValue("_NameDebitur",txtNama.Text);
                            cmd.Parameters.AddWithValue("_TokenDebitur", txtToken.Text);
                            cmd.Parameters.AddWithValue("_NameCustomer", txtReference.Text);
                            cmd.Parameters.AddWithValue("_ActionType", "1");
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Data Reference Berhasil Ditambahkan !!!");
                                ClearData();
                                getAllDebitur();
                                this.dataGridView2.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("Gagal Menambahkan Data Reference !!!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            getNameDebitur();
            dataGridView2.Refresh();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtToken.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtReference.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnSave.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ConnectionManager Mycon = new ConnectionManager();
            try
            {
                using (MySqlConnection conn = Mycon.ConnectionDb)
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("ApproveDebitur", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_IdDebitur", lblId.Text);
                        cmd.Parameters.AddWithValue("_NameDebitur", txtNama.Text);
                        cmd.Parameters.AddWithValue("_TokenDebitur", txtToken.Text);
                        cmd.Parameters.AddWithValue("_NameCustomer", txtReference.Text);
                        cmd.Parameters.AddWithValue("_ActionType", "2");
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Berhasil Di Update !!!");
                            ClearData();
                            getAllDebitur();
                            this.dataGridView2.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Gagal Update Data !!!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Mycon = null;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
