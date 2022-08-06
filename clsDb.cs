using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow
{
    public class clsDb
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter adp = new SqlDataAdapter();
        public BindingSource bindSrc = new BindingSource();
        public SqlDataReader read;
        public string pathBackup = "";

        public string query = "";

        public void Connect()
        {
            con = new SqlConnection("Data Source=" + Custom.ip_adrs + ";Initial Catalog=dbGrow;User Id=sa;Password=123;Integrated Security=True");
            con.Open();
        }

        public SqlConnection getCon()		//returns connection object
        {
            return con;
        }

        public void closeCon()
        {
            con.Close();
        }

        public bool runQuery(bool openedCon = false)
        {
            int rowEffected = 0;
            bool result = false;

            if (!openedCon)
                Connect();
            cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            try
            {
                rowEffected = cmd.ExecuteNonQuery();
                result = true;
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }

            if (!openedCon)
                closeCon();
            return result;
        }

        public bool runQuery(SqlTransaction tran)
        {
            bool result = false;

            try
            {
                cmd = new SqlCommand(query, tran.Connection, tran);
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            return result;
        }

        public DataTable getDataTable()
        {
            bool b = runQuery();
            if (!b)
                return null;
            DataTable dtable = null;
            try
            {
                Connect();
                adp.SelectCommand = cmd;
                dtable = new DataTable();
                adp.Fill(dtable);
                bindSrc.DataSource = dtable;
                adp.Update(dtable);
                closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dtable;
        }

        public DataRow getDataRow()
        {
            bool b = runQuery();
            if (!b)
                return null;

            DataTable dtable = null;
            DataRow row = null;
            try
            {
                Connect();
                adp.SelectCommand = cmd;
                dtable = new DataTable();
                adp.Fill(dtable);
                bindSrc.DataSource = dtable;
                adp.Update(dtable);
                closeCon();

                row = dtable.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return row;
        }

        public int readInt()
        {
            int result = 0;
            try
            {
                Connect();
                runQuery(true);
                read = cmd.ExecuteReader();
                if (read.Depth < 0)
                    return 0;
                while (read.Read())
                {
                    result = read.GetInt32(0);
                    break;
                }
            }
            catch (Exception ex)
            {
                result = 0;
            }
            finally
            {
                closeCon();
            }
            return result;
        }

        public long calBal(DataTable tbl, string colA, string colB)
        {
            object res = tbl.Compute("sum(" + colA + ") - sum(" + colB + ")", "");
            long bal = res.GetType() == typeof(DBNull) ? 0 : Convert.ToInt64(res);
            
            return bal;
        }

        public long calBal(DataTable tbl, string colA, string colB, long acc_id, bool asset)
        {
            object res = tbl.Compute("sum(" + colA + ") - sum(" + colB + ")", "");
            long bal = res.GetType() == typeof(DBNull) ? 0 : Convert.ToInt64(res);

            return bal;
        }

        public short readShort()
        {
            short result = 0;
            try
            {
                Connect();
                runQuery(true);
                read = cmd.ExecuteReader();
                if (read.Depth < 0)
                    return 0;
                while (read.Read())
                {
                    result = read.GetInt16(0);
                    break;
                }
                closeCon();
            }
            catch (Exception ex)
            {
                result = 0;
            }
            return result;
        }

        public long readLong()
        {
            long result = 0;
            try
            {
                Connect();
                runQuery(true);
                read = cmd.ExecuteReader();
                if (read.Depth < 0)
                    return 0;
                while (read.Read())
                {
                    result = read.GetInt64(0);
                    break;
                }
                closeCon();
            }
            catch (Exception ex)
            {
                result = 0;
            }
            return result;
        }

        public string readString()
        {
            string result = "";
            try
            {
                Connect();
                runQuery(true);
                read = cmd.ExecuteReader();
                if (read.Depth < 0)
                    return "";
                while (read.Read())
                {
                    result = read.GetString(0);
                    break;
                }
                closeCon();
            }
            catch (Exception ex)
            {
                result = "";
            }
            return result;
        }
        
        public double readDouble(string _query)
        {
            double result = 0;
            try
            {
                Connect();
                runQuery(true);
                read = cmd.ExecuteReader();
                if (read.Depth < 0)
                {
                    result = 0;
                }
                while (read.Read())
                {
                    result = read.GetDouble(0);
                    break;
                }
                closeCon();
            }
            catch (InvalidCastException)
            {
                result = 0;
            }
            catch (Exception ex)
            {
                result = 0;
            }
            return result;
        }

        public bool deleteTran(SqlTransaction tran, string entity, long tranId)
        {
            query = "update " + entity + " set status = " + Constants.status_deleted + " where tran_id = " + tranId;

            return runQuery(tran);
        }

        public bool deleteHead(SqlTransaction tran, string entity, long acc_id)
        {
            return true;
        }

        public bool delete(SqlTransaction tran, string entity, long id)
        {
            return true;
        }

        public long getNextId(string entity)
        {
            long id = 0;
            query = "select max(id) as a from " + entity;
            id = readLong();
            return ++id;
        }

        public long getLastId(string entity)
        {
            long id = 0;
            query = "select max(id) as a from " + entity;
            id = readLong();
            return id;
        }

        public int getNextId(string entity, string attribute)
        {
            int res = 0;
            query = "select max(" + attribute + ") as a from " + entity;
            res = readInt();
            return ++res;
        }

        public bool dbBackup()
        {
            string database = "";
            bool result = false;
            try
            {
                Connect();
                database = con.Database.ToString();
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + pathBackup + "" + database + ".bak'";
                using (SqlCommand command = new SqlCommand(cmd, con))
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    command.ExecuteNonQuery();
                }
                result = true;
            }
            catch(Exception ex)
            {
                result = false;
            }
            finally
            {
                closeCon();
            }
            return result;
        }

        public bool dataExist(string tblName, string[] cols, char[] oper, string[] vals)
        {
            if (cols.Length != vals.Length && cols.Length != oper.Length)
                return false;
            bool res = false;

            query = "select id from " + tblName + " WHERE " + Environment.NewLine;

            for (int i = 0; i < cols.Length; i++)
            {
                query += cols[i] + oper[i] + vals[i] + " and " + Environment.NewLine;
            }

            query += "status = " + Constants.status_active;
            res = getDataTable().Rows.Count > 0;
            return res;
        }

        public bool dataExistIMEIs(string pid, string ime)
        {
            bool res = false;
            query = @"SELECT     prod_id, imei, SUM(dr) AS SumOfdr, SUM(cr) AS SumOfcr, status
                    FROM         IMEI
                    GROUP BY imei, status, prod_id
                    HAVING      (SUM(dr) > SUM(cr)) AND (prod_id=" + pid + ") AND (imei = N'" + ime + "')  AND (status = " + Constants.status_active + ") ";
            res = getDataTable().Rows.Count > 0;
            return res;
        }
    }
}