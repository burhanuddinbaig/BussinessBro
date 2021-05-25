using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjGrow
{
    public class Pos
    {
        public bool result = true;
        public string msg = "";
        public short msg_type = Constants.message_info;
        public string sqlLine = Environment.NewLine;

        //customized Modules
        public static bool mod_manufact = false, mod_bakers = false, mod_mobile = false, mod_fnb = false;

        //Customize Features
        public static bool fet_wsale = false, fet_bcode = false, fet_item_dist = false, fet_freight = false, fet_sup_order = false;

        public static string client_name = "";
        public static string client_adrs = "";
        public static string client_contact = "";
        public static string client_qoute = "";

        public void setMessage(string entity, string operation)
        {
            if (result)
            {
                msg = entity + " " + operation + " Successfully";
                msg_type = Constants.message_success;
            }
            else
            {
                msg = "Sorry, " + entity + " Cannot be " + operation;
                msg_type = Constants.message_error;
            }
        }

        public void setMessage(string _msg, short type)
        {
                msg = _msg;
                msg_type = type;
        }
    }
}