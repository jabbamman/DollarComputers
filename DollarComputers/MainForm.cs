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
    public partial class MainForm : Form
    {
       
        
        public MainForm()
        {
            InitializeComponent();
           
          

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            TheButton.BackColor = Color.FromArgb(229, 126, 49);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            TheButton.BackColor = Color.FromArgb(41, 53, 65);
        }

        private void XLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            //SelectForm selectForm = new SelectForm();
            

            SelectForm selectForm = new SelectForm();
            selectForm.TopLevel = false;
            selectForm.AutoScroll = true;
            this.mainPanel.Controls.Add(selectForm);
            selectForm.Show();

        }
    }
}
