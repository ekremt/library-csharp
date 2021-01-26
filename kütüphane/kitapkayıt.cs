using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kütüphane
{
    public partial class kitapkayıt : Form
    {
        public kitapkayıt()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection();
        OleDbCommand komut = new OleDbCommand();
        OleDbDataReader oku;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 kk = new Form1();
            kk.ShowDialog();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut.Connection = bag;
            komut.CommandText = "insert into kitap (k_adi,b_tarihi,sayfa_sayisi,konusu)values('" + textBox2.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "'," + Convert.ToInt32(textBox4.Text) + ",'" + richTextBox1.Text + "')";
            komut.ExecuteNonQuery();
            MessageBox.Show("kayıt eklendi");
        }

        private void kitapkayıt_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox5.Visible = true;
                bag.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=data.accdb";
                bag.Open();
                
               
            }
            catch
            {
                MessageBox.Show("Bağlantı Yok");
            }

            komut.Connection = bag;
            komut.CommandText = "select * from kitap";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[1].ToString());
            }
            oku.Close();
                


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Silinsin Mi?");
            komut.Connection = bag;
            komut.CommandText = "delete from kitap where k_no=" + Convert.ToInt32(textBox16.Text) + "";
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            komut.Connection = bag;
            komut.CommandText = "select * from kitap";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                listBox1.Items.Add(oku[1].ToString());
            }
            oku.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            komut.Connection = bag;
            komut.CommandText = "select * from kitap where k_adi='" + textBox1.Text + "'";
            oku = komut.ExecuteReader();
            oku.Read();
            textBox3.Text = oku[1].ToString();
            textBox13.Text = oku[2].ToString();
            textBox14.Text = oku[3].ToString();
            textBox15.Text = oku[4].ToString();
            textBox17.Text = oku[0].ToString();
            oku.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            komut.Connection = bag;
            komut.CommandText = "update kitap set k_adi='" + textBox3.Text + "',b_tarihi='" + Convert.ToDateTime(textBox13.Text).ToShortDateString() + "' ,sayfa_sayisi=" + Convert.ToInt32(textBox14.Text) + " ,konu='" + textBox15.Text + "'  where k_no=" + Convert.ToInt32(textBox17.Text) + "";
           
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Değiştirildi");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            komut.Connection = bag;
            komut.CommandText = "delete from kitap where k_no=" + Convert.ToInt32(textBox17.Text) + "";


            komut.ExecuteNonQuery();
            textBox3.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            MessageBox.Show("Kayıt Değiştirildi");
        }
    }
}
