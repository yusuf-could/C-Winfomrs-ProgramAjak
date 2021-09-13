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
    public partial class ReportDataReference : Form
    {
        public ReportDataReference()
        {
            InitializeComponent();
        }

        private void ReportDataReference_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ajak.tbldebitur_tk' table. You can move, or remove it, as needed.
            this.tbldebitur_tkTableAdapter.Fill(this.ajak.tbldebitur_tk);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbldebitur_tkTableAdapter.FillBy1(this.ajak.tbldebitur_tk, dateTimePicker1.Value, dateTimePicker2.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
