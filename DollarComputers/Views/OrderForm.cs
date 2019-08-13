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
            Application.Exit();

        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();

        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            productPrintForm.PrintAction = PrintAction.PrintToPreview;
            productPrintForm.Print();
            MessageBox.Show("Thank you for shopping with us, your order will be processed in 7 - 10 business days");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide();
        }

        private void selectFormButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void productInfoButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
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
            productPrintForm.PrintAction = PrintAction.PrintToPreview;
            productPrintForm.Print();
        }

        private void HomePictureBox_Click(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            // assigning the fields to the controls for the header of the form
            ConditionTextBox.Text = Program.product.condition.ToString();
            manufacturerTextBox.Text = Program.product.manufacturer.ToString();
            platformTextBox.Text = Program.product.platform.ToString();
            modelTextBox.Text = Program.product.model.ToString();


            // showing the picture based on the selected platform

            if (platformTextBox.Text == "Laptop")
            {
                LaptopPictureBox.Visible = true;
            }
            else if (platformTextBox.Text == "Desktop PC")
            {
                PCPictureBox.Visible = true;
            }


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


            // Clearing the price calculation 




            // showing the price and calculating the tax
            priceTextBox.Text = Convert.ToDecimal(Program.product.cost).ToString("#.##");
            
            decimal taxPercentage = (0.13M), GrandTotal;
            taxTextBox.Text = (Convert.ToDecimal(priceTextBox.Text) * taxPercentage).ToString("#.##");

            GrandTotal = Decimal.Add(Convert.ToDecimal(taxTextBox.Text), Convert.ToDecimal(priceTextBox.Text));

            totalTextBox.Text = GrandTotal.ToString("C2");


        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
