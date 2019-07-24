using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SpalshForm : Form
    {
        public SpalshForm()
        {
            InitializeComponent();
        }
        private void SpalshForm_Load(object sender, EventArgs e)
        {
            splashTimer.Enabled = true;
        }
        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
        }

        
    }
}
