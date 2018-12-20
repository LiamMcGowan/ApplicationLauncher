using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLauncher
{
    public partial class frmAbout : Form
    {

        private static string m_sStatus; 

        public frmAbout()
        {
            InitializeComponent();
            
            UpdateTimer.Start();
            UpdateTimer.Interval = 50;

            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);

            lblHelp.Text = "Please report any errors to the IT Service Desk quoting the details below.";
            lblBDAppNumber.Text = "BDApp Reference Number: #######";
            lblBDAppName.Text = "BDApp Name: Application Launcher";
            lblResolver.Text = "Resolver Group: HMRC B Local Compliance";
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = m_sStatus;
        }

        static public void SetStatus(string newStatus)
        {
            //if (frmAbout == null)
            //    return;
            m_sStatus = newStatus;
        }

        private void frmAbout_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateTimer.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);
            if (pictureBox1.Location.X + pictureBox1.Width > Width)
            {
                timer1.Stop();
                timer2.Start();
            }

            if (pictureBox1.Location.Y + pictureBox1.Height > Height)
            {
                timer1.Stop();
                timer3.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y + 5);
            if (pictureBox1.Location.Y + pictureBox1.Height > Height)
            {
                timer2.Stop();
                timer4.Start();
            }

            if (pictureBox1.Location.X < 0)
            {
                timer2.Stop();
                timer1.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y - 5);
            if (pictureBox1.Location.X + pictureBox1.Width > Width)
            {
                timer3.Stop();
                timer4.Start();
            }

            if (pictureBox1.Location.Y < 0)
            {
                timer3.Stop();
                timer1.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 5);
            if (pictureBox1.Location.X < 0)
            {
                timer4.Stop();
                timer3.Start();
            }

            if (pictureBox1.Location.Y < 0)
            {
                timer4.Stop();
                timer2.Start();
            }
        }

        private void frmAbout_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void frmAbout_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }
    }
}
