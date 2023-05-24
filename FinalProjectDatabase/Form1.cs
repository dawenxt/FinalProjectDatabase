using System;
using System.Windows.Forms;
// Rounded
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace FinalProjectDatabase
{
    public partial class Form1 : Form
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

        // Applying Rounded Corner in Form1
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        // To change different Form using Panel
        // Show multiple forms in Panel
        public void formLoad(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }
        
        // This panel is to show other forms
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // try Catch here Retrive username Details from Database
        // Display name in login label text
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
            string query = "SELECT TOP 1 username FROM loginAccount"; // Retrieve any username from the loginAccount table
            string username = null; 

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    username = command.ExecuteScalar() as string;
                }
            }

            if (string.IsNullOrEmpty(username))
            {
                // Username not found in the database
                Console.WriteLine("Username not found.");
            }
            else
            {
                // Username found, display the value
                lblDetails.Text = "Username: " + username;
            }

            Console.ReadLine();


        }

        // Bg Rounded corner of All Buttons
        private void pnBg_Paint(object sender, PaintEventArgs e)
        {
            pnBg.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnBg.Width, pnBg.Height, 25, 25));
        }

        // Button = Dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            formLoad(new myDashboard());
        }

        // Button = Order History
        private void btnHistory_Click(object sender, EventArgs e)
        {
            formLoad(new OrderHistory());
        }

        // Button = Stock Inventory
        private void button2_Click(object sender, EventArgs e)
        {
            formLoad(new Stock());
        }

        // Button = Settings
        private void btnSettings_Click(object sender, EventArgs e)
        {
            formLoad(new Settings());
        }

        // Button = Support
        private void btnSupport_Click(object sender, EventArgs e)
        {
            formLoad(new Support());
        }

        // Button = New Order
        private void btnNeworder_Click(object sender, EventArgs e)
        {
            
        }

        // Panel Logo Rounded
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            panelLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelLogo.Width, panelLogo.Height, 25, 25));
        }

        
    }
}