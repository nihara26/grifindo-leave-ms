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
    public partial class LeaveReports : Form
    {
        public LeaveReports()
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

        private void LeaveReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoLeaveMSDataSet5.LeaveHistory' table. You can move, or remove it, as needed.
            this.leaveHistoryTableAdapter.Fill(this.grifindoLeaveMSDataSet5.LeaveHistory);

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                string EmployeeID = txtsearchEmpID.Text.Trim();
                DateTime StartDate = TimePickerStartLR.Value;
                DateTime EndDate = TimePickerEndDateLR.Value;

                // If no Employee ID and no date range is provided, show a validation message
                if (string.IsNullOrWhiteSpace(EmployeeID) && !TimePickerStartLR.Checked && !TimePickerEndDateLR.Checked)
                {
                    MessageBox.Show("Please provide either an Employee ID or a valid date range.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if no EmployeeID or date range is provided
                }

                // Ensure the end date is not earlier than the start date if both dates are checked
                if (TimePickerStartLR.Checked && TimePickerEndDateLR.Checked && EndDate < StartDate)
                {
                    MessageBox.Show("End date must be after the start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                con.Open();

                string query;

                if (!string.IsNullOrWhiteSpace(EmployeeID))
                {
                    // Query for a specific employee without checking the date range
                    query = @"SELECT EmployeeID, LeaveCategory, LeaveDate, ActionDate, Status 
                      FROM LeaveHistory 
                      WHERE EmployeeID = @EmployeeID";

                    // If both DateTimePickers are checked, add the date range
                    if (TimePickerStartLR.Checked && TimePickerEndDateLR.Checked)
                    {
                        query += " AND LeaveDate BETWEEN @StartDate AND @EndDate";
                    }
                }
                else
                {
                    // Query for all employees within the date range if no Employee ID is provided
                    query = @"SELECT EmployeeID, LeaveCategory, LeaveDate, ActionDate, Status 
                      FROM LeaveHistory 
                      WHERE LeaveDate BETWEEN @StartDate AND @EndDate";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add date range parameters if they are checked
                    if (TimePickerStartLR.Checked && TimePickerEndDateLR.Checked)
                    {
                        cmd.Parameters.AddWithValue("@StartDate", StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", EndDate);
                    }

                    // Add EmployeeID if provided
                    if (!string.IsNullOrWhiteSpace(EmployeeID))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Check if the result set is empty
                        if (dt.Rows.Count > 0)
                        {
                            dataGridDefineR.DataSource = dt;  // Bind the result to the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No leave records found for the given Employee ID or date range.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridDefineR.DataSource = null;  // Clear the grid
                        }
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching leave reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
