using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FinalProjectDatabase
{
        // This Code is form the Rounded Corner of this Form(loading.cs)
        public partial class loading : Form
        {
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

        // Initialize Rounded Corner Form
        public loading()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        // Timer Start
        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Condition of Timer and Progress Bar
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 10)
            {
                progressBar1.Value += 5;

                label1.Text = "Analyzing Application.";

                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else if (progressBar1.Value < 20)
            {
                progressBar1.Value += 5;

                label1.Text = "Please Wait..";

                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else if (progressBar1.Value < 30)
            {
                progressBar1.Value += 5;

                label1.Text = "Please Wait....";

                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else if (progressBar1.Value < 40)
            {
                progressBar1.Value += 5;

                label1.Text = "Data Updating..";

                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else if (progressBar1.Value < 50)
            {
                progressBar1.Value += 5;

                label1.Text = "Connecting to MS Database..";

                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else if (progressBar1.Value < 60)
            {
                progressBar1.Value += 5;

                label1.Text = "Loading.";

                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else if (progressBar1.Value < 70)
            {
                progressBar1.Value += 5;

                label1.Text = "Loading..";

                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else if (progressBar1.Value < 80)
            {
                progressBar1.Value += 5;

                label1.Text = "Loading...";

                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else if (progressBar1.Value < 90)
            {
                progressBar1.Value += 5;

                label1.Text = "Loading....";

                label2.Text = progressBar1.Value.ToString() + "%";

            }
            else if (progressBar1.Value < 100)
            {
                progressBar1.Value += 5;

                label1.Text = "Loading.....";

                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();

                Form1 frm1 = new Form1();
                frm1.ShowDialog();
               
            }

        }
    }
}
