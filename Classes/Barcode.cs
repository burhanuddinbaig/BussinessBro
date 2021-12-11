using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using CrystalDecisions.CrystalReports.Engine;
//using OnBarcode.Barcode.WinForms;
using System.Drawing;
//using OnBarcode.Barcode;
using System.Data.Common;

namespace prjGrow.Classes
{
    public class Barcode: Gen		//class barcode
    {
        public long prod_id { get; set; }
        public string prod_code { get; set; }
        public string prod_name { get; set; }
        public long qty { get; set; }
        public long price { get; set; }

        public Bitmap img;
//        Linear barcode = new Linear();
        
        public string curCode = "";

        public clsReports reps = new clsReports();

        public DataTable tblProd = new DataTable();
        public DataTable tblCodes = new DataTable();

        public void createTable()
        {
            DataColumn[] cols = new DataColumn[] {
                new DataColumn(Product.col_prod_id, typeof(long)),
                new DataColumn(Product.col_code, typeof(string)),
                new DataColumn(Product.col_prod_name, typeof(string)),
                new DataColumn(Product.col_qty, typeof(long)),
                new DataColumn(Product.col_price, typeof(long))
            };

            tblCodes.Columns.AddRange(cols);
        }


        public void getLastCode()
        {
            db.query = "select max(prod_code) as [" + Product.col_code + "]" + sqlLine;
            db.query += "from Product where len(prod_code) = 6" + sqlLine;

            curCode = db.readString();
            if (string.IsNullOrEmpty(curCode))
                curCode = "100000";
        }

        public void nextCode()
        {
            long tmp = Convert.ToInt64(curCode);
            ++tmp;
            curCode = tmp.ToString();
        }

  /*      public Bitmap generateBarcode(string str)
        {
 /           Linear barcode = new Linear();
            barcode.Type = BarcodeType.UPCA;
            barcode.BarcodeHeight = 16;
            barcode.Data = str;

            barcode.UOM = UnitOfMeasure.PIXEL;
            barcode.Resolution = 100;
            barcode.Rotate = Rotate.Rotate0;

            barcode.ShowText = true;
            barcode.TextFont = new Font("Arial", 8f, FontStyle.Regular);
            barcode.TextMargin = 6;

            Bitmap tmp = barcode.drawBarcode();
            return tmp;
        }*/

        public void addToTmp()
        {
            db.query = "truncate table tmp_codes" + sqlLine;
            db.runQuery();

            foreach (DataRow row in tblCodes.Rows)
            {
                prod_name = row[Product.col_prod_name].ToString();
                prod_code = row[Product.col_code].ToString();
                qty = Convert.ToInt64(row[Product.col_qty]);
                price = Convert.ToInt64(row[Product.col_price]);

                for (int i = 0; i < qty; i++)
                {
                    db.query = "insert into tmp_codes(prod_name, prod_code, price)" + sqlLine;
                    db.query += "values('" + prod_name + "','" + prod_code + "'," + price + ")" + sqlLine;
                    db.runQuery();
                }
            }

/*            DataAdapter dataAdapter = new DataAdapter("select * from Customer", db.getCon());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            //add a new column named "Barcode" to the DataSet, the new column data type is byte[]
            ds.Tables[0].Columns.Add(new DataColumn("Barcode", typeof(byte[])));
            Linear barcode = new Linear();
            barcode.Type = BarcodeType.CODE128;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                barcode.Data = (int)dr["CustomerId"] + "";
                byte[] imageData = barcode.drawBarcodeAsBytes();
                dr["Barcode"] = imageData;
            }
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(ds);
            this.crystalReportViewer1.ReportSource = rpt;
            aConnection.Close();*/
        }

        public void updateCodes()
        {
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                foreach (DataRow row in tblCodes.Rows)
                {
                    prod_id = Convert.ToInt64(row[Product.col_prod_id]);
                    prod_code = row[Product.col_code].ToString();
                    qty = Convert.ToInt64(row[Product.col_qty]);

                    db.query = "update Product set" + sqlLine;
                    db.query += "prod_code = '" + prod_code + "'" + sqlLine;
                    db.query += "where id = " + prod_id + sqlLine;
                    result = db.runQuery();
                    if (!result)
                        break;
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
                com.setMessage("Codes", "Generated");
                db.closeCon();
            }
        }

        public void print()
        {
            ReportDocument codes = reps.getReport("repCodesBar.rpt");
            codes.PrintToPrinter(new PrinterSettings(), new PageSettings(), false);
        }
    }
}