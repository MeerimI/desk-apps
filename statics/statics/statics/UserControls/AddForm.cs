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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
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

        private void Button1_Click(object sender, EventArgs e)
        {
            name.Text = "";
            age.Text = "";
            gender.Text = ""; 
            education.Text = "";
            citizen.Text = "";
            work.Text = "";
           
           
        }
        dbConnect dbCon1 = new dbConnect();

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void saveOK_Click(object sender, EventArgs e)
        {
            if (name.Text != null && citizen.Text != null && gender.Text != null && work.Text != null)
            {
                dbCon1.Execat("INSERT INTO users(Name, Age, Gender, Education, Сitizen, Unemployed)" +

                 $"VALUES ('{name.Text}','{age.Text}','{gender.Text}','{education.Text}', '{citizen.Text}', '{work.Text}') ");
                MessageBox.Show("Успешно Добавлено!");

                name.Text = "";
                age.Text = "";
                gender.Text = "";
                education.Text = "";
                citizen.Text = "";
                work.Text = "";
            }
            else if (name.Text == null | citizen.Text == null | gender.Text == null | education.Text == null)
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
