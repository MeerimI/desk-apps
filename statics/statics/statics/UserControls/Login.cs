using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using statics.UserControls;



namespace statics
{
    public partial class Login : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );



        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        int count = 0, count2 = 4;

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbConnect dbCon = new dbConnect();

            string log = TextBox1.Text;
            string pass = TextBox2.Text;
            if (count <= 3)
            {

                if (dbCon.ReadData($"SELECT * FROM admin WHERE login='{log}' AND password ='{pass}'") == 1)
                {
                    /* using (Form1 fd = new Form1())
                     {
                         fd.Show();
                         this.Hide();
                     }
                    */
                    Form1 fd = new Form1();
                    fd.Show();
                    this.Hide();

                }
                else
                {
                    count2--;
                    label4.Text = $"Неправильный логин или пароль. Осталось {count2}-попытки";
                    count++;
                }
            }
            else
            {
                label4.Text = "Нет Попыток!";
            }
        }
    }
}
