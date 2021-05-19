using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statics.UserControls
{
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }
       
        public MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='statics';username=root;password=root;CharSet=utf8;");
        public MySqlCommand command = new MySqlCommand();
        public MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        //public DataTable filldata()
        //{

        //    //conn.Open();
        //    DataTable dt = new DataTable();
        //    command = new MySqlCommand("SELECT * FROM users", conn);
        //    adapter = new MySqlDataAdapter(command);
        //    adapter.Fill(dt);
        //    conn.Close();
        //    return dt;
        //}
        public void FillDGV(string valueToSearch)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE CONCAT(ID, Name, Age, Gender, Education, Сitizen, Unemployed ) LIKE '%" + valueToSearch + "%'", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvViewChange.RowTemplate.Height = 40;

            dgvViewChange.AllowUserToAddRows = false;
            dgvViewChange.DataSource = table;

            dgvViewChange.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


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

                MessageBox.Show("Запрос Не Выполнен");

            }

            conn.Close();

            FillDGV("");
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            //dgvViewChange.DataSource = filldata();
            FillDGV("");
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='statics';username=root;password=root;CharSet=utf8;");

                string selectQuery = "SELECT * FROM combobox";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    gender.Items.Add(reader.GetString("Gender"));
                    citizen.Items.Add(reader.GetString("Citizen"));
                    work.Items.Add(reader.GetString("Unemployed"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveOK_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
           
            MySqlCommand command = new MySqlCommand("UPDATE users SET Name=@name, Age=@age, Gender=@gender, Education=@education, 	Сitizen=@citizen, Unemployed=@unemployed WHERE ID = @id", conn);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtID.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = age.Text;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender.Text;
            command.Parameters.Add("@education", MySqlDbType.VarChar).Value = education.Text;
            command.Parameters.Add("@citizen", MySqlDbType.VarChar).Value = citizen.Text;
            command.Parameters.Add("@unemployed", MySqlDbType.VarChar).Value = work.Text;

            ExecMyQuery(command, "Успешно изменён!");
            //ExecMyQuery(command, "Data Updated");

        }

        private void dgvViewChange_Click(object sender, EventArgs e)
        {
            
            txtID.Text = dgvViewChange.CurrentRow.Cells[0].Value.ToString();
            name.Text = dgvViewChange.CurrentRow.Cells[1].Value.ToString();
            age.Text = dgvViewChange.CurrentRow.Cells[2].Value.ToString();
            gender.Text = dgvViewChange.CurrentRow.Cells[3].Value.ToString();
            education.Text = dgvViewChange.CurrentRow.Cells[4].Value.ToString();
            citizen.Text = dgvViewChange.CurrentRow.Cells[5].Value.ToString();
            work.Text = dgvViewChange.CurrentRow.Cells[6].Value.ToString();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            name.Text = "";
            age.Text = "";
            gender.Text = "";
            education.Text = "";
            citizen.Text = "";
            work.Text = "";
        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void customInstaller1_AfterInstall(object sender, System.Configuration.Install.InstallEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
