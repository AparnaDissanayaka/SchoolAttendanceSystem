using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolAutomationSystem
{
    public partial class AdminLogin : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Visible = true;
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand ck = new SqlCommand(
                "select * from AdminDetails where Name='"+txtadminname.Text+"'",connection
                );
            SqlDataReader ckread = ck.ExecuteReader();
            if (ckread.Read())
            {
                connection.Close();
                connection.Open();
                SqlCommand check = new SqlCommand(
                    "select * from AdminPassword where AdminName='" + txtadminname.Text + "' and Password='" + txtpassword.Text + "';", connection
                    );
                SqlDataReader readcheck = check.ExecuteReader();
                if (readcheck.Read())
                {
                    connection.Close();
                    AdminLogedForm adminlog = new AdminLogedForm();
                    adminlog.Visible = true;
                    this.Close();
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("Check your Admin and Password...");
                    txtadminname.Text = "";
                    txtpassword.Text = "";
                }
            }
            else {
                connection.Close();
                MessageBox.Show("You haven't permission to access to the system...");
            }
        }

        private void btnteacherlogin_Click(object sender, EventArgs e)
        {
            TeacherLogin tl = new TeacherLogin();
            tl.Visible = true;
            this.Hide();
        }

        private void btnstudentlogin_Click(object sender, EventArgs e)
        {
            StudentLogin sl = new StudentLogin();
            sl.Visible = true;
            this.Hide();
        }

        private void no_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newAccount.Visible = true;

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (password.Text == confirmpassword.Text)
            {
                connection.Open();

                SqlCommand readNIC = new SqlCommand(
                    "select * from AdminDetails where Name='" + txtadmin.Text + "';", connection
                    );
                SqlDataReader read = readNIC.ExecuteReader();
                if (read.Read())
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand readNIC2 = new SqlCommand(
                        "select * from AdminPassword where AdminName='"+txtadmin.Text + "';", connection
                        );
                    SqlDataReader read2 = readNIC2.ExecuteReader();
                    if (read2.Read())
                    {
                        connection.Close();
                        MessageBox.Show("Already You have an Admin account...");
                        txtadmin.Text = "";
                        password.Text = "";
                        confirmpassword.Text = "";
                    }
                    else
                    {
                        connection.Close();
                        connection.Open();
                        SqlCommand insert = new SqlCommand(
                            "insert into AdminPassword values('" + txtadmin.Text + "','" + password.Text + "');", connection
                            );
                        insert.ExecuteNonQuery();
                        connection.Close();
                        AdminLogedForm adminlog = new AdminLogedForm();
                        adminlog.Visible = true;
                        this.Hide();
                    }

                }
                else
                {
                    connection.Close();
                    MessageBox.Show("There is no any Admin Name insert by admin.......");
                    txtadmin.Text = "";
                    password.Text = "";
                    confirmpassword.Text = "";
                }

            }
            else
            {
                MessageBox.Show("confirm password != password");
            }

        }

       
    }
}
