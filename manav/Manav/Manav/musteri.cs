using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Manav
{
    public partial class musteri : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        urunsql urunler = new urunsql();
        public musteri()
        {
            InitializeComponent();
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=manav";
                conn.Open();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            urun();
        }
        public void urun()
        {
            try
            {
                listBox1.Items.Clear();
                string sql = "SELECT * FROM urun";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBox1.Sorted = true;
                    listBox1.Items.Add("Barkod : " + rdr[2] + "   ~" 
                        + rdr[1] + "~   " + rdr[3] + " ₺/kg");

                }
                rdr.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
        private void hesapla()
        {
            try
            {
                string sqll = "SELECT sum(fiyat) FROM urun where 0";
                MySqlCommand cmd = new MySqlCommand(sqll, conn);
                label4.Text = cmd.ExecuteScalar()+ " tl";
                 //conn.Close();
            }
            catch (Exception)
            {
                ;
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                urun();
                string sql = "SELECT * FROM urun WHERE `barkod`='" + textBox1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                //Urun u = (Urun)listBox2.SelectedItem;
                while (rdr.Read())
                {
                    
                    listBox2.Items.Add("Barkod : " + rdr[2] 
                        + " ~" + rdr[1] + "~  " + rdr[3] +" ₺/kg");
                }
                hesapla();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaekran anaekran = new anaekran();
            anaekran.Show();
            this.Hide();
        }

        private void musteri_Load(object sender, EventArgs e)
        {
            //listBox2.DataSource = urunler.uruns;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //fiş
            MessageBox.Show
            (
                  "\n" +
                  "\n\nSistem Hatalarından dolayi Tek ürün satışı yapılmaktadır.\n" +
                  "\n--------------------------------------------------------------" +
                  "\nAlınan Ürün : " + listBox2.SelectedItem +
                  "\n--------------------------------------------------------------" +
                  "\n\nGÜNGÖR MANAV          iyi alışverişler dileriz " 
            );
        }
    }
}
