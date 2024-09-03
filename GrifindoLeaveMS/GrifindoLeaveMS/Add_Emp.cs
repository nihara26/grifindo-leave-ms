using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GrifindoLeaveMS
{
    public partial class Add_Emp : Form
    {
        public Add_Emp()
        {
            InitializeComponent();

            //connect to database
            string connectionstring = "Data Source=ASUS_NEBULA\\SQLEXPRESS;Initial Catalog=GrifindoLeaveMS;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(connectionstring);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            A_Dashboard AD = new A_Dashboard();
            this.Hide();
            AD.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking data from the form
                string EmployeeID = txtEmpID.Text; // EmployeeID will be entered manually
                string Name = txtname.Text;
                string Password = txtpw.Text;
                string DOB = datePickerDOB.Value.ToString("yyyy-MM-dd"); // Format the date for SQL
                string Address = txtaddress.Text;
                string PhoneNo = txtphone.Text;
                string JobStartDate = datePickerJobDate.Value.ToString("yyyy-MM-dd"); // Format the date for SQL

                // Check if any of the required fields are empty
                if (string.IsNullOrWhiteSpace(EmployeeID) || string.IsNullOrWhiteSpace(Name) ||
                    string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(Address) ||
                    string.IsNullOrWhiteSpace(PhoneNo))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method without executing the SQL query
                }

                // Open the SQL connection
                using (SqlConnection con = new SqlConnection("Data Source=ASUS_NEBULA\\SQLEXPRESS;Initial Catalog=GrifindoLeaveMS;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();

                    // Check if the EmployeeID already exists in the database
                    string check_query = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @EmployeeID;";
                    using (SqlCommand checkCmd = new SqlCommand(check_query, con))
                    {
                        checkCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        int existingEmployeeCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (existingEmployeeCount > 0)
                        {
                            MessageBox.Show("Unable to proceed. The EmployeeID provided already exists in the database.", "Duplicate EmployeeID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Exit the method without executing the SQL query
                        }
                    }

                    // SQL Insert Query
                    string insert_query = "INSERT INTO Employee (EmployeeID, Name, Password, DOB, Address, PhoneNo, JobStartDate) " +
                                          "VALUES (@EmployeeID, @Name, @Password, @DOB, @Address, @PhoneNo, @JobStartDate);";

                    // SQL Command
                    using (SqlCommand cmd = new SqlCommand(insert_query, con))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@DOB", DOB);
                        cmd.Parameters.AddWithValue("@Address", Address);
                        cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                        cmd.Parameters.AddWithValue("@JobStartDate", JobStartDate);

                        // Execute the command
                        cmd.ExecuteNonQuery();

                        // MessageBox with success icon
                        MessageBox.Show("Employee details successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // MessageBox with error icon and detailed error message
                MessageBox.Show("An error occurred while processing the operation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Emp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoLeaveMSDataSet2.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.grifindoLeaveMSDataSet2.Employee);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the input values from the form
                string EmployeeID = txtEmpID.Text; // EmployeeID will be entered manually
                string Name = txtname.Text;
                string Password = txtpw.Text;
                string DOB = datePickerDOB.Value.ToString("yyyy-MM-dd"); // Format the date for SQL
                string Address = txtaddress.Text;
                string PhoneNo = txtphone.Text;
                string JobStartDate = datePickerJobDate.Value.ToString("yyyy-MM-dd"); // Format the date for SQL

                // Check if any of the required fields are empty
                if (string.IsNullOrWhiteSpace(EmployeeID) || string.IsNullOrWhiteSpace(Name) ||
                    string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(Address) ||
                    string.IsNullOrWhiteSpace(PhoneNo))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if validation fails
                }

                // Open the SQL connection
                using (SqlConnection con = new SqlConnection("Data Source=ASUS_NEBULA\\SQLEXPRESS;Initial Catalog=GrifindoLeaveMS;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();

                    // Check if the EmployeeID exists in the database
                    string check_query = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @EmployeeID;";
                    using (SqlCommand checkCmd = new SqlCommand(check_query, con))
                    {
                        checkCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        int employeeExists = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (employeeExists == 0)
                        {
                            MessageBox.Show("No records found with the specified EmployeeID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Exit the method if no employee exists
                        }
                    }

                    // SQL Update Query
                    string update_query = @"UPDATE Employee 
                                    SET Name = @Name, Password = @Password, DOB = @DOB, 
                                        Address = @Address, PhoneNo = @PhoneNo, JobStartDate = @JobStartDate
                                    WHERE EmployeeID = @EmployeeID";

                    // SQL Command to execute the update query
                    using (SqlCommand cmd = new SqlCommand(update_query, con))
                    {
                        // Add parameters to the query
                        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@DOB", DOB);
                        cmd.Parameters.AddWithValue("@Address", Address);
                        cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                        cmd.Parameters.AddWithValue("@JobStartDate", JobStartDate);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Show a success message if the update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were updated.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the update
                MessageBox.Show("An error occurred while updating the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAddEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the clicked cell is within a valid row
                if (e.RowIndex >= 0 && dataGridAddEmp.SelectedRows.Count > 0)
                {
                    // Assuming the order of columns is the same as in your table definition:
                    txtEmpID.Text = dataGridAddEmp.SelectedRows[0].Cells[0].Value.ToString(); //EmployeeID
                    txtname.Text = dataGridAddEmp.SelectedRows[0].Cells[1].Value.ToString();  //Name
                    txtpw.Text = dataGridAddEmp.SelectedRows[0].Cells[2].Value.ToString();    //Password

                    // Format DOB and Job Start Date properly
                    datePickerDOB.Value = Convert.ToDateTime(dataGridAddEmp.SelectedRows[0].Cells[3].Value);  //DOB
                    datePickerJobDate.Value = Convert.ToDateTime(dataGridAddEmp.SelectedRows[0].Cells[6].Value); //JobStartDate

                    txtaddress.Text = dataGridAddEmp.SelectedRows[0].Cells[4].Value.ToString(); //Address
                    txtphone.Text = dataGridAddEmp.SelectedRows[0].Cells[5].Value.ToString();   //PhoneNo
                }
                else
                {
                    MessageBox.Show("Please select the full row to auto fill the text.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the EmployeeID from the textbox
                string employeeID = txtEmpID.Text.Trim();

                // SQL query string
                string select_query;

                // Check if EmployeeID is provided
                if (string.IsNullOrWhiteSpace(employeeID))
                {
                    // If no EmployeeID is provided, select all records
                    select_query = "SELECT * FROM Employee";
                }
                else
                {
                    // If EmployeeID is provided, select the specific record
                    select_query = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID";
                }

                using (SqlConnection con = new SqlConnection("Data Source=ASUS_NEBULA\\SQLEXPRESS;Initial Catalog=GrifindoLeaveMS;Integrated Security=True;Encrypt=False"))
                {
                    SqlDataAdapter da = new SqlDataAdapter(select_query, con);

                    // If searching by EmployeeID, add parameter to avoid SQL injection
                    if (!string.IsNullOrWhiteSpace(employeeID))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                    }

                    // Create a DataSet to hold the results
                    DataSet ds = new DataSet();

                    con.Open();

                    // Fill the DataSet
                    da.Fill(ds, "Employee");

                    con.Close();

                    // Check if any records are found
                    if (ds.Tables["Employee"].Rows.Count > 0)
                    {
                        // Bind the DataSet to the DataGridView to display results
                        dataGridAddEmp.DataSource = ds.Tables["Employee"];
                    }
                    else
                    {
                        MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear the DataGridView
                        dataGridAddEmp.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the search
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all text boxes
            txtEmpID.Clear();
            txtname.Clear();
            txtpw.Clear();
            txtaddress.Clear();
            txtphone.Clear();

            // Reset the DateTimePickers to today's date or any default date
            datePickerDOB.Value = DateTime.Today;
            datePickerJobDate.Value = DateTime.Today;

            // Clear the DataGridView selection (optional, if applicable)
            dataGridAddEmp.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the EmployeeID for deletion
                string EmployeeID = txtEmpID.Text;

                // Check if the EmployeeID is empty
                if (string.IsNullOrWhiteSpace(EmployeeID))
                {
                    MessageBox.Show("Please enter an Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if EmployeeID is empty
                }

                // Check if the given EmployeeID exists in the database
                bool employeeExists = false;
                using (SqlConnection con = new SqlConnection("Data Source=ASUS_NEBULA\\SQLEXPRESS;Initial Catalog=GrifindoLeaveMS;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    string check_query = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @EmployeeID;";
                    using (SqlCommand checkCmd = new SqlCommand(check_query, con))
                    {
                        checkCmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        int existingEmployeeCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                        employeeExists = existingEmployeeCount > 0;
                    }
                    con.Close();
                }

                // If the employee does not exist, show a warning message
                if (!employeeExists)
                {
                    MessageBox.Show("The Employee ID does not exist in the database. Deletion cannot be performed.", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If user clicks Yes, proceed with deletion
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection("Data Source=ASUS_NEBULA\\SQLEXPRESS;Initial Catalog=GrifindoLeaveMS;Integrated Security=True;Encrypt=False"))
                    {
                        con.Open();

                        // SQL DELETE Query
                        string delete_query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID;";

                        // SQL Command
                        SqlCommand cmd = new SqlCommand(delete_query, con);
                        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                        // Execute the command
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Deletion completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, clear the form fields after deletion
                        btnClear_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Deletion canceled by user.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the deletion process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
