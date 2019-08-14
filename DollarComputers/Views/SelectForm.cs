using DollarComputers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
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

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide();
        }

        private void selectFormButton_Click(object sender, EventArgs e)
        {
            
        }

        private void productInfoButton_Click(object sender, EventArgs e)
        {
            if (selectionLable.Text =="")
            {
                MessageBox.Show("You did not select any product","Error");
            }
            else
            {
                Program.productInfoForm.Show();
                this.Hide();
            }
            
        }

        private void orderFormButton_Click(object sender, EventArgs e)
        {
            if (selectionLable.Text == "")
            {
                MessageBox.Show("You did not select any product", "Error");
            }
            else

            {
                Program.orderForm.Show();
                this.Hide();
            }
                
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Local Scope Alias 
            var rowIndex = productsDataGridView.CurrentCell.RowIndex;
            var rows = productsDataGridView.Rows;
            var columnCount = productsDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;
            rows[rowIndex].Selected = true;
            string outputstring = string.Empty;

            outputstring += cells[2].Value.ToString() + "   ";
            outputstring += cells[3].Value.ToString() + "   ";
            outputstring += cells[1].Value.ToString() + "   ";
            selectionLable.Text = outputstring;
            nextButton.Enabled = true;
            AddingFieldsToEnum(cells);

        









        }

        private static void AddingFieldsToEnum(DataGridViewCellCollection cells)
        {
            Program.product.productID = short.Parse(cells[(int)(ProductFields.PRODUCT_ID)].Value.ToString());
            Program.product.cost = decimal.Parse(cells[(int)(ProductFields.COST)].Value.ToString());
            Program.product.manufacturer = cells[(int)(ProductFields.MANUFACTURER)].Value.ToString();
            Program.product.model = cells[(int)(ProductFields.MODEL)].Value.ToString();
            Program.product.RAM_type = cells[(int)(ProductFields.RAM_TYPE)].Value.ToString();
            Program.product.RAM_size = cells[(int)(ProductFields.RAM_SIZE)].Value.ToString();

            Program.product.displaytype = cells[(int)(ProductFields.DISPLAY_TYPE)].Value.ToString();
            Program.product.screensize = cells[(int)(ProductFields.SCREEN_SIZE)].Value.ToString();
            Program.product.resolution = cells[(int)(ProductFields.RESOLUTION)].Value.ToString();
            Program.product.CPU_Class = cells[(int)(ProductFields.CPU_CLASS)].Value.ToString();
            Program.product.CPU_brand = cells[(int)(ProductFields.CPU_BRAND)].Value.ToString();
            Program.product.CPU_type = cells[(int)(ProductFields.CPU_TYPE)].Value.ToString();

            Program.product.CPU_speed = cells[(int)(ProductFields.CPU_SPEED)].Value.ToString();
            Program.product.CPU_number = cells[(int)(ProductFields.CPU_NUMBER)].Value.ToString();
            Program.product.condition = cells[(int)(ProductFields.CONDITION)].Value.ToString();
            Program.product.OS = cells[(int)(ProductFields.OS)].Value.ToString();
            Program.product.platform = cells[(int)(ProductFields.PLATFORM)].Value.ToString();
            Program.product.HDD_size = cells[(int)(ProductFields.HDD_SIZE)].Value.ToString();

            Program.product.HDD_speed = cells[(int)(ProductFields.HDD_SPEED)].Value.ToString();
            Program.product.GPU_Type = cells[(int)(ProductFields.GPU_TYPE)].Value.ToString();
            Program.product.optical_drive = cells[(int)(ProductFields.OPTICAL_DRIVE)].Value.ToString();
            Program.product.Audio_type = cells[(int)(ProductFields.AUDIO_TYPE)].Value.ToString();
            Program.product.LAN = cells[(int)(ProductFields.LAN)].Value.ToString();
            Program.product.WIFI = cells[(int)(ProductFields.WIFI)].Value.ToString();


            Program.product.width = cells[(int)(ProductFields.WIDTH)].Value.ToString();
            Program.product.height = cells[(int)(ProductFields.HEIGHT)].Value.ToString();
            Program.product.depth = cells[(int)(ProductFields.DEPTH)].Value.ToString();
            Program.product.weight = cells[(int)(ProductFields.WEIGHT)].Value.ToString();
            Program.product.moust_type = cells[(int)(ProductFields.MOUSE_TYPE)].Value.ToString();
            Program.product.power = cells[(int)(ProductFields.POWER)].Value.ToString();

            Program.product.webcam = cells[(int)(ProductFields.WEB_CAM)].Value.ToString();
        }

        private void HomePictureBox_Click(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide(); 
            
        }
    }
}
