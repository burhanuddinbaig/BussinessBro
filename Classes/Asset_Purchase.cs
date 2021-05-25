using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    class Asset_Purchase: Journal
    {
        public long id { get; set; }
        public long sup_id { get; set; }
        public long asset_id { get; set; }
        public string description { get; set; }
        public long quantity { get; set; }
        public long cost { get; set; }
        public long paid { get; set; }
        public long credit { get; set; }

        void getAccIds()
        {
            acc_id_cash = coa.getAccId(Constants.config_cash);
            acc_id_sup = coa.getAccId("Supplier", sup_id);
            acc_id_asset = coa.getAccId("Asset", asset_id);
        }

        public DataTable getAssetPur()
        {
            db.query = "select astPur.id as [" + col_id + "], astPur.sup_id as [" + col_sup_id + "], s.name as [" + col_sup_name + "]," + sqlLine;
            db.query += " astPur.asset_id as [" + col_asset_id + "],  a.assetName as [" + col_asset_name + "],  astPur.description as [" + col_descrip + "], astPur.date as [" + col_date + "], astPur.quantity as [" + col_qty + "], astPur.cost as [" + col_cost + "], " + sqlLine;
            db.query += "astPur.paid as [" + col_paid + "], astPur.credit as [" + col_credit + "]" + sqlLine;
            db.query += " from Asset a inner join  AssetPurchase astPur on a.id=astPur.asset_id LEFT OUTER JOIN Supplier s on astPur.sup_id=s.id " + sqlLine;
            db.query += " where astPur.status = " + Constants.status_active + " and a.status = " + Constants.status_active + sqlLine;
            db.query += " order by astPur.id desc" + sqlLine;

            return db.getDataTable();
        }

        public void saveAssetPurchase()
        {
            getAccIds();
            tran_id = getTranidNext();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into AssetPurchase (sup_id, date, asset_id, description, quantity, cost, paid, credit, uid, tran_id)" + sqlLine;
                db.query += "values(" + sup_id + ",'" + date + "'," + asset_id + ",'" + description + "', " + quantity + ", " + cost + ", " + paid + ", " + this.credit + ", " + User.curUid + ", " + tran_id + ")" + sqlLine;
                result = db.runQuery();

                if (result)
                    result = debit(tran, date, "Asset Purchased ", acc_id_asset, cost);              //debit to Asset

                if (result && paid > 0)
                    result = credit(tran, date, "From Cash acc", acc_id_cash, paid);          //credit to cash acc

                if (sup_id > 0 && result && (cost - paid) > 0)
                    result = credit(tran, date, "Credit on supplier", acc_id_sup, cost - paid);
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

                setMessage("Asset Purchased", "Saved");
            }
        }

        public void updateAssetPurchase()
        {
            getAccIds();
            tran_id = getTranid(id, "AssetPurchase");
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "Update AssetPurchase set" + sqlLine;
                db.query += "date = '" + date + "', sup_id = " + sup_id + ", asset_id = " + asset_id + ", description = '" + description + "', quantity = " + quantity + ", cost = " + cost + ", paid = " + paid + ", credit = " + this.credit + sqlLine;
                db.query += ", uid = " + User.curUid + sqlLine;
                db.query += "where tran_id = " + tran_id + sqlLine;

                result = db.runQuery();

                if (result)
                    result = deleteTransaction(tran);

                if (result)
                    result = debit(tran, date, "Asset Purchased ", acc_id_asset, cost);              //debit to Asset

                if (result && paid > 0)
                    result = credit(tran, date, "From Cash acc", acc_id_cash, paid);          //credit to cash acc

                if (sup_id > 0 && result && (cost - paid) > 0)
                    result = credit(tran, date, "Credit on supplier", acc_id_sup, cost - paid);
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

                setMessage("Asset Purchased", "Updated");
            }
        }

        public void deleteAssetPurchase()
        {
            getAccIds();
            tran_id = getTranid(id, "AssetPurchase");
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                result = deleteTransaction(tran, "AssetPurchase");
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

                setMessage("Asset Purchase", "Deleted");
            }
        }


    }
}
