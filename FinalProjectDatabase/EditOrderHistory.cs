using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// System.Data.OleDb is namespace in the .NET Framework that provides a set of classes for accessing data in a variety of data sources using the OLE DB data provider.
using System.Data.OleDb;

// Regex symbols or regular expression is a sequence of characters that define a search pattern.
// They can be used to search for specific words or phrases, extract data from text.
using System.Text.RegularExpressions;

namespace FinalProjectDatabase
{
    public partial class EditOrderHistory : Form
    {
        private OleDbConnection conn; // Declare the connection object at the class level

        public EditOrderHistory()
        {
            InitializeComponent();
        }

        // Set variable name to System.Data.OleDB (Line 18)

        // Connection to database
        OleDbConnection conns;
        // Commands to insert delete or update, select, and Reader (ExecuteReader() and ExecuteNonQuery())
        OleDbCommand cmd;
        // To Connect the Tools like datagridview direct to database
        OleDbDataAdapter adapter;
        // This is a column and rows in our database and inserting in our Forms ( Database access to Windows Form )
        DataTable table;

        // This method retrieves data from the database and fills the DataGridView
        void dgLists()
        {
            // ...

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb");

            // And yung database file na nasa folder is babasahin nya yung name na myLists sa access database at magcreate siya ng table
            table = new DataTable();

            // Icoconnect na ang adapter at para mailagay siya sa database using tools
            adapter = new OleDbDataAdapter("SELECT * FROM OrderHistory", conn);

            // Opening the Database
            conn.Open();

            // Dito ireread niya yung column at rows sa database and ififill nya ito sa datagridview
            adapter.Fill(table);

            // Ilalagay na niya sa table at yung mismong database information gamit itong method name dgLists
            dgOrderHistory.DataSource = table;

            // Database Close to run the Program
            conn.Close();

            // ...
        }


        // Save Button Database
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Using try Catch to lessen bugs
            try
            {
                string studentNo = addStudent.Text;
                // Need this pattern to insert in Student Number
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                // Comparing 2 variable if the condition success if the condition not follow the error show.
                bool isValid = Regex.IsMatch(studentNo, pattern);

                if (isValid)
                {
                    string addNew = "INSERT INTO OrderHistory (orderNumber,studentNumber,productId,quantity,totalCost,paymentMethod,orderDate) VALUES (@orderNumber,@studentNumber,@productId,@quantity,@totalCost,@paymentMethod,@orderDate)";
                    cmd = new OleDbCommand(addNew, conn);

                    cmd.Parameters.AddWithValue("@orderNumber", addOrder.Text);
                    cmd.Parameters.AddWithValue("@studentNumber", addStudent.Text);
                    cmd.Parameters.AddWithValue("@productId", addProduct.Text);
                    cmd.Parameters.AddWithValue("@quantity", addQuantity.Text);
                    cmd.Parameters.AddWithValue("@totalCost", addTotal.Text);
                    cmd.Parameters.AddWithValue("@paymentMethod", addPayment.Text);
                    cmd.Parameters.AddWithValue("@orderDate", dtTime.Value.ToString("yyyy-MM-dd"));

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success Insert to Database");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        dgLists();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address");
                }
            }
            catch (Exception ex)
            {
                // Bug Catches
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        // Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
                string studentNo = addStudent.Text;
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                bool isValid = Regex.IsMatch(studentNo, pattern);

                if (isValid)
                {
                    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
                    OleDbConnection connection = new OleDbConnection(connectionString);

                    string insertQuery = "UPDATE OrderHistory SET orderNumber = @orderNumber, studentNumber=@studentNumber, productId=@productId, quantity=@quantity, totalCost=@totalCost, paymentMethod=@paymentMethod, orderDate = @orderDate WHERE ID=@ID";

                    OleDbCommand cmd = new OleDbCommand(insertQuery, connection);

                    cmd.Parameters.AddWithValue("@orderNumber", addOrder.Text);
                    cmd.Parameters.AddWithValue("@studentNumber", addStudent.Text);
                    cmd.Parameters.AddWithValue("@productId", addProduct.Text);
                    cmd.Parameters.AddWithValue("@quantity", addQuantity.Text);
                    cmd.Parameters.AddWithValue("@totalCost", addTotal.Text);
                    cmd.Parameters.AddWithValue("@paymentMethod", addPayment.Text);
                    cmd.Parameters.AddWithValue("@orderDate", dtTime.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(lblID.Text)); // set the id of the record to be updated
                try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success: Email added to database");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
   
                    }
                dgLists();
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address");
                }
           
        }

        // Button Delete in OrderHistory Table Database
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string deleteRecord = "DELETE FROM OrderHistory WHERE ID=@ID";
            cmd = new OleDbCommand(deleteRecord, conn);
            cmd.Parameters.AddWithValue("@ID", lblID.Text); // set the id of the record to be deleted
            conn.Open(); // Opening Database
            cmd.ExecuteNonQuery(); // Read Line 114
            conn.Close(); // Closing Database

            MessageBox.Show("Success Delete from Database");

            // You need to call the conn void to save in our Database (Line 88)
            dgLists();
        }

        // This Function Select the row in DatagridView
        private void dgOrderHistory_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblShow.Text = "";
            lblID.Text = dgOrderHistory.CurrentRow.Cells[0].Value.ToString();
            addOrder.Text = dgOrderHistory.CurrentRow.Cells[1].Value.ToString();
            addStudent.Text = dgOrderHistory.CurrentRow.Cells[2].Value.ToString();
            addProduct.Text = dgOrderHistory.CurrentRow.Cells[3].Value.ToString();
            addQuantity.Text = dgOrderHistory.CurrentRow.Cells[4].Value.ToString();
            addTotal.Text = dgOrderHistory.CurrentRow.Cells[5].Value.ToString();
            addPayment.Text = dgOrderHistory.CurrentRow.Cells[6].Value.ToString();
            DateTime dateValue;
            if (DateTime.TryParse(dgOrderHistory.CurrentRow.Cells[7].Value.ToString(), out dateValue))
            {
                dtTime.Value = dateValue;
            }
        }

        // Clear all input select in rows that display in textbox
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Fill up new in Form";
            lblID.Text = "";
            addOrder.Text = "";
            addStudent.Text = "";
            addProduct.Text = "";
            addQuantity.Text = "";
            addTotal.Text = "";
            addPayment.Text = "";
        }

        // Button = Close Cancel
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
            dgLists();
        }

        // This is Form Load
        private void EditOrderHistory_Load(object sender, EventArgs e)
        {
            dgLists();

            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Set the label text to the current date
            lblDateEdit.Text = currentDate.ToString("dddd, MMMM dd, yyyy");

            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Set the label text to the current time
            lblTime.Text = currentTime.ToString("hh:mm:ss tt");

            // Set up connection string to MS Access database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";

            // Set up SQL query to retrieve username from database
            string query = "SELECT username FROM loginAccount WHERE ID = ID"; // Replace 1 with the appropriate user ID

            // Set up OleDbConnection and OleDbCommand objects
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                // Open the database connection
                connection.Open();

                // Execute the SQL query and retrieve the username
                string username = (string)command.ExecuteScalar();

                // Display the username in a label control
                lblAdmin.Text = username;
            }
        }


       
    }
}
