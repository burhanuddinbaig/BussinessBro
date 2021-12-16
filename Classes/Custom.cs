using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjGrow.Classes;
using System.Data;

namespace prjGrow.Classes
{
    public class Custom : Pos		//Custom
    {
        clsDb db = new clsDb();
        DataTable tblMod = null;

        public static bool largeScreen = false;
        public static string ip_adrs = /*"192.168.1.99";//*/".";
        public static long client_id_active = 2;
        public static string col_feat_id = "feat_id", col_status = "status";
        public static string col_full_name = "full_name", col_adrs = "address", col_cell = "cell", col_phone = "phone", col_email = "email", col_qoute = "qoute";
        string tmpStr = "";

        public void Customize()
        {
            db.query = "select c.feat_id as "+col_feat_id+", c.status as "+col_status+"" + sqlLine;
            db.query += "from Custom c" + sqlLine;
            db.query += "where c.client_id = " + client_id_active + sqlLine;
            db.query += "and c.status = " + Constants.status_active + sqlLine;
            db.query += "order by feat_id" + sqlLine;

            tblMod = db.getDataTable();
            DataRow[] tmpRow = null;

            tmpRow = tblMod.Select(col_feat_id + " = 1", "");
            mod_manufact = tmpRow.Length > 0;

            tmpRow = tblMod.Select(col_feat_id + " = 2", "");
            mod_bakers = tmpRow.Length > 0;

            tmpRow = tblMod.Select(col_feat_id + " = 3", "");
            fet_wsale = tmpRow.Length > 0;

            tmpRow = tblMod.Select(col_feat_id + " = 4", "");
            mod_mobile = tmpRow.Length > 0;

            tmpRow = tblMod.Select(col_feat_id + " = 5", "");
            mod_fnb = tmpRow.Length > 0;

            tmpRow = tblMod.Select(col_feat_id + " = 6", "");
            fet_bcode = tmpRow.Length > 0;

            tmpRow = tblMod.Select(col_feat_id + " = 7", "");
            fet_item_dist = tmpRow.Length > 0;

            tmpRow = tblMod.Select(col_feat_id + " = 8", "");
            fet_freight = tmpRow.Length > 0;

            tmpRow = tblMod.Select(col_feat_id + " = 9", "");
            fet_sup_order = tmpRow.Length > 0;

            db.query = "select full_name as "+col_full_name+", adrs as "+col_adrs+", cell as "+col_cell+", phone as "+col_phone+", email as "+col_email+", qoute as "+col_qoute+"" + sqlLine;
            db.query += "from Client where id = " + client_id_active + sqlLine;

            DataRow row = db.getDataRow();
            client_name = row[col_full_name].ToString();
            client_adrs = row[col_adrs].ToString();
            client_contact = row[col_cell].ToString() + ", " + row[col_phone].ToString();
            client_qoute = row[col_qoute].ToString() + "";
        }
    }
}