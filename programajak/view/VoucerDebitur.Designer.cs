
namespace programajak.view
{
    partial class VoucerDebitur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.IDCOLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIFCOLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMACOLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALCOLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TANGGALCOLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDCOLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovalColomnsButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOUCER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXPAIRED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIGUNAKAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCOLUMN,
            this.CIFCOLUMN,
            this.NAMACOLUMN,
            this.TOTALCOLUMN,
            this.TANGGALCOLUMN,
            this.ENDCOLUMN,
            this.ApprovalColomnsButton});
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(414, 396);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CIF,
            this.NAMA,
            this.VOUCER,
            this.EXPAIRED,
            this.DIGUNAKAN});
            this.dataGridView2.Location = new System.Drawing.Point(451, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(401, 396);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(190, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(154, 21);
            this.txtSearch.TabIndex = 3;
            // 
            // IDCOLUMN
            // 
            this.IDCOLUMN.DataPropertyName = "id_customer";
            this.IDCOLUMN.HeaderText = "ID";
            this.IDCOLUMN.Name = "IDCOLUMN";
            this.IDCOLUMN.Width = 43;
            // 
            // CIFCOLUMN
            // 
            this.CIFCOLUMN.DataPropertyName = "CIF";
            this.CIFCOLUMN.HeaderText = "CIF";
            this.CIFCOLUMN.Name = "CIFCOLUMN";
            this.CIFCOLUMN.Width = 48;
            // 
            // NAMACOLUMN
            // 
            this.NAMACOLUMN.DataPropertyName = "name_customer";
            this.NAMACOLUMN.HeaderText = "NAMA";
            this.NAMACOLUMN.Name = "NAMACOLUMN";
            this.NAMACOLUMN.Width = 63;
            // 
            // TOTALCOLUMN
            // 
            this.TOTALCOLUMN.DataPropertyName = "total_voucer";
            this.TOTALCOLUMN.HeaderText = "TOTAL";
            this.TOTALCOLUMN.Name = "TOTALCOLUMN";
            this.TOTALCOLUMN.Width = 67;
            // 
            // TANGGALCOLUMN
            // 
            this.TANGGALCOLUMN.DataPropertyName = "start_date";
            this.TANGGALCOLUMN.HeaderText = "TANGGAL";
            this.TANGGALCOLUMN.Name = "TANGGALCOLUMN";
            this.TANGGALCOLUMN.Width = 83;
            // 
            // ENDCOLUMN
            // 
            this.ENDCOLUMN.DataPropertyName = "end_date";
            this.ENDCOLUMN.HeaderText = "EXPAIRED";
            this.ENDCOLUMN.Name = "ENDCOLUMN";
            this.ENDCOLUMN.Width = 86;
            // 
            // ApprovalColomnsButton
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApprovalColomnsButton.DefaultCellStyle = dataGridViewCellStyle2;
            this.ApprovalColomnsButton.HeaderText = "APPROVE";
            this.ApprovalColomnsButton.Name = "ApprovalColomnsButton";
            this.ApprovalColomnsButton.Text = "APPROVE";
            this.ApprovalColomnsButton.UseColumnTextForButtonValue = true;
            this.ApprovalColomnsButton.Width = 64;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_customer";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // CIF
            // 
            this.CIF.DataPropertyName = "CIF";
            this.CIF.HeaderText = "CIF";
            this.CIF.Name = "CIF";
            this.CIF.Width = 48;
            // 
            // NAMA
            // 
            this.NAMA.DataPropertyName = "name_customer";
            this.NAMA.HeaderText = "NAMA";
            this.NAMA.Name = "NAMA";
            this.NAMA.Width = 63;
            // 
            // VOUCER
            // 
            this.VOUCER.DataPropertyName = "total_voucer";
            this.VOUCER.HeaderText = "VOUCER";
            this.VOUCER.Name = "VOUCER";
            this.VOUCER.Width = 77;
            // 
            // EXPAIRED
            // 
            this.EXPAIRED.DataPropertyName = "end_date";
            this.EXPAIRED.HeaderText = "EXPAIRED";
            this.EXPAIRED.Name = "EXPAIRED";
            this.EXPAIRED.Width = 86;
            // 
            // DIGUNAKAN
            // 
            this.DIGUNAKAN.DataPropertyName = "last_change_date";
            this.DIGUNAKAN.HeaderText = "DIGUNAKAN";
            this.DIGUNAKAN.Name = "DIGUNAKAN";
            this.DIGUNAKAN.Width = 96;
            // 
            // txtSearch2
            // 
            this.txtSearch2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch2.Location = new System.Drawing.Point(616, 23);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(154, 21);
            this.txtSearch2.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(776, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // VoucerDebitur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 451);
            this.Controls.Add(this.txtSearch2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VoucerDebitur";
            this.Text = "Voucer Debitur";
            this.Load += new System.EventHandler(this.VoucerDebitur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCOLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIFCOLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMACOLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALCOLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TANGGALCOLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDCOLUMN;
        private System.Windows.Forms.DataGridViewButtonColumn ApprovalColomnsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCER;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPAIRED;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIGUNAKAN;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.Button btnSearch;
    }
}