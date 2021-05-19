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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        public MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='statics';username=root;password=root;CharSet=utf8;");
        public MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();


        public void FillDGV(string valueToSearch)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE CONCAT(ID, Name, Age, Gender, Education, Сitizen, Unemployed ) LIKE '%" + valueToSearch + "%'", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvViewDelete.RowTemplate.Height = 40;

            dgvViewDelete.AllowUserToAddRows = false;
            dgvViewDelete.DataSource = table;

            dgvViewDelete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            conn.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show(myMsg);

            }
            else
            {

                MessageBox.Show("Query Not Executed");

            }

            conn.Close();

            FillDGV("");
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string loadd = "DELETE FROM users WHERE ID = '" + dgvViewDelete.CurrentRow.Cells[0].Value.ToString() + "';";
            command = new MySqlCommand(loadd, conn);
            command.ExecuteNonQuery();
            FillDGV("");
            dgvViewDelete.Refresh();
            MessageBox.Show("Успешно удалено!");
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            string loadd = "SELECT * FROM users WHERE Name like '%" + guna2TextBox1.Text + "%' OR Age like '%" + guna2TextBox1.Text + "%' OR Gender like '%" + guna2TextBox1.Text + "%'OR Education  like '%" + guna2TextBox1.Text + "%'OR Сitizen  like '%" + guna2TextBox1.Text + "%'OR Unemployed  like '%" + guna2TextBox1.Text + "%'";
            command = new MySqlCommand(loadd, conn);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(tbl);
            conn.Close();
            dgvViewDelete.DataSource = tbl;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Load(object sender, EventArgs e)
        {
            FillDGV("");
            
        }
    }
}
