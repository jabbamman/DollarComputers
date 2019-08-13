﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers.Views
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
            productIDTextBox.Text = Program.product.productID.ToString();
            conditionTextBox.Text = Program.product.condition.ToString();
            costTextBox.Text = Convert.ToDecimal(Program.product.cost).ToString("C2");

            platformTextBox.Text = Program.product.platform.ToString();
            osTextBox.Text = Program.product.OS.ToString();
            manufacturerTextBox.Text = Program.product.manufacturer.ToString();
            modelTextBox.Text = Program.product.model.ToString();

            memoryTextBox.Text = Program.product.RAM_size.ToString();
            cpuBrandTextBox.Text = Program.product.CPU_brand.ToString();
            cpuTypeTextBox.Text = Program.product.CPU_type.ToString();

            lcdSizeTextBox.Text = Program.product.displaytype.ToString();
            cpuNumberTextBox.Text = Program.product.CPU_number.ToString();
            cpuSpeedTextBox.Text = Program.product.CPU_speed.ToString();

            hddTextBox.Text = Program.product.HDD_size.ToString();
            gpuTypeTextBox.Text = Program.product.GPU_Type.ToString();
            webCamTextBox.Text = Program.product.webcam.ToString();





        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {

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
          
        }

        private void orderFormButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void HomePictureBox_Click(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          using (StreamWriter outputStream = new StreamWriter(File.Open("ProductInfo.txt", FileMode.Create)))
                {
                    outputStream.WriteLine(Program.product.productID);
                    outputStream.WriteLine(Program.product.cost);
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.RAM_type);
                    outputStream.WriteLine(Program.product.RAM_size);
               
                    outputStream.WriteLine(Program.product.displaytype);
                    outputStream.WriteLine(Program.product.screensize);
                    outputStream.WriteLine(Program.product.resolution);
                    outputStream.WriteLine(Program.product.CPU_Class);
                    outputStream.WriteLine(Program.product.CPU_brand);
                    outputStream.WriteLine(Program.product.CPU_type);

                    outputStream.WriteLine(Program.product.CPU_speed);
                    outputStream.WriteLine(Program.product.CPU_number);
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.OS);
                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.HDD_size);

                    outputStream.WriteLine(Program.product.HDD_speed);
                    outputStream.WriteLine(Program.product.GPU_Type);
                    outputStream.WriteLine(Program.product.optical_drive);
                    outputStream.WriteLine(Program.product.Audio_type);
                    outputStream.WriteLine(Program.product.LAN);
                    outputStream.WriteLine(Program.product.WIFI);

                    outputStream.WriteLine(Program.product.width);
                    outputStream.WriteLine(Program.product.height);
                    outputStream.WriteLine(Program.product.depth);
                    outputStream.WriteLine(Program.product.weight);
                    outputStream.WriteLine(Program.product.moust_type);
                    outputStream.WriteLine(Program.product.power);

                    outputStream.WriteLine(Program.product.webcam);

                    outputStream.Close();
                    outputStream.Dispose();
                }
            

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader inputStream = new StreamReader(
                File.Open("ProductInfo.txt", FileMode.Open)))
                {
                 
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

                    inputStream.Close();
                    inputStream.Dispose();
                }

            }
            catch (IOException exception)
            {
                MessageBox.Show("Error:" + exception);
            }
        }
    }
    
}
