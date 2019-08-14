using DollarComputers.Models;
using DollarComputers.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>

/* Student Name: Mohamed A.Ali
 * Student ID: 301036444
 * Description: This is a Dollarcomputers sales aplication, contains of 
 * five forms: Spalsh - Start Form - Select Form - Product info form - order form
*/
/// </summary>
namespace DollarComputers
{
      static class Program
    {
        // Static members 
        public static SpalshForm spalshForm;
        public static OrderForm orderForm;
        public static ProductInfoForm productInfoForm;
        public static SelectForm selectForm;
        public static StartForm startForm;
        public static AboutBox aboutBox;
        public static Product product;
        
     

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Instantiate the forms 
            spalshForm = new SpalshForm();
            orderForm = new OrderForm();
            productInfoForm = new ProductInfoForm();
            selectForm = new SelectForm();
            startForm = new StartForm();
            aboutBox = new AboutBox();
            product = new Product();
            Application.Run(new SpalshForm());
        }
    }
}
