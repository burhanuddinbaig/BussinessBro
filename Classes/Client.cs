using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace prjGrow.Classes
{
  public  class Client:Coa
    {
      public int id { get; set; }
        public string full_name { get; set; }
        public string short_name { get; set; }
        public string adrs { get; set; }
        public string cell { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int status { get; set; }
        public string qoute { get; set; }
        public byte[] logo { get; set; }

        Common common = new Common();
        Journal journal = new Journal();
        public DataTable getClients()
        {
            db.query = @"SELECT id, full_name as " + Client.col_name + ", short_name as " + Client.col_sname + ", adrs as " + Client.col_adrs + ", cell as " + Client.col_cell + ", phone as " + Client.col_contact + ", email as " + Client.col_email + ", status, qoute as " + Client.col_quote + ", logo FROM Client";
            return db.getDataTable();
        }
        
        public bool saveClient()
        {
           db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Client(full_name, short_name, adrs, cell, phone, email, status, qoute, logo)" + sqlLine;
                db.query += "values('" + full_name + "','" + short_name + "','" + adrs + "','" + cell + "','" + phone + "','" + email + "'," + status + ",'" + qoute + "', " + logo + ")";
                result = db.runQuery();
              
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }
            finally
            {
                db.closeCon();
            }

            setMessage("Client Information", "Saved");
            return result;
        }

        public bool updateClient()
        {
          
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "Update client set " + Environment.NewLine;
                db.query += "full_name = '" + full_name + "', short_name= '" + short_name + "', adrs = " + adrs + ", cell =" + cell + ", phone =" + phone + ", email=" + email + ", status=" + status + ", qoute=" + qoute + ", logo=" + logo + "";
                db.query += "where id = " + this.id;

                result = db.runQuery();
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                db.closeCon();
            }

            setMessage("Client", "Updated");
            return result;
        }
        
        public bool deleteClient()
        {
            return false;
        }
    }
}