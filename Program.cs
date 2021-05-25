using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using prjGrow.Users;
using prjGrow.Classes;

namespace prjGrow
{
    static class Program
    {
        ///<summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Accounts.frmCustomerTran());
        //    Application.Run(new StockInfo.frmSupplierOrders());
        //    Application.Run(new Reporting.frmShortStockRep());
        //    Application.Run(new General.frmEmp());
        //    Application.Run(new Manufacture.frmConsume());
        //    Application.Run(new Fnb.frmPlaceOrder());

            Application.Run(new frmlogin());
            if (User.login_success)
                Application.Run(new frmDashboard());
            else
                Application.Exit();
        }
    }
}