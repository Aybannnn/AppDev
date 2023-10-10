using MySqlConnector;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 manageUser = new Form2();
            manageUser.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "",
                Database = "databasevs"
            };

            var connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            MessageBox.Show("Database Connected Successfully");
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set these values
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "",
                Database = "databasevs",
            };

            try
            {
                // Open a connection
                using (var con = new MySqlConnection(builder.ConnectionString))
                {
                    con.Open();

                    // Create a database command and set the SQL statement with parameters
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM tbluser WHERE Username = @username AND Password = @password";
                        cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);

                        // Execute the command and get the result
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Login failed. Please check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
