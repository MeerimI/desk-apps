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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        dbConnect dbCon =new dbConnect();
            private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbCon.Execat("INSERT INTO users(name, surname, dataB, login, password)" +
                $"VALUES ('{textBox1.Text}','{textBox2.Text}','{dateTimePicker1.Text}','{textBox3.Text}','{textBox4.Text}') ");
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
