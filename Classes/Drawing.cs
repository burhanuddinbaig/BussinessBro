using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Drawing : Journal
    {
        public Int64 id { get; set; }
        public string remarks { get; set; }
        public Int64 invest { get; set; }
        public Int64 draw { get; set; }

        public Bank_ledger bnk = new Bank_ledger();

        void getAccIds()
        {
            acc_id_cash = coa.getAccId(Constants.config_cash);
            acc_id_bank = coa.getAccId("Bank", bnk_id);
            acc_id_draw = coa.getAccId(Constants.config_capital);
            acc_id_invest = coa.getAccId(Constants.config_capital);
        }

        public DataTable getDrawInvest()
        {
            db.query = "select id as [" + col_id + "], tran_id as [" + col_tran_id + "], date as [" + col_date + "], acc_id as [" + col_acc_id +"]," + sqlLine;
            db.query += "dr as [" + col_dr + "], cr as [" + col_cr + "], remarks as [" + col_remarks + "], bank_id as [" + col_bnk_id + "], bank_name as [" + col_bank + "]" + sqlLine;
            db.query += "from led_drawing" + sqlLine;

            return db.getDataTable();
        }

        public void saveDrawInvest()
        {
            getAccIds();

            tran_id = getTranidNext();
            bnk.tran_id = tran_id;
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Drawing(tran_id, remarks, uid)" + sqlLine;
                db.query += "values(" + tran_id + ",'" + remarks + "'," + User.curUid + ")" + sqlLine;

                result = db.runQuery();

                if (result && invest > 0)
                    result = credit(tran, date, "Investment", acc_id_invest, invest);
                else if (result && draw > 0)
                    result = debit(tran, date, "Drawing by Owner " + remarks, acc_id_draw, draw);

                if (result && bnk_id == 0)
                    result = entry(tran, date, "To cash by Capital " + remarks, acc_id_cash, invest, draw);
                else if (result && bnk_id > 0)
                {
                    result = entry(tran, date, "To Bank by Capital " + remarks, acc_id_bank, invest, draw);
                    if (result)
                        result = bnk.addBankLedger(tran);
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

                setMessage("Record","Saved");
            }
        }

        public void updDrawInvest()
        {
            getAccIds();

            bnk.tran_id = tran_id;
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update Drawing set" + sqlLine;
                db.query += "tran_id = " + tran_id + ", remarks = '" + remarks + "', uid = " + User.curUid + "" + sqlLine;
                db.query += "where id = " + this.id + sqlLine;

                result = db.runQuery();

                if (result)
                    deleteTransaction("Bank_ledger");

                if (result && invest > 0)
                    result = credit(tran, date, "Investment", acc_id_invest, invest);
                else if (result && draw > 0)
                    result = debit(tran, date, "Drawing by Owner", acc_id_draw, draw);

                if (result && bnk_id == 0)
                    result = entry(tran, date, "To cash by Capital", acc_id_cash, invest, draw);
                else if (result && bnk_id > 0)
                {
                    result = entry(tran, date, "To Bank by Capital", acc_id_bank, invest, draw);
                    if (result)
                        result = bnk.addBankLedger(tran);
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

                setMessage("Record", "Updated");
            }
        }
    }
}