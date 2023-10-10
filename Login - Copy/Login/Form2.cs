using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var builder = new MySqlConnectionStringBuilder
                {
                    Server = "localhost",
                    UserID = "root",
                    Password = "",
                    Database = "databasevs",
                };
                using (var con = new MySqlConnection(builder.ConnectionString))
                {
                    con.Open();

                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = @"INSERT INTO tbluser (Name, Username, Password,TypeofUser,CreatedBy,DateCreated, IsActive, UpdatedBy, DateUpdated)
                                          VALUES(@name, @username, @password, @typeofUser,@createdby, @createdon, @isactive, @updatedby, @updatedon)";
                        cmd.Parameters.AddWithValue("@name", NameTextBox.Text);
                        cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                        cmd.Parameters.AddWithValue("@typeofUser", cmbTypeofUser.Text);
                        cmd.Parameters.AddWithValue("@createdby", UsernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@createdon", DateTime.Now);
                        cmd.Parameters.AddWithValue("@isactive", 1);
                        cmd.Parameters.AddWithValue("@updatedby", "");
                        cmd.Parameters.AddWithValue("@updatedon", DateTime.Parse("1900-01-01"));

                        var result = cmd.ExecuteNonQuery();

                        if (result != -1)
                        {
                            MessageBox.Show("Successfully saved to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to save in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };
                };
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error in the system, please contact your system administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
