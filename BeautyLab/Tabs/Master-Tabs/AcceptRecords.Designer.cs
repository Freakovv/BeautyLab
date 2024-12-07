namespace BeautyLab.Tabs.Master_Tabs
{
    partial class AcceptRecords
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Table = new Guna.UI2.WinForms.Guna2DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            PhoneColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            TimeColumn = new DataGridViewTextBoxColumn();
            MasterColumn = new DataGridViewTextBoxColumn();
            ServiceColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Table).BeginInit();
            SuspendLayout();
            // 
            // Table
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(227, 89, 164);
            dataGridViewCellStyle2.Font = new Font("Jura", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Table.ColumnHeadersHeight = 27;
            Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Table.Columns.AddRange(new DataGridViewColumn[] { NameColumn, PhoneColumn, DateColumn, TimeColumn, MasterColumn, ServiceColumn, PriceColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Table.DefaultCellStyle = dataGridViewCellStyle3;
            Table.GridColor = Color.FromArgb(227, 89, 164);
            Table.Location = new Point(23, 14);
            Table.Name = "Table";
            Table.ReadOnly = true;
            Table.RowHeadersVisible = false;
            Table.Size = new Size(1233, 652);
            Table.TabIndex = 1;
            Table.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            Table.ThemeStyle.AlternatingRowsStyle.Font = null;
            Table.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            Table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            Table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            Table.ThemeStyle.BackColor = Color.White;
            Table.ThemeStyle.GridColor = Color.FromArgb(227, 89, 164);
            Table.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(227, 89, 164);
            Table.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            Table.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            Table.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            Table.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Table.ThemeStyle.HeaderStyle.Height = 27;
            Table.ThemeStyle.ReadOnly = true;
            Table.ThemeStyle.RowsStyle.BackColor = Color.White;
            Table.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Table.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            Table.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            Table.ThemeStyle.RowsStyle.Height = 25;
            Table.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            Table.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // NameColumn
            // 
            NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NameColumn.FillWeight = 200F;
            NameColumn.HeaderText = "ФИО клиента";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 147;
            // 
            // PhoneColumn
            // 
            PhoneColumn.FillWeight = 21.9120178F;
            PhoneColumn.HeaderText = "Номер тел.";
            PhoneColumn.Name = "PhoneColumn";
            PhoneColumn.ReadOnly = true;
            // 
            // DateColumn
            // 
            DateColumn.FillWeight = 21.9120178F;
            DateColumn.HeaderText = "Дата";
            DateColumn.Name = "DateColumn";
            DateColumn.ReadOnly = true;
            // 
            // TimeColumn
            // 
            TimeColumn.FillWeight = 21.9120178F;
            TimeColumn.HeaderText = "Время";
            TimeColumn.Name = "TimeColumn";
            TimeColumn.ReadOnly = true;
            // 
            // MasterColumn
            // 
            MasterColumn.FillWeight = 21.9120178F;
            MasterColumn.HeaderText = "Мастер";
            MasterColumn.Name = "MasterColumn";
            MasterColumn.ReadOnly = true;
            // 
            // ServiceColumn
            // 
            ServiceColumn.FillWeight = 21.9120178F;
            ServiceColumn.HeaderText = "Услуга";
            ServiceColumn.Name = "ServiceColumn";
            ServiceColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            PriceColumn.FillWeight = 21.9120178F;
            PriceColumn.HeaderText = "Стоимость";
            PriceColumn.Name = "PriceColumn";
            PriceColumn.ReadOnly = true;
            // 
            // RecordAcceptControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(Table);
            Name = "RecordAcceptControl";
            Size = new Size(1280, 689);
            Load += RecordAcceptControl_Load;
            ((System.ComponentModel.ISupportInitialize)Table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Table;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PhoneColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn TimeColumn;
        private DataGridViewTextBoxColumn MasterColumn;
        private DataGridViewTextBoxColumn ServiceColumn;
        private DataGridViewTextBoxColumn PriceColumn;
    }
}
