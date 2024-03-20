using System.Numerics;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace WinFormsApptest
{
    public partial class Form1 : Form

    {
        //private string connectionString;

        public Form1()
        {
            InitializeComponent();

           // connectionString = "server=localhost; user=root; password=0000;Database=Karaterbog";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double Grade1, Grade2, Grade3, Grade4, Grade5, Lowest_Grade, Highest_Grade, Average_Grade;

                Grade1 = int.Parse(textBox16.Text);
                Grade2 = int.Parse(textBox13.Text);
                Grade3 = int.Parse(textBox12.Text);
                Grade4 = int.Parse(textBox15.Text);
                Grade5 = int.Parse(textBox10.Text);

                Lowest_Grade = Math.Min(Math.Min(Grade1, Grade2), Math.Min(Grade3, Grade4));
                Lowest_Grade = Math.Min(Lowest_Grade, Grade5);

                Highest_Grade = Math.Max(Math.Max(Grade1, Grade2), Math.Max(Grade3, Grade4));
                Highest_Grade = Math.Max(Highest_Grade, Grade5);

                textBox11.Text = Lowest_Grade.ToString();
                textBox14.Text = Highest_Grade.ToString();

                Average_Grade = (Grade1 + Grade2 + Grade3 + Grade4 + Grade5) / 5;
                textBox9.Text = Average_Grade.ToString();
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost; user=root; password=0000;Database=Karaterbog";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "INSERT INTO `karaterbog`.`karater`\r\n(`Lowest grade`,\r\n`Highest grade`,\r\n`Average grade`)\r\nVALUES\r\n('"+ textBox11.Text +"',\r\n'"+ textBox14.Text + "',\r\n'"+ textBox9.Text +"');";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        
        
        }

    }
}
