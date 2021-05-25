using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Manufacture_accounts : Journal
    {
        public long id { get; set; }
        public long advance { get; set; }
        public long amount { get; set; }
        public long paid { get; set; }
        public long remain { get; set; }
        public long total { get; set; }

        public Bank_ledger bnk = new Bank_ledger();
        public Cus_ledger cus = new Cus_ledger();

        public void getAccIds()
        {
            if (advance > 0)
                acc_id_order = coa.getAccId(Constants.config_order);
            if (paid > 0 && bnk_id > 0)
                acc_id_bank = coa.getAccId("Bank", bnk_id);
            else if (paid > 0)
                acc_id_cash = coa.getAccId(Constants.config_cash);
            if(remain > 0)
                acc_id_cus = coa.getAccId("Customer", cus.cus_id);
        }

        public bool saveOrderTran(SqlTransaction tran)
        {
            if (bnk_id > 0)
            {
                bnk.tran_id = tran_id;
                bnk.dr = advance;
                result = bnk.addBankLedger(tran);
                if (result)
                    result = debit(tran, date, "to bank on advance on order", acc_id_bank, advance);
            }
            else
            {
                result = debit(tran, date, "to cash on advance on order", acc_id_cash, advance);
            }

            if (result && cus.cus_id > 0)
            {
                cus.tran_id = tran_id;
                cus.acc_id_cus = acc_id_cus;
                cus.date = date;
                cus.dr = total - advance;
                result = cus.addCusLedger(tran);
                if (result)
                    debit(tran, date, "customer remaining on order", acc_id_cus, total - advance);
            }

            if (result)
                result = credit(tran, date, "customer order", acc_id_order, total);

            return result;
        }
    }
}