using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin3
{   

    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=TrimTime;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee employeeForm = new Employee();
            employeeForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 booking = new Form1();
            booking.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Services service = new Services();
            service.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trimTimeDataSet3.COMPLETEDBOOKING' table. You can move, or remove it, as needed.
            this.cOMPLETEDBOOKINGTableAdapter.Fill(this.trimTimeDataSet3.COMPLETEDBOOKING);
            // TODO: This line of code loads data into the 'trimTimeDataSet2.BOOKING' table. You can move, or remove it, as needed.
            this.bOOKINGTableAdapter.Fill(this.trimTimeDataSet2.BOOKING);

        }
        
           private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name = guna2TextBox1.Text; // Get the name from the textbox

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            try
            {
                // Find the row in guna2DataGridView1 that matches the entered name
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    if (row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString().Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        // Clone the row and add it to guna2DataGridView2
                        int rowIndex = guna2DataGridView2.Rows.Add();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            guna2DataGridView2.Rows[rowIndex].Cells[cell.ColumnIndex].Value = cell.Value;
                        }

                        // Remove the row from guna2DataGridView1
                        guna2DataGridView1.Rows.Remove(row);

                        MessageBox.Show("Booking moved to the second DataGridView successfully.");
                        return;
                    }
                }

                // If no matching row is found
                MessageBox.Show("Name not found in the first DataGridView.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
