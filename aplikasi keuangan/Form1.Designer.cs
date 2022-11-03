namespace aplikasi_keuangan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tgl = new System.Windows.Forms.Label();
            this.nama_pemasukan = new System.Windows.Forms.Label();
            this.jumlah1 = new System.Windows.Forms.Label();
            this.catatan = new System.Windows.Forms.Label();
            this.txt_tanggal = new System.Windows.Forms.TextBox();
            this.txt_catatan = new System.Windows.Forms.TextBox();
            this.txt_jumlah = new System.Windows.Forms.TextBox();
            this.txt_pemasukan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_pemasukan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_ctnpengeluaran = new System.Windows.Forms.TextBox();
            this.txt_namapengeluaran = new System.Windows.Forms.TextBox();
            this.txt_jumlahpengeluaran = new System.Windows.Forms.TextBox();
            this.txt_tglpengeluaran = new System.Windows.Forms.TextBox();
            this.lbl_catatan = new System.Windows.Forms.Label();
            this.lbl_jumlah = new System.Windows.Forms.Label();
            this.lbl_pengeluaran = new System.Windows.Forms.Label();
            this.lbl_tanggal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_pengeluaran = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_submit2 = new System.Windows.Forms.Button();
            this.btn_delete2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tgl
            // 
            this.tgl.AutoSize = true;
            this.tgl.Location = new System.Drawing.Point(9, 24);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(49, 15);
            this.tgl.TabIndex = 0;
            this.tgl.Text = "Tanggal";
            this.tgl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nama_pemasukan
            // 
            this.nama_pemasukan.AutoSize = true;
            this.nama_pemasukan.Location = new System.Drawing.Point(9, 62);
            this.nama_pemasukan.Name = "nama_pemasukan";
            this.nama_pemasukan.Size = new System.Drawing.Size(103, 15);
            this.nama_pemasukan.TabIndex = 1;
            this.nama_pemasukan.Text = "Nama Pemasukan";
            this.nama_pemasukan.Click += new System.EventHandler(this.nama_pemasukan_Click);
            // 
            // jumlah1
            // 
            this.jumlah1.AutoSize = true;
            this.jumlah1.Location = new System.Drawing.Point(12, 91);
            this.jumlah1.Name = "jumlah1";
            this.jumlah1.Size = new System.Drawing.Size(45, 15);
            this.jumlah1.TabIndex = 2;
            this.jumlah1.Text = "Jumlah";
            this.jumlah1.Click += new System.EventHandler(this.jumlah1_Click);
            // 
            // catatan
            // 
            this.catatan.AutoSize = true;
            this.catatan.Location = new System.Drawing.Point(9, 123);
            this.catatan.Name = "catatan";
            this.catatan.Size = new System.Drawing.Size(48, 15);
            this.catatan.TabIndex = 3;
            this.catatan.Text = "Catatan";
            this.catatan.Click += new System.EventHandler(this.catatan_Click);
            // 
            // txt_tanggal
            // 
            this.txt_tanggal.Location = new System.Drawing.Point(162, 21);
            this.txt_tanggal.Name = "txt_tanggal";
            this.txt_tanggal.Size = new System.Drawing.Size(389, 23);
            this.txt_tanggal.TabIndex = 4;
            this.txt_tanggal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_catatan
            // 
            this.txt_catatan.Location = new System.Drawing.Point(162, 123);
            this.txt_catatan.Name = "txt_catatan";
            this.txt_catatan.Size = new System.Drawing.Size(389, 23);
            this.txt_catatan.TabIndex = 5;
            // 
            // txt_jumlah
            // 
            this.txt_jumlah.Location = new System.Drawing.Point(162, 91);
            this.txt_jumlah.Name = "txt_jumlah";
            this.txt_jumlah.Size = new System.Drawing.Size(389, 23);
            this.txt_jumlah.TabIndex = 6;
            this.txt_jumlah.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_pemasukan
            // 
            this.txt_pemasukan.Location = new System.Drawing.Point(162, 54);
            this.txt_pemasukan.Name = "txt_pemasukan";
            this.txt_pemasukan.Size = new System.Drawing.Size(389, 23);
            this.txt_pemasukan.TabIndex = 7;
            this.txt_pemasukan.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tgl);
            this.groupBox1.Controls.Add(this.txt_catatan);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_submit);
            this.groupBox1.Controls.Add(this.txt_jumlah);
            this.groupBox1.Controls.Add(this.txt_pemasukan);
            this.groupBox1.Controls.Add(this.nama_pemasukan);
            this.groupBox1.Controls.Add(this.jumlah1);
            this.groupBox1.Controls.Add(this.catatan);
            this.groupBox1.Controls.Add(this.txt_tanggal);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 165);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(795, 22);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(90, 43);
            this.button_exit.TabIndex = 10;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(586, 91);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 43);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(586, 22);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(90, 43);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lbl_pemasukan);
            this.groupBox2.Location = new System.Drawing.Point(18, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 150);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // lbl_pemasukan
            // 
            this.lbl_pemasukan.AutoSize = true;
            this.lbl_pemasukan.Location = new System.Drawing.Point(7, 19);
            this.lbl_pemasukan.Name = "lbl_pemasukan";
            this.lbl_pemasukan.Size = new System.Drawing.Size(68, 15);
            this.lbl_pemasukan.TabIndex = 0;
            this.lbl_pemasukan.Text = "Pemasukan";
            this.lbl_pemasukan.Visible = false;
            this.lbl_pemasukan.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btn_delete2);
            this.groupBox3.Controls.Add(this.btn_submit2);
            this.groupBox3.Controls.Add(this.txt_ctnpengeluaran);
            this.groupBox3.Controls.Add(this.txt_namapengeluaran);
            this.groupBox3.Controls.Add(this.txt_jumlahpengeluaran);
            this.groupBox3.Controls.Add(this.txt_tglpengeluaran);
            this.groupBox3.Controls.Add(this.lbl_catatan);
            this.groupBox3.Controls.Add(this.lbl_jumlah);
            this.groupBox3.Controls.Add(this.lbl_pengeluaran);
            this.groupBox3.Controls.Add(this.lbl_tanggal);
            this.groupBox3.Location = new System.Drawing.Point(18, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(708, 155);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txt_ctnpengeluaran
            // 
            this.txt_ctnpengeluaran.Location = new System.Drawing.Point(162, 112);
            this.txt_ctnpengeluaran.Name = "txt_ctnpengeluaran";
            this.txt_ctnpengeluaran.Size = new System.Drawing.Size(389, 23);
            this.txt_ctnpengeluaran.TabIndex = 17;
            // 
            // txt_namapengeluaran
            // 
            this.txt_namapengeluaran.Location = new System.Drawing.Point(162, 51);
            this.txt_namapengeluaran.Name = "txt_namapengeluaran";
            this.txt_namapengeluaran.Size = new System.Drawing.Size(389, 23);
            this.txt_namapengeluaran.TabIndex = 16;
            // 
            // txt_jumlahpengeluaran
            // 
            this.txt_jumlahpengeluaran.Location = new System.Drawing.Point(162, 80);
            this.txt_jumlahpengeluaran.Name = "txt_jumlahpengeluaran";
            this.txt_jumlahpengeluaran.Size = new System.Drawing.Size(389, 23);
            this.txt_jumlahpengeluaran.TabIndex = 15;
            // 
            // txt_tglpengeluaran
            // 
            this.txt_tglpengeluaran.Location = new System.Drawing.Point(162, 16);
            this.txt_tglpengeluaran.Name = "txt_tglpengeluaran";
            this.txt_tglpengeluaran.Size = new System.Drawing.Size(389, 23);
            this.txt_tglpengeluaran.TabIndex = 14;
            // 
            // lbl_catatan
            // 
            this.lbl_catatan.AutoSize = true;
            this.lbl_catatan.Location = new System.Drawing.Point(16, 112);
            this.lbl_catatan.Name = "lbl_catatan";
            this.lbl_catatan.Size = new System.Drawing.Size(48, 15);
            this.lbl_catatan.TabIndex = 13;
            this.lbl_catatan.Text = "Catatan";
            this.lbl_catatan.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_jumlah
            // 
            this.lbl_jumlah.AutoSize = true;
            this.lbl_jumlah.Location = new System.Drawing.Point(16, 80);
            this.lbl_jumlah.Name = "lbl_jumlah";
            this.lbl_jumlah.Size = new System.Drawing.Size(45, 15);
            this.lbl_jumlah.TabIndex = 12;
            this.lbl_jumlah.Text = "Jumlah";
            // 
            // lbl_pengeluaran
            // 
            this.lbl_pengeluaran.AutoSize = true;
            this.lbl_pengeluaran.Location = new System.Drawing.Point(16, 51);
            this.lbl_pengeluaran.Name = "lbl_pengeluaran";
            this.lbl_pengeluaran.Size = new System.Drawing.Size(108, 15);
            this.lbl_pengeluaran.TabIndex = 11;
            this.lbl_pengeluaran.Text = "Nama Pengeluaran";
            // 
            // lbl_tanggal
            // 
            this.lbl_tanggal.AutoSize = true;
            this.lbl_tanggal.Location = new System.Drawing.Point(16, 19);
            this.lbl_tanggal.Name = "lbl_tanggal";
            this.lbl_tanggal.Size = new System.Drawing.Size(49, 15);
            this.lbl_tanggal.TabIndex = 10;
            this.lbl_tanggal.Text = "Tanggal";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.label_pengeluaran);
            this.groupBox4.Location = new System.Drawing.Point(267, 353);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 150);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // label_pengeluaran
            // 
            this.label_pengeluaran.AutoSize = true;
            this.label_pengeluaran.Location = new System.Drawing.Point(7, 19);
            this.label_pengeluaran.Name = "label_pengeluaran";
            this.label_pengeluaran.Size = new System.Drawing.Size(73, 15);
            this.label_pengeluaran.TabIndex = 0;
            this.label_pengeluaran.Text = "Pengeluaran";
            this.label_pengeluaran.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.lbl_total);
            this.groupBox5.Location = new System.Drawing.Point(505, 353);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(221, 150);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(7, 19);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(89, 15);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "Total Keuangan";
            this.lbl_total.Visible = false;
            // 
            // btn_submit2
            // 
            this.btn_submit2.Location = new System.Drawing.Point(586, 31);
            this.btn_submit2.Name = "btn_submit2";
            this.btn_submit2.Size = new System.Drawing.Size(90, 43);
            this.btn_submit2.TabIndex = 10;
            this.btn_submit2.Text = "Submit";
            this.btn_submit2.UseVisualStyleBackColor = true;
            this.btn_submit2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_delete2
            // 
            this.btn_delete2.Location = new System.Drawing.Point(586, 84);
            this.btn_delete2.Name = "btn_delete2";
            this.btn_delete2.Size = new System.Drawing.Size(90, 43);
            this.btn_delete2.TabIndex = 10;
            this.btn_delete2.Text = "Delete";
            this.btn_delete2.UseVisualStyleBackColor = true;
            this.btn_delete2.Click += new System.EventHandler(this.btn_delete2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(914, 529);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label tgl;
        private Label nama_pemasukan;
        private Label jumlah1;
        private Label catatan;
        private TextBox txt_tanggal;
        private TextBox txt_catatan;
        private TextBox txt_jumlah;
        private TextBox txt_pemasukan;
        private GroupBox groupBox1;
        private Button btn_delete;
        private Button btn_submit;
        private GroupBox groupBox2;
        private Label lbl_pemasukan;
        private Button button_exit;
        private GroupBox groupBox3;
        private Label lbl_catatan;
        private Label lbl_jumlah;
        private Label lbl_pengeluaran;
        private Label lbl_tanggal;
        private TextBox txt_ctnpengeluaran;
        private TextBox txt_namapengeluaran;
        private TextBox txt_jumlahpengeluaran;
        private TextBox txt_tglpengeluaran;
        private GroupBox groupBox4;
        private Label label_pengeluaran;
        private GroupBox groupBox5;
        private Label lbl_total;
        private Button btn_delete2;
        private Button btn_submit2;
    }
}