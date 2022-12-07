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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Text = null;
        }

        public static class Conn
        {

            public static MySqlConnection conn = new MySqlConnection("server=localhost;user=root;port=3306;password=;database=foldrajz");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void gomb1_Click(object sender, EventArgs e)
        {
            string feladat = "Mi MADAGASZKÁR fővárosa? ";
            string sql1 = "SELECT fovaros, penznem FROM orszagok WHERE orszag LIKE 'MADAGASZKÁR'";
            MySqlCommand command_1 = new MySqlCommand(sql1, Conn.conn);
            MySqlDataReader read_1 = command_1.ExecuteReader();
            string megoldas = "";
            while (read_1.Read())
            {
                megoldas = " \nLegidősebb: " + read_1[0] + " Legfiatalabb: " + read_1[1];
            }
            read_1.Close();
        }

        private void gomb2_Click(object sender, EventArgs e)
        {
        
        }

        private void gomb3_Click(object sender, EventArgs e)
        {

        }

        private void gomb4_Click(object sender, EventArgs e)
        {

        }

        private void gomb5_Click(object sender, EventArgs e)
        {

        }

        private void gomb6_Click(object sender, EventArgs e)
        {

        }

        private void gomb7_Click(object sender, EventArgs e)
        {

        }

        private void gomb8_Click(object sender, EventArgs e)
        {

        }

        private void gomb9_Click(object sender, EventArgs e)
        {

        }

        private void gomb10_Click(object sender, EventArgs e)
        {

        }
    }
}
