using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programajak
{
    public partial class DataPrint : Form
    {
        public DataPrint()
        {
            InitializeComponent();
        }

        private void DataPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ajak.tblapprovevoucer_tm' table. You can move, or remove it, as needed.
            this.tblapprovevoucer_tmTableAdapter.Fill(this.ajak.tblapprovevoucer_tm);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.tblapprovevoucer_tmTableAdapter.FillBy(this.ajak.tblapprovevoucer_tm, textBox1.Text);

            //this.dataGridView1.Refresh();
        }
    }
}
