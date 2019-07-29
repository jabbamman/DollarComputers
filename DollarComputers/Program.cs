using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    /// <summary>
    /// Project Updates: 
    /// 22 JJuly 2019: Initial Commit .. Creating All The forms.
    /// 23 July 2019: Finishing The Design of The Forms and controls
    /// 25 July 2019: Connect the SelectForm to db.
    /// 
    /// </summary>



    static class Program
    {
        public static SpalshForm spalshForm;
        public static OrderForm orderForm;
        public static ProductInfoForm productInfoForm;
        public static SelectForm selectForm;
        public static StartForm startForm;
        public static AboutBox aboutBox;
        public static MainForm mainForm;
        public static ProductInfoClass ProductInfoClass;
     

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
            aboutBox = new AboutBox();
            mainForm = new MainForm();
            ProductInfoClass = new ProductInfoClass();
            Application.Run(new SpalshForm());
        }
    }
}
