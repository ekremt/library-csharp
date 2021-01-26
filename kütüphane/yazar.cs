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
    public partial class yazar : Form
    {
        public yazar()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection();
        OleDbCommand komut = new OleDbCommand();
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            komut.Connection = bag;
            komut.CommandText = "insert into yazar(y_adı,y_soyadı)values('" + textBox1.Text + "','" + textBox2.Text + "')";
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void yazar_Load(object sender, EventArgs e)
        {
            bag.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=data.accdb";
            bag.Open();
            MessageBox.Show("Bağlantı Yapıldı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 kk = new Form1();
            kk.ShowDialog();

        }
    }
}
