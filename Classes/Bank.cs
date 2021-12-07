using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjGrow.Classes
{
    public class Bank : Coa		//class Bank
    {
        public long id { get; set; }
        public string name { get; set; }
        public string bnk_acc_no { get; set; }
        public long balance { get; set; }
        
        Common common = new Common();
        Journal journal = new Journal();

        public bool saveBank()
        {
            acc_id = getNextAccId();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();		//begins the transaction
            try
            {
                db.query = "insert into bank(name, acc_no, acc_id, uid)" + sqlLine;
                db.query += "values('" + name + "','" + bnk_acc_no + "'," + acc_id + "," + User.curUid + ")";
                result = db.runQuery(tran);
                if (!result) { tran.Rollback(); return false; }

                result = saveCoa(tran, Constants.acc_assets, Constants.config_bank);
                if (!result) { tran.Rollback(); return false; }

                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                db.closeCon();
            }

            setMessage("Bank", "Saved");
            return result;
        }

        public bool updateBank()
        {
            acc_id = getAccId("Bank", this.id);		//to get accid
            
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "Update bank set " + Environment.NewLine;
                db.query += "name = '" + name + "', acc_no = '" + bnk_acc_no + "', uid = " + User.curUid + sqlLine;
                db.query += "where id = " + this.id;

                result = db.runQuery(tran);
                if (!result) { tran.Rollback(); return false; }

                updateAccName(tran);
                if (!result) { tran.Rollback(); return false; }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                db.closeCon();
            }
            
            setMessage("Bank", "Updated");
            return result;
        }

        public bool deleteBank()
        {
            acc_id = getAccId("Bank", this.id);

            if (haveEntries())
            {
                setMessage("Bank have Entries", Constants.message_warning);
                result = false;
                return result;
            }

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "Update bank set " + sqlLine;
                db.query += "status = " + Constants.status_deleted + sqlLine;
                db.query += "where id = " + this.id;

                result = db.runQuery(tran);
                if (!result) { tran.Rollback(); return false; }

                deleteAcc(tran);
                if (!result) { tran.Rollback(); return false; }

                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                db.closeCon();
            }
            
            setMessage("Bank", "Deleted");
            return result;
        }

        public DataTable getBanks()
        {
            db.query = "select id as [" + col_id + "],  acc_no as [" + col_acc_no + "], name as [" + col_bank + "]" + sqlLine;
            db.query += "from Bank" + sqlLine;
            db.query += "where status = " + Constants.status_active + sqlLine;
            db.query += "order by name";

            return db.getDataTable();
        }

        public DataTable getBankBalances()
        {
            db.query = "select b.id as [" + col_id + "], b.name as [" + col_bank + "], b.acc_no as [" + col_acc_no + "], c.dr - c.cr + isnull(sum(j.dr) - sum(j.cr), 0) as [" + col_balance + "]" + sqlLine;
            db.query += "from Bank b inner join Coa c on b.acc_id = c.id" + sqlLine;
            db.query += "left outer join Journal j on b.acc_id = j.acc_id" + sqlLine;
            db.query += "where b.status = " + Constants.status_active + " and (j.status = " + Constants.status_active + " or j.status is null)" + sqlLine;
            db.query += "group by b.id, b.name, b.acc_no, c.dr, c.cr" + Environment.NewLine;
            db.query += "order by name";
            
            return db.getDataTable();
        }

        public string bankAccNo(long Id)
        {
            db.query = "select acc_no from bank where id = " + Id + " and status = " + Constants.status_active;
            return db.readString();
        }

        public long getBalance(long Id)
        {
            acc_id = getAccId("Customer", Id);
            balance = journal.getAccBalance(acc_id, Constants.acc_assets);

            return balance;
        }
    }
}