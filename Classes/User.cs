using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace prjGrow.Classes
{
    public class User : Gen
    {
        public static bool login_success = false;

        public long id { get; set; }
        public string full_name { get; set; }
        public string user_name { get; set; }
        public string pass { get; set; }
        public short auth_id { get; set; }
        public string auth_name { get; set; }

        public static int curUid = 0;
        public static string curfullName = "";
        public static string curUserName = "";
        public static string curPass = "";
        public static short curAuth = 1;

        public DataTable getUsers()
        {
            db.query = "select u.id as [" + col_user_id + "], u.user_name  as [" + col_user_name + "], u.full_name  as [" + col_full_name + "]," + sqlLine;
            db.query += " a.id as [" + col_auth_id + "], a.auth_name as [" + col_auth_name + "]" + sqlLine;
            db.query += "from Users u inner join Authorities a on u.auth = a.id " + sqlLine;
            db.query += "where u.status = " + Constants.status_active + " and a.status = " + Constants.status_active + sqlLine;

            return db.getDataTable();
        }

        public DataTable getAuthorities()
        {
            db.query = "select id as [" + col_auth_id + "], auth_name as [" + col_auth_name + "]" + sqlLine;
            db.query += "from Authorities where status = " + Constants.status_active + " and auth_name not like'Developer'" + sqlLine;

            return db.getDataTable();
        }

        public void setUserInfo(long userName)
        {
            db.query = "Select id, full_name, user_name, pass, auth " + sqlLine;
            db.query += "from User" + sqlLine;
            db.query += "where user_name = " + userName + sqlLine;
            db.query += "and status = " + Constants.status_active + sqlLine;

            DataRow row = db.getDataTable().Rows[0];

            curUid = Convert.ToInt32(row["id"]);
            curUserName = row["user_name"].ToString();
            curfullName = row["full_name"].ToString();
            curPass = row["pass"].ToString();
            curAuth = Convert.ToInt16(row["auth"].ToString());
        }

        public void saveUser()
        {
            db.query = "insert into Users(user_name, full_name, pass, auth)" + sqlLine;
            db.query += "values('"+user_name+"','"+full_name+"','"+pass+"',"+auth_id+")" + sqlLine;

            result = db.runQuery();

            if (result)
            {
                msg = "New User added Successfully";
                msg_type = Constants.message_success;
            }
            else
            {
                msg = "User cannot be added";
                msg_type = Constants.message_error;
            }
        }

        public void delUser()
        {
            db.query = "Update Users set status = " + Constants.status_disabled + sqlLine;
            db.query += "where id = " + this.id + sqlLine;

            result = db.runQuery();
           
            if (result)
            {
                msg = "User Deleted Successfully";
                msg_type = Constants.message_success;
            }
            else
            {
                msg = "User cannot be Deleted";
                msg_type = Constants.message_error;
            }
        }

        public string getPassword(string userName)
        {
            db.query = "select pass from Users" + sqlLine;
            db.query += "where user_name = '"+userName+"'" + sqlLine;
            db.query += "and status = " + Constants.status_active + sqlLine;

            return db.readString();
        }

        public void changePassword()
        {
            db.query = "Update Users set pass = '" + pass + "'" + sqlLine;
            db.query += "where id = " + User.curUid + sqlLine;

            result = db.runQuery();
        }

        public void setData()
        {
            db.query = "Select id as [" + col_id + "],full_name as [" + col_full_name + "], pass as [" + col_pass + "],auth as [" + col_auth_id +"]" + sqlLine;
            db.query += "from Users where user_name = '" + user_name + "'" + sqlLine;
            db.query += "and status = " + Constants.status_active + sqlLine;

            DataRow row = db.getDataRow();

            curUid = Convert.ToInt32(row[col_id]);
            curUserName = user_name;
            curfullName = row[col_full_name].ToString();
            curPass = row[col_pass].ToString();
            curAuth = Convert.ToInt16(row[col_auth_id]);
        }

        public string[] getUserNames()
        {
            db.query = "select user_name from Users where status = " + Constants.status_active;
            DataTable tblTmp = db.getDataTable();
            int max = tblTmp.Rows.Count;
            string[] S = new string[max];
            for (int i = 0; i < max; i++)
            {
                S[i] = tblTmp.Rows[i]["user_name"].ToString();
            }

            return S;
        }
    }
}