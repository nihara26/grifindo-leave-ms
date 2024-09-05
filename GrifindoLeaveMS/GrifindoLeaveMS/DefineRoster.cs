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
    public partial class DefineRoster : Form
    {
        public DefineRoster()
        {
            InitializeComponent();

        }

        static string connectionstring = "Data Source=ASUS_NEBULA\\SQLEXPRESS;Initial Catalog=GrifindoLeaveMS;Integrated Security=True;Encrypt=False";
        SqlConnection con = new SqlConnection(connectionstring);

        private void btnBack_Click(object sender, EventArgs e)
        {
            A_Dashboard AD = new A_Dashboard();
            this.Hide();
            AD.Show();
        }

        private void DefineRoster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoLeaveMSDataSet3.ShiftRoster' table. You can move, or remove it, as needed.
            this.shiftRosterTableAdapter.Fill(this.grifindoLeaveMSDataSet3.ShiftRoster);

        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the input values from the form
                string EmployeeID = txtEmpID.Text.Trim();
                DateTime ShiftDate = datePickerDOB.Value;
                string StartTime = mtbStartTimeDR.Text.Trim();
                string EndTime = mtbEndTimeDR.Text.Trim();

                // Validate input fields
                if (string.IsNullOrWhiteSpace(EmployeeID))
                {
                    MessageBox.Show("Please enter an Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(StartTime) || string.IsNullOrWhiteSpace(EndTime))
                {
                    MessageBox.Show("Please enter both Start Time and End Time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                con.Open();

                // SQL query to check if a shift record already exists for the employee on the given date
                string check_query = "SELECT COUNT(*) FROM ShiftRoster WHERE EmployeeID = @EmployeeID AND ShiftDate = @ShiftDate;";
                using (SqlCommand checkCmd = new SqlCommand(check_query, con))
                {
                    checkCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    checkCmd.Parameters.AddWithValue("@ShiftDate", ShiftDate);

                    int recordExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (recordExists > 0)
                    {
                        // If record already exists, show a message
                        MessageBox.Show("A shift for this employee on the specified date already exists. Please use the 'Update Shift' button to modify it.", "Shift Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // SQL query to insert a new shift record
                        string insert_query = @"INSERT INTO ShiftRoster (EmployeeID, ShiftDate, StartTime, EndTime)
                                        VALUES (@EmployeeID, @ShiftDate, @StartTime, @EndTime);";
                        using (SqlCommand insertCmd = new SqlCommand(insert_query, con))
                        {
                            insertCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                            insertCmd.Parameters.AddWithValue("@ShiftDate", ShiftDate);
                            insertCmd.Parameters.AddWithValue("@StartTime", TimeSpan.Parse(StartTime));
                            insertCmd.Parameters.AddWithValue("@EndTime", TimeSpan.Parse(EndTime));

                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show("Shift added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the shift: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateShift_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the input values from the form
                string EmployeeID = txtEmpID.Text.Trim();
                DateTime ShiftDate = datePickerDOB.Value;
                string StartTime = mtbStartTimeDR.Text.Trim();
                string EndTime = mtbEndTimeDR.Text.Trim();

                // Validate input fields
                if (string.IsNullOrWhiteSpace(EmployeeID))
                {
                    MessageBox.Show("Please enter an Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(StartTime) || string.IsNullOrWhiteSpace(EndTime))
                {
                    MessageBox.Show("Please enter both Start Time and End Time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                con.Open();

                // SQL query to check if a shift record exists for the employee on the given date
                string check_query = "SELECT COUNT(*) FROM ShiftRoster WHERE EmployeeID = @EmployeeID AND ShiftDate = @ShiftDate;";
                using (SqlCommand checkCmd = new SqlCommand(check_query, con))
                {
                    checkCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    checkCmd.Parameters.AddWithValue("@ShiftDate", ShiftDate);

                    int recordExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (recordExists > 0)
                    {
                        // SQL query to update the shift record
                        string update_query = @"UPDATE ShiftRoster 
                                        SET StartTime = @StartTime, 
                                            EndTime = @EndTime 
                                        WHERE EmployeeID = @EmployeeID AND ShiftDate = @ShiftDate;";
                        using (SqlCommand updateCmd = new SqlCommand(update_query, con))
                        {
                            updateCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                            updateCmd.Parameters.AddWithValue("@ShiftDate", ShiftDate);
                            updateCmd.Parameters.AddWithValue("@StartTime", TimeSpan.Parse(StartTime));
                            updateCmd.Parameters.AddWithValue("@EndTime", TimeSpan.Parse(EndTime));

                            updateCmd.ExecuteNonQuery();
                            MessageBox.Show("Shift updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Show a message if no shift record exists to update
                        MessageBox.Show("No shift record found for this employee on the specified date. Please use the 'Add Shift' button to add a new shift.", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the shift: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridDefineR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the clicked cell is within a valid row
                if (e.RowIndex >= 0 && dataGridDefineR.SelectedRows.Count > 0)
                {
                    // Fill the text boxes with data from the selected row
                    txtEmpID.Text = dataGridDefineR.SelectedRows[0].Cells["EmployeeID"].Value.ToString();
                    datePickerDOB.Value = Convert.ToDateTime(dataGridDefineR.SelectedRows[0].Cells["ShiftDate"].Value);
                    mtbStartTimeDR.Text = dataGridDefineR.SelectedRows[0].Cells["StartTime"].Value.ToString();
                    mtbEndTimeDR.Text = dataGridDefineR.SelectedRows[0].Cells["EndTime"].Value.ToString();
                }
                else
                {
                    // Inform the user to select the full row
                    MessageBox.Show("Please select the full row to auto-fill the fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Display any exception that might occur
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
