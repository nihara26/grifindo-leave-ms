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
    public partial class ManageLeaves : Form
    {
        public ManageLeaves()
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

        private void ManageLeaves_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoLeaveMSDataSet4.EApplyLeave' table. You can move, or remove it, as needed.
            this.eApplyLeaveTableAdapter.Fill(this.grifindoLeaveMSDataSet4.EApplyLeave);

        }

        private void dataGridDefineR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the clicked cell is within a valid row
                if (e.RowIndex >= 0 && dataGridDefineR.SelectedRows.Count > 0)
                {
                    // Use column index to get EmployeeID, assuming EmployeeID is in the first column (index 0)
                    txtEmpID.Text = dataGridDefineR.SelectedRows[0].Cells[0].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a full row to auto-fill EmployeeID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                string EmployeeID = txtEmpID.Text.Trim();

                if (string.IsNullOrWhiteSpace(EmployeeID))
                {
                    MessageBox.Show("Please select an Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if EmployeeID is not provided
                }

                con.Open();

                // Update query to approve the leave
                string update_query = @"UPDATE LeaveHistory 
                                SET Status = 'Approved', ActionDate = GETDATE() 
                                WHERE EmployeeID = @EmployeeID AND Status = 'Pending';";
                using (SqlCommand cmd = new SqlCommand(update_query, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Leave approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No pending leaves found for this employee.", "No Pending Leaves", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while approving the leave: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnreject_Click(object sender, EventArgs e)
        {
            try
            {
                string EmployeeID = txtEmpID.Text.Trim();

                if (string.IsNullOrWhiteSpace(EmployeeID))
                {
                    MessageBox.Show("Please select an Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if EmployeeID is not provided
                }

                con.Open();

                // Update query to reject the leave
                string update_query = @"UPDATE LeaveHistory 
                                SET Status = 'Rejected', ActionDate = GETDATE() 
                                WHERE EmployeeID = @EmployeeID AND Status = 'Pending';";
                using (SqlCommand cmd = new SqlCommand(update_query, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Leave rejected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No pending leaves found for this employee.", "No Pending Leaves", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while rejecting the leave: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // SQL query to fetch all leaves and their statuses
                string query = @"SELECT EmployeeID, LeaveCategory, LeaveDate, StartTime, EndTime 
                         FROM EApplyLeave
                         WHERE NOT EXISTS 
                         (SELECT 1 FROM LeaveHistory 
                          WHERE LeaveHistory.EmployeeID = EApplyLeave.EmployeeID AND LeaveHistory.LeaveDate = EApplyLeave.LeaveDate);";

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridDefineR.DataSource = dt;  // Bind DataTable to DataGridView
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading leave data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
