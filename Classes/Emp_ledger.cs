using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Emp_ledger: Journal
    {
        public Int64 id { get; set; }
        public Int64 emp_id { get; set; }
        public string remarks { get; set; }
        public Int64 adv { get; set;}
        public Int64 aloc { get; set; }
        public Int64 paid { get; set; }
        public Int64 deduc { get; set; }
        public Int64 wage { get; set; }
        public Int64 bonus { get; set; }

        public Employee emp = new Employee();
        DataTable tblEmp = new DataTable();
        public DataTable tblLabour = new DataTable();

        void getAccIds()
        {
            acc_id_cash = coa.getAccId(Constants.config_cash);
            acc_id_sal = coa.getAccId(Constants.config_salery);
            acc_id_emp = coa.getAccId("Employee", emp_id);
        }
        public DataTable getEmpledger(Int64 empid)
        {
            db.query = "select id as " + col_id + ", emp_id as " + col_emp_id + ", date as " + col_date + ", name as " + col_emp_name + ", tran_id as " + col_tran_id + ", remarks as " + col_remarks + "" + sqlLine;
            db.query += ", acc_id as " + col_acc_id + ", dr as " + col_debit + ", cr as " + col_credit +  sqlLine;
            db.query += "from led_emp " + sqlLine;
            db.query += " where emp_id=" + empid + "" + sqlLine;
            return db.getDataTable();
        }
        public void savEmpledger()
        {
            getAccIds();
            tran_id = getTranidNext();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Emp_Ledger(emp_id, tran_id, remarks, uid)" + sqlLine;
                db.query += "values(" + emp_id + "," + tran_id + ",'" + remarks + "'," + User.curUid + ")" + sqlLine;

                result = db.runQuery(tran);
                if (result && adv > 0)
                {
                    narration = "Advance to employee " + narration;
                    debit(tran, date, narration, acc_id_emp, adv);
                    if (result)
                        credit(tran, date, narration, acc_id_cash, adv);
                }
                else if (result && deduc > 0)
                {
                    narration = "Employee salary deduction " + narration;
                    debit(tran, date, narration, acc_id_emp, deduc);
                    if (result)
                        credit(tran, date, narration, acc_id_sal, deduc);
                }
                else if (result && aloc > 0)
                {
                    narration = "Employee salary allocation " + narration;
                    debit(tran, date, narration, acc_id_sal, aloc);
                    if (result)
                        credit(tran, date, narration, acc_id_emp, aloc);
                }
                else if (result && paid > 0)
                {
                    narration = "Payment to employee " + narration;
                    debit(tran, date, narration, acc_id_emp, paid);
                    if (result)
                        credit(tran, date, narration, acc_id_cash, paid);
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

                setMessage("Employee Record", "Saved");
            }
        }
        public void upEmpledger()
        {
            getAccIds();
            tran_id = getTranid(id, "Emp_ledger");           
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {                
                db.query = "update Emp_Ledger set" + sqlLine;
                db.query += " emp_id=" + emp_id + ", tran_id=" + tran_id + ", remarks='" + remarks + "', uid=" + User.curUid + "" + sqlLine;
                db.query += "where id=" + this.id + sqlLine;

                result = db.runQuery(tran);
                if (result)
                    deleteTransaction(tran);
                if (result && adv > 0)
                {
                    narration = "Advance to employee";
                    debit(tran, date, narration, acc_id_emp, adv);
                    if (result)
                        credit(tran, date, narration, acc_id_cash, adv);
                }
                else if (result && deduc > 0)
                {
                    narration = "Employee salary deduction";
                    debit(tran, date, narration, acc_id_emp, deduc);
                    if (result)
                        credit(tran, date, narration, acc_id_sal, deduc);
                }
                else if (result && aloc > 0)
                {
                    narration = "Employee salary allocation";
                    debit(tran, date, narration, acc_id_sal, aloc);
                    if (result)
                        credit(tran, date, narration, acc_id_emp, aloc);
                }
                else if (result && paid > 0)
                {
                    narration = "Payment to employee";
                    debit(tran, date, narration, acc_id_emp, paid);
                    if (result)
                        credit(tran, date, narration, acc_id_cash, paid);
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

                setMessage("Employee Record", "Updated");
            }
        }
        public void allocateSalaries()
        {
            if (!com.sureOption("Do you want to allocate salaries to all employees"))
                return;
            tblEmp = emp.getEmps();


            foreach(DataRow row in tblEmp.Rows)
            {
                emp_id = Convert.ToInt64(row[Employee.col_id]);
                aloc = Convert.ToInt64(row[Employee.col_sal]);

                savEmpledger();
            }

        }
        public void delEmpledger()
        {
            getAccIds();
            tran_id = getTranid(id, "Emp_ledger");
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                    deleteTransaction(tran,"Emp_ledger");               
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

                setMessage("Employee Record", "Deleted");
            }
        }

        public bool saveWages(SqlTransaction tran)
        {
            
            foreach (DataRow row in tblLabour.Rows)
            {
                emp_id = Convert.ToInt64(row[col_emp_id].ToString());
                acc_id_emp = Convert.ToInt64(row[col_acc_id].ToString());
                wage = Convert.ToInt64(row[col_amount].ToString());

                db.query = "insert into Emp_ledger(emp_id, tran_id, remarks, uid)" + sqlLine;
                db.query += "values(" + emp_id + "," + tran_id + ",'Employee Wage'," + User.curUid + ")" + sqlLine;
                result = db.runQuery(tran);

                if (result)
                    result = debit(tran, date, "Employee wage", acc_id_emp, wage);

                if (result)
                    result = credit(tran, date, "Employee wage", acc_id_cash, wage);
            }
            return result;
        }

        public bool saveBonus(SqlTransaction tran, DataTable tblCart, long emp_id)
        {
            bonus = 0;
            long tmpReal = 0;
            long tmpPrice = 0;
            long tmpBonus = 0;
            
            foreach (DataRow row in tblCart.Rows)
            {
                tmpReal = Convert.ToInt64(row[Product.col_real_price]);
                tmpPrice = Convert.ToInt64(row[Product.col_price]);
                tmpBonus = (Convert.ToInt64(row[Product.col_qty]) * (tmpPrice - tmpReal))/2;
                bonus += tmpBonus > 0 ? tmpBonus : 0;
            }

            if (bonus > 0)
            {
                narration = "Bonus on Sale";
                db.query = "insert into Emp_ledger(emp_id, tran_id, remarks, uid)" + sqlLine;
                db.query += "values(" + emp_id + "," + tran_id + ",'Bonus on Sale'," + User.curUid + ")" + sqlLine;
                result = db.runQuery(tran);
                debit(tran, date, narration, acc_id_emp, bonus);
                if (result)
                    credit(tran, date, narration, acc_id_sal, bonus);
            }
            else
                result = true;
            return result;
        }
    }
}