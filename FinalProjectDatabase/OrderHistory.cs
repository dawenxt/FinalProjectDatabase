using System;
using System.Collections.Generic;
using System.ComponentModel;
// Rounded Corner
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Filename Database: DataFile_InventorySystemITEC103.accdb

// If you are not Install and have a problem in (line 29) Install a System.Data.OleDb in manage nuggets 
// Step: ( Right Click FinalProjectDatabase file and manage nuggets then search in Browse System.Data.OleDb and install )
// to use the function of System.Data.OleDb ( Database using Microsoft Access )

// System.Data.OleDb is namespace in the .NET Framework that provides a set of classes for accessing data in a variety of data sources using the OLE DB data provider.
using System.Data.OleDb;

// This is for Print Receipt ( to be continue )
using System.Drawing.Printing;
using System.IO;

// Regex symbols or regular expression is a sequence of characters that define a search pattern.
// They can be used to search for specific words or phrases, extract data from text.
using System.Text.RegularExpressions;

namespace FinalProjectDatabase
{
    

    public partial class OrderHistory : Form
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

        // Set variable name to System.Data.OleDB (Line 18)

        // Connection to database
        OleDbConnection conn;
        // Commands to insert delete or update, select, and Reader (ExecuteReader() and ExecuteNonQuery())
        OleDbCommand cmd;
        // To Connect the Tools like datagridview direct to database
        OleDbDataAdapter adapter;
        // This is a column and rows in our database and inserting in our Forms ( Database access to Windows Form )
        DataTable table;

        public OrderHistory()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }



        // This is a Save Info in Database and Fill the DataGridView to list all data input in our Database Access
        void dgLists() 
        {
            // File Path of Database and to test Data (Go to Server Explorer right click Data Connections (Add New Connection))
            // then select data source Microsoft Access Database File (OLE DB) then paste your Database Access File Name Location
            // next is click advance and copy the Provider at the bottom.
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


        }


        // Calling the void we set to Run the Database in the main form of Mylist Designer
        private void myList_Load(object sender, EventArgs e)
        {
            dgLists();

        }


// Selection the table fill to Update the text Label
        private void dgList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

// This is for "EXIT" new Database (Button EXIT)
        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            this.Hide();        
        }

        private void dgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

// This is for "SEARCH" new Database (textbox SEARCH)
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // creating new variable name to call the Database Access file Location to exist in current context
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
                // kapag ikaw ay nag type sa text box with name txt.search
                string searchTerm = txtSearch.Text;
                // dito ilalagay or kukunin yung database info (SELECT DATABASE Column and Rows)
                string query = "SELECT * FROM OrderHistory WHERE ID LIKE '%" + searchTerm + "%'";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    // First is select database info and second is to direct save in our database ( variable name query is "SELECT" and variable name connection is the file path to "SAVE" data )
                    OleDbCommand command = new OleDbCommand(query, connection);
                    // Opening Database File
                    connection.Open();
                    // Open Database Reader
                    OleDbDataReader reader = command.ExecuteReader();

                    // 1st Condition
                    if (reader.HasRows)
                    {
                        // This Section Print the result in Label (resultId, resultNo, resultName, resultBrgy, resultDate)
                        reader.Read();
                        resId.Text = reader["ID"].ToString();
                        resOrder.Text = reader["orderNumber"].ToString();
                        resStudent.Text = reader["studentNumber"].ToString();
                        resProduct.Text = reader["productid"].ToString();
                        resQuan.Text = reader["quantity"].ToString();
                        resTotal.Text = reader["totalCost"].ToString();
                        resPayment.Text = reader["paymentMethod"].ToString();
                        resDate.Text = reader["orderDate"].ToString();
                    }
                    else
                    {
                        // Try searching using student number instead
                        query = "SELECT * FROM OrderHistory WHERE orderNumber LIKE '%" + searchTerm + "%'";
                        command = new OleDbCommand(query, connection);
                        reader = command.ExecuteReader();

                        // 2nd Condition
                        if (reader.HasRows)
                        {
                            reader.Read();
                           
                            resOrder.Text = reader["orderNumber"].ToString();
                            resStudent.Text = reader["studentNumber"].ToString();
                            resProduct.Text = reader["productid"].ToString();
                            resQuan.Text = reader["quantity"].ToString();
                            resTotal.Text = reader["totalCost"].ToString();
                            resPayment.Text = reader["paymentMethod"].ToString();
                            resDate.Text = reader["orderDate"].ToString();
                            resId.Text = reader["ID"].ToString();
                        }
                        else
                        {
                            // This section shows a message box indicating that the data was not found
                            MessageBox.Show("This Data Not Found in Our Database");
                            // Delete the List if the error Appears 
                            resId.Text = "";
                            resOrder.Text = "";
                            resStudent.Text = "";
                            resProduct.Text = "";
                            resQuan.Text = "";
                            resTotal.Text = "";
                            resPayment.Text = "";
                            resDate.Text = "";
                        }
                    }  
                }
            }
            catch
            {
                // If the error is not out of bound
                MessageBox.Show("This is Error in our Database, Sorry!");
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditOrderHistory edit = new EditOrderHistory();
            edit.Show();
        }

        private void dgOrderHistory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void lblDateNow_Click(object sender, EventArgs e)
        {

        }
    }
    }
