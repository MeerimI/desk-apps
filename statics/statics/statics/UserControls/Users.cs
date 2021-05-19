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

namespace statics.UserControls
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        public MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='statics';username=root;password=root;CharSet=utf8;");
        public MySqlCommand command = new MySqlCommand();
        public MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public DataTable filldata()
        {
            dgvView.RowTemplate.Height = 40;

            dgvView.AllowUserToAddRows = false;
            //conn.Open();
            DataTable dt = new DataTable();
            command = new MySqlCommand("SELECT * FROM users", conn);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(dt);
            conn.Close();
            return dt;

        }

        private void Users_Load(object sender, EventArgs e)
        {
            dgvView.DataSource = filldata();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

            DataTable tbl = new DataTable();
            string loadd = "SELECT * FROM users WHERE Name like '%" + guna2TextBox1.Text + "%' OR Age like '%" + guna2TextBox1.Text + "%' OR Gender like '%" + guna2TextBox1.Text + "%'OR Education  like '%" + guna2TextBox1.Text + "%'OR Сitizen  like '%" + guna2TextBox1.Text + "%'OR Unemployed  like '%" + guna2TextBox1.Text + "%'"; 
             command = new MySqlCommand(loadd, conn);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(tbl);
            conn.Close();
            dgvView.DataSource = tbl;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
