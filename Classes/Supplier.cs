using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Supplier: Coa
    {
        public long id { get; set; }
        public string name { get; set; }
        public string contact { get; set; }
        public string cell { get; set; }
        public string adrs { get; set; }

        public DataTable getSupliers()
        {
            db.query = "select s.id as [" + col_id + "], s.name as [" + col_sup_name + "], s.contact as [" + col_contact + "], s.cell as [" + col_cell + "], s.adrs as [" + col_adrs + "]," + sqlLine;
            db.query += "co.cr - co.dr + isnull(sum(sl.cr) - sum(sl.dr), 0) as " + col_balance + ", s.acc_id as [" + col_acc_id + "] " + sqlLine;
            db.query += "from Supplier s inner join Coa co on s.acc_id = co.id" + sqlLine;
            db.query += "left outer join Sup_ledger sl on s.id = sl.sup_id" + sqlLine;
            db.query += "where s.status = " + Constants.status_active + " and (sl.status = " + Constants.status_active + " or sl.status is null) and co.status = " + Constants.status_active + sqlLine;
            db.query += "group by s.id, s.name, s.contact, s.cell, s.adrs, s.acc_id, co.dr, co.cr" + sqlLine;

            return db.getDataTable();
        }

        public long getSuplierBal(long supId)
        {
            acc_id = getAccId("Supplier", supId);

            db.query = "select dbo.getOpeningBal("+acc_id+",'"+DateTime.MaxValue+"') as a" + sqlLine;

            return db.readLong();
        }

        public void saveSup()
        {
            acc_id = getNextAccId();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "insert into Supplier(name, cell, contact, adrs, acc_id)" + sqlLine;
                db.query += "values('" + name + "','" + cell + "','" + contact + "','" + adrs + "'," + acc_id + ")" + sqlLine;
                result = db.runQuery(tran);
                
                if (result)
                    result = saveCoa(tran, Constants.acc_libality, Constants.config_suplier);
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

                setMessage( "Supplier", "Saved" );
            }
        }

        public void updSup()
        {
            acc_id = getAccId("Supplier",this.id);
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update Supplier set" + sqlLine;
                db.query += "name = '"+name+"', cell  = '"+cell+"', contact = '"+contact+"', adrs  = '"+adrs+"'" + sqlLine;
                db.query += "where id = " + this.id + sqlLine;

                result = db.runQuery();

                if (result)
                    updateAccName(tran);
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
                
                setMessage("Supplier", "Updated");
            }
        }

        public void delSup()
        {
            acc_id = getAccId("supplier",this.id);

            if (haveEntries())
            {
                setMessage("Supplier have Entries",Constants.message_warning);
                result = false;
                return;
            }
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update supplier set status = " + Constants.status_deleted + sqlLine;
                db.query += "where id = " + this.id + sqlLine;

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

                setMessage("Supplier", "Deleted");
            }
        }
    }
}