using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    static class Program
    {
        public static SpalshForm spalshForm;
        public static OrderForm orderForm;
        public static ProductInfoForm productInfoForm;
        public static SelectForm selectForm;
        public static StartForm startForm;
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            spalshForm = new SpalshForm();
            orderForm = new OrderForm();
            productInfoForm = new ProductInfoForm();
            selectForm = new SelectForm();
            startForm = new StartForm();
            Application.Run(new SpalshForm());
        }
    }
}
