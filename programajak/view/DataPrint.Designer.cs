
namespace programajak
{
    partial class DataPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbldebiturBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ajak = new programajak.ajak();
            this.tbldebiturTableAdapter = new programajak.ajakTableAdapters.tbldebiturTableAdapter();
            this.tblapprovevoucertmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblapprovevoucer_tmTableAdapter = new programajak.ajakTableAdapters.tblapprovevoucer_tmTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_voucer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_voucer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_change_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldebiturBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblapprovevoucertmBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIFDataGridViewTextBoxColumn,
            this.name_customer,
            this.total_voucer,
            this.qty_voucer,
            this.end_date,
            this.last_change_date});
            this.dataGridView1.DataSource = this.tblapprovevoucertmBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(796, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbldebiturBindingSource
            // 
            this.tbldebiturBindingSource.DataMember = "tbldebitur";
            this.tbldebiturBindingSource.DataSource = this.ajak;
            // 
            // ajak
            // 
            this.ajak.DataSetName = "ajak";
            this.ajak.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldebiturTableAdapter
            // 
            this.tbldebiturTableAdapter.ClearBeforeFill = true;
            // 
            // tblapprovevoucertmBindingSource
            // 
            this.tblapprovevoucertmBindingSource.DataMember = "tblapprovevoucer_tm";
            this.tblapprovevoucertmBindingSource.DataSource = this.ajak;
            // 
            // tblapprovevoucer_tmTableAdapter
            // 
            this.tblapprovevoucer_tmTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(87, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 21);
            this.textBox1.TabIndex = 18;
            // 
            // cIFDataGridViewTextBoxColumn
            // 
            this.cIFDataGridViewTextBoxColumn.DataPropertyName = "CIF";
            this.cIFDataGridViewTextBoxColumn.HeaderText = "CIF";
            this.cIFDataGridViewTextBoxColumn.Name = "cIFDataGridViewTextBoxColumn";
            this.cIFDataGridViewTextBoxColumn.Width = 48;
            // 
            // name_customer
            // 
            this.name_customer.DataPropertyName = "name_customer";
            this.name_customer.HeaderText = "NAMA";
            this.name_customer.Name = "name_customer";
            this.name_customer.Width = 63;
            // 
            // total_voucer
            // 
            this.total_voucer.DataPropertyName = "total_voucer";
            this.total_voucer.HeaderText = "JUMLAH";
            this.total_voucer.Name = "total_voucer";
            this.total_voucer.Width = 75;
            // 
            // qty_voucer
            // 
            this.qty_voucer.DataPropertyName = "qty_voucer";
            this.qty_voucer.HeaderText = "VOUCER";
            this.qty_voucer.Name = "qty_voucer";
            this.qty_voucer.Width = 77;
            // 
            // end_date
            // 
            this.end_date.DataPropertyName = "end_date";
            this.end_date.HeaderText = "EXPAIRED";
            this.end_date.Name = "end_date";
            this.end_date.Width = 86;
            // 
            // last_change_date
            // 
            this.last_change_date.DataPropertyName = "last_change_date";
            this.last_change_date.HeaderText = "TANGGAL";
            this.last_change_date.Name = "last_change_date";
            this.last_change_date.Width = 83;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 409);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Penggunaan Voucer";
            // 
            // DataPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 433);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataPrint";
            this.Text = "DataPrint";
            this.Load += new System.EventHandler(this.DataPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldebiturBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblapprovevoucertmBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tbldebiturBindingSource;
        private ajak ajak;
        private ajakTableAdapters.tbldebiturTableAdapter tbldebiturTableAdapter;
        private System.Windows.Forms.BindingSource tblapprovevoucertmBindingSource;
        private ajakTableAdapters.tblapprovevoucer_tmTableAdapter tblapprovevoucer_tmTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_voucer;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_voucer;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_change_date;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}