using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Rounded using System
using System.Runtime.InteropServices;

// Filename Database: DataFile_InventorySystemITEC103.accdb

// If you are not Install and have a problem in (line 29) Install a System.Data.OleDb in manage nuggets 
// Step: ( Right Click FinalProjectDatabase file and manage nuggets then search in Browse System.Data.OleDb and install )
// to use the function of System.Data.OleDb ( Database using Microsoft Access )

// System.Data.OleDb is namespace in the .NET Framework that provides a set of classes for accessing data in a variety of data sources using the OLE DB data provider.
using System.Data.OleDb;

// Regex symbols or regular expression is a sequence of characters that define a search pattern.
// They can be used to search for specific words or phrases, extract data from text.
using System.Text.RegularExpressions;

namespace FinalProjectDatabase
{
    public partial class EditStock : Form
    {
        // Importing Rounded Corner
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public EditStock()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {
            dgLists();

            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Set the label text to the current date
            lblDate.Text = currentDate.ToString("dddd, MMMM dd, yyyy");

            // Get the current time
            DateTime currentTime = DateTime.Now;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblFill.Text = "Fill Up new in Form";
            lblID.Text = "";
            lblProduct.Text = "";
            lblDescription.Text = "";
            txtOpening.Text = "";
            txtStock.Text = "";
            txtOut.Text = "";
            txtCost.Text = "";
            txtSales.Text = "";
            txtStatus.Text = "";
            txtStorage.Text = "";
            txtReorder.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));
        }

        // Set variable name to System.Data.OleDB (Line 18)

        // Connection to database
        OleDbConnection conn;
        // Commands to insert delete or update, select, and Reader (ExecuteReader() and ExecuteNonQuery())
        OleDbCommand cmd;
        // To Connect the Tools like datagridview direct to database
        OleDbDataAdapter adapter;
        // This is a column and rows in our database and inserting in our Forms ( Database access to Windows Form )
        DataTable table;

        // DATABASE
        void dgLists()
        {
            // ...

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb");

            // And yung database file na nasa folder is babasahin nya yung name na myLists sa access database at magcreate siya ng table
            table = new DataTable();

            // Icoconnect na ang adapter at para mailagay siya sa database using tools
            adapter = new OleDbDataAdapter("SELECT * FROM StockInventory", conn);

            // Opening the Database
            conn.Open();

            // Dito ireread niya yung column at rows sa database and ififill nya ito sa datagridview
            adapter.Fill(table);

            // Ilalagay na niya sa table at yung mismong database information gamit itong method name dgLists
            dgList.DataSource = table;

            // Database Close to run the Program
            conn.Close();

            // ...
        }

        


        // Button Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Using try Catch to lessen bugs
            try
            {          
                    string addNew = "INSERT INTO StockInventory (productNum,description,openingStock,stockValue,out,costItem,sales,status,storageNumber,reorder) VALUES (@productNum,@description,@openingStock,@stockValue,@out,@costItem,@sales,@status,@storageNumber,@reorder)";
                    cmd = new OleDbCommand(addNew, conn);

                    cmd.Parameters.AddWithValue("@productNum", lblProduct.Text);
                    cmd.Parameters.AddWithValue("@description", lblDescription.Text);
                    cmd.Parameters.AddWithValue("@openingStock", txtOpening.Text);
                    cmd.Parameters.AddWithValue("@stockValue", txtStock.Text);
                    cmd.Parameters.AddWithValue("@out", txtOut.Text);
                    cmd.Parameters.AddWithValue("@costItem", txtCost.Text);
                    cmd.Parameters.AddWithValue("@sales", txtSales.Text);
                    cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                    cmd.Parameters.AddWithValue("@storageNumber", txtStorage.Text);
                    cmd.Parameters.AddWithValue("@reorder", txtReorder.Text);

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
            catch (Exception ex)
            {
                // Bug Catches
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);

            string insertQuery = "UPDATE StockInventory SET productNum = @productNum, description=@description, openingStock=@openingStock, stockValue=@stockValue, out=@out, costItem=@costItem, sales = @sales, status = @status, storagenumber = @storageNumber, reorder = @reorder WHERE ID=@ID";

            OleDbCommand cmd = new OleDbCommand(insertQuery, connection);

            cmd.Parameters.AddWithValue("@productNum", lblProduct.Text);
            cmd.Parameters.AddWithValue("@description", lblDescription.Text);
            cmd.Parameters.AddWithValue("@openingStock", txtOpening.Text);
            cmd.Parameters.AddWithValue("@stockValue", txtStock.Text);
            cmd.Parameters.AddWithValue("@out", txtOut.Text);
            cmd.Parameters.AddWithValue("@costItem", txtCost.Text);
            cmd.Parameters.AddWithValue("@sales", txtSales.Text);
            cmd.Parameters.AddWithValue("@status", txtStatus.Text);
            cmd.Parameters.AddWithValue("@storageNumber", txtStorage.Text);
            cmd.Parameters.AddWithValue("@reorder", txtReorder.Text);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(lblID.Text)); // set the id of the record to be updated
            try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
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


        // Select in DATAGRID
        private void dgList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgList.CurrentRow.Cells[0].Value.ToString();
            lblProduct.Text = dgList.CurrentRow.Cells[1].Value.ToString();
            lblDescription.Text = dgList.CurrentRow.Cells[2].Value.ToString();
            txtOpening.Text = dgList.CurrentRow.Cells[3].Value.ToString();
            txtStock.Text = dgList.CurrentRow.Cells[4].Value.ToString();
            txtOut.Text = dgList.CurrentRow.Cells[5].Value.ToString();
            txtCost.Text = dgList.CurrentRow.Cells[6].Value.ToString();
            txtSales.Text = dgList.CurrentRow.Cells[7].Value.ToString();
            txtStatus.Text = dgList.CurrentRow.Cells[8].Value.ToString();
            txtStorage.Text = dgList.CurrentRow.Cells[9].Value.ToString();
            txtReorder.Text = dgList.CurrentRow.Cells[10].Value.ToString();
        }

        // Button = Delete
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string deleteRecord = "DELETE FROM StockInventory WHERE ID=@ID";
            cmd = new OleDbCommand(deleteRecord, conn);
            cmd.Parameters.AddWithValue("@ID", lblID.Text); // set the id of the record to be deleted
            conn.Open(); // Opening Database
            cmd.ExecuteNonQuery(); // Read Line 114
            conn.Close(); // Closing Database

            MessageBox.Show("Success Delete from Database");

            // You need to call the conn void to save in our Database (Line 88)
            dgLists();
        }
    }
}


