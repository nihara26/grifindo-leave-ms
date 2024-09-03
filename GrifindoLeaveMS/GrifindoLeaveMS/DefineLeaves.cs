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

namespace GrifindoLeaveMS
{
    public partial class DefineLeaves : Form
    {
        public DefineLeaves()
        {
            InitializeComponent();
        }

        //connect to database
        static string connectionstring = "Data Source=ASUS_NEBULA\\SQLEXPRESS;Initial Catalog=GrifindoLeaveMS;Integrated Security=True;Encrypt=False";
        SqlConnection con = new SqlConnection(connectionstring);

        private void btnBack_Click(object sender, EventArgs e)
        {
            A_Dashboard AD = new A_Dashboard();
            this.Hide();
            AD.Show();
        }

        private void btnDefineL_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the input values from the form
                string EmployeeID = txtEmpID.Text.Trim();
                string yearText = txtyear.Text.Trim();
                string monthText = txtmonth.Text.Trim();

                //Check if any of the required fields are empty
                if (string.IsNullOrWhiteSpace(EmployeeID))
                {
                    MessageBox.Show("Please enter an Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if EmployeeID is not filled
                }

                if (string.IsNullOrWhiteSpace(yearText) || !int.TryParse(yearText, out int Year))
                {
                    MessageBox.Show("Please enter a valid Year.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if Year is not filled or invalid
                }

                if (string.IsNullOrWhiteSpace(monthText) || !int.TryParse(monthText, out int Month) || Month <= 0 || Month > 12)
                {
                    MessageBox.Show("Please enter a valid Month (1-12).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if Month is not filled or invalid
                }

                int AnnualLeaves = (int)numericAnnaulL.Value;
                int CasualLeaves = (int)numericCasualL.Value;
                int ShortLeaves = (int)numericShortL.Value;

                con.Open();

                // Check if the leave record already exists
                string check_query = "SELECT COUNT(*) FROM DefineLeaves WHERE EmployeeID = @EmployeeID AND Year = @Year AND Month = @Month;";
                using (SqlCommand checkCmd = new SqlCommand(check_query, con))
                {
                    checkCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    checkCmd.Parameters.AddWithValue("@Year", Year);
                    checkCmd.Parameters.AddWithValue("@Month", Month);

                    int recordExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (recordExists > 0)
                    {
                        // If record exists, update it
                        string update_query = @"UPDATE DefineLeaves 
                                        SET AnnualLeaves = @AnnualLeaves, 
                                            CasualLeaves = @CasualLeaves, 
                                            ShortLeaves = @ShortLeaves 
                                        WHERE EmployeeID = @EmployeeID AND Year = @Year AND Month = @Month;";
                        using (SqlCommand updateCmd = new SqlCommand(update_query, con))
                        {
                            updateCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                            updateCmd.Parameters.AddWithValue("@Year", Year);
                            updateCmd.Parameters.AddWithValue("@Month", Month);
                            updateCmd.Parameters.AddWithValue("@AnnualLeaves", AnnualLeaves);
                            updateCmd.Parameters.AddWithValue("@CasualLeaves", CasualLeaves);
                            updateCmd.Parameters.AddWithValue("@ShortLeaves", ShortLeaves);

                            updateCmd.ExecuteNonQuery();
                            MessageBox.Show("Leave records updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // If no record exists, insert a new one
                        string insert_query = @"INSERT INTO DefineLeaves (EmployeeID, Year, Month, AnnualLeaves, CasualLeaves, ShortLeaves) 
                                        VALUES (@EmployeeID, @Year, @Month, @AnnualLeaves, @CasualLeaves, @ShortLeaves);";
                        using (SqlCommand insertCmd = new SqlCommand(insert_query, con))
                        {
                            insertCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                            insertCmd.Parameters.AddWithValue("@Year", Year);
                            insertCmd.Parameters.AddWithValue("@Month", Month);
                            insertCmd.Parameters.AddWithValue("@AnnualLeaves", AnnualLeaves);
                            insertCmd.Parameters.AddWithValue("@CasualLeaves", CasualLeaves);
                            insertCmd.Parameters.AddWithValue("@ShortLeaves", ShortLeaves);

                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show("Leave records defined successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while defining leave records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the EmployeeID from the textbox
                string EmployeeID = txtEmpID.Text.Trim();

                // Check if EmployeeID is provided
                if (string.IsNullOrWhiteSpace(EmployeeID))
                {
                    MessageBox.Show("Please enter an Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if no EmployeeID is provided
                }

                con.Open();

                // SQL query to fetch the employee's leave details
                string query = @"SELECT Year, Month, AnnualLeaves, CasualLeaves, ShortLeaves 
                         FROM DefineLeaves 
                         WHERE EmployeeID = @EmployeeID;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Read the data and populate the fields
                            while (reader.Read())
                            {
                                txtyear.Text = reader["Year"].ToString();
                                txtmonth.Text = reader["Month"].ToString();
                                numericAnnaulL.Value = Convert.ToInt32(reader["AnnualLeaves"]);
                                numericCasualL.Value = Convert.ToInt32(reader["CasualLeaves"]);
                                numericShortL.Value = Convert.ToInt32(reader["ShortLeaves"]);
                            }
                        }
                        else
                        {
                            // Show a message if no record is found
                            MessageBox.Show("No leave records found for the given Employee ID.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for leave records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
