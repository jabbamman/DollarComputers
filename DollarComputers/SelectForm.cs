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
            productSaveFileDialog.FileName = "ProductInfo";
            productSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            productSaveFileDialog.Filter = "Text Files(*.txt)*.txt | All Files (*.*)|*.*";

            var result = productSaveFileDialog.ShowDialog();
            if (result !=DialogResult.Cancel)
            {
                WritingProductToFile();
                Program.productInfoForm.Show();
                this.Hide();
            }
          

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

        private void productsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var _rowIndex = productsDataGridView.CurrentCell.RowIndex;
            var _rows = productsDataGridView.Rows;
            var _cells = _rows[_rowIndex].Cells;
            var _columnCount = productsDataGridView.ColumnCount;
            productsDataGridView.Rows[_rowIndex].Selected = true;
            string _outputstring = string.Empty;
            for (int index = 0; index < _columnCount; index++)
            {
                _outputstring += _cells[index].Value.ToString() + "   ";
                selectionLable.Text = _outputstring;
            }




            AddingFieldsToEnums(_cells);
        }

        private static void WritingProductToFile()
        {
            using (StreamWriter outputStream = new StreamWriter(File.Open("ProductInfo.txt", FileMode.Create)))
            {
                outputStream.WriteLine(Program.ProductInfoClass.ProductID);
                outputStream.WriteLine(Program.ProductInfoClass.Cost);
                outputStream.WriteLine(Program.ProductInfoClass.Manufacturer);
                outputStream.WriteLine(Program.ProductInfoClass.Model);
                outputStream.WriteLine(Program.ProductInfoClass.RamType);
                outputStream.WriteLine(Program.ProductInfoClass.RamSize);

                outputStream.WriteLine(Program.ProductInfoClass.DisplayType);
                outputStream.WriteLine(Program.ProductInfoClass.ScreenSize);
                outputStream.WriteLine(Program.ProductInfoClass.Resolution);
                outputStream.WriteLine(Program.ProductInfoClass.CPUClass);
                outputStream.WriteLine(Program.ProductInfoClass.CPUBrand);
                outputStream.WriteLine(Program.ProductInfoClass.Model);
                outputStream.WriteLine(Program.ProductInfoClass.CPUType);
                outputStream.WriteLine(Program.ProductInfoClass.CPUSpeed);


                outputStream.WriteLine(Program.ProductInfoClass.CPUNumber);
                outputStream.WriteLine(Program.ProductInfoClass.Condition);
                outputStream.WriteLine(Program.ProductInfoClass.OS);
                outputStream.WriteLine(Program.ProductInfoClass.Platform);
                outputStream.WriteLine(Program.ProductInfoClass.HDDSize);
                outputStream.WriteLine(Program.ProductInfoClass.HDDSpeed);
                outputStream.WriteLine(Program.ProductInfoClass.CPUType);
                outputStream.WriteLine(Program.ProductInfoClass.GPUType);


                outputStream.WriteLine(Program.ProductInfoClass.OpticalDrive);
                outputStream.WriteLine(Program.ProductInfoClass.AudioType);
                outputStream.WriteLine(Program.ProductInfoClass.LAN);
                outputStream.WriteLine(Program.ProductInfoClass.WIFI);
                outputStream.WriteLine(Program.ProductInfoClass.Width);


                outputStream.WriteLine(Program.ProductInfoClass.Height);
                outputStream.WriteLine(Program.ProductInfoClass.Depth);
                outputStream.WriteLine(Program.ProductInfoClass.Weight);
                outputStream.WriteLine(Program.ProductInfoClass.MouseType);
                outputStream.WriteLine(Program.ProductInfoClass.Power);
                outputStream.WriteLine(Program.ProductInfoClass.Webcam);

                outputStream.Close();
                outputStream.Dispose();
            }
        }

        private static void AddingFieldsToEnums(DataGridViewCellCollection _cells)
        {
            Program.ProductInfoClass.ProductID = int.Parse(_cells[(int)(ProductFields.ProductID)].Value.ToString());
            Program.ProductInfoClass.Cost = float.Parse(_cells[(int)(ProductFields.Cost)].Value.ToString());
            Program.ProductInfoClass.Manufacturer = _cells[(int)(ProductFields.Manufacturer)].Value.ToString();
            Program.ProductInfoClass.Model = _cells[(int)(ProductFields.Model)].Value.ToString();
            Program.ProductInfoClass.RamType = _cells[(int)(ProductFields.Ram_Type)].Value.ToString();
            Program.ProductInfoClass.RamSize = _cells[(int)(ProductFields.Ram_Size)].Value.ToString();

            Program.ProductInfoClass.DisplayType = _cells[(int)(ProductFields.Display_Type)].Value.ToString();
            Program.ProductInfoClass.ScreenSize = _cells[(int)(ProductFields.Screen_Size)].Value.ToString();
            Program.ProductInfoClass.Resolution = _cells[(int)(ProductFields.Resolution)].Value.ToString();
            Program.ProductInfoClass.CPUClass = _cells[(int)(ProductFields.CPU_Class)].Value.ToString();
            Program.ProductInfoClass.CPUBrand = _cells[(int)(ProductFields.CPU_Brand)].Value.ToString();
            Program.ProductInfoClass.Model = _cells[(int)(ProductFields.Model)].Value.ToString();
            Program.ProductInfoClass.CPUType = _cells[(int)(ProductFields.CPU_Type)].Value.ToString();
            Program.ProductInfoClass.CPUSpeed = _cells[(int)(ProductFields.CPU_Speed)].Value.ToString();


            Program.ProductInfoClass.CPUNumber = _cells[(int)(ProductFields.CPU_Number)].Value.ToString();
            Program.ProductInfoClass.Condition = _cells[(int)(ProductFields.Condition)].Value.ToString();
            Program.ProductInfoClass.OS = _cells[(int)(ProductFields.OS)].Value.ToString();
            Program.ProductInfoClass.Platform = _cells[(int)(ProductFields.Platform)].Value.ToString();
            Program.ProductInfoClass.HDDSize = _cells[(int)(ProductFields.HDD_Size)].Value.ToString();
            Program.ProductInfoClass.HDDSpeed = _cells[(int)(ProductFields.HDD_Speed)].Value.ToString();


            Program.ProductInfoClass.GPUType = _cells[(int)(ProductFields.GPU_Type)].Value.ToString();
            Program.ProductInfoClass.OpticalDrive = _cells[(int)(ProductFields.Optical_Drive)].Value.ToString();
            Program.ProductInfoClass.AudioType = _cells[(int)(ProductFields.Audio_Type)].Value.ToString();
            Program.ProductInfoClass.LAN = _cells[(int)(ProductFields.LAN)].Value.ToString();
            Program.ProductInfoClass.WIFI = _cells[(int)(ProductFields.WIFI)].Value.ToString();
            Program.ProductInfoClass.Width = _cells[(int)(ProductFields.Width)].Value.ToString();



            Program.ProductInfoClass.Height = _cells[(int)(ProductFields.Height)].Value.ToString();
            Program.ProductInfoClass.Depth = _cells[(int)(ProductFields.Depth)].Value.ToString();
            Program.ProductInfoClass.Weight = _cells[(int)(ProductFields.Weight)].Value.ToString();                
            Program.ProductInfoClass.MouseType = _cells[(int)(ProductFields.Mouse_Type)].Value.ToString();
            Program.ProductInfoClass.Power = _cells[(int)(ProductFields.Power)].Value.ToString();
            Program.ProductInfoClass.Webcam = _cells[(int)(ProductFields.Webcam)].Value.ToString();
        }


    }
}
