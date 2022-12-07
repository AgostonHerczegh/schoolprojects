using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Lekerdezes
{
    public partial class Form1 : Form
    {
        public static class SQLFORM
        {
            public static MySqlConnection kapcsolat = new MySqlConnection("server=localhost;user=root;port=3306;password=;database=foldrajz");
        }
        public Form1()
        {
            SQLFORM.kapcsolat.Open();
            InitializeComponent();
        }
        public Form1(string megoldas, string feladat)
        {


        }
        private void Form1_Load(object sender, EventArgs e)
        {   
            richTextBox1.ReadOnly = true;
            string kapcsolat = "server=localhost;user=root;port=3306;password=";
            MySqlConnection adb = new MySqlConnection(kapcsolat);
            MySqlCommand dropadb = new MySqlCommand("DROP DATABASE IF EXISTS foldrajz", adb);
            adb.Open();
            dropadb.ExecuteNonQuery();
            adb.Close();
            MySqlCommand letrehoz = new MySqlCommand("CREATE DATABASE foldrajz DEFAULT CHARSET utf8 COLLATE utf8_hungarian_ci", adb);
            adb.Open();
            letrehoz.ExecuteNonQuery();
            adb.Close();
        }
        public void gomb1(string megoldas, string feladat)
        {

        }
        private void button1_Click(object sender, EventArgs e)    // 1. - 10.
        {
            Form2 ten = new Form2();
            ten.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ten.TopLevel = false;
            this.panel1.Controls.Add(ten);
            ten.BringToFront();
            ten.Show();

            richTextBox1.Visible = true;
            textBox1.Visible = true;
        }

    }
}
