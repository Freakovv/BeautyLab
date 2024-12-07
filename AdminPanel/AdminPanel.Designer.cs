namespace AdminPanel
{
    partial class AdminPanel
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            borderForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            Tabs = new Guna.UI2.WinForms.Guna2TabControl();
            TabCreateAdmin = new TabPage();
            btnAddAdmin = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            labelAdd = new Label();
            TableAdmins = new Guna.UI2.WinForms.Guna2DataGridView();
            Администраторы = new DataGridViewTextBoxColumn();
            btnReject = new DataGridViewButtonColumn();
            tabUsers = new TabPage();
            msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            Tabs.SuspendLayout();
            TabCreateAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TableAdmins).BeginInit();
            SuspendLayout();
            // 
            // borderForm
            // 
            borderForm.AnimateWindow = true;
            borderForm.BorderRadius = 15;
            borderForm.ContainerControl = this;
            borderForm.DockIndicatorTransparencyValue = 0.6D;
            borderForm.TransparentWhileDrag = true;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.CustomizableEdges = customizableEdges1;
            btnExit.FillColor = Color.FromArgb(139, 152, 166);
            btnExit.IconColor = Color.White;
            btnExit.Location = new Point(1219, -2);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit.Size = new Size(45, 42);
            btnExit.TabIndex = 0;
            btnExit.Click += btnExit_Click;
            // 
            // Tabs
            // 
            Tabs.Controls.Add(TabCreateAdmin);
            Tabs.Controls.Add(tabUsers);
            Tabs.ItemSize = new Size(633, 40);
            Tabs.Location = new Point(0, 0);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(1273, 720);
            Tabs.TabButtonHoverState.BorderColor = Color.Empty;
            Tabs.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            Tabs.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            Tabs.TabButtonHoverState.ForeColor = Color.White;
            Tabs.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            Tabs.TabButtonIdleState.BorderColor = Color.Empty;
            Tabs.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            Tabs.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            Tabs.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            Tabs.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            Tabs.TabButtonSelectedState.BorderColor = Color.Empty;
            Tabs.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            Tabs.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            Tabs.TabButtonSelectedState.ForeColor = Color.White;
            Tabs.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            Tabs.TabButtonSize = new Size(633, 40);
            Tabs.TabIndex = 1;
            Tabs.TabMenuBackColor = Color.FromArgb(139, 152, 166);
            Tabs.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // TabCreateAdmin
            // 
            TabCreateAdmin.Controls.Add(btnAddAdmin);
            TabCreateAdmin.Controls.Add(label2);
            TabCreateAdmin.Controls.Add(txtPass);
            TabCreateAdmin.Controls.Add(label1);
            TabCreateAdmin.Controls.Add(txtLogin);
            TabCreateAdmin.Controls.Add(labelAdd);
            TabCreateAdmin.Controls.Add(TableAdmins);
            TabCreateAdmin.Location = new Point(4, 44);
            TabCreateAdmin.Name = "TabCreateAdmin";
            TabCreateAdmin.Padding = new Padding(3);
            TabCreateAdmin.Size = new Size(1265, 672);
            TabCreateAdmin.TabIndex = 0;
            TabCreateAdmin.Text = "Администраторы";
            TabCreateAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.CustomizableEdges = customizableEdges3;
            btnAddAdmin.DisabledState.BorderColor = Color.DarkGray;
            btnAddAdmin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddAdmin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddAdmin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddAdmin.FillColor = SystemColors.ActiveCaption;
            btnAddAdmin.Font = new Font("Segoe UI", 9F);
            btnAddAdmin.ForeColor = Color.White;
            btnAddAdmin.Location = new Point(118, 425);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddAdmin.Size = new Size(146, 38);
            btnAddAdmin.TabIndex = 6;
            btnAddAdmin.Text = "Добавить";
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 328);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 5;
            label2.Text = "Пароль:";
            // 
            // txtPass
            // 
            txtPass.CustomizableEdges = customizableEdges5;
            txtPass.DefaultText = "";
            txtPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Font = new Font("Segoe UI", 9F);
            txtPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Location = new Point(57, 351);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '●';
            txtPass.PlaceholderText = "";
            txtPass.SelectedText = "";
            txtPass.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPass.Size = new Size(268, 36);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 240);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Логин:";
            // 
            // txtLogin
            // 
            txtLogin.CustomizableEdges = customizableEdges7;
            txtLogin.DefaultText = "";
            txtLogin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLogin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLogin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLogin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLogin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLogin.Font = new Font("Segoe UI", 9F);
            txtLogin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLogin.Location = new Point(57, 263);
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PlaceholderText = "";
            txtLogin.SelectedText = "";
            txtLogin.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtLogin.Size = new Size(268, 36);
            txtLogin.TabIndex = 2;
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAdd.Location = new Point(57, 174);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(268, 25);
            labelAdd.TabIndex = 1;
            labelAdd.Text = "Добавление администратора";
            // 
            // TableAdmins
            // 
            TableAdmins.AllowUserToAddRows = false;
            TableAdmins.AllowUserToDeleteRows = false;
            TableAdmins.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(189, 223, 251);
            TableAdmins.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TableAdmins.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 242);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TableAdmins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TableAdmins.ColumnHeadersHeight = 25;
            TableAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            TableAdmins.Columns.AddRange(new DataGridViewColumn[] { Администраторы, btnReject });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            TableAdmins.DefaultCellStyle = dataGridViewCellStyle3;
            TableAdmins.EditMode = DataGridViewEditMode.EditOnEnter;
            TableAdmins.GridColor = Color.FromArgb(187, 222, 251);
            TableAdmins.Location = new Point(399, 6);
            TableAdmins.Name = "TableAdmins";
            TableAdmins.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            TableAdmins.RowHeadersVisible = false;
            TableAdmins.ScrollBars = ScrollBars.Vertical;
            TableAdmins.Size = new Size(850, 658);
            TableAdmins.StandardTab = true;
            TableAdmins.TabIndex = 0;
            TableAdmins.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            TableAdmins.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(189, 223, 251);
            TableAdmins.ThemeStyle.AlternatingRowsStyle.Font = null;
            TableAdmins.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            TableAdmins.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            TableAdmins.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            TableAdmins.ThemeStyle.BackColor = Color.White;
            TableAdmins.ThemeStyle.GridColor = Color.FromArgb(187, 222, 251);
            TableAdmins.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(33, 150, 242);
            TableAdmins.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            TableAdmins.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            TableAdmins.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            TableAdmins.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            TableAdmins.ThemeStyle.HeaderStyle.Height = 25;
            TableAdmins.ThemeStyle.ReadOnly = false;
            TableAdmins.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(211, 233, 252);
            TableAdmins.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TableAdmins.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TableAdmins.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            TableAdmins.ThemeStyle.RowsStyle.Height = 25;
            TableAdmins.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(107, 185, 246);
            TableAdmins.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            TableAdmins.CellContentClick += TableAdmins_CellContentClick;
            // 
            // Администраторы
            // 
            Администраторы.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Администраторы.HeaderText = "Администраторы";
            Администраторы.Name = "Администраторы";
            Администраторы.ReadOnly = true;
            Администраторы.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnReject
            // 
            btnReject.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnReject.HeaderText = "Управление";
            btnReject.Name = "btnReject";
            btnReject.Text = "Удалить";
            btnReject.ToolTipText = "Удалить";
            btnReject.UseColumnTextForButtonValue = true;
            btnReject.Width = 200;
            // 
            // tabUsers
            // 
            tabUsers.Location = new Point(4, 44);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(3);
            tabUsers.Size = new Size(1265, 672);
            tabUsers.TabIndex = 1;
            tabUsers.Text = "Пользователи";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // msg
            // 
            msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            msg.Caption = null;
            msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            msg.Parent = this;
            msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            msg.Text = null;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 720);
            Controls.Add(btnExit);
            Controls.Add(Tabs);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            Load += AdminPanel_Load;
            Tabs.ResumeLayout(false);
            TabCreateAdmin.ResumeLayout(false);
            TabCreateAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TableAdmins).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderForm;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2TabControl Tabs;
        private TabPage TabCreateAdmin;
        private TabPage tabUsers;
        private Guna.UI2.WinForms.Guna2DataGridView TableAdmins;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtLogin;
        private Label labelAdd;
        private Guna.UI2.WinForms.Guna2Button btnAddAdmin;
        private Guna.UI2.WinForms.Guna2MessageDialog msg;
        private DataGridViewTextBoxColumn Администраторы;
        private DataGridViewButtonColumn btnReject;
    }
}