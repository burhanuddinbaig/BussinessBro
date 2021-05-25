using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace prjGrow.Classes
{
    public class Gen: Pos
    {
        public clsDb db = new clsDb();

        public Common com = new Common();

        public const string col_id = "Id", col_auth_id = "Auth_id", col_auth_name = "Authority", col_pass = "password", col_user_name = "User Name", col_full_name = "Full Name", col_user_id = "User Id";
        public const string col_prod_type_id = "Type_Id", col_prod_type = "Product_Type", col_date = "Date", col_emp_id = "emp_id", col_emp_name = "Employee Name", col_status = "Status";
        public const string col_tbl_name = "Table_", col_real_price = "Real_Price", col_dist = "Discount";
        public const string col_prod_id = "Prod_Id", col_code = "Product_Code", col_prod_name = "Product_Name", col_cost = "Cost", col_whole = "Whole Price", col_cate = "Category", col_unit = "Unit";
        public const string col_retail = "Retail Price", col_price = "Price", col_flip_price = "Flip", col_stock = "Stock", col_qty = "Qty", col_amount = "Amount";
        public const string col_opening_stock = "Opening Stock", col_min_stock = "Minimum Stock", col_raw_id = "link_id", col_raw = "Raw";
        public const string col_veh_id = "veh_id", col_veh_name = "Vehicle_Name", col_plate_no = "Plate_no", col_term_id = "Term_id", col_frieght = "Frieght";
    }
}