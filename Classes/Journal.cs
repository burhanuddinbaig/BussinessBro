using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Journal: Pos
    {
        public long id { get; set; }
        public long tran_id { get; set; }
        public DateTime date { get; set; }
        public string narration { get; set; }
        public long acc_id { get; set; }
        public long dr { get; set; }
        public long cr { get; set; }
        public string remarks { get; set; }
        public Int64 bnk_id { get; set; }

        public bool by_cheq = false;

        public DateTime sdate = new DateTime(), edate= new DateTime();

        public clsDb db = new clsDb();
        public Coa coa = new Coa();
        public Common com = new Common();

    //    public Bank_ledger bnk = new Bank_ledger();

        #region column_names

        public const string col_tran_id = "tran_id", col_dr = "Debit", col_cr = "Credit", col_acc_id = "Acc_id";
        public const string col_id = "Id", col_sno = "sno", col_issue_date = "Issue Date", col_reference = "Reference", col_cheq_no = "Cheque_No", col_sale_id = "Sale_Id", col_prod_id = "prod_id", col_qty = "Qty", col_qty_init = "qty_init", col_cost = "Cost";
        public const string col_retail = "Retail", col_whole = "Whole", col_sold = "Price", col_amount = "Amount", col_remarks = "Remarks", col_descrip = "Description";
        public const string col_prod_code = "Code", col_prod_name = "Product", col_date = "Date", col_stock = "Stock", col_price = "Price";
        public const string col_bnk_id = "bank_id", col_bank = "Bank", col_deposit = "Deposit", col_withdraw = "Withdraw", col_native = "Native";
        public const string col_sup_id = "sup_id", col_invoice = "Invoice", col_remain = "Remaining", col_paid = "Paid", col_discount = "Discount";
        public const string col_exp_id = "exp_id", col_type_id = "type_id", col_exp_type = "Expense Type", col_sup_name = "Supplier Name";
        public const string col_cus_id = "cus_id", col_cus_name = "Customer_Name", col_debit = "Debit", col_credit = "Credit";
        public const string col_emp_id = "emp_id", col_emp_name = "Employee_Name", col_progress = "Progress", col_prog_id = "prog_id";
        public const string col_inbnd_date = "indate", col_trem_id = "term_id", col_store = "Store", col_shop = "Shop";
        public const string col_order_no = "Order_no", col_target = "Target_Date", col_target_time = "Target_Time", col_advance = "Advance";
        public const string col_imei = "IMEI", col_Sr = "Sr. #", col_item_dist = "Discount_";
        public const string order_active = "Active", order_ready = "Ready", order_late = "Late", order_delivered = "Delivered";
        public const string col_wage = "Wage", col_unit = "Unit", col_Item_price = "Price_", col_Item_qty = "Quantity_", col_Item_amount = "Amount_";
        public const string col_asset_id = "asset_id", col_asset_name = "Asset";
        public const string col_tbl_id = "tbl_id", col_tbl_name = "Table_";
        public const string col_veh_id = "veh_id", col_frieght = "Frieght";
        public const string col_stk_a = "stk_a", col_stk_b = "stk_b", col_ready = "Ready", col_display = "Display", col_factory = "Factory";

        #endregion

        public long acc_id_sale = 0, acc_id_pur = 0, acc_id_sup = 0, acc_id_cus = 0, acc_id_bank = 0, acc_id_cash = 0, acc_id_exp = 0,
            acc_id_draw = 0, acc_id_invest = 0, acc_id_order = 0, acc_id_emp = 0, acc_id_sal = 0, acc_id_discount = 0, acc_id_asset = 0,
            acc_id_damage = 0, acc_id_comp = 0, acc_id_cheq = 0, acc_id_adv_order = 0, acc_id_freight = 0, acc_id_direct_cost = 0;

        public bool createTran(SqlTransaction tran, DateTime date)
        {
            acc_id = 0;
            this.date = date;
          //  this.narration = "Stock Damage";
            this.dr = 0;
            this.cr = 0;

            db.query = "Insert into Journal(tran_id, date, narration, acc_id,  dr, cr, uid)";
            db.query += " values(" + tran_id + ",'" + this.date + "','" + this.narration + "'," + acc_id + "," + dr + ", " + cr + "," + User.curUid + ")";

            return db.runQuery(tran);
        }

        public bool debit(SqlTransaction tran, DateTime date, string narration, long accId, long amount)
        {
            acc_id = accId;
            this.date = date;
            this.narration = narration;
            this.dr = amount;
            this.cr = 0;

            db.query = "Insert into Journal(tran_id, date, narration, acc_id,  dr, cr, uid)";
            db.query += " values(" + tran_id + ",'" + this.date + "','" + this.narration + "'," + acc_id + "," + dr + ", " + cr + "," + User.curUid + ")";

            return db.runQuery(tran);
        }

        public bool credit(SqlTransaction tran, DateTime date, string narration, long accId, long amount)
        {
            acc_id = accId;
            this.date = date;
            this.narration = narration;
            this.dr = 0;
            this.cr = amount;

            db.query = "Insert into Journal(tran_id, date, narration, acc_id,  dr, cr, uid)";
            db.query += " values(" + tran_id + ",'" + this.date + "','" + this.narration + "'," + acc_id + "," + dr + ", " + cr + "," + User.curUid + ")";

            return db.runQuery(tran);
        }

        public bool entry(SqlTransaction tran, DateTime date, string narration, long accId, long dr, long cr)
        {
            acc_id = accId;
            this.date = date;
            this.narration = narration;
            this.dr = dr;
            this.cr = cr;

            db.query = "Insert into Journal(tran_id, date, narration, acc_id,  dr, cr, uid)";
            db.query += " values(" + tran_id + ",'" + this.date + "','" + this.narration + "'," + acc_id + "," + dr + ", " + cr + "," + User.curUid + ")";

            return db.runQuery(tran);
        }

        public bool deleteTransaction(SqlTransaction tran)
        {
            db.query = "Update Journal set status = " + Constants.status_deleted + sqlLine;
            db.query += "where status = " + Constants.status_active + " and tran_id = " + tran_id ;

            return db.runQuery(tran);
        }

        public bool deleteTransaction(SqlTransaction tran, params string[] S)
        {
            try
            {
                foreach (string str in S)
                {
                    db.query = "Update " + str + " set status = " + Constants.status_deleted + sqlLine;
                    db.query += "where status = " + Constants.status_active + " and tran_id = " + tran_id;

                    db.runQuery(tran);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            db.query = "Update Journal set status = " + Constants.status_deleted + sqlLine;
            db.query += "where status = " + Constants.status_active + " and tran_id = " + tran_id;
            return db.runQuery(tran);
        }

        public void deleteTransaction(params string[] S)
        {
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "Update Journal set status = " + Constants.status_deleted + sqlLine;
                db.query += "where status = " + Constants.status_active + " and tran_id = " + tran_id;
                result = db.runQuery(tran);
                
                foreach (string str in S)
                {
                    db.query = "Update " + str + " set status = " + Constants.status_deleted + sqlLine;
                    db.query += "where status = " + Constants.status_active + " and tran_id = " + tran_id;
                    db.runQuery(tran);
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();
                db.closeCon();

                setMessage(S[0], "Deleted");
            }
        }

        public long getAccBalance(long accId, short accType)
        {
            if (accType == Constants.acc_assets)
            {
                db.query = "select c.dr - c.cr + sum(dr) - sum(cr) as bal ";
                db.query += "from Journal j inner join Coa c on j.acc_id = c.id" + sqlLine;
                db.query += "where id = " + accId + " and status = " + Constants.status_active + sqlLine;
                db.query += "group by c.id, c.dr, c.cr" + sqlLine;
            }
            else
            {
                db.query = "select sum(cr) - sum(dr) as bal from Journal where id = " + accId + " and status = " + Constants.status_active;
                db.query += "" + sqlLine;
                db.query += "" + sqlLine;
            }

            return db.readLong();
        }

        public long getTranidNext()
        {
            db.query = "select max(tran_id) from Journal";
            long res = db.readLong();
            return ++res;
        }

        public long getTranid(long Id, string entity = "Journal")
        {
            db.query = "select tran_id from " + entity + sqlLine;
            db.query += "where id = " + Id + " and " + entity + ".status = " + Constants.status_active;
            long res = db.readLong();
            return res;
        }

        public bool haveLinks(params string[] entities)
        {
            foreach(string entity in entities)
            {
                db.query = "select count(*) as A from " + entity + sqlLine;
                db.query += "where tran_id = " + tran_id + " and status = " + Constants.status_active + sqlLine;

                if (db.readInt() > 0)
                    return true;
            }

            return false;
        }
    }
}