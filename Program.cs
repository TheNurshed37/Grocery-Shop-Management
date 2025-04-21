using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegistrationForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Splash());
             Application.Run(new MessageForm());
            //Application.Run(new ProductSell());
            //Application.Run(new ProductSell());
            //Application.Run(new SellerForm());
            //Application.Run(new CustomerForm());
        }
    }
}
