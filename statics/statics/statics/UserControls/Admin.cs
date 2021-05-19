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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dgvViewAdmin.DataSource = filldata();
          
        }

        public MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='statics';username=root;password=root;CharSet=utf8;");
        public MySqlCommand command = new MySqlCommand();
        public MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public DataTable filldata()
        {
            dgvViewAdmin.RowTemplate.Height = 40;

            dgvViewAdmin.AllowUserToAddRows = false;
            //conn.Open();
            DataTable dt = new DataTable();
            command = new MySqlCommand("SELECT * FROM admin", conn);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(dt);
            conn.Close();
            return dt;

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

  
        private void SearchAdmin_TextChanged(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            string loadd = "SELECT * FROM admin WHERE Name like '%" + SearchAdmin.Text + "%' OR Surname like '%" + SearchAdmin.Text + "%' OR Login like '%" + SearchAdmin.Text + "%'OR Password  like '%" + SearchAdmin.Text + "%'";
            command = new MySqlCommand(loadd, conn);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(tbl);
            conn.Close();
            dgvViewAdmin.DataSource = tbl;
        }
        public void FillDGV(string valueToSearch)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM admin WHERE CONCAT(ID, Name, Surname, Login, Password ) LIKE '%" + valueToSearch + "%'", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvViewAdmin.RowTemplate.Height = 40;

            dgvViewAdmin.AllowUserToAddRows = false;
            dgvViewAdmin.DataSource = table;

            dgvViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string loadd = "DELETE FROM admin WHERE ID = '" + dgvViewAdmin.CurrentRow.Cells[0].Value.ToString() + "';";
            command = new MySqlCommand(loadd, conn);
            command.ExecuteNonQuery();
           
            FillDGV("");
            dgvViewAdmin.Refresh();
            MessageBox.Show("Успешно Удалено!");
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
