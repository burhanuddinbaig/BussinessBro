using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    class Asset :Coa		//Assets
    {
        public long id { get; set; }
        public string assetName { get; set; }
        public string assetCode { get; set; }
        public Int32 assetType { get; set; }

        public DataTable getAssets()
        {
            db.query = "select id as [" + col_id + "], assetName as [" + col_asset_Name + "], assetCode as [" + col_asset_code + "], assetType as [" + col_asset_type + "]," + sqlLine;
            db.query += "acc_id as [" + col_acc_id + "] " + sqlLine;
            db.query += "from Asset" + sqlLine;
            db.query += "where status = " + Constants.status_active + sqlLine;

            return db.getDataTable();
        }

        public void saveAsset()
        {
            acc_id = getNextAccId();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "insert into Asset(assetName, assetCode, assetType, acc_id, uid)" + sqlLine;
                db.query += "values('" + assetName + "','" + assetCode + "'," + assetType + "," + acc_id + ", " + User.curUid + ")" + sqlLine;
                result = db.runQuery(tran);

                if (result)
                    result = saveCoa(tran, Constants.acc_assets, Constants.config_fixed_assets);
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

                setMessage("Asset", "Saved");
            }
        }
        public void updAsset()
        {
            acc_id = getAccId("Asset", this.id);
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update Asset set" + sqlLine;
                db.query += "assetName = '" + assetName + "', assetCode  = '" + assetCode + "'" + sqlLine;
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

                setMessage("Asset", "Updated");
            }
        }
        public void delSup()
        {
            acc_id = getAccId("Asset", this.id);

            if (haveEntries())
            {
                setMessage("Asset have Entries", Constants.message_warning);
                result = false;
                return;
            }
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update Asset set status = " + Constants.status_deleted + sqlLine;
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

                setMessage("Asset", "Deleted");
            }
        }

    }
}
