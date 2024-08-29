using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
namespace SignupFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void InsertData_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=LAPTOP-8CMGPOIT\\SQLEXPRESS;Initial Catalog=SignupWindowFormDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string insertQuery = "INSERT INTO Users (FirstName, LastName, Email, Password) VALUES (@FirstName, @LastName, @Email, @Password)";
            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@FirstName", firstName.Text);
            command.Parameters.AddWithValue("@LastName", lastName.Text);
            command.Parameters.AddWithValue("@Email", emailInput.Text);
            command.Parameters.AddWithValue("@Password", passwordInput.Text);
            int count = command.ExecuteNonQuery();
            connection.Close();
            if (count > 0)
            {
                MessageBox.Show("Data created successfully");
            }
            else
            {
                MessageBox.Show("Please try again");
            }

        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }

            string connectionString = "Data Source=LAPTOP-8CMGPOIT\\SQLEXPRESS;Initial Catalog=SignupWindowFormDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string selectQuery = "SELECT UserId, FirstName, LastName, Email, Password FROM Users";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    try
                    {
                        adapter.Fill(dataTable); // Fill the DataTable with data from the database
                        dataGridView1.DataSource = dataTable; // Bind the DataTable to the DataGridView
                        dataGridView1.Visible = true; // Show the DataGridView

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }



        }

        private void Home_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }

        }

        //update
        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-8CMGPOIT\\SQLEXPRESS;Initial Catalog=SignupWindowFormDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Password = @Password WHERE UserId = @UserId";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Adding parameters to the command
                    command.Parameters.AddWithValue("@FirstName", firstName.Text);
                    command.Parameters.AddWithValue("@LastName", lastName.Text); // Assuming you have a txtLastName TextBox
                    command.Parameters.AddWithValue("@Email", emailInput.Text);
                    command.Parameters.AddWithValue("@Password", passwordInput.Text);
                    command.Parameters.AddWithValue("@UserId", numericUpDown1.Value);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Check the UserId.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void DeleteData_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-8CMGPOIT\\SQLEXPRESS;Initial Catalog=SignupWindowFormDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM Users WHERE UserId = @UserId";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    // Adding parameter to the command
                    command.Parameters.AddWithValue("@UserId", numericUpDown1.Value); // Assuming you have a NumericUpDown for UserId

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted successfully");

                        }
                        else
                        {
                            MessageBox.Show("No records were deleted. Check the UserId.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            }
    }

}
