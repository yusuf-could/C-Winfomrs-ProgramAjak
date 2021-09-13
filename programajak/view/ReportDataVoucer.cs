using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programajak.view
{
    public partial class ReportDataVoucer : Form
    {
        public ReportDataVoucer()
        {
            InitializeComponent();
        }

        private void ReportDataVoucer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ajak.tblapprovevoucer_tm' table. You can move, or remove it, as needed.
            this.tblapprovevoucer_tmTableAdapter.Fill(this.ajak.tblapprovevoucer_tm);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tblapprovevoucer_tmTableAdapter.FillBy(this.ajak.tblapprovevoucer_tm, dateTimePicker1.Value, dateTimePicker2.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
