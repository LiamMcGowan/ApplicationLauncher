using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace ApplicationLauncher
{
    class Apps : IEnumerable
    {
        public IList<BDApp> BDAppList { get { return this._apps ; } }
        private List<BDApp> _apps = new List<BDApp>();

        // Public methods.  
        public void Add(BDApp c)
        {
            _apps.Add(c);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (BDApp _app in _apps)
            {
                yield return _app;
            }
        }

        public void GetAllApps()
        {
            BDApp _app = null;
            try
            {
                SqlConnection con = new SqlConnection(Global.ConnectionString);
                SqlCommand cmd = new SqlCommand("qryGetAllApps", con);
                cmd.CommandTimeout = Global.TimeOut;
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                //OleDbDataReader dr = cmd.ExecuteReader();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    // Call Read before accessing data.
                    while (dr.Read())
                    {
                        _app = new BDApp();
                        _app.BDApp_ID = Convert.ToInt32(dr["BDApp_ID"].ToString());
                        _app.BDApp_Number = Convert.ToInt32(dr["BDApp_Number"].ToString());
                        _app.BDApp_Name = dr["BDApp_Name"].ToString();
                        _app.BDApp_Friendly_Name = dr["BDApp_Friendly_Name"].ToString();
                        _app.Restricted_BDApp = Convert.ToBoolean(dr["Restricted_BDApp"].ToString());
                        _app.BDApp_Governing_DL = Convert.ToInt16(dr["BDApp_Governing_DL"].ToString());

                        _app.BDApp_Admin_Contact = dr["BDApp_Admin_Contact"].ToString();
                        _app.BDApp_Version_Number = dr["BDApp_Version_Number"].ToString();
                        _app.BDApp_Install_File = dr["BDApp_Install_File"].ToString();
                        _app.BDApp_Status = Convert.ToInt16(dr["BDApp_Status"].ToString());
                        _app.Updated_By = Convert.ToInt32(dr["Updated_By"].ToString());
                        try
                        {
                            _app.Date_Updated = Convert.ToDateTime(dr["Date_Updated"].ToString());
                        }
                        catch
                        {
                            _app.Date_Updated = Convert.ToDateTime("01/01/1900 00:00:00");
                        }
                        _app.Update_Process = dr["Update_Process"].ToString();
                        _app.Status_Description = dr["Status_Description"].ToString();
                        _app.Governing_DL = dr["Governing_DL"].ToString();
                        _app.List_Managers = dr["List_Managers"].ToString();
                        _apps.Add(_app);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == -2) // connection time-out
                {
                    System.Windows.Forms.MessageBox.Show("The application could not connect to the database, and will now close.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    // Close the application
                    Environment.Exit(1);
                }
            }
        }


        public void GetUserApps(int intPID)
        {
            BDApp _app = null;
            try
            {
                SqlConnection con = new SqlConnection(Global.ConnectionString);
                SqlCommand cmd = new SqlCommand("qryGetUserApps", con);
                cmd.CommandTimeout = Global.TimeOut;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                SqlParameter prmID253 = cmd.Parameters.Add("@PID", SqlDbType.Int);
                prmID253.Value = intPID;

                con.Open();

                //OleDbDataReader dr = cmd.ExecuteReader();
                SqlDataReader dr = cmd.ExecuteReader();
                

                if (dr != null)
                {
                    // Call Read before accessing data.
                    while (dr.Read())
                    {
                        _app = new BDApp();
                        _app.BDApp_ID = Convert.ToInt32(dr["BDApp_ID"].ToString());
                        _app.BDApp_Number = Convert.ToInt32(dr["BDApp_Number"].ToString());
                        _app.App_Fav = Convert.ToInt16(dr["Favourite_App"].ToString());
                        _app.BDApp_Name = _app.App_Fav == 1 ? dr["BDAppName"].ToString() + " #" : dr["BDAppName"].ToString();  /* Toggled with friendly name.  Favourites flagged with #. */
                        _app.Restricted_BDApp = Convert.ToBoolean(dr["Restricted_BDApp"].ToString());
                        _app.BDApp_Governing_DL = Convert.ToInt16(dr["BDApp_Governing_DL"].ToString());
                        _app.BDApp_Install_File = dr["BDApp_Install_File"].ToString();
                        _app.BDApp_Command = dr["BDApp_Command"].ToString();
                        _app.BDApp_Admin_Contact = dr["BDApp_Admin_Contact"].ToString();
                        _app.BDApp_Version_Number = dr["BDApp_Version_Number"].ToString();
                        _app.BDApp_Install_File = dr["BDApp_Install_File"].ToString();
                        _app.BDApp_Status = Convert.ToInt16(dr["BDApp_Status"].ToString());
                        _app.Updated_By = Convert.ToInt32(dr["Updated_By"].ToString());
                        try
                        {
                            _app.Date_Updated = Convert.ToDateTime(dr["Date_Updated"].ToString());
                        }
                        catch
                        {
                            _app.Date_Updated = Convert.ToDateTime("01/01/1900 00:00:00");
                        }
                        _app.Update_Process = dr["Update_Process"].ToString();
                        _app.App_Odr = Convert.ToInt16(dr["odr"].ToString());
                        byte[] img = (byte[])dr["BDApp_Image"]; /*read image*/
                        MemoryStream ms = new MemoryStream(img); /*set as MemoryStream e*/
                        _app.App_Img = new Bitmap(ms);  /*assign as bitmap*/
                        //_app.Governing_DL = dr["Governing_DL"].ToString();
                        //_app.List_Managers = dr["List_Managers"].ToString();
                        _apps.Add(_app);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == -2) // connection time-out
                {
                    System.Windows.Forms.MessageBox.Show("The application could not connect to the database, and will now close.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    // Close the application
                    Environment.Exit(1);
                }
            }
        }

        public void AddBDAppIcon(int BDApp_No)
        {
            SqlConnection con = new SqlConnection(Global.ConnectionString);

            try
            {
                OpenFileDialog fop = new OpenFileDialog();
                fop.InitialDirectory = @"H:\Icons\Windows 8 Metro Icons\Metro ICO\Other\";
                fop.Filter = "[Icon]|*.ico";
                if (fop.ShowDialog() == DialogResult.OK)
                {
                    FileStream FS = new FileStream(@fop.FileName, FileMode.Open, FileAccess.Read);
                    byte[] img = new byte[FS.Length];
                    FS.Read(img, 0, Convert.ToInt32(FS.Length));

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("qryAddBDAppIcon", con);
                    cmd.CommandTimeout = Global.TimeOut;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nBDApp_No", BDApp_No);
                    cmd.Parameters.Add("@nBDApp_Icon", SqlDbType.Image).Value = img;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Image Save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Image save aborted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public void ToggleUserFavourite(int intPID, int intBDAppID, bool blnIsFavourite)
        {
            try
            {
                SqlConnection con = new SqlConnection(Global.ConnectionString);
                SqlCommand cmd = new SqlCommand("qryAmendUserFavourite", con);
                cmd.CommandTimeout = Global.TimeOut;
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@iPID", intPID);
                cmd.Parameters.AddWithValue("@iBDAppID", intBDAppID);
                cmd.Parameters.AddWithValue("@bIsFavourite", blnIsFavourite);
                cmd.ExecuteNonQuery();
                con.Close();
                cmd.Dispose();
                cmd.Parameters.Clear();
                return;
            }
            catch
            {
                MessageBox.Show("There was an error. Your Favourite preference could not be changed", Global.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }

    public class BDApp
    {

        private Int32 _bdappId;
        private Int32 _bdappNumber;
        private string _bdappName;
        private string _bdappFriendlyName;
        private bool _restrictedBdapp;
        private Int16 _bdappGoverningDl;
        private string _bdappAdminContact;
        private string _bdappVersionNumber;
        private string _bdappInstallFile;
        private Int16 _bdappStatus;
        private Int32 _updatedBy;
        private DateTime _dateUpdated;
        private string _updateProcess;
        private string _statusDescription;
        private string _governingDl;
        private string _listManagers;
        private Int16 _appOdr;
        private Int16 _appFav;
        private Bitmap _appImg;
        private string _bdappCommand;

        public BDApp()
        {

        }

        public BDApp(int _bdappid, int _bdappnumber, string _bdappname, string _bdappfriendlyname, bool _restrictedbdapp, short _bdappgoverningdl, 
            string _bdappadmincontact, string _bdappversionnumber, string _bdappinstallfile, short _bdappstatus, short _updatedby, 
            DateTime _dateupdated, string _updateprocess, string _statusdescription, string _governingdl, string _listmanagers, short _appodr, short _appfav, Bitmap _appimg, string _bdappcommand)
        {
            this._bdappId = _bdappid;
            this._bdappNumber = _bdappnumber;
            this._bdappName = _bdappname;
            this._bdappFriendlyName = _bdappfriendlyname;
            this._restrictedBdapp = _restrictedbdapp;
            this._bdappGoverningDl = _bdappgoverningdl;
            this._bdappAdminContact = _bdappadmincontact;
            this._bdappVersionNumber = _bdappversionnumber;
            this._bdappInstallFile = _bdappinstallfile;
            this._bdappStatus = _bdappstatus;
            this._updatedBy = _updatedby;
            this._dateUpdated = _dateupdated;
            this._updateProcess = _updateprocess;
            this._statusDescription = _statusdescription;
            this._governingDl = _governingdl;
            this._listManagers = _listmanagers;
            this._appOdr = _appodr;
            this._appFav = _appfav;
            this._appImg = _appimg;
            this._bdappCommand = _bdappcommand;
        }

        public Int32 BDApp_ID
        {
            get
            {
                return _bdappId;
            }
            set
            {
                _bdappId = value;
            }
        }

        public Int32 BDApp_Number {
            get
            {
                return _bdappNumber;
            }
            set
            {
                _bdappNumber = value;
            }
        }

        public string BDApp_Name
        {
            get
            {
                return _bdappName;
            }
            set
            {
                _bdappName = value;
            }
        }

        public string BDApp_Friendly_Name
        {
            get
            {
                return _bdappFriendlyName;
            }
            set
            {
                _bdappFriendlyName = value;
            }
        }

        public bool Restricted_BDApp
        {
            get
            {
                return _restrictedBdapp;
            }
            set
            {
                _restrictedBdapp = value;
            }
        }

        public Int16 BDApp_Governing_DL
        {
            get
            {
                return _bdappGoverningDl;
            }
            set
            {
                _bdappGoverningDl = value;
            }
        }

        public string BDApp_Admin_Contact
        {
            get
            {
                return _bdappAdminContact;
            }
            set
            {
                _bdappAdminContact = value;
            }
        }

        public string BDApp_Version_Number
        {
            get
            {
                return _bdappVersionNumber;
            }
            set
            {
                _bdappVersionNumber = value;
            }
        }

        public string BDApp_Install_File
        {
            get
            {
                return _bdappInstallFile;
            }
            set
            {
                _bdappInstallFile = value;
            }
        }

        public Int16 BDApp_Status
        {
            get
            {
                return _bdappStatus;
            }
            set
            {
                _bdappStatus = value;
            }
        }

        public Int32 Updated_By
        {
            get
            {
                return _updatedBy;
            }
            set
            {
                _updatedBy = value;
            }
        }

        public DateTime Date_Updated
        {
            get
            {
                return _dateUpdated;
            }
            set
            {
                _dateUpdated = value;
            }
        }

        public string Update_Process
        {
            get
            {
                return _updateProcess;
            }
            set
            {
                _updateProcess = value;
            }
        }

        public string Status_Description
        {
            get
            {
                return _statusDescription;
            }
            set
            {
                _statusDescription = value;
            }
        }

        public string Governing_DL
        {
            get
            {
                return _governingDl;
            }
            set
            {
                _governingDl = value;
            }
        }

        public string List_Managers
        {
            get
            {
                return _listManagers;
            }
            set
            {
                _listManagers = value;
            }
        }

        public Int16 App_Odr
        {
            get
            {
                return _appOdr;
            }
            set
            {
                _appOdr = value;
            }
        }

        public Int16 App_Fav
        {
            get
            {
                return _appFav;
            }
            set
            {
                _appFav = value;
            }
        }

        public Bitmap App_Img
        {
            get
            {
                return _appImg;
            }
            set
            {
                _appImg = value;
            }
        }

        public string BDApp_Command
        {
            get
            {
                return _bdappCommand;
            }
            set
            {
                _bdappCommand = value;
            }
        }

    }
}