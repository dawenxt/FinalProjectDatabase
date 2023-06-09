﻿using System;
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


namespace FinalProjectDatabase
{
    public partial class Stock : Form
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

        public Stock()
        {
            InitializeComponent();
        }

        // DATABASE

        void dgLists()
        {
            // File Path of Database and to test Data (Go to Server Explorer right click Data Connections (Add New Connection))
            // then select data source Microsoft Access Database File (OLE DB) then paste your Database Access File Name Location
            // next is click advance and copy the Provider at the bottom.
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
            dataGridView1.DataSource = table;

            // Database Close to run the Program
            conn.Close();

        }

        // THIS IS DESIGN
        private void OrderHistory_Load(object sender, EventArgs e)
        {
            // Database
            dgLists();

            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Set the label text to the current date
            lblDateNow.Text = currentDate.ToString("dddd, MMMM dd, yyyy");

            lblDate.Text = currentDate.ToString("dddd, MMMM dd, yyyy");
            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Set the label text to the current time
            lblTimeNow.Text = currentTime.ToString("hh:mm:ss tt");
        }

        // Rounded in Background of Order History 
        private void pnOrder_Paint(object sender, PaintEventArgs e)
        {
            pnOrder.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnOrder.Width, pnOrder.Height, 25, 25));
        }

        // Rounded in Background of Search in Order History
        private void pnBgsearch_Paint(object sender, PaintEventArgs e)
        {
            pnBgsearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnBgsearch.Width, pnBgsearch.Height, 25, 25));          
        }

        // pnBg1 and 2 are display design rounded
        private void pnBg1_Paint(object sender, PaintEventArgs e)
        {
            pnBg1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnBg1.Width, pnBg1.Height, 25, 25));
        }

        // pnBg2
        private void pnBg2_Paint(object sender, PaintEventArgs e)
        {
            pnBg2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnBg2.Width, pnBg2.Height, 25, 25));
        }

        // Button Search
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // creating new variable name to call the Database Access file Location to exist in current context
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
                // kapag ikaw ay nag type sa text box with name txt.search
                string searchTerm = tbSearch.Text;
                // dito ilalagay or kukunin yung database info (SELECT DATABASE Column and Rows)
                string query = "SELECT * FROM StockInventory WHERE productNum LIKE '%" + searchTerm + "%'";

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
                        lblid.Text = reader["ID"].ToString();
                        lblproduct.Text = reader["productNum"].ToString();
                        lblDes.Text = reader["description"].ToString();
                        lblStock.Text = reader["openingStock"].ToString();
                        lblValue.Text = reader["stockValue"].ToString();
                        lblOut.Text = reader["out"].ToString();
                        lblSales.Text = reader["sales"].ToString();
                        lblOn.Text = reader["status"].ToString();
                        lblStorage.Text = reader["storageNumber"].ToString();
                        lblReorder.Text = reader["reorder"].ToString();

                    }
                    else
                    {
                        // This section shows a message box indicating that the data was not found
                        MessageBox.Show("This Data Not Found in Our Database");
                        // Delete the List if the error Appears 
                        lblid.Text = "";
                        lblproduct.Text = "";
                        lblDes.Text = "";
                        lblStock.Text = "";
                        lblValue.Text = "";
                        lblOut.Text = "";
                        lblSales.Text = "";
                        lblStorage.Text = "";
                        lblOn.Text = "";
                        lblReorder.Text = "";
                    }
                }
            }
            catch
            {
                // If the error is not out of bound
                MessageBox.Show("This is Error in our Database, Sorry!");
            }

        }

        // Button = Edit Stock Inventory
        private void button5_Click(object sender, EventArgs e)
        {
            EditStock updateOrder = new EditStock();
            updateOrder.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDateNow_Click(object sender, EventArgs e)
        {

        }

        // Button View Product List
        private void btnView_Click(object sender, EventArgs e)
        {
            productList view = new productList();
            view.Show();
        }
    }
}
