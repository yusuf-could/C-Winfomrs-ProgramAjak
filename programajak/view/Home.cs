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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ApproveVoucer apv = new ApproveVoucer();
            apv.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RescipientReference rf = new RescipientReference();
            rf.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            view.VoucerDebitur dpt = new view.VoucerDebitur();
            dpt.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            view.ReportDataVoucer rdv = new view.ReportDataVoucer();
            rdv.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            view.ReportDataReference rdr = new view.ReportDataReference();
            rdr.ShowDialog();
        }
    }
}
