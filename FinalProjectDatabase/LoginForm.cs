﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Rounded Corner Design
using System.Runtime.InteropServices;
// System.Data.OleDb is namespace in the .NET Framework that provides a set of classes for accessing data in a variety of data sources using the OLE DB data provider.
using System.Data.OleDb;

namespace FinalProjectDatabase
{
    public partial class LoginForm : Form
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

        // Connection to database
        OleDbConnection conn;
        // Commands to insert delete or update, select, and Reader (ExecuteReader() and ExecuteNonQuery())
        OleDbCommand cmd;
        // To Connect the Tools like datagridview, textbox direct to database
        OleDbDataAdapter adapter;
        // This is a column and rows in our database and inserting in our Forms ( Database access to Windows Form )

        // Login using Database 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
            string query = "SELECT COUNT(*) FROM loginAccount WHERE Username = @username AND Password = @password";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);
                connection.Open();
                int result = (int)command.ExecuteScalar();
                if (result > 0)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnBg_Paint(object sender, PaintEventArgs e)
        {
            pnBg.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnBg.Width, pnBg.Height, 25, 25));
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            pbLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbLogo.Width, pbLogo.Height, 25, 25));
        }

        private void pnUsernameDesign_Paint(object sender, PaintEventArgs e)
        {
            pnUsernameDesign.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnUsernameDesign.Width, pnUsernameDesign.Height, 10, 10));
        }

        private void pnPasswordDesign_Paint(object sender, PaintEventArgs e)
        {
            pnPasswordDesign.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnPasswordDesign.Width, pnPasswordDesign.Height, 10, 10));
        }

        private void pnDes_Paint(object sender, PaintEventArgs e)
        {
            pnDes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnDes.Width, pnDes.Height, 30, 30));
        }

       
    }
}
