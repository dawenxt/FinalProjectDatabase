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
    public partial class EditOrderHistory : Form
    {
        public EditOrderHistory()
        {
            InitializeComponent();
        }

        // Button = Close Cancel
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
