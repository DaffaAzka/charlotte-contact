using Econtact.Database;
using Econtact.Models;
using System.Data;

namespace Econtact
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }

        Data data = new Data();
        DB databases = new DB();

        private void Econtact_Load(object sender, EventArgs e)
        {
            DataTable dt = databases.Select();
            databasesGridView.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            data.FullName = nameBox.Text;
            data.Contact = contactBox.Text;
            data.Email = emailBox.Text;
            data.Gender = genderComboBox.Text;

            // Insert Database
            bool success = databases.Insert(data);
            if (success)
            {
                MessageBox.Show("Success submit data");
            }
            else
            {
                MessageBox.Show("Fail submit data, please try again later...");
            }

            DataTable dt = databases.Select();
            databasesGridView.DataSource = dt;
        }

        private void databasesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
