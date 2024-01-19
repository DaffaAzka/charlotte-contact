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
                Clear();
                MessageBox.Show("Success submit data");
            }
            else
            {
                MessageBox.Show("Failed submit data, please try again later...");
            }

            DataTable dt = databases.Select();
            databasesGridView.DataSource = dt;
        }

        private void databasesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clear()
        {
            idBox.Text = "";
            nameBox.Text = "";
            contactBox.Text = "";
            emailBox.Text = "";
            genderComboBox.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            data.Id = int.Parse(idBox.Text);
            data.FullName = nameBox.Text;
            data.Contact = contactBox.Text;
            data.Email = emailBox.Text;
            data.Gender = genderComboBox.Text;

            // Insert Database
            bool success = databases.Update(data);
            if (success)
            {
                Clear();
                MessageBox.Show("Success updating data");
            }
            else
            {
                MessageBox.Show("Failed updating data, please try again later...");
            }

            DataTable dt = databases.Select();
            databasesGridView.DataSource = dt;
        }

        private void databasesGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            idBox.Text = databasesGridView.Rows[rowIndex].Cells[0].Value.ToString();
            nameBox.Text = databasesGridView.Rows[rowIndex].Cells[1].Value.ToString();
            contactBox.Text = databasesGridView.Rows[rowIndex].Cells[2].Value.ToString();
            emailBox.Text = databasesGridView.Rows[rowIndex].Cells[3].Value.ToString();
            genderComboBox.Text = databasesGridView.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            data.Id = int.Parse(idBox.Text);

            // Insert Database
            bool success = databases.Delete(data);
            if (success)
            {
                Clear();
                MessageBox.Show("Success deleting data");
            }
            else
            {
                MessageBox.Show("Failed deleting data, please try again later...");
            }

            DataTable dt = databases.Select();
            databasesGridView.DataSource = dt;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
