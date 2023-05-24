using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDatabase
{

    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private bool isDarkMode = false;

        private void ToggleDarkMode()
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                // Set dark mode colors
                this.BackColor = Color.FromArgb(33, 33, 33);
                this.ForeColor = Color.White;

                // Modify other controls and components' colors
                // For example:
                // label1.ForeColor = Color.White;
                // button1.BackColor = Color.FromArgb(64, 64, 64);
                // ...

                // Optionally, change the theme of any third-party controls you are using
            }
            else
            {
                // Set light mode colors
                this.BackColor = SystemColors.Control;
                this.ForeColor = SystemColors.ControlText;

                // Reset other controls and components' colors
                // For example:
                // label1.ForeColor = SystemColors.ControlText;
                // button1.BackColor = SystemColors.Control;
                // ...

                // Optionally, revert the theme of any third-party controls you are using
            }
        }


        private void btnDarkmode_Click(object sender, EventArgs e)
        {
            ToggleDarkMode();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
