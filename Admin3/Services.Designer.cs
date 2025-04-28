namespace Admin3
{
    partial class Services
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Services1 = new System.Windows.Forms.Button();
            this.Booking1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.trimTimeDataSet1 = new Admin3.TrimTimeDataSet1();
            this.sERVICESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICESTableAdapter = new Admin3.TrimTimeDataSet1TableAdapters.SERVICESTableAdapter();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimTimeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Services1
            // 
            this.Services1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services1.Location = new System.Drawing.Point(0, 235);
            this.Services1.Name = "Services1";
            this.Services1.Size = new System.Drawing.Size(254, 55);
            this.Services1.TabIndex = 3;
            this.Services1.Text = "Manage Services";
            this.Services1.UseVisualStyleBackColor = true;
            this.Services1.Click += new System.EventHandler(this.Services1_Click);
            // 
            // Booking1
            // 
            this.Booking1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking1.Location = new System.Drawing.Point(0, 157);
            this.Booking1.Name = "Booking1";
            this.Booking1.Size = new System.Drawing.Size(254, 55);
            this.Booking1.TabIndex = 1;
            this.Booking1.Text = "Manage Booking";
            this.Booking1.UseVisualStyleBackColor = true;
            this.Booking1.Click += new System.EventHandler(this.Booking1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(24, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 75);
            this.label2.TabIndex = 0;
            this.label2.Text = "Admin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Services1);
            this.panel1.Controls.Add(this.Booking1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 666);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lists of Services";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Name of Service";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(829, 181);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 16;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "Price";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(829, 223);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox2.TabIndex = 17;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(829, 265);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(91, 29);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Add";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(938, 265);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(91, 29);
            this.guna2Button2.TabIndex = 19;
            this.guna2Button2.Text = "Delete";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 15;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.servicePriceDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.sERVICESBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(330, 80);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(454, 397);
            this.guna2DataGridView1.TabIndex = 21;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 15;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // trimTimeDataSet1
            // 
            this.trimTimeDataSet1.DataSetName = "TrimTimeDataSet1";
            this.trimTimeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sERVICESBindingSource
            // 
            this.sERVICESBindingSource.DataMember = "SERVICES";
            this.sERVICESBindingSource.DataSource = this.trimTimeDataSet1;
            // 
            // sERVICESTableAdapter
            // 
            this.sERVICESTableAdapter.ClearBeforeFill = true;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            // 
            // servicePriceDataGridViewTextBoxColumn
            // 
            this.servicePriceDataGridViewTextBoxColumn.DataPropertyName = "ServicePrice";
            this.servicePriceDataGridViewTextBoxColumn.HeaderText = "ServicePrice";
            this.servicePriceDataGridViewTextBoxColumn.Name = "servicePriceDataGridViewTextBoxColumn";
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "Name of Service";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(829, 70);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox3.TabIndex = 22;
            this.guna2TextBox3.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(829, 115);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(200, 24);
            this.guna2Button3.TabIndex = 23;
            this.guna2Button3.Text = "Search";
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "Name of Service";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Location = new System.Drawing.Point(829, 348);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox4.TabIndex = 24;
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(829, 390);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(91, 29);
            this.guna2Button4.TabIndex = 25;
            this.guna2Button4.Text = "Add";
            // 
            // guna2Button5
            // 
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(938, 390);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(91, 29);
            this.guna2Button5.TabIndex = 26;
            this.guna2Button5.Text = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(847, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Manage Discounts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView2.AutoGenerateColumns = false;
            this.guna2DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView2.ColumnHeadersHeight = 15;
            this.guna2DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.guna2DataGridView2.DataSource = this.sERVICESBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(822, 425);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.Size = new System.Drawing.Size(207, 122);
            this.guna2DataGridView2.TabIndex = 28;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 15;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ServiceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ServiceID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ServiceName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ServiceName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ServicePrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "ServicePrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(847, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Manage Discounts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(858, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Search Service";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 666);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2DataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2TextBox4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Name = "Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimTimeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Services1;
        private System.Windows.Forms.Button Booking1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private TrimTimeDataSet1 trimTimeDataSet1;
        private System.Windows.Forms.BindingSource sERVICESBindingSource;
        private TrimTimeDataSet1TableAdapters.SERVICESTableAdapter sERVICESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicePriceDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}