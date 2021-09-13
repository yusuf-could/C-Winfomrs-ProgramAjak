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

namespace programajak.view
{
    public partial class VoucerDebitur : Form
    {
        public VoucerDebitur()
        {
            InitializeComponent();
        }

        private void VoucerDebitur_Load(object sender, EventArgs e)
        {
            getDataDebitur();
            dataGridView1.Refresh();

            getDataApprove();
            dataGridView2.Refresh();

            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            
            dataGridView2.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dataGridView2.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getDataDebiturName();
            dataGridView1.Refresh();
        }

        private DataTable getDataDebitur()
        {
            ConnectionManager Mycon = new ConnectionManager();
            try
            {
                using (MySqlConnection conn = Mycon.ConnectionDb)
                {
                    conn.Open();
                    using (DataTable dt = new DataTable())
                    {
                        string query = "SELECT * FROM tblapprovevoucer";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
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

        private DataTable getDataDebiturName()
        {
            ConnectionManager Mycon = new ConnectionManager();
            try
            {
                using (MySqlConnection conn = Mycon.ConnectionDb)
                {
                    conn.Open();
                    using (DataTable dt = new DataTable())
                    {
                        string query = "SELECT * FROM tblapprovevoucer WHERE name_customer = @name";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@name", txtSearch.Text);

                            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
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

        private DataTable getDataApprove()
        {
            ConnectionManager Mycon = new ConnectionManager();
            try
            {
                using (MySqlConnection conn = Mycon.ConnectionDb)
                {
                    conn.Open();
                    using (DataTable dt = new DataTable())
                    {
                        string query = "SELECT * FROM tblapprovevoucer_tm";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
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

        private DataTable getDataApproveName()
        {
            ConnectionManager Mycon = new ConnectionManager();
            try
            {
                using (MySqlConnection conn = Mycon.ConnectionDb)
                {
                    conn.Open();
                    using (DataTable dt = new DataTable())
                    {
                        string query = "SELECT * FROM tblapprovevoucer_tm WHERE name_customer = @name";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
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
            if(dataGridView1.Columns[e.ColumnIndex].HeaderText=="APPROVE")
            {
                DialogResult confirm = MessageBox.Show("Yakin Approve !!!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(confirm == DialogResult.Yes)
                {
                    int id_customer,total_voucer;
                    string CIF, name_customer;
                    DateTime end_date;
                    string date;

                    id_customer = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDCOLUMN"].Value);
                    CIF = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["CIFCOLUMN"].Value);
                    name_customer = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NAMACOLUMN"].Value);
                    total_voucer = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["TOTALCOLUMN"].Value);
                    end_date = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["ENDCOLUMN"].Value);
                    date = end_date.ToString("dd/MM/yyyy");

                    ConnectionManager Mycon = new ConnectionManager();
                    
                    try
                    {
                        using (MySqlConnection conn = Mycon.ConnectionDb)
                        {
                            conn.Open();
                            using (MySqlCommand cmd = new MySqlCommand("ApproveTransaction", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("_ActionType", "1");
                                cmd.Parameters.AddWithValue("_IdCustomer", id_customer);
                                cmd.Parameters.AddWithValue("_CIF", CIF);
                                cmd.Parameters.AddWithValue("_NameCustomer", name_customer);
                                cmd.Parameters.AddWithValue("_TotalVoucer", total_voucer);
                                cmd.Parameters.AddWithValue("_EndDate", date);
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("Berhasil Di Approve !!!");
                                    getDataApprove();
                                }
                                else
                                {
                                    MessageBox.Show("Gagal Approve !!!");
                                }
                                conn.Close();
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
                        //conn.Close();
                    }
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getDataApproveName();
            dataGridView2.Refresh();
        }
    }
}
