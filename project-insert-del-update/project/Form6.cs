using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace project
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='project-c#';username=root;password=root;CharSet=utf8;");
        private void Form6_Load(object sender, EventArgs e)
        {
            FillDGV("");
        }

        public void FillDGV(string valueToSearch)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM products WHERE CONCAT(ID, Name, De) LIKE '%" + valueToSearch + "%'", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.RowTemplate.Height = 60;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[3];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void BTN_CHOOSE_IMAGE_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[3].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);

            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxDesc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            connection.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show(myMsg);

            }
            else
            {

                MessageBox.Show("Query Not Executed");

            }

            connection.Close();

            FillDGV("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDGV(textBoxSearch.Text);
        }

        private void BTN_CHOOSE_I_Click(object sender, EventArgs e)
        {

        }

        private void BTN_INSERT_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO products(ID, Name, De, Image) VALUES (@id,@name,@de,@img)", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@de", MySqlDbType.VarChar).Value = textBoxDesc.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Inserted");

        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE products SET Name=@name, De=@de, Image=@img WHERE ID = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@de", MySqlDbType.VarChar).Value = textBoxDesc.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Updated");
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM products WHERE ID = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;

            ExecMyQuery(command, "Data Deleted");

            ClearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_FIND_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM products WHERE ID = @id", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("No Data Found");
                ClearFields();
            }
            else
            {

                textBoxID.Text = table.Rows[0][0].ToString();
                textBoxName.Text = table.Rows[0][1].ToString();
                textBoxDesc.Text = table.Rows[0][2].ToString();

                byte[] img = (byte[])table.Rows[0][3];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);

            }
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        public void ClearFields()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxDesc.Text = "";

            pictureBox1.Image = null;

        }
    }
}
