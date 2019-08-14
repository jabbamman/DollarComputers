using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Student Name: Mohamed A.Ali
 * Student ID: 301036444
 * Description: where the user is shown the cost of the hardware and can print his order.
*/
namespace DollarComputers.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exiting the Application 
            Application.Exit();
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Showing Product Info Form 
            Program.productInfoForm.Show();
            // Hiding Order Form 
            this.Hide();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            // Showing a Message Informing the user before printing the form 
            MessageBox.Show("Thank you for shopping with us, your order will be processed in 7 - 10 business days","Printing",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //Printing the form 
            productPrintForm.PrintAction = PrintAction.PrintToPreview;
            productPrintForm.Print();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Showing About Box
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            // Showing Start Form 
            Program.startForm.Show();
            // Hiding Order Form 
            this.Hide();
        }

        private void selectFormButton_Click(object sender, EventArgs e)
        {
            //Showing Select Form 
            Program.selectForm.Show();
            // Hiding Order Form 
            this.Hide();
        }

        private void productInfoButton_Click(object sender, EventArgs e)
        {
            //Showing Product info Form 
            Program.productInfoForm.Show();
            // Hiding Order Form 
            this.Hide();
        }

        private void orderFormButton_Click(object sender, EventArgs e)
        {
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // printing the form 
            MessageBox.Show("Kindly Press Ok to Proceed Priting the order", "Printing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            productPrintForm.PrintAction = PrintAction.PrintToPreview;
            productPrintForm.Print();
        }

        private void HomePictureBox_Click(object sender, EventArgs e)
        {
            //Showing Start Form 
            Program.startForm.Show();
            // Hiding Order Form 
            this.Hide();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            // Filling Controls with Data 
            FillingData();
            // showing the picture based on the selected platform
            ShowingHardwarePicture();
            // showing the price and calculating the tax
            TaxCalculation();
        }

        private void FillingData()
        {
            ConditionTextBox.Text = Program.product.condition.ToString();
            manufacturerTextBox.Text = Program.product.manufacturer.ToString();
            platformTextBox.Text = Program.product.platform.ToString();
            modelTextBox.Text = Program.product.model.ToString();
            // adding data to multiline text box 
            ProductInfoTextBox.Text += Program.product.screensize.ToString() + System.Environment.NewLine;
            ProductInfoTextBox.Text += Program.product.RAM_size.ToString() + System.Environment.NewLine; ;
            ProductInfoTextBox.Text += Program.product.CPU_brand.ToString() + System.Environment.NewLine;
            ProductInfoTextBox.Text += Program.product.CPU_type.ToString() + System.Environment.NewLine;
            ProductInfoTextBox.Text += Program.product.CPU_number.ToString() + System.Environment.NewLine;
            ProductInfoTextBox.Text += Program.product.CPU_speed.ToString() + System.Environment.NewLine;
            ProductInfoTextBox.Text += Program.product.HDD_size.ToString() + System.Environment.NewLine;
            ProductInfoTextBox.Text += Program.product.GPU_Type.ToString() + System.Environment.NewLine;
            ProductInfoTextBox.Text += Program.product.webcam.ToString() + System.Environment.NewLine;
            ProductInfoTextBox.Text += Program.product.OS.ToString() + System.Environment.NewLine;
        }

        private void ShowingHardwarePicture()
        {
            if (platformTextBox.Text == "Laptop")
            {
                LaptopPictureBox.Visible = true;
            }
            else if (platformTextBox.Text == "Desktop PC")
            {
                PCPictureBox.Visible = true;
            }
        }

        private void TaxCalculation()
        {
            priceTextBox.Text = Convert.ToDecimal(Program.product.cost).ToString("#.##");
            decimal taxPercentage = (0.13M), GrandTotal;
            taxTextBox.Text = (Convert.ToDecimal(priceTextBox.Text) * taxPercentage).ToString("#.##");
            GrandTotal = Decimal.Add(Convert.ToDecimal(taxTextBox.Text), Convert.ToDecimal(priceTextBox.Text));
            totalTextBox.Text = GrandTotal.ToString("C2");
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
           
        }

        private void FinishButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for shopping with us, your order will be processed in 7 - 10 business days", "Sending", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
