using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using prjGrow.Classes;

namespace prjGrow.Classes
{
    public class Manufacturing : Pos
    {
        public Common com = new Common();
        public clsDb db = new clsDb();

        public const string order_active = "Active", order_ready = "Ready", order_late = "Late", order_delivered = "Delivered";
        public const string col_id = "id", col_cus_id = "cus_id", col_cus_name = "Customer Name", col_prod_id = "prod_id", col_date = "Date", col_amount = "Amount";
        public const string col_progress = "Progress", col_prod_name = "Product Name", col_price = "Price", col_qty = "Quantity", col_advance = "Advance";
        public const string col_emp = "Employee", col_wage = "Wage", col_unit = "Unit", col_Item_price = "Price_", col_Item_qty = "Quantity_", col_Item_amount = "Amount_";
        public const string col_descrip = "Description", col_prod_code = "Product_Code";
    }
}