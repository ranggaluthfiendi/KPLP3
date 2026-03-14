namespace Modul3_103022400021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Celcius");
            comboBox1.Items.Add("Fahreinheit");
            comboBox1.Items.Add("Kelvin");
            comboBox1.Items.Add("Reamur");

            comboBox2.Items.Add("Celcius");
            comboBox2.Items.Add("Fahreinheit");
            comboBox2.Items.Add("Kelvin");
            comboBox2.Items.Add("Reamur");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Masukkan angka yang valid");
                return;
            }

            double nilai = Convert.ToDouble(textBox1.Text);
            double celcius = 0;
            double hasil = 0;

            string awal = comboBox1.Text;
            string akhir = comboBox2.Text;

            if (awal == "Celcius")
            {
                celcius = nilai;
            }
            else if (awal == "Fahreinheit")
            {
                celcius = (nilai - 32) * 5 / 9;
            }
            else if (awal == "Kelvin")
            {
                celcius = nilai - 273.15;
            }
            else if (awal == "Reamur")
            {
                celcius = nilai * 5 / 4;
            }

            if (akhir == "Celcius")
            {
                hasil = celcius;
            }
            else if (akhir == "Fahreinheit")
            {
                hasil = (celcius * 9 / 5) + 32;
            }
            else if (akhir == "Kelvin")
            {
                hasil = celcius + 273.15;
            }
            else if (akhir == "Reamur")
            {
                hasil = celcius * 4 / 5;
            }

            textBox2.Text = hasil.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
