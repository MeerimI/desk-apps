using Guna.UI2.WinForms;
using statics.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace statics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
            //Delete frm = new Delete() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //showpnl(frm);
            //frm.Show();
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 121, b.Location.Y - 30);
            imgSlide.SendToBack();

        }

     
   

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void showpnl(Control pnl)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(pnl);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
            showpnl(panel2);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void pnlMain_Paint_1(object sender, PaintEventArgs e)
        {

        }

       
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void home_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void home_Click(object sender, EventArgs e)
        {
            Home frm = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm);
            frm.Show();
        }

        private void list_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void list_Click(object sender, EventArgs e)
        {
            Users frm = new Users() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm);
            frm.Show();
        }

        private void add_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddForm frm = new AddForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm);
            frm.Show();
        }

        private void edit_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void delete_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void admin_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            ChangeForm frm = new ChangeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm);
            frm.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Delete frm = new Delete() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm);
            frm.Show();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Admin frm = new Admin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm);
            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
