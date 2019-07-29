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

namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void selectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader inputStream = new StreamReader(
                File.Open("ProductInfo.txt", FileMode.Open)))
                {
                    Program.ProductInfoClass.ProductID= int.Parse(inputStream.ReadLine()); 
                    Program.ProductInfoClass.Cost= float.Parse(inputStream.ReadLine()); ;
                    Program.ProductInfoClass.Manufacturer= inputStream.ReadLine();
                    Program.ProductInfoClass.Model= inputStream.ReadLine();
                    Program.ProductInfoClass.RamType= inputStream.ReadLine(); 
                    Program.ProductInfoClass.RamSize= inputStream.ReadLine();

                    Program.ProductInfoClass.DisplayType= inputStream.ReadLine();
                    Program.ProductInfoClass.ScreenSize= inputStream.ReadLine();
                    Program.ProductInfoClass.Resolution= inputStream.ReadLine();
                    Program.ProductInfoClass.CPUClass= inputStream.ReadLine();
                    Program.ProductInfoClass.CPUBrand= inputStream.ReadLine();
                    Program.ProductInfoClass.Model= inputStream.ReadLine();
                    Program.ProductInfoClass.CPUType= inputStream.ReadLine();
                    Program.ProductInfoClass.CPUSpeed= inputStream.ReadLine();


                    Program.ProductInfoClass.CPUNumber= inputStream.ReadLine();
                    Program.ProductInfoClass.Condition= inputStream.ReadLine();
                    Program.ProductInfoClass.OS= inputStream.ReadLine();
                    Program.ProductInfoClass.Platform= inputStream.ReadLine();
                    Program.ProductInfoClass.HDDSize= inputStream.ReadLine();
                    Program.ProductInfoClass.HDDSpeed= inputStream.ReadLine();
                    Program.ProductInfoClass.CPUType= inputStream.ReadLine();
                    Program.ProductInfoClass.GPUType= inputStream.ReadLine();


                    Program.ProductInfoClass.OpticalDrive= inputStream.ReadLine();
                    Program.ProductInfoClass.AudioType= inputStream.ReadLine();
                    Program.ProductInfoClass.LAN= inputStream.ReadLine();
                    Program.ProductInfoClass.WIFI= inputStream.ReadLine();
                    Program.ProductInfoClass.Width= inputStream.ReadLine();


                    Program.ProductInfoClass.Height= inputStream.ReadLine();
                    Program.ProductInfoClass.Depth= inputStream.ReadLine();
                    Program.ProductInfoClass.Weight= inputStream.ReadLine();
                    Program.ProductInfoClass.MouseType= inputStream.ReadLine();
                    Program.ProductInfoClass.Power= inputStream.ReadLine();
                    Program.ProductInfoClass.Webcam= inputStream.ReadLine();
                                                        
                    inputStream.Close();
                    inputStream.Dispose();



                    productIDTextBox.Text = Program.ProductInfoClass.ProductID.ToString();
                    conditionTextBox.Text = Program.ProductInfoClass.Condition.ToString();
                    costTextBox.Text = Program.ProductInfoClass.Cost.ToString();

                    platformTextBox.Text = Program.ProductInfoClass.Platform.ToString();
                    osTextBox.Text = Program.ProductInfoClass.OS.ToString();
                    manufacturerTextBox.Text = Program.ProductInfoClass.Manufacturer.ToString();
                    modelTextBox.Text = Program.ProductInfoClass.Model.ToString();

                    memoryTextBox.Text = Program.ProductInfoClass.RamSize.ToString();
                    cpuBrandTextBox.Text = Program.ProductInfoClass.CPUBrand.ToString();
                    cpuTypeTextBox.Text = Program.ProductInfoClass.CPUType.ToString();

                    lcdSizeTextBox.Text = Program.ProductInfoClass.DisplayType.ToString();
                    cpuNumberTextBox.Text = Program.ProductInfoClass.CPUNumber.ToString();
                    cpuSpeedTextBox.Text = Program.ProductInfoClass.CPUSpeed.ToString();

                    hddTextBox.Text = Program.ProductInfoClass.HDDSize.ToString();
                    gpuTypeTextBox.Text = Program.ProductInfoClass.GPUType.ToString();
                    webCamTextBox.Text = Program.ProductInfoClass.Webcam.ToString();




                }

            }
            catch (IOException exception)
            {

                MessageBox.Show("Error:" + exception);

            }
        }
    }
}
