using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Student Name: Mohamed A.Ali
 * Student ID: 301036444
 * Description: a splash page will last for 3 second and then will disapear and will show the start form
*/  

namespace DollarComputers.Views
{
    public partial class SpalshForm : Form
    {
        public SpalshForm()
        {
            InitializeComponent();
        }
        private void SpalshForm_Load(object sender, EventArgs e)
        {
            // Enabling the timer to start count
            splashTimer.Enabled = true;
        }
        private void splashTimer_Tick(object sender, EventArgs e)
        {
            // after hitting 3000 mseconds the timer will turn to false 
            splashTimer.Enabled = false;
            // showing start form 
            Program.startForm.Show();
            // hide splash form
            this.Hide();
        }

        
    }
}
