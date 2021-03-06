﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApplicationLauncher
{
    public class User
    {
        public String Input;
        public User()
        {
            try
            {
                PID = Convert.ToInt32(Environment.UserName).ToString();

            }
            catch
            {
                PID = "0000000";
            }

            try
            {
                if (!String.IsNullOrEmpty(Options.PID))
                {
                    PID = Options.PID;
                }
            }
            catch
            {
                PID = "0000000";
            }

            try
            {
                FullName = Environment.UserDomainName.ToString();

            }
            catch
            {
                FullName = "Unknown";
            }

            GetUserInfo();

        }


        public User(string _pid)
        {
            PID = _pid;
            GetUserInfo();
        }

        private string _pid = "0000000";
        private string _fullname = "";
        private bool _active = false; // 0 = No, 1 = Yes
        private bool _admin = false; // 0 = No, 1 = Yes
        private string _adminText = "No";


        public string PID
        {
            get
            {
                return _pid;
            }
            set
            {
                _pid = value;
            }
        }

        public bool Admin
        {
            get
            {
                return _admin;
            }
            set
            {
                _admin = value;
            }
        }

        public string AdminText
        {
            get
            {
                if (Admin == true)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
            set
            {
                _adminText = value;
            }
        }

        public bool Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
            }
        }

        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = value;
            }
        }

        public void GetUserInfo()
        {

            SqlConnection con = new SqlConnection(Global.ConnectionString);
            SqlCommand cmd = new SqlCommand("qryGetUserDetails", con);
            cmd.CommandTimeout = Global.TimeOut;
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter prmID253 = cmd.Parameters.Add("@PID", SqlDbType.Int);
            prmID253.Value = PID;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            #region Recordset
            if (reader.HasRows)
            {
                reader.Read();
                {
                    //FullName = reader["Full_Name"].ToString();
                    Active = Convert.ToBoolean(reader["Active"].ToString());
                    Admin = Convert.ToBoolean(reader["App_Launcher_Admin"].ToString());
                }
            }
            else
            {
                //Input = "Please enter your full name"; Dave want us to move away from user entering their own name - User class enviroment.UserDomainName added and code change here
                //Global.ShowInputDialog(ref Input, Application.ProductName + " - You are not known by this application.");
                ////we need to add code here to add the user including the name they have just input or to kick them out if they haven't added a name
                //MessageBox.Show(input, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //if (Input == "Please enter your full name" || Input == "") 
                //{
                //Environment.Exit(0);
                //}
                //else
                {

                    //SaveUserInfo(Input); replaced by line below
                    SaveUserInfo(FullName);

                    //FullName = Input;
                    Active = true;
                    Admin = false;
                }
            }

            #endregion
        }

        public void SaveUserInfo(string FullName)
        {
            try
            {
                SqlConnection con = new SqlConnection(Global.ConnectionString);
                SqlCommand cmd = new SqlCommand("qryAddNewUser", con);
                cmd.CommandTimeout = Global.TimeOut;
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                cmd.Parameters.Clear();
                cmd.CommandText = "qryAddNewUser";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nPID", PID);
                cmd.Parameters.AddWithValue("@nFullName", FullName);
                cmd.ExecuteNonQuery();

                con.Close();
                cmd.Dispose();
                cmd.Parameters.Clear();
            }
            catch
            {
                MessageBox.Show("There was an error. Your details has not been saved", Global.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
