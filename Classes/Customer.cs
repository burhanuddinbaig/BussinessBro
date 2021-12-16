using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Customer: Coa			//Customer
    {
        public long id { get; set; }
        public string name { get; set; }
        public string contact { get; set; }
        public string adrs { get; set; }
        public string cnic { get; set; }
        public long balance { get; set; }
        public string chest_no { get; set; }
        
        Journal journal = new Journal();

        public DataTable getCustomers()
        {
            db.query = "select c.id as " + col_id + ", c.name as " + col_name + ", c.contact as [" + col_contact + "], c.cnic as [" + col_cnic + "], c.adrs as [" + col_adrs + "], c.chassis as [" + col_chassis + "]" + Environment.NewLine;
            db.query += ", co.dr - co.cr + (select isnull(sum(cl.dr) - sum(cl.cr), 0) as " + col_balance + " from Cus_ledger cl where c.id = cl.cus_id and cl.status = " + Constants.status_active + " ) as [" + col_balance + "]" + sqlLine;
            db.query += "from Customer c inner join Coa co on c.acc_id = co.id" + sqlLine;
            db.query += "left outer join Cus_ledger cl on c.id = cl.cus_id" + Environment.NewLine;
            db.query += "where c.status = " + Constants.status_active + " and (cl.status = " + Constants.status_active + " or cl.status is null) " + Environment.NewLine;
            db.query += "group by c.id, c.name , c.contact, c.cnic, c.adrs, co.dr, co.cr, c.chassis" + sqlLine;
            db.query += "order by name" + Environment.NewLine;

            return db.getDataTable();
        }

        public long getCustomerBalance(long Id)
        {
            acc_id = getAccId("Customer", Id);
            balance = journal.getAccBalance(acc_id, Constants.acc_assets);

            return balance;
        }

        public void saveCustomer()
        {
            acc_id = getNextAccId();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Customer(name, contact, cnic, adrs, acc_id, chassis, uid)" + sqlLine;
                db.query += "values('"+name+"','"+contact+"','"+cnic+"','"+adrs+"',"+acc_id+",'"+chest_no+"',"+User.curUid+")" + sqlLine;
                result = db.runQuery();

                if (result)
                    result = saveCoa(tran, Constants.acc_assets, Constants.config_customer);
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

                setMessage("Customer", "Saved");
            }
        }

        public void updateCustomer()
        {
            acc_id = getAccId("Customer", id);
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "Update Customer set" + sqlLine;
                db.query += "name = '" + name + "', contact  = '" + contact + "', cnic  = '" + cnic + "', adrs = '" + adrs + "', chassis = '" + chest_no + "'" + sqlLine;
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

                setMessage("Customer", "Updated");
            }
        }
    }
}