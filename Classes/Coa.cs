using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Coa : Pos		//COA
    {
        public long acc_id { get; set; }
        public int acc_code { get; set; }
        public long acc_no { get; set; }
        public string acc_name { get; set; }
        public short type { get; set; }
        public long parent_acc_id { get; set; }
        public short config { get; set; }
        public long balance { get; set; }
        public long drBal { get; set; }
        public long crBal { get; set; }

        public clsDb db = new clsDb();

        public const string col_acc_code = "Account Code", col_acc_no = "Account No", col_acc_name = "Account Name", col_type = "Account Type", col_name = "Name";
        public const string col_parent_id = "Parent Id", col_acc_parent = "Account Parent", col_config = "Config", col_acc_id = "Account_id", col_balance = "Balance";
        public const string col_id = "Id", col_sup_id = "sup_id", col_sup_name = "Supplier", col_contact = "Contact", col_adrs = "Address", col_cell = "Cell_no", col_cnic = "CNIC";
        public const string col_bnk_id = "bank_id", col_bank = "Bank", col_chassis = "Chassis no";
        public const string col_sal = "Salary", col_dr_bal = "Debit Balance", col_cr_bal = "Credit Balance";
        public const string col_asset_Name = "Asset Name", col_asset_code = "Asset Code", col_asset_type = "Asset Type";
        public const string col_sname = "S_Name", col_email = "Email", col_quote = "qoute";
        public const string col_jdate = "Joining", col_ldate = "Leaveing";

        public long acc_cus = 0, acc_sup = 0, acc_bank = 0, acc_emp = 0, acc_cash = 0;

        public int getAccId(string entity, long id)
        {
            db.query = "select acc_id from "+entity+" where id = " + id + " and status = " + Constants.status_active;
            int res = db.readInt();
            return res;
        }

        public long getAccId(short config)
        {
            db.query = "select id from coa where config = " + config + " and status = " + Constants.status_active;
            long res = db.readLong();
            return res;
        }

        public int getAccCode(short config)
        {
            db.query = "select acc_code from coa where config = " + config + " and status = " + Constants.status_active;
            int res = db.readInt();
            return res;
        }

        public long getNextAccId()
        {
            db.query = "select max(id) from coa";
            long res = db.readLong();
            return ++res;
        }

        public long getNextAccNo(int accCode)
        {
            db.query = "select max(acc_no) as accno from coa where acc_code = " + accCode;
            long res = db.readLong();
            return ++res;
        }

        public short getAccType(short accConfig)
        {
            db.query = "select type as tp from coa where config = " + accConfig;
            short res = db.readShort();
            return res;
        }

        public bool saveCoa( SqlTransaction tran, short accType, short config)
        {
            acc_code = getAccCode(config);
            acc_no = getNextAccNo(acc_code);
            type = accType;
            parent_acc_id = getAccId(config);
            this.config = config;

            db.query = "insert into Coa(acc_code, acc_no, acc_name, type, parent_acc_id, config, uid)" + Environment.NewLine;
            db.query += "values(" +acc_code +"," +acc_no +",'" + acc_name +"'," +type +"," +parent_acc_id +", 0," +User.curUid +")";

            return db.runQuery(tran);
        }

        public bool updateAccName(SqlTransaction tran)
        {
            db.query = "update coa set acc_name = '" + acc_name + "' where id = " + acc_id;

            return db.runQuery(tran);
        }

        public void deleteAcc(SqlTransaction tran)
        {
            db.query = "update coa set status = " + Constants.status_deleted + " where id = " + acc_id;

            result = db.runQuery(tran);
        }

        public void deleteAcc(string entity)    //acc_id must be set before deletion
        {
            if (haveEntries())
            {
                setMessage("Sorry " + entity + " have entries",Constants.message_warning);
                result = false;
                return;
            }
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "update " + entity + " set status = " + Constants.status_deleted + sqlLine;
                db.query += "where acc_id = " + acc_id + sqlLine;
                result = db.runQuery();

                if (result)
                    deleteAcc(tran);
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

                setMessage(entity,"Deleted");
            }
        }

        public DataTable getCoaData()
        {
            acc_cus = getAccId(Constants.config_customer);
            acc_sup = getAccId(Constants.config_suplier);
            acc_bank = getAccId(Constants.config_bank);
            acc_emp = getAccId(Constants.config_employee);
            acc_cash = getAccId(Constants.config_cash);

            db.query = "select id as [" + col_acc_id + "], acc_code as [" + col_acc_code + "], acc_no as [" + col_acc_no + "], acc_name as [" + col_acc_name + "], dr as [" + col_dr_bal + "], cr as [" + col_cr_bal + "]" + sqlLine;
            db.query += "from Coa" + sqlLine;
            db.query += "where status = " + Constants.status_active + sqlLine;
            db.query += "and (parent_acc_id in(" + acc_cus + "," + acc_sup + "," + acc_bank + ", " + acc_emp + ") or id in(" + acc_cash + "))" + sqlLine;
            db.query += "order by acc_code, acc_no" + sqlLine;

            return db.getDataTable();
        }

        public void updCoa()
        {
            db.query = "update coa" + sqlLine;
            db.query += "set dr = " + drBal + ", cr = " + crBal + "" + sqlLine;
            db.query += "where id = " + this.acc_id + sqlLine;

            result = db.runQuery();

            setMessage("Account","Updated");
        }

        public bool haveEntries()
        {
            db.query = "select count(*) as A from Journal" + sqlLine;
            db.query += "where acc_id = " + acc_id + " and status = " + Constants.status_active + sqlLine;

            return db.readInt() > 0;
        }
    }
}