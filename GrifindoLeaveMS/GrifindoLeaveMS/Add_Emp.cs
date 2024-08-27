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
    }
}
