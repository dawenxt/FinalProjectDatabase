using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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

        private void Form1_Load(object sender, EventArgs e)
        {

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

        // Button = New Order
        private void btnNeworder_Click(object sender, EventArgs e)
        {
            formLoad(new myList());
        }

        // Panel Logo Rounded
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
            panelLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelLogo.Width, panelLogo.Height, 25, 25));
        }
    }
}