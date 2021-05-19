using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int count = 0, count2 = 4;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dbConnect dbCon = new dbConnect();
        
            string log = textBox2.Text;
            string pass = textBox1.Text;
            if (count <= 3)
            {
         
                if (dbCon.ReadData($"SELECT * FROM users WHERE login='{log}' AND password ='{pass}'")==1)
                {
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    count2--;
                    label1.Text = $"Пароль ката!- {count2} жолу теруу мумкунчулук калды";
                    count++;
                }
            }
        else
            {
                label1.Text = "Сизде попытка калган жок!";
            }
        }

    }
}
