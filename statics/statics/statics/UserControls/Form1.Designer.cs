namespace statics
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Guna2Button home;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new Guna.UI2.WinForms.Guna2Button();
            this.admin = new Guna.UI2.WinForms.Guna2Button();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.edit = new Guna.UI2.WinForms.Guna2Button();
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.list = new Guna.UI2.WinForms.Guna2Button();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain2 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            home = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMain2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // home
            // 
            home.BackColor = System.Drawing.Color.Transparent;
            home.BorderRadius = 22;
            home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            home.Checked = true;
            home.CheckedState.FillColor = System.Drawing.Color.White;
            home.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            home.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("home.CheckedState.Image")));
            home.CheckedState.Parent = home;
            home.CustomImages.Parent = home;
            home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            home.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            home.ForeColor = System.Drawing.Color.White;
            home.HoverState.Parent = home;
            home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            home.ImageOffset = new System.Drawing.Point(10, 0);
            home.Location = new System.Drawing.Point(22, 116);
            home.Name = "home";
            home.ShadowDecoration.Parent = home;
            home.Size = new System.Drawing.Size(143, 43);
            home.TabIndex = 3;
            home.Text = "    Главное";
            home.UseTransparentBackground = true;
            home.CheckedChanged += new System.EventHandler(this.home_CheckedChanged);
            home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.admin);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.list);
            this.panel1.Controls.Add(home);
            this.panel1.Controls.Add(this.imgSlide);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 608);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BorderRadius = 22;
            this.exit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.exit.CheckedState.FillColor = System.Drawing.Color.White;
            this.exit.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.exit.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("exit.CheckedState.Image")));
            this.exit.CheckedState.Parent = this.exit;
            this.exit.CustomImages.Parent = this.exit;
            this.exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.exit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.HoverState.Parent = this.exit;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exit.ImageOffset = new System.Drawing.Point(10, 0);
            this.exit.Location = new System.Drawing.Point(22, 488);
            this.exit.Name = "exit";
            this.exit.ShadowDecoration.Parent = this.exit;
            this.exit.Size = new System.Drawing.Size(143, 43);
            this.exit.TabIndex = 3;
            this.exit.Text = "Выйти";
            this.exit.UseTransparentBackground = true;
            this.exit.CheckedChanged += new System.EventHandler(this.exit_CheckedChanged);
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.BorderRadius = 22;
            this.admin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.admin.CheckedState.FillColor = System.Drawing.Color.White;
            this.admin.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.admin.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("admin.CheckedState.Image")));
            this.admin.CheckedState.Parent = this.admin;
            this.admin.CustomImages.Parent = this.admin;
            this.admin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.admin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admin.ForeColor = System.Drawing.Color.White;
            this.admin.HoverState.Parent = this.admin;
            this.admin.Image = ((System.Drawing.Image)(resources.GetObject("admin.Image")));
            this.admin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.admin.ImageOffset = new System.Drawing.Point(10, 0);
            this.admin.Location = new System.Drawing.Point(22, 426);
            this.admin.Name = "admin";
            this.admin.ShadowDecoration.Parent = this.admin;
            this.admin.Size = new System.Drawing.Size(143, 43);
            this.admin.TabIndex = 3;
            this.admin.Text = "  Админ";
            this.admin.UseTransparentBackground = true;
            this.admin.CheckedChanged += new System.EventHandler(this.admin_CheckedChanged);
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BorderRadius = 22;
            this.delete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.delete.CheckedState.FillColor = System.Drawing.Color.White;
            this.delete.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.delete.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("delete.CheckedState.Image")));
            this.delete.CheckedState.Parent = this.delete;
            this.delete.CustomImages.Parent = this.delete;
            this.delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.HoverState.Parent = this.delete;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.delete.ImageOffset = new System.Drawing.Point(10, 0);
            this.delete.Location = new System.Drawing.Point(22, 364);
            this.delete.Name = "delete";
            this.delete.ShadowDecoration.Parent = this.delete;
            this.delete.Size = new System.Drawing.Size(143, 43);
            this.delete.TabIndex = 3;
            this.delete.Text = "    Удалить";
            this.delete.UseTransparentBackground = true;
            this.delete.CheckedChanged += new System.EventHandler(this.delete_CheckedChanged);
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.BorderRadius = 22;
            this.edit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.edit.CheckedState.FillColor = System.Drawing.Color.White;
            this.edit.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.edit.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("edit.CheckedState.Image")));
            this.edit.CheckedState.Parent = this.edit;
            this.edit.CustomImages.Parent = this.edit;
            this.edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.HoverState.Parent = this.edit;
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.edit.ImageOffset = new System.Drawing.Point(10, 0);
            this.edit.Location = new System.Drawing.Point(22, 302);
            this.edit.Name = "edit";
            this.edit.ShadowDecoration.Parent = this.edit;
            this.edit.Size = new System.Drawing.Size(143, 43);
            this.edit.TabIndex = 3;
            this.edit.Text = "       Изменить";
            this.edit.UseTransparentBackground = true;
            this.edit.CheckedChanged += new System.EventHandler(this.edit_CheckedChanged);
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BorderRadius = 22;
            this.add.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.add.CheckedState.FillColor = System.Drawing.Color.White;
            this.add.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.add.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("add.CheckedState.Image")));
            this.add.CheckedState.Parent = this.add;
            this.add.CustomImages.Parent = this.add;
            this.add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.HoverState.Parent = this.add;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.add.ImageOffset = new System.Drawing.Point(10, 0);
            this.add.Location = new System.Drawing.Point(22, 240);
            this.add.Name = "add";
            this.add.ShadowDecoration.Parent = this.add;
            this.add.Size = new System.Drawing.Size(143, 43);
            this.add.TabIndex = 3;
            this.add.Text = "        Добавить";
            this.add.UseTransparentBackground = true;
            this.add.CheckedChanged += new System.EventHandler(this.add_CheckedChanged);
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.Transparent;
            this.list.BorderRadius = 22;
            this.list.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.list.CheckedState.FillColor = System.Drawing.Color.White;
            this.list.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.list.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("list.CheckedState.Image")));
            this.list.CheckedState.Parent = this.list;
            this.list.CustomImages.Parent = this.list;
            this.list.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.list.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list.ForeColor = System.Drawing.Color.White;
            this.list.HoverState.Parent = this.list;
            this.list.Image = ((System.Drawing.Image)(resources.GetObject("list.Image")));
            this.list.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.list.ImageOffset = new System.Drawing.Point(10, 0);
            this.list.Location = new System.Drawing.Point(22, 178);
            this.list.Name = "list";
            this.list.ShadowDecoration.Parent = this.list;
            this.list.Size = new System.Drawing.Size(143, 43);
            this.list.TabIndex = 3;
            this.list.Text = "    Список";
            this.list.UseTransparentBackground = true;
            this.list.CheckedChanged += new System.EventHandler(this.list_CheckedChanged);
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // imgSlide
            // 
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.Location = new System.Drawing.Point(143, 86);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(39, 100);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 1;
            this.imgSlide.TabStop = false;
            this.imgSlide.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Анкета";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlMain2
            // 
            this.pnlMain2.Controls.Add(this.pnlMain);
            this.pnlMain2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain2.Location = new System.Drawing.Point(180, 0);
            this.pnlMain2.Name = "pnlMain2";
            this.pnlMain2.Padding = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.pnlMain2.Size = new System.Drawing.Size(892, 608);
            this.pnlMain2.TabIndex = 1;
            this.pnlMain2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Location = new System.Drawing.Point(-1, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(879, 582);
            this.pnlMain.TabIndex = 4;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint_1);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 26;
            this.guna2Elipse2.TargetControl = this.pnlMain;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.guna2HtmlLabel1);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Location = new System.Drawing.Point(-1, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 582);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(341, 236);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(384, 265);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 63;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(67, 146);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(384, 265);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 64;
            this.pictureBox7.TabStop = false;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 26;
            this.guna2Elipse3.TargetControl = home;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(2)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(274, 47);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(308, 21);
            this.guna2HtmlLabel1.TabIndex = 66;
            this.guna2HtmlLabel1.Text = "Социологические опросы населения";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(2)))), ((int)(((byte)(149)))));
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(29, 63);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(790, 28);
            this.guna2Separator1.TabIndex = 65;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1072, 608);
            this.Controls.Add(this.pnlMain2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMain2.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2Button edit;
        private Guna.UI2.WinForms.Guna2Button add;
        private Guna.UI2.WinForms.Guna2Button list;
        private System.Windows.Forms.Panel pnlMain2;
        private Guna.UI2.WinForms.Guna2Button exit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button admin;
        private System.Windows.Forms.Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}

