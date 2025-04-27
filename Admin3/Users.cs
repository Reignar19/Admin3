using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin3
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Services1_Click(object sender, EventArgs e)
        {
            Services service = new Services();
            service.Show();
            this.Hide();
        }

        private void Booking1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Employees1_Click(object sender, EventArgs e)
        {
            Employee employeeForm = new Employee();
            employeeForm.Show();
            this.Hide();
        }

        private void User1_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
            this.Hide();
        }
    }
}
