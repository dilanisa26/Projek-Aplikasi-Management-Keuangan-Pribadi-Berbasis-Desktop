namespace aplikasi_keuangan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void catatan_Click(object sender, EventArgs e)
        {

        }

        private void nama_pemasukan_Click(object sender, EventArgs e)
        {

        }

        private void jumlah1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_pemasukan.Visible = true;
            lbl_pemasukan.Text = "Tanggal:" + txt_tanggal.Text + "\nNama Pemasukan:" + txt_pemasukan.Text + "\nJumlah:" + txt_jumlah.Text + "\nCatatan:" + txt_catatan.Text + "";
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            txt_tanggal.Text = "";
            txt_pemasukan.Text = "";
            txt_jumlah.Text = "";
            txt_catatan.Text = "";
            lbl_pemasukan.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label_pengeluaran.Visible = true;
            label_pengeluaran.Text = "Tanggal:" + txt_tglpengeluaran.Text + "\nNama Pengeluaran:" + txt_namapengeluaran.Text + "\nJumlah:" + txt_jumlahpengeluaran.Text + "\nCatatan:" + txt_ctnpengeluaran.Text + "";
        }

        private void btn_delete2_Click(object sender, EventArgs e)
        {
            txt_tglpengeluaran.Text = "";
            txt_namapengeluaran.Text = "";
            txt_jumlahpengeluaran.Text = "";
            txt_ctnpengeluaran.Text = "";
            label_pengeluaran.Text = "";
        }
    }
}