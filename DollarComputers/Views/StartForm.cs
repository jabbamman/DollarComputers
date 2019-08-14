using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Student Name: Mohamed A.Ali
 * Student ID: 301036444
 * Description: StartForm where the user selects between starting a new order or loading a saved order
*/
namespace DollarComputers.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Application Exit Command shared handler
            Application.Exit();
        }

        private void startNewOrderBtn_Click(object sender, EventArgs e)
        {
            // monving to select Form
            Program.selectForm.Show();
            this.Hide();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form Closing event leads to exit the application
            Application.Exit();
        }

        private void loadSavedOrderBtn_Click(object sender, EventArgs e)
        {
            // Configure ProductOpenFile Dialogue

            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text File (*.txt)|*txt|All Files (*.*)|*.*";
            // Open ProductOpenFile Dialogue 

            var result = ProductOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    using (StreamReader inputStream = new StreamReader(
                    File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // calling methods to the calss product members
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.cost = decimal.Parse(inputStream.ReadLine()); ;
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_type = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();

                        Program.product.displaytype = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.resolution = inputStream.ReadLine();
                        Program.product.CPU_Class = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();

                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();

                        Program.product.HDD_speed = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.optical_drive = inputStream.ReadLine();
                        Program.product.Audio_type = inputStream.ReadLine();
                        Program.product.LAN = inputStream.ReadLine();
                        Program.product.WIFI = inputStream.ReadLine();

                        Program.product.width = inputStream.ReadLine();
                        Program.product.height = inputStream.ReadLine();
                        Program.product.depth = inputStream.ReadLine();
                        Program.product.weight = inputStream.ReadLine();
                        Program.product.moust_type = inputStream.ReadLine();
                        Program.product.power = inputStream.ReadLine();

                        Program.product.webcam = inputStream.ReadLine();
                        // closing the stream 
                        inputStream.Close();
                        inputStream.Dispose();
                        // showing the product info form 
                        Program.productInfoForm.Show();
                        //hiding the form
                        this.Hide();
                    }

                }
                catch (IOException exception)
                {
                    // Message box showing the error if the previouse code failed to retrieve the file
                    MessageBox.Show("Error:" + exception.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            
        }

        private void selectFormButton_Click(object sender, EventArgs e)
        {
            //showing selec form
            Program.selectForm.Show();
            // hide start form 
            this.Hide();
        }

        private void productInfoButton_Click(object sender, EventArgs e)
        {
            //showing product info form 
            Program.productInfoForm.Show();
            // hide start form 
            this.Hide();
        }

        private void orderFormButton_Click(object sender, EventArgs e)
        {
            //showing order form 
            Program.orderForm.Show();
            // hide start form 
            this.Hide();
        }
    }
}
