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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputerDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputerDataSet.products);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // var productsList =
                //from DollarComputerDataSet.products;

        }
    }
}
