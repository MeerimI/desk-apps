namespace statics.UserControls
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvViewAdmin = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SearchAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // dgvViewAdmin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(24)))), ((int)(((byte)(154)))));
            this.dgvViewAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvViewAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewAdmin.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(24)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewAdmin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvViewAdmin.DoubleBuffered = true;
            this.dgvViewAdmin.EnableHeadersVisualStyles = false;
            this.dgvViewAdmin.GridColor = System.Drawing.Color.White;
            this.dgvViewAdmin.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.dgvViewAdmin.HeaderForeColor = System.Drawing.Color.White;
            this.dgvViewAdmin.Location = new System.Drawing.Point(43, 159);
            this.dgvViewAdmin.Name = "dgvViewAdmin";
            this.dgvViewAdmin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvViewAdmin.RowHeadersVisible = false;
            this.dgvViewAdmin.RowTemplate.DividerHeight = 3;
            this.dgvViewAdmin.RowTemplate.Height = 30;
            this.dgvViewAdmin.RowTemplate.ReadOnly = true;
            this.dgvViewAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewAdmin.Size = new System.Drawing.Size(790, 299);
            this.dgvViewAdmin.TabIndex = 3;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoRoundedCorners = true;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BorderRadius = 19;
            this.deleteBtn.CheckedState.Parent = this.deleteBtn;
            this.deleteBtn.CustomImages.Parent = this.deleteBtn;
            this.deleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.HoverState.Parent = this.deleteBtn;
            this.deleteBtn.Location = new System.Drawing.Point(722, 484);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ShadowDecoration.BorderRadius = 19;
            this.deleteBtn.ShadowDecoration.Color = System.Drawing.Color.BlanchedAlmond;
            this.deleteBtn.ShadowDecoration.Enabled = true;
            this.deleteBtn.ShadowDecoration.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(111, 41);
            this.deleteBtn.TabIndex = 56;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(2)))), ((int)(((byte)(149)))));
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(43, 53);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(790, 28);
            this.guna2Separator1.TabIndex = 57;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(2)))), ((int)(((byte)(149)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(400, 37);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(70, 21);
            this.guna2HtmlLabel1.TabIndex = 58;
            this.guna2HtmlLabel1.Text = "Админы";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchAdmin
            // 
            this.SearchAdmin.BorderRadius = 14;
            this.SearchAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchAdmin.DefaultText = "";
            this.SearchAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchAdmin.DisabledState.Parent = this.SearchAdmin;
            this.SearchAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.SearchAdmin.FocusedState.Parent = this.SearchAdmin;
            this.SearchAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.SearchAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.SearchAdmin.HoverState.Parent = this.SearchAdmin;
            this.SearchAdmin.IconLeft = ((System.Drawing.Image)(resources.GetObject("SearchAdmin.IconLeft")));
            this.SearchAdmin.Location = new System.Drawing.Point(43, 106);
            this.SearchAdmin.Name = "SearchAdmin";
            this.SearchAdmin.PasswordChar = '\0';
            this.SearchAdmin.PlaceholderText = "";
            this.SearchAdmin.SelectedText = "";
            this.SearchAdmin.ShadowDecoration.Parent = this.SearchAdmin;
            this.SearchAdmin.Size = new System.Drawing.Size(790, 29);
            this.SearchAdmin.TabIndex = 5;
            this.SearchAdmin.TextChanged += new System.EventHandler(this.SearchAdmin_TextChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 569);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.SearchAdmin);
            this.Controls.Add(this.dgvViewAdmin);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvViewAdmin;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox SearchAdmin;
    }
}