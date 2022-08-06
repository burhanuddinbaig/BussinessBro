using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Timers;
using prjGrow.Classes;

namespace prjGrow
{
    public class Common: Pos		//Common Class with common functions
    {
        clsDb db = new clsDb();
        public DateTime sdate = new DateTime(), edate = new DateTime();

        public bool delOption(string entity)
        {
            bool res = sureOption("Do you want to delete a " + entity);
            return res;
        }
        public bool sureOption(string userMessage)
        {
            DialogResult res = MessageBox.Show(userMessage, "Are You Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                return false;
            else
                return true;
        }
        public bool chkNull(Control cnt)
        {
            return string.IsNullOrEmpty(cnt.Text);
        }
        public bool chkNull(Control cnt, string cntName)
        {
            if (cnt.Text == "")
            {
                msg = "Please Enter " + cntName;
                msg_type = Constants.message_info;
                cnt.Focus();
                return false;
            }
            return true;
        }
        public bool chkPass(TextBox txt)
        {
            if (txt.Text.Length < 4)
            {
                msg = "Password Must be of minimum 4 charactors";
                msg_type = Constants.message_info;
                txt.Focus();
                return false;
            }
            return true;
        }
        public bool chkNull(Control cnt, string cntName, bool showMessageIfNull)
        {
            if (cnt.Text == "")
            {
                if (showMessageIfNull)
                {
                    msg = "Please Enter " + cntName;
                    msg_type = Constants.message_info;
                }
                cnt.Focus();
                return false;
            }
            return true;
        }
        public bool chkCombo(ComboBox cmb)      //returns true if is not empty
        {
            int i = cmb.SelectedIndex;
            if (i < 0)
            {
                return false;
            }
            return true;
        }
        public bool chkCombo(ComboBox cmb, string cntName)
        {
            int i = cmb.SelectedIndex;
            if (i < 0)
            {
                msg = "Please Select any " + cntName;
                msg_type = Constants.message_info;
                cmb.Focus();
                return false;
            }
            return true;
        }
        public bool chkNum(NumericUpDown num)		//Checks a num up down is empty or not
        {
            if (num.Value == num.Minimum)
            {
                num.Focus();
                return false;
            }
            return true;
        }
        public bool chkNum(NumericUpDown num, string cntName)
        {
            if (num.Value == num.Minimum)
            {
                msg = "Please Enter " + cntName;
                msg_type = Constants.message_info;
                num.Focus();
                return false;
            }
            return true;
        }
        public bool chkNum(string cntNames, params NumericUpDown[] num)
        {
            if(num.ToArray().Count() == 2)
            {
                if (num[0].Value == num[0].Minimum && num[1].Value == num[1].Minimum)
                {
                    msg = "Please Enter " + cntNames;
                    msg_type = Constants.message_info;
                    num[0].Focus();
                    return false;
                }
            }
            else if (num.ToArray().Count() == 3)
            {
                if (num[0].Value == num[0].Minimum && num[1].Value == num[1].Minimum && num[2].Value == num[2].Minimum)
                {
                    msg = "Please Enter " + cntNames;
                    msg_type = Constants.message_info;
                    num[0].Focus();
                    return false;
                }
            }
            return true;
        }
        public bool chkMtb(MaskedTextBox mtb, string cntName)
        {
            if (mtb.Text.Contains("_"))
            {
                msg = "Please Enter valid " + cntName;
                msg_type = Constants.message_info;
                mtb.Focus();
                return false;
            }
            else
                return true;
        }
        public bool chkTbl(DataTable tbl, string tblName)
        {
            result = true;
            if (tbl == null)
                result = false;
            else if (tbl.Rows.Count <= 0)
                result = false;
            if (!result)
            {
                msg = tblName + " is Empty";
                msg_type = Constants.message_info;
            }
            return result;
        }
        public static void isAlphabet(KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar)) && (!Char.IsDigit(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar))))
            {
                e.Handled = true;
            }
        }
        public static void isNumeric(KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar))))
            {
                e.Handled = true;
            }
        }
        public static void isEmail(KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar)) && (!Char.IsDigit(e.KeyChar) && (!Char.IsWhiteSpace(e.KeyChar)) && (!Char.IsControl(e.KeyChar))) && (e.KeyChar != 46) && e.KeyChar != 64 && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }
        public static void isAlphaNumeric(KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar)) && (!Char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true;
            }
        }
        public bool chkValid(Control[] C, string[] Name)
        {
            if (C.Length != Name.Length)
            {
                return false;
            }

            bool res = true;

            for (int i = 0; i < C.Length; i++)
            {
                string cntType = C[i].GetType().ToString();
                string cntName = Name[i];
                if (cntType.Equals("System.Windows.Forms.TextBox"))
                {
                    if (!chkNull((TextBox)C[i], cntName))
                    {
                        res = false;
                        break;
                    }
                }
                else if (cntType.Equals("System.Windows.Forms.DateTimePicker"))
                {
                    if (!chkNull(C[i], cntName))
                    {
                        res = false;
                        break;
                    }
                }
                else if (cntType.Equals("System.Windows.Forms.ComboBox"))
                {
                    if (!chkCombo((ComboBox)C[i], cntName))
                    {
                        res = false;
                        break;
                    }
                }
                else if (cntType.Equals("System.Windows.Forms.NumericUpDown"))
                {
                    if (!chkNum((NumericUpDown)C[i], cntName))
                    {
                        res = false;
                        break;
                    }
                }
                else if (cntType.Equals("System.Windows.Forms.MaskedTextBox"))
                {
                    if (!chkMtb((MaskedTextBox)C[i], cntName))
                    {
                        res = false;
                        break;
                    }
                }
                else
                {
                    //msg("Unknown Control");
                }
            }
            return res;
        }
        public bool chkValid(Control[] C, string[] Name, Label lbl, System.Windows.Forms.Timer tmr)
        {
            if (C.Length != Name.Length)
            {
                return false;
            }

            bool res = true;

            for (int i = 0; i < C.Length; i++)
            {
                string cntType = C[i].GetType().ToString();
                string cntName = Name[i];
                if (cntType.Equals("System.Windows.Forms.TextBox"))
                {
                    if (!chkNull((TextBox)C[i], cntName))
                    {
                        res = false;
                        break;
                    }
                }
                else if (cntType.Equals("System.Windows.Forms.DateTimePicker"))
                {
                    if (!chkNull(C[i], cntName))
                    {
                        res = false;
                        break;
                    }
                }
                else if (cntType.Equals("System.Windows.Forms.ComboBox"))
                {
                    if (!chkCombo((ComboBox)C[i], cntName))
                    {
                        res = false;
                        break;
                    }
                }
                else if (cntType.Equals("System.Windows.Forms.NumericUpDown"))
                {
                    if (!chkNum((NumericUpDown)C[i], cntName))
                    {
                        res = false;
                        break;
                    }
                }
                else if (cntType.Equals("System.Windows.Forms.MaskedTextBox"))
                {
                    if (!chkMtb((MaskedTextBox)C[i], cntName))
                    {
                        res = false;
                        break;
                    }
                }
                else
                {
                    //msg("Unknown Control");
                }
            }
            if (!res)
            {
                tmr.Start();
                showMessage(msg,lbl, Constants.message_info);
            }
            return res;
        }
        public void clearForm(Form frm, bool clrGrid = false)
        {
            foreach (Control C in frm.Controls)
            {
                string cntType = C.GetType().ToString();
                if (cntType.Equals("System.Windows.Forms.TextBox") || cntType.Equals("System.Windows.Forms.ComboBox") ||
                     cntType.Equals("System.Windows.Forms.DateTimePicker") || cntType.Equals("System.Windows.Forms.MaskedTextBox"))
                {
                    C.ResetText();
                }
                else if (cntType.Equals("System.Windows.Forms.NumericUpDown"))
                {
                    NumericUpDown num = new NumericUpDown();
                    num.Value = num.Minimum;
                }
                else if (cntType.Equals("System.Windows.Forms.CheckBox"))
                {
                    CheckBox c = (CheckBox)C;
                    c.Checked = false;
                }
                else if (cntType.Equals("System.Windows.Forms.RadioButton"))
                {
                    C.Select();
                }
                else if (cntType.Equals("System.Windows.Forms.DataGridView"))
                {
                    if (clrGrid)
                    {
                        DataGridView dgv = (DataGridView)C;
                        dgv.DataSource = null;
                        dgv.ColumnCount = 0;
                    }
                }
                else if (cntType.Equals("System.Windows.Forms.GroupBox"))
                {
                    GroupBox GB = (GroupBox)C;
                    foreach (Control Cnt in GB.Controls)
                    {

                        cntType = Cnt.GetType().ToString();
                        if (cntType.Equals("System.Windows.Forms.TextBox") || cntType.Equals("System.Windows.Forms.ComboBox") ||
                            cntType.Equals("System.Windows.Forms.NumericUpDown") || cntType.Equals("System.Windows.Forms.DateTimePicker") ||
                            cntType.Equals("System.Windows.Forms.MaskedTextBox"))
                        {
                            Cnt.ResetText();
                        }
                        else if (cntType.Equals("System.Windows.Forms.CheckBox"))
                        {
                            CheckBox c = (CheckBox)Cnt;
                            c.Checked = false;
                        }
                        else if (cntType.Equals("System.Windows.Forms.RadioButton"))
                        {
                            Cnt.Select();
                        }
                        else if (cntType.Equals("System.Windows.Forms.DataGridView"))
                        {
                            DataGridView dgv = (DataGridView)Cnt;
                            dgv.DataSource = null;
                            dgv.ColumnCount = 0;
                        }
                    }
                }
                else if (cntType.Equals("System.Windows.Forms.Panel"))
                {

                }
            }
        }
        public void clearContainer(Control cont)
        {
            foreach (Control Cnt in cont.Controls)
            {
                string cntType = Cnt.GetType().ToString();
                if (cntType.Equals("System.Windows.Forms.TextBox") || cntType.Equals("System.Windows.Forms.ComboBox") ||
                    cntType.Equals("System.Windows.Forms.NumericUpDown") || cntType.Equals("System.Windows.Forms.DateTimePicker") ||
                    cntType.Equals("System.Windows.Forms.MaskedTextBox"))
                {
                    Cnt.ResetText();
                }
                else if (cntType.Equals("System.Windows.Forms.CheckBox"))
                {
                    CheckBox c = (CheckBox)Cnt;
                    c.Checked = false;
                }
                else if (cntType.Equals("System.Windows.Forms.RadioButton"))
                {
                    Cnt.Select();
                }
                else if (cntType.Equals("System.Windows.Forms.DataGridView"))
                {
                    DataGridView dgv = (DataGridView)Cnt;
                    dgv.DataSource = null;
                    dgv.ColumnCount = 0;
                }
            }
        }
        public void clearControls(Control[] C)
        {
            for (int i = 0; i < C.Length; i++)
            {
                string cntname = C[i].GetType().ToString();
                if (cntname.Equals("System.Windows.Forms.TextBox") || cntname.Equals("System.Windows.Forms.ComboBox") ||
                     cntname.Equals("System.Windows.Forms.DateTimePicker") || cntname.Equals("System.Windows.Forms.MaskedTextBox"))
                {
                    C[i].ResetText();
                }
                else if(cntname.Equals("System.Windows.Forms.NumericUpDown"))
                {
                    NumericUpDown num = (NumericUpDown)C[i];
                    if (num.Minimum < 0)
                        num.Value = 0;
                    else
                        num.Value = num.Minimum;
                }
                else if (cntname.Equals("System.Windows.Forms.CheckBox"))
                {
                    CheckBox c = (CheckBox)C[i];
                    c.Checked = false;
                }
                else if (cntname.Equals("System.Windows.Forms.RadioButton"))
                {
                    C[i].Select();
                }
                else if (cntname.Equals("System.Windows.Forms.Label"))
                {
                    C[i].Text = "";
                }
            }
        }
        public void clearControls(Control[] C, Control cntFocus, Button btn)
        {
            for (int i = 0; i < C.Length; i++)
            {
                string cntname = C[i].GetType().ToString();
                if (cntname.Equals("System.Windows.Forms.TextBox") || cntname.Equals("System.Windows.Forms.ComboBox") ||
                     cntname.Equals("System.Windows.Forms.DateTimePicker") || cntname.Equals("System.Windows.Forms.MaskedTextBox"))
                {
                    C[i].ResetText();
                }
                else if (cntname.Equals("System.Windows.Forms.NumericUpDown"))
                {
                    NumericUpDown num = (NumericUpDown)C[i];
                    if (num.Minimum < 0)
                        num.Value = 0;
                    else
                        num.Value = num.Minimum;
                }
                else if (cntname.Equals("System.Windows.Forms.CheckBox"))
                {
                    CheckBox c = (CheckBox)C[i];
                    c.Checked = false;
                }
                else if (cntname.Equals("System.Windows.Forms.RadioButton"))
                {
                    C[i].Select();
                }
                else if (cntname.Equals("System.Windows.Forms.Label"))
                {
                    C[i].Text = "";
                }
            }

            if(cntFocus != null)
                cntFocus.Focus();
            if (btn != null)
                btn.Text = "&Save";
        }
        public bool chkNullValueInGrid(DataGridViewCell cell)
        {
            if (cell.Value.GetType().ToString() == "System.DBNull")
                return false;
            else
                return true;
        }
        public void showMessage(string message, Label lblMsg, short messageType)
        {
            if (string.IsNullOrEmpty(message))
                return;
            lblMsg.Show();
            lblMsg.ForeColor = Color.White;
            lblMsg.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            switch (messageType)
            {
                case Constants.message_info:
                    message = "Info: " + message;
                    lblMsg.BackColor = Color.Goldenrod;
                    break;
                case Constants.message_success:
                    message = "Message: " + message;
                    lblMsg.BackColor = Color.ForestGreen;
                    break;
                case Constants.message_error:
                    message = "Error: " + message;
                    lblMsg.BackColor = Color.IndianRed;
                    break;
                case Constants.message_warning:
                    message = "Warning: " + message;
                    lblMsg.BackColor = Color.Orange;
                    break;
            }
            lblMsg.Text = message;
        }
        public void showMessage( string message, Label lblMsg, short messageType, System.Windows.Forms.Timer tmr)
        {
            if (string.IsNullOrEmpty(message))
                return;
            lblMsg.Show();
            lblMsg.ForeColor = Color.White;
            lblMsg.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            switch (messageType)
            {
                case Constants.message_info:
                    message = "Info: " + message;
                    lblMsg.BackColor = Color.Goldenrod;
                    break;
                case Constants.message_success:
                    message = "Message: " + message;
                    lblMsg.BackColor = Color.ForestGreen;
                    break;
                case Constants.message_error:
                    message = "Error: " + message;
                    lblMsg.BackColor = Color.IndianRed;
                    break;
                case Constants.message_warning:
                    message = "Warning: " + message;
                    lblMsg.BackColor = Color.Orange;
                    break;
            }
            lblMsg.Text = message;
            tmr.Start();
        }
        public void showMessage( Label lblMsg, System.Windows.Forms.Timer tmr )
        {
            lblMsg.Show();
            lblMsg.ForeColor = Color.White;
            lblMsg.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            switch (msg_type)
            {
                case Constants.message_info:
                    msg = "Info: " + msg;
                    lblMsg.BackColor = Color.Goldenrod;
                    break;
                case Constants.message_success:
                    msg = "Message: " + msg;
                    lblMsg.BackColor = Color.ForestGreen;
                    break;
                case Constants.message_error:
                    msg = "Error: " + msg;
                    lblMsg.BackColor = Color.IndianRed;
                    break;
                case Constants.message_warning:
                    msg = "Warning: " + msg;
                    lblMsg.BackColor = Color.Orange;
                    break;
            }
            lblMsg.Text = msg;
            tmr.Start();
        }
        public int searchTableIndex(DataTable tbl, string col, string val)
        {
            int z = tbl.Rows.Count;
            for (int i = 0; i < z; i++)
            {
                if (tbl.Rows[i][col].ToString() == val)
                {
                    return i;
                }
            }
            return -1;
        }
        public int searchTableIndex(DataTable tbl, string col1, string col2, string val1, string val2)
        {
            int z = tbl.Rows.Count;
            for (int i = 0; i < z; i++)
            {
                if (tbl.Rows[i][col1].ToString() == val1 && tbl.Rows[i][col2].ToString() == val2)
                {
                    return i;
                }
            }
            return -1;
        }
        public DataRow searchTableRow(DataTable tbl, string col, string val)
        {
            int z = tbl.Rows.Count;
            for (int i = 0; i < z; i++)
            {
                if (tbl.Rows[i][col].ToString() == val)
                {
                    return tbl.Rows[i];
                }
            }
            return null;
        }
        public DataRow searchTableRow(DataTable tbl, string col1, string col2, string val1, string val2)
        {
            int z = tbl.Rows.Count;
            for (int i = 0; i < z; i++)
            {
                if (tbl.Rows[i][col1].ToString() == val1 && tbl.Rows[i][col2].ToString() == val2)
                {
                    return tbl.Rows[i];
                }
            }
            return null;
        }
        public void loadFormInfo(Form frm, DataGridView dgv, string title, Label lblClient, Label lblTitle)
        {
            lblClient.Text = Constants.client_name;
            lblTitle.Text = title;
            if (Custom.largeScreen)
            {
                frm.Font = new Font("Microsoft Sans Serif", 16);
                lblTitle.Font = new Font("Microsoft Sans Serif", 24);
                lblClient.Font = new Font("Microsoft Sans Serif", 24);
                dgv.RowTemplate.Height = 32;
            }

            Size siz = SystemInformation.VirtualScreen.Size;
            if (siz.Height == 768 && siz.Width == 1024)
                frm.Font = new Font("Microsoft Sans Serif", 10);
        }
        public void loadFormInfo(Form frm, string title, Label lblClient, Label lblTitle)
        {
            lblClient.Text = Constants.client_name;
            lblTitle.Text = title;
            if (Custom.largeScreen)
            {
                frm.Font = new Font("Microsoft Sans Serif", 16);
                lblTitle.Font = new Font("Microsoft Sans Serif", 24);
                lblClient.Font = new Font("Microsoft Sans Serif", 24);
            }

            Size siz = SystemInformation.VirtualScreen.Size;
            if (siz.Height == 768 && siz.Width == 1024)
                frm.Font = new Font("Microsoft Sans Serif", 10);
        }
        public void loadFormInfo(Form frm, string title, Label lblTitle)
        {
            lblTitle.Text = title;
            if (Custom.largeScreen)
            {
                frm.Font = new Font("Microsoft Sans Serif", 16);
                lblTitle.Font = new Font("Microsoft Sans Serif", 24);
            }

            Size siz = SystemInformation.VirtualScreen.Size;
            if (siz.Height == 768 && siz.Width == 1024)
                frm.Font = new Font("Microsoft Sans Serif", 10);
        }
        public void loadFormInfo(string title, Label lblClient, Label lblTitle)
        {
            lblClient.Text = Constants.client_name;
            lblTitle.Text = title;
        }
        public void loadFormInfo(string title, Label lblTitle)
        {
            lblTitle.Text = title;
        }
        public bool chkAttack(Control cnt)
        {
            string str = cnt.Text;
            if (str.Contains("select") || str.Contains("update") || str.Contains("delete") || str.Contains("insert") || str.Contains(";"))
            {
                return true;
            }
            return false;
        }
        public void freezeColumns(DataGridView dgv, string[] editable)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].ReadOnly = true;
            }

            foreach (string str in editable)
            {
                dgv.Columns[str].ReadOnly = false;
            }
        }
        public int countRows(string _entity, string _attribute)
        {
            int result = 0;
            try
            {
                db.query = "select count(" + _entity + "." + _attribute + ") from " + _entity;
                db.runQuery();
                db.read = db.cmd.ExecuteReader();
                while (db.read.Read())
                {
                    result = db.read.GetInt32(0);
                    break;
                }
            }
            catch (Exception ex)
            {
                result = 0;
            }
            return result;
        }
        public int countRows(string query)
        {
            int result = 0;
            try
            {
                db.query = query;
                db.runQuery();
                db.read = db.cmd.ExecuteReader();
                while (db.read.Read())
                {
                    result = db.read.GetInt32(0);
                    break;
                }
            }
            catch (Exception ex)
            {
                result = 0;
            }
            return result;
        }
        public void setdata(string s, DataGridView grid)
        {
            db.Connect();
            db.query = s;
            DataTable dtable = db.getDataTable();            
            if(dtable.Rows.Count <= 0)
                return;
            grid.DataSource = dtable;
        }
        public void loadCombo(ComboBox cmb, DataTable dtData, string displayMember, string valueMember)
        {
            cmb.DataSource = dtData;
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb.SelectedIndex = -1;
        }
        public void hideColumns(DataGridView dgv, string[] cols)
        { 
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                foreach (string str in cols)
                {
                    if (col.Name == str)
                        dgv.Columns[col.Index].Visible = false;
                }
            }
        }
        public void showColumns(DataGridView dgv, string[] cols)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                foreach (string str in cols)
                {
                    if (col.Name == str)
                        dgv.Columns[col.Index].Visible = true;
                }
            }
        }
        public void enableColumns(DataGridView dgv, string[] cols, bool enable)
        {
            if (enable)
                showColumns(dgv, cols);
            else
                hideColumns(dgv, cols);
        }
        public void lockColumns(DataGridView dgv, bool readOnly, params string[] cols)
        {
            foreach(string str in cols)
            {
                dgv.Columns[str].ReadOnly = readOnly;
            }
        }
        public bool DataExists(string str, string col_name, DataTable tbl)
        {
            if (tbl.Rows.Count <= 0)
                return false;
            int tmp = Convert.ToInt32(tbl.Compute( "count(["+col_name+"])", "[" + col_name + "] like '" + str + "'"));
            return tmp > 0;
        }
        public DataTable filterValueToTable( DataTable tbl, string col_name, string val )
        {
            if (tbl == null)
                return null;
            if (tbl.Rows.Count <= 0)
                return null;
            DataView dv = tbl.DefaultView;
            dv.RowFilter = col_name + " = " + val + "";
            return dv.ToTable();
        }
        public DataTable filterInverseToTable(DataTable tbl, string col_name, string val)
        {
            if (tbl == null)
                return null;
            if (tbl.Rows.Count <= 0)
                return null;
            DataView dv = tbl.DefaultView;
            dv.RowFilter = col_name + " != " + val + "";
            return dv.ToTable();
        }
        public void filterData(string str, string col_name, DataTable tbl, bool wildcard = false)
        {
            if (tbl == null)
                return;
            DataView dv = tbl.DefaultView;
            dv.RowFilter = wildcard ? col_name + " LIKE '%" + str + "%'" : col_name + " LIKE '" + str + "'";
        }
        public void filterData(string str, string col_name, DataGridView dgv, DataTable tbl, bool wildcard = true)
        {
            if (tbl == null)
                return;
            DataView dv = tbl.DefaultView;
            dv.RowFilter = wildcard ? col_name + " LIKE '%" + str + "%'" : col_name + " LIKE '" + str + "'";
            dgv.DataSource = dv;
        }
        public void filterDataParity(string str, string col_name, DataGridView dgv, DataTable tbl)
        {
            if (tbl == null)
                return;
            DataView dv = tbl.DefaultView;
            dv.RowFilter = col_name + " LIKE '%" + str + "'";
            dgv.DataSource = dv;
        }
        public void filterValue(string str, string col_name, DataGridView dgv, DataTable tbl)
        {
            DataView dv = tbl.DefaultView;
            dv.RowFilter = col_name + " = " + str + "";
            dgv.DataSource = dv;
        }
        public void delRows(DataTable tbl, string col, object val)
        {
            int count = tbl.Rows.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                if (tbl.Rows[i][col].ToString() == val.ToString())
                    tbl.Rows.RemoveAt(i);
            }
        }
        public void delRows(DataTable tbl, string col1, string col2, object val1, object val2)
        {
            int count = tbl.Rows.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                if (tbl.Rows[i][col1].ToString() == val1.ToString() && tbl.Rows[i][col2].ToString() == val2.ToString())
                    tbl.Rows.RemoveAt(i);
            }
        }
        public void loadFields(DataRow row, Control[] C, string[] S)
        {
            int i = 0;
            foreach (Control cnt in C)
            {
                if (cnt.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    TextBox txt = (TextBox)cnt;
                    txt.Text = row[S[i]].ToString();
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.NumericUpDown))
                { 
                    NumericUpDown num = (NumericUpDown)cnt;
                    num.Value = Convert.ToDecimal(row[S[i]].ToString());
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    ComboBox cmb = (ComboBox)cnt;
                    cmb.Text = row[S[i]].ToString();
                //    cmb.SelectedItem = row[S[i]].ToString();
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.DateTimePicker))
                {
                    DateTimePicker dtp = (DateTimePicker)cnt;
                    dtp.Value = Convert.ToDateTime(row[S[i]].ToString());
                }
                i++;
            }
        }
        public void loadFields(DataGridViewRow row, Control[] C, string[] S)
        {
            int i = 0;
            foreach (Control cnt in C)
            {
                if (cnt.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    TextBox txt = (TextBox)cnt;
                    txt.Text = row.Cells[S[i]].Value.ToString();
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.NumericUpDown))
                {
                    NumericUpDown num = (NumericUpDown)cnt;
                    
                   string tmpStr = row.Cells[S[i]].Value.ToString();
                    if (string.IsNullOrEmpty(tmpStr))
                        tmpStr = "0";

                    num.Value = Convert.ToDecimal(tmpStr);
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    ComboBox cmb = (ComboBox)cnt;
                    if (String.IsNullOrEmpty(row.Cells[S[i]].Value.ToString()))
                        cmb.SelectedValue = -1;
                    cmb.SelectedValue = row.Cells[S[i]].Value.ToString();
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.DateTimePicker))
                {
                    DateTimePicker dtp = (DateTimePicker)cnt;
                    dtp.Value = Convert.ToDateTime(row.Cells[S[i]].Value.ToString());
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.MaskedTextBox))
                {
                    MaskedTextBox mtb = (MaskedTextBox)cnt;
                    mtb.Text = row.Cells[S[i]].Value.ToString();
                }
                i++;
            }
        }
        public void loadFields(DataGridViewRow row, Control[] C, string[] S, Control focus, Button btn)
        {
            int i = 0;
            foreach (Control cnt in C)
            {
                if (cnt.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    TextBox txt = (TextBox)cnt;
                    txt.Text = row.Cells[S[i]].Value.ToString();
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.NumericUpDown))
                {
                    NumericUpDown num = (NumericUpDown)cnt;

                    string tmpStr = row.Cells[S[i]].Value.ToString();
                    if (string.IsNullOrEmpty(tmpStr))
                        tmpStr = "0";

                    num.Value = Convert.ToDecimal(tmpStr);
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    ComboBox cmb = (ComboBox)cnt;
                    if (String.IsNullOrEmpty(row.Cells[S[i]].Value.ToString()))
                        cmb.SelectedValue = -1;
                    else
                    {
                        cmb.SelectedValue = (object)row.Cells[S[i]].Value.ToString();
                    }
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.DateTimePicker))
                {
                    DateTimePicker dtp = (DateTimePicker)cnt;
                    if (String.IsNullOrEmpty(row.Cells[S[i]].Value.ToString()))
                        dtp.Value = DateTime.Today;
                    else
                        dtp.Value = Convert.ToDateTime(row.Cells[S[i]].Value.ToString());
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.MaskedTextBox))
                {
                    MaskedTextBox mtb = (MaskedTextBox)cnt;
                    mtb.Text = row.Cells[S[i]].Value.ToString();
                }
                if(focus != null)
                    focus.Focus();
                if(btn != null)
                    btn.Text = "&Update";
                i++;
            }
        }
        public void addtoGrid(DataGridView dgv, DataTable tbl, string[] S, Control[] C)
        {
            int i = 0;
            if (!(dgv.DataSource == tbl))
                return;

            DataRow row = tbl.NewRow();
            
            foreach (Control cnt in C)
            {
                if (cnt.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    TextBox txt = (TextBox)cnt;
                    row[S[i]] = txt.Text;
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.NumericUpDown))
                {
                    NumericUpDown num = (NumericUpDown)cnt;
                    row[S[i]] = num.Value;
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    ComboBox cmb = (ComboBox)cnt;
                    row[S[i]] = cmb.Text;
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.DateTimePicker))
                {
                    DateTimePicker dtp = (DateTimePicker)cnt;
                    row[S[i]] = dtp.Value.ToShortDateString();
                }
                i++;
            }

            tbl.Rows.Add(row);
            dgv.DataSource = tbl;
        }
        public void addtoGrid(DataGridView dgv, DataTable tbl, string[] S, Control[] C, bool comboValue)
        {
            int i = 0;
            if (!(dgv.DataSource == tbl))
                return;

            DataRow row = tbl.NewRow();

            foreach (Control cnt in C)
            {
                if (cnt.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    TextBox txt = (TextBox)cnt;
                    row[S[i]] = txt.Text;
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.NumericUpDown))
                {
                    NumericUpDown num = (NumericUpDown)cnt;
                    row[S[i]] = num.Value;
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    ComboBox cmb = (ComboBox)cnt; 
                    row[S[i]] = cmb.SelectedValue;
                    i++;
                    row[S[i]] = cmb.Text;
                }
                else if (cnt.GetType() == typeof(System.Windows.Forms.DateTimePicker))
                {
                    DateTimePicker dtp = (DateTimePicker)cnt;
                    row[S[i]] = dtp.Value.ToShortDateString();
                }
                i++;
            }

            tbl.Rows.Add(row);
            dgv.DataSource = tbl;
        }
        public bool chkPassword(Control cnt, Label lblMsg, System.Windows.Forms.Timer tmr)
        {
            bool res = (cnt.Text == User.curPass);
            if (!res)
            {
                showMessage("Please enter valid Password", lblMsg, Constants.message_info, tmr);
                cnt.Focus();
            }
            return res;
        }
        public void setBounds(DateTime date)
        {
            sdate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            edate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
        }
        /*
        public string dateTraverse(string dt)
        {
            int a = dt.Length;
            string y = null;
            string z;
            string x = dt.Substring(a - 4, 4);

            int b = dt.IndexOf("/", 0, 3);
            z = dt.Substring(b + 1, 2);
            if (z.Contains('/'))
                z = dt.Substring(b + 1, 1);
            y = dt.Substring(0, b);

            return x + "/" + y + "/" + z;
        }
        public object getSelectedRowValue(DataGridView dgv, int cellIndex = 0, bool remove = false)
        {
            object ob;
            int i = dgv.SelectedRows.Count;
            if (i != 1)
                return null;
            DataGridViewRow row = dgv.SelectedRows[0];
            ob = row.Cells[cellIndex].Value;
            if (remove)
                dgv.SelectedRows[0].Dispose();
            return ob;
        }
        public object getSelectedRowValue(DataGridView dgv, bool remove = false)
        {
            object ob;
            int i = dgv.SelectedRows.Count;
            if (i != 1)
                return null;
            DataGridViewRow row = dgv.SelectedRows[0];
            ob = row.Cells[0].Value;
            if (remove)
                row.Dispose();
            return ob;
        }
        public object getSelectedRowValue(DataGridView dgv)
        {
            object ob;
            int i = dgv.SelectedRows.Count;
            if (i != 1)
                return null;
            DataGridViewRow row = dgv.SelectedRows[0];
            ob = row.Cells[0].Value;
            return ob;
        }
        public void setChart(string _query, System.Windows.Forms.DataVisualization.Charting.Chart crt)
        {
            int result = 0;
            try
            {
                con.Connect();
                runQuery(_query);
                read = cmd.ExecuteReader();
                if (read.Depth < 0)
                    return;
                while (read.Read())
                {
                    crt.Series[0].Points.AddXY(read.GetString(0), read.GetInt32(1));
                }
                con.closeCon();
                return;
            }
            catch (Exception ex)
            {
                err(ex.Message);
            }
        }
        public void priCont(params Control[] C)
        {
            bool b = users.isadmin();
            foreach (Control cnt in C)
            {
                cnt.Enabled = b;
            }
        }
        public void priFrm(Form frm)
        {
            frmMiniLog log = new frmMiniLog("Login First");
            if (!users.isadmin())
            {
                msg("Access is Denied");
                frm.Close();
                return;
            }
            else
            {
                log.ShowDialog();
            }
            if (!users.miniaccess)
            {
                msg("Access is Denied");
                frm.Close();
            }
        }
        public void plotString(string value, int _x, int _y, System.Drawing.Printing.PrintPageEventArgs _e)
        {
            _e.Graphics.DrawString(value, new Font("Century", 10, FontStyle.Regular), Brushes.Black, new Point(_x, _y));
        }
        public void plotString(string value, int _x, int _y, System.Drawing.Printing.PrintPageEventArgs _e, int _fontSize)
        {
            _e.Graphics.DrawString(value, new Font("Century", _fontSize, FontStyle.Regular), Brushes.Black, new Point(_x, _y));
        }
        public void plotString(string value, int _x, int _y, System.Drawing.Printing.PrintPageEventArgs _e, FontStyle _style)
        {
            _e.Graphics.DrawString(value, new Font("Century", 10, _style), Brushes.Black, new Point(_x, _y));
        }
        public void plotString(string value, int _x, int _y, System.Drawing.Printing.PrintPageEventArgs _e, int _fontSize, FontStyle _style)
        {
            _e.Graphics.DrawString(value, new Font("Century", _fontSize, _style), Brushes.Black, new Point(_x, _y));
        }
        public void plotLine(int _x, int _y, System.Drawing.Printing.PrintPageEventArgs _e, int l = 2)
        {
            string str = "";
            for (int i = 0; i < l; i++)
                str = str + "____";
            _e.Graphics.DrawString(str, new Font("Century", 10, FontStyle.Regular), Brushes.Black, new Point(_x, _y));
        }

        */
    }
}