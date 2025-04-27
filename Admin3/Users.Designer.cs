namespace Admin3
{
    partial class Users
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Services1 = new System.Windows.Forms.Button();
            this.Employees1 = new System.Windows.Forms.Button();
            this.Booking1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.Services1);
            this.panel1.Controls.Add(this.Employees1);
            this.panel1.Controls.Add(this.Booking1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 666);
            this.panel1.TabIndex = 2;
            // 
            // Services1
            // 
            this.Services1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services1.Location = new System.Drawing.Point(0, 289);
            this.Services1.Name = "Services1";
            this.Services1.Size = new System.Drawing.Size(254, 55);
            this.Services1.TabIndex = 3;
            this.Services1.Text = "Manage Services";
            this.Services1.UseVisualStyleBackColor = true;
            this.Services1.Click += new System.EventHandler(this.Services1_Click);
            // 
            // Employees1
            // 
            this.Employees1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees1.Location = new System.Drawing.Point(0, 223);
            this.Employees1.Name = "Employees1";
            this.Employees1.Size = new System.Drawing.Size(254, 55);
            this.Employees1.TabIndex = 2;
            this.Employees1.Text = "Manage Employees";
            this.Employees1.UseVisualStyleBackColor = true;
            this.Employees1.Click += new System.EventHandler(this.Employees1_Click);
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
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 666);
            this.Controls.Add(this.panel1);
            this.Name = "Users";
            this.Text = "Users";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Services1;
        private System.Windows.Forms.Button Employees1;
        private System.Windows.Forms.Button Booking1;
        private System.Windows.Forms.Label label2;
    }
}