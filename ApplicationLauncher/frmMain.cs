using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ApplicationLauncher
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // Populate global variables
            LoadAppVarables gen = new LoadAppVarables();
            gen.LoadApplication();

            // Check if access is granted and/or message to be displayed
            frmAbout.SetStatus("Checking Broadcast messages");
            Global.CheckBroadcast();

            // Check version numbers
            frmAbout.SetStatus("Checking version numbers");
            System.Threading.Thread.Sleep(900);
            Global.CheckVersions();

            // Check if db is online
            #region DB Online
            if (!Global.IsServerConnected(Global.ConnectionString))
            {
                MessageBox.Show(Application.ProductName + " is not available.  Please try again later.  If the problem persists, please report the error to the IT Helpdesk", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Threading.Thread.CurrentThread.Abort();
                Application.Exit();
                Environment.Exit(1);
            }
            #endregion DB Online

            // Get user details
            frmAbout.SetStatus("Checking User");
            System.Threading.Thread.Sleep(900);
            User user = new User();
            Global.FullName = user.FullName;
            Global.PID = user.PID;
            Global.Admin = user.Admin;

            this.toolStripStatusPID.Text = "PID : " + user.PID;
            this.toolStripStatusName.Text = "Name : " + user.FullName;
            frmAbout.SetStatus("Loading Application data");
            System.Threading.Thread.Sleep(900);

        }

        private void lstApplications_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            // Populate Data View Grid - dvgUserApps
            populateUserApps();

            //Display Menu Items dependant upon rights
            if (Global.Admin == true)
            {
                this.AdmintoolStripMenuItem.Visible = true;
                this.dTaSAdminToolStripMenuItem.Visible = true;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvUserApps_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // get row index
                var hti = dgvUserApps.HitTest(e.X, e.Y);
                this.dgvUserApps.ClearSelection();
                this.dgvUserApps.Rows[hti.RowIndex].Selected = true;
                int thisrow = hti.RowIndex;
                if (thisrow < 0)
                {
                    return;
                }
                int iBDApp_ID = Convert.ToInt16(dgvUserApps.Rows[thisrow].Cells[0].Value); /*Col 0 is BDApp_ID*/
                bool bFavourite = Convert.ToBoolean(dgvUserApps.Rows[thisrow].Cells[4].Value); /*Col 4 is App_Fav*/

                int iOdr = Convert.ToInt16(dgvUserApps.Rows[thisrow].Cells[2].Value); /*Col 2 is App_Odr if 1 then approved if 2 not approved*/

                if (iOdr == 1)
                {
                    Apps apps = new Apps();
                    apps.ToggleUserFavourite(Convert.ToInt16(Global.PID), iBDApp_ID, bFavourite);
                    //MessageBox.Show("place marker to flag favourite", "Favourite", MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, true);
                    return;
                }
                else
                {
                    //Apply for application approval
                    MessageBox.Show("Here");
                }
            }
            else
            {
                //// get row index
                //int thisrow = dgvUserApps.CurrentCell.RowIndex;
                //if (thisrow < 0)
                //{
                //    return;
                //}
                //// get command info
                //string thiscommand = dgvUserApps.Rows[thisrow].Cells[6].Value.ToString(); /*Col 6 is BDApp_Command*/
                //string thisapp = dgvUserApps.Rows[thisrow].Cells[3].Value.ToString(); /*Col 3 is BDApp_Name*/
                //string thismissing = thisapp == "" ? "This BDApp" : thisapp + " is currently unavailable.";
                //string thisproject = Global.ApplicationName == "" ? "BDapp" : Global.ApplicationName;

                //// advse user if no command
                //if (thiscommand == "")
                //{
                //    MessageBox.Show(thismissing, thisproject, MessageBoxButtons.OK,
                //        MessageBoxIcon.Information);
                //    return;
                //}

                //// launch app
                //Cursor.Current = Cursors.WaitCursor;
                //try
                //{
                //    var psi = new ProcessStartInfo(@"" + thiscommand)
                //    {
                //        Arguments = @"",
                //        UseShellExecute = false,
                //        CreateNoWindow = true
                //    };
                //    Process.Start(psi);
                //    Application.Exit();
                //    return;
                //}
                //catch
                //{
                //    MessageBox.Show(thismissing, thisproject, MessageBoxButtons.OK,
                //        MessageBoxIcon.Information);
                //}
                //Cursor.Current = Cursors.Default;

            }
        }

        private void addBDAppIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apps apps = new Apps();

            // Add code here to let user add BDApp ID

            apps.AddBDAppIcon(110893);

            // Populate Data View Grid - dvgUserApps
            populateUserApps();
        }

        private void populateUserApps()
        {
            // Populate datagrid - this needs pulling out as a separate proceedure in order to refresh following changes
            Apps apps = new Apps();
            int PID = 0;

            #region GetPID
            if (System.Diagnostics.Debugger.IsAttached == true)
            {
                if (Global.PID == "0000000")
                {
                    PID = 7090214;
                }
                else
                {
                    PID = Convert.ToInt32(Global.PID);
                }
            }
            #endregion

            apps.GetUserApps(PID);

            #region SetColWidths
            int cols = dgvUserApps.Columns.Count > 0 ? dgvUserApps.Columns.Count : 1;
            int onepc = dgvUserApps.Width / 100; /* one percent of grid width */

            // create colwidth array, initialising all elements to zero 
            int[] colwidth = new int[cols];
            int i;

            for (i = 0; i<cols; i++)
            {
                colwidth[i] = 0;
            }

            // specific columns
            colwidth[1] = 20 * onepc;
            colwidth[3] = 70 * onepc;
            colwidth[5] = 15 * onepc;

            // apply widths values
            for (i = 0; i<cols; i++)
            {
                if (colwidth[i] > 0)
                {
                    dgvUserApps.Columns[i].Width = colwidth[i];
                }
                else
                {
                    dgvUserApps.Columns[i].Visible = false; /* hide zero width columns */
                }

            }
            #endregion

            dgvUserApps.DataSource = apps.BDAppList;

            // highlight user apps
            int rows = dgvUserApps.Rows.Count;
            int ord = 0;
            int fav = 0;

            for (i = 0; i<rows; i++)
            {
                fav = Convert.ToInt16(dgvUserApps.Rows[i].Cells[4].Value.ToString());
                if (fav == 1)
                {
                    dgvUserApps.Rows[i].DefaultCellStyle.Font = new Font(dgvUserApps.DefaultCellStyle.Font, FontStyle.Bold);
                    dgvUserApps.Rows[i].DefaultCellStyle.BackColor = Color.LightCyan;
                }
                else
                { 
                    ord = Convert.ToInt16(dgvUserApps.Rows[i].Cells[2].Value.ToString());
                    if (ord == 1)
                    {
                        dgvUserApps.Rows[i].DefaultCellStyle.Font = new Font(dgvUserApps.DefaultCellStyle.Font, FontStyle.Bold);
                        dgvUserApps.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                }
            }

            // specific headers. needs to be handled better
            dgvUserApps.Columns[1].HeaderText = "BDApp Number";
            dgvUserApps.Columns[3].HeaderText = "BDApp Name";
        }

        private void dgvUserApps_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvUserApps.CurrentCell = dgvUserApps.Rows[e.RowIndex].Cells[e.ColumnIndex];
            dgvUserApps.Rows[e.RowIndex].Selected = true;
            dgvUserApps.Focus();
        }

        private void dgvUserApps_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int thisrow = dgvUserApps.CurrentCell.RowIndex;
            if (thisrow < 0)
            {
                return;
            }
            // get command info
            string thiscommand = dgvUserApps.Rows[thisrow].Cells[6].Value.ToString(); /*Col 6 is BDApp_Command*/
            string thisapp = dgvUserApps.Rows[thisrow].Cells[3].Value.ToString(); /*Col 3 is BDApp_Name*/
            string thismissing = thisapp == "" ? "This BDApp" : thisapp + " is currently unavailable.";
            string thisproject = Global.ApplicationName == "" ? "BDapp" : Global.ApplicationName;

            // advse user if no command
            if (thiscommand == "")
            {
                MessageBox.Show(thismissing, thisproject, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // launch app
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                var psi = new ProcessStartInfo(@"" + thiscommand)
                {
                    Arguments = @"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process.Start(psi);
                Application.Exit();
                return;
            }
            catch
            {
                MessageBox.Show(thismissing, thisproject, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
