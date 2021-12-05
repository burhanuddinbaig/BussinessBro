using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace prjGrow
{
    public class Constants : Pos
    {
//        public const string client_name = "Malik Steel Works";
        
        public const string bottom_label_general = "Shortcut Keys=> Save: Alt + S, Update: Alt + U, Clear: Alt + R, Close: Alt + C";

        public Color color = Color.FromArgb(1,138, 43, 226);


        public static bool multiple_forms = true;

        public const short module_product = 1;
//        public const short module_bank = 2;
//        public const short module_suplier = 3;
//        public const short module_customer = 4;
//        public const short module_employee = 5;
        public const short module_purchase = 6;
        public const short module_sale = 7;
        public const short module_damage = 8;
//        public const short module_stock = 9;
 //       public const short module_suplier_ledger = 10;
  //      public const short module_client_ledger = 11;
//        public const short module_employee_ledger = 12;
//        public const short module_bank_transaction = 13;

        public const short status_deleted = 0;
        public const short status_active = 1;
        public const short status_disabled = 2;

        public const short acc_assets = 1;
        public const short acc_libality = 2;
        public const short acc_capital = 3;
        public const short acc_income = 4;
        public const short acc_expense = 5;

        public const short message_info = 1;
        public const short message_error = 2;
        public const short message_success = 3;
        public const short message_warning = 4;

        public const short interval_message = 3000;

        //-------Account Configration-------------------
        public const short config_none = 0;
        public const short config_cash = 1;
        public const short config_sale = 3;
        public const short config_discount = 4;
        public const short config_bank = 5;
        public const short config_expense = 6;
        public const short config_income = 7;
        public const short config_customer = 8;
        public const short config_suplier = 9;
        public const short config_purchase = 10;
        public const short config_capital = 11;
        public const short config_employee = 12;
        public const short config_order = 13;
        public const short config_pur_discount = 14;
        public const short config_fixed_assets = 15;
        public const short config_goods_damage = 16;
        public const short config_comp = 17;
        public const short opening_balances = 18;
        public const short config_cheq_payment = 19;
        public const short config_cheq_recive = 20;
        public const short config_adv_order = 21;
        public const short config_frieght = 22;
        public const short config_salery = 23;
        //-----------------------------------------------

        public const string operation_save = "&Save";
        public const string operation_update = "&Update";
        public const string operation_edit = "Edit";
        public const string operation_delete = "Del";

        public const short cate_stock = 1;
        public const short cate_raw = 2;
        public const short cate_gadget = 3;
        public const short cate_mobile = 4;
        public const short cate_cake = 5;
        public const short cate_partial = 6;
        public const short cate_service = 7;

        public const short term_shop = 1;
        public const short term_store = 2;
        public const short term_order_queue = 3;
        public const short term_factory = 4;

        public const short cheq_pymnt = 1;
        public const short cheq_recive = 2;

        public const short cheq_status_pending = 1;
        public const short cheq_status_processed = 2;

        public const short auth_dev = 1;
        public const short auth_admin = 2;
        public const short auth_guest = 3;

        public const string btn_cnc = "Ca&ncel", btn_save = "&Save";

        public const short order_new = 1, order_factory = 2, order_ready = 3, order_display = 4, order_recieved = 8, order_delivered = 9;

        public const string code_bag_sm = "100001", code_bag_lg = "100002";
    }
}