using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Admin3
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void Employees1_Click(object sender, EventArgs e)
        {
            Employee employeeForm = new Employee();
            employeeForm.Show();
            this.Hide();
        }

        private void Booking1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void User1_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
            this.Hide();
        }

        private void Services1_Click(object sender, EventArgs e)
        {
            Services service = new Services();
            service.Show();
            this.Hide();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            // Load the Services table data when the form loads
            LoadServicesData();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Reload the Services table data when a cell is clicked
            LoadServicesData();
        }

        private void LoadServicesData()
        {
            try
            {
                // Replace with your actual database connection string
                string connectionString = "your_connection_string_here";

                // SQL query to fetch data from the Services table
                string query = "SELECT * FROM Services";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // Use SqlDataAdapter to fetch data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable servicesTable = new DataTable();
                    adapter.Fill(servicesTable);

                    // Bind the data to the DataGridView
                    guna2DataGridView1.DataSource = servicesTable;
                }
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show("An error occurred while loading the Services data: " + ex.Message);
            }
        }
    }
}
