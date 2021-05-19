namespace statics.UserControls
{
    partial class ChangeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.saveOK = new Guna.UI2.WinForms.Guna2Button();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dgvViewChange = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.age = new Guna.UI2.WinForms.Guna2TextBox();
            this.education = new Guna.UI2.WinForms.Guna2TextBox();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.work = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.citizen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewChange)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // saveOK
            // 
            this.saveOK.AutoRoundedCorners = true;
            this.saveOK.BackColor = System.Drawing.Color.Transparent;
            this.saveOK.BorderRadius = 19;
            this.saveOK.CheckedState.Parent = this.saveOK;
            this.saveOK.CustomImages.Parent = this.saveOK;
            this.saveOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.saveOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveOK.ForeColor = System.Drawing.Color.White;
            this.saveOK.HoverState.Parent = this.saveOK;
            this.saveOK.Location = new System.Drawing.Point(714, 463);
            this.saveOK.Name = "saveOK";
            this.saveOK.ShadowDecoration.BorderRadius = 19;
            this.saveOK.ShadowDecoration.Color = System.Drawing.Color.BlanchedAlmond;
            this.saveOK.ShadowDecoration.Enabled = true;
            this.saveOK.ShadowDecoration.Parent = this.saveOK;
            this.saveOK.Size = new System.Drawing.Size(111, 41);
            this.saveOK.TabIndex = 1;
            this.saveOK.Text = "Изменить";
            this.saveOK.Click += new System.EventHandler(this.saveOK_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AutoRoundedCorners = true;
            this.clearBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.clearBtn.BorderRadius = 19;
            this.clearBtn.BorderThickness = 2;
            this.clearBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.clearBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.clearBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.clearBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.clearBtn.CheckedState.Parent = this.clearBtn;
            this.clearBtn.CustomImages.Parent = this.clearBtn;
            this.clearBtn.FillColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.clearBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.clearBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.clearBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.clearBtn.HoverState.Parent = this.clearBtn;
            this.clearBtn.Location = new System.Drawing.Point(583, 463);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.ShadowDecoration.Parent = this.clearBtn;
            this.clearBtn.Size = new System.Drawing.Size(111, 41);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // dgvViewChange
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(24)))), ((int)(((byte)(154)))));
            this.dgvViewChange.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvViewChange.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewChange.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewChange.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvViewChange.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewChange.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvViewChange.ColumnHeadersHeight = 45;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(24)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewChange.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvViewChange.DoubleBuffered = true;
            this.dgvViewChange.EnableHeadersVisualStyles = false;
            this.dgvViewChange.GridColor = System.Drawing.Color.White;
            this.dgvViewChange.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.dgvViewChange.HeaderForeColor = System.Drawing.Color.White;
            this.dgvViewChange.Location = new System.Drawing.Point(35, 296);
            this.dgvViewChange.Name = "dgvViewChange";
            this.dgvViewChange.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvViewChange.RowHeadersVisible = false;
            this.dgvViewChange.RowTemplate.DividerHeight = 3;
            this.dgvViewChange.RowTemplate.Height = 30;
            this.dgvViewChange.RowTemplate.ReadOnly = true;
            this.dgvViewChange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewChange.Size = new System.Drawing.Size(790, 157);
            this.dgvViewChange.TabIndex = 60;
            this.dgvViewChange.Click += new System.EventHandler(this.dgvViewChange_Click);
            // 
            // age
            // 
            this.age.AutoRoundedCorners = true;
            this.age.BorderColor = System.Drawing.Color.Gray;
            this.age.BorderRadius = 14;
            this.age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.age.DefaultText = "";
            this.age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age.DisabledState.Parent = this.age;
            this.age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.age.FocusedState.Parent = this.age;
            this.age.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.age.HoverState.Parent = this.age;
            this.age.Location = new System.Drawing.Point(126, 186);
            this.age.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.age.Name = "age";
            this.age.PasswordChar = '\0';
            this.age.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.age.PlaceholderText = "";
            this.age.SelectedText = "";
            this.age.ShadowDecoration.Parent = this.age;
            this.age.Size = new System.Drawing.Size(277, 30);
            this.age.TabIndex = 3;
            // 
            // education
            // 
            this.education.AutoRoundedCorners = true;
            this.education.BorderColor = System.Drawing.Color.Gray;
            this.education.BorderRadius = 14;
            this.education.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.education.DefaultText = "";
            this.education.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.education.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.education.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.education.DisabledState.Parent = this.education;
            this.education.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.education.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.education.FocusedState.Parent = this.education;
            this.education.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.education.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.education.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.education.HoverState.Parent = this.education;
            this.education.Location = new System.Drawing.Point(548, 123);
            this.education.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.education.Name = "education";
            this.education.PasswordChar = '\0';
            this.education.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.education.PlaceholderText = "";
            this.education.SelectedText = "";
            this.education.ShadowDecoration.Parent = this.education;
            this.education.Size = new System.Drawing.Size(277, 30);
            this.education.TabIndex = 5;
            // 
            // name
            // 
            this.name.AutoRoundedCorners = true;
            this.name.BorderColor = System.Drawing.Color.Gray;
            this.name.BorderRadius = 14;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.DefaultText = "";
            this.name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.DisabledState.Parent = this.name;
            this.name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.name.FocusedState.Parent = this.name;
            this.name.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.name.HoverState.Parent = this.name;
            this.name.Location = new System.Drawing.Point(126, 123);
            this.name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.name.PlaceholderText = "";
            this.name.SelectedText = "";
            this.name.ShadowDecoration.Parent = this.name;
            this.name.Size = new System.Drawing.Size(277, 30);
            this.name.TabIndex = 2;
            // 
            // work
            // 
            this.work.AutoRoundedCorners = true;
            this.work.BackColor = System.Drawing.Color.Transparent;
            this.work.BorderColor = System.Drawing.Color.Gray;
            this.work.BorderRadius = 14;
            this.work.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.work.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.work.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.work.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.work.FocusedState.Parent = this.work;
            this.work.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.work.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.work.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.work.HoverState.Parent = this.work;
            this.work.ItemHeight = 24;
            this.work.ItemsAppearance.Parent = this.work;
            this.work.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.work.Location = new System.Drawing.Point(548, 249);
            this.work.Name = "work";
            this.work.ShadowDecoration.Parent = this.work;
            this.work.Size = new System.Drawing.Size(277, 30);
            this.work.TabIndex = 7;
            // 
            // gender
            // 
            this.gender.AutoRoundedCorners = true;
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.BorderColor = System.Drawing.Color.Gray;
            this.gender.BorderRadius = 14;
            this.gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gender.FocusedState.Parent = this.gender;
            this.gender.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.gender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gender.HoverState.Parent = this.gender;
            this.gender.ItemHeight = 24;
            this.gender.ItemsAppearance.Parent = this.gender;
            this.gender.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gender.Location = new System.Drawing.Point(126, 249);
            this.gender.Name = "gender";
            this.gender.ShadowDecoration.Parent = this.gender;
            this.gender.Size = new System.Drawing.Size(277, 30);
            this.gender.TabIndex = 4;
            // 
            // citizen
            // 
            this.citizen.AutoRoundedCorners = true;
            this.citizen.BackColor = System.Drawing.Color.Transparent;
            this.citizen.BorderColor = System.Drawing.Color.Gray;
            this.citizen.BorderRadius = 14;
            this.citizen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.citizen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citizen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.citizen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.citizen.FocusedState.Parent = this.citizen;
            this.citizen.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.citizen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.citizen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.citizen.HoverState.Parent = this.citizen;
            this.citizen.ItemHeight = 24;
            this.citizen.ItemsAppearance.Parent = this.citizen;
            this.citizen.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.citizen.Location = new System.Drawing.Point(548, 186);
            this.citizen.Name = "citizen";
            this.citizen.ShadowDecoration.Parent = this.citizen;
            this.citizen.Size = new System.Drawing.Size(277, 30);
            this.citizen.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Location = new System.Drawing.Point(126, 74);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(184, 16);
            this.txtID.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label7.Location = new System.Drawing.Point(461, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Работа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label6.Location = new System.Drawing.Point(462, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Житель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label4.Location = new System.Drawing.Point(66, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Пол:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label2.Location = new System.Drawing.Point(63, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Имя:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label5.Location = new System.Drawing.Point(422, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Образовние:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label3.Location = new System.Drawing.Point(33, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Возраст:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label1.Location = new System.Drawing.Point(78, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "ID:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(2)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(308, 28);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(241, 21);
            this.guna2HtmlLabel1.TabIndex = 76;
            this.guna2HtmlLabel1.Text = "Изменить Инфо о Персонале";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(2)))), ((int)(((byte)(149)))));
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(36, 44);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(790, 28);
            this.guna2Separator1.TabIndex = 75;
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 530);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.education);
            this.Controls.Add(this.name);
            this.Controls.Add(this.work);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.citizen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvViewChange);
            this.Controls.Add(this.saveOK);
            this.Controls.Add(this.clearBtn);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button saveOK;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvViewChange;
        private Guna.UI2.WinForms.Guna2TextBox age;
        private Guna.UI2.WinForms.Guna2TextBox education;
        private Guna.UI2.WinForms.Guna2TextBox name;
        private Guna.UI2.WinForms.Guna2ComboBox work;
        private Guna.UI2.WinForms.Guna2ComboBox gender;
        private Guna.UI2.WinForms.Guna2ComboBox citizen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}