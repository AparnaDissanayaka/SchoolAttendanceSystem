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
    public partial class TeacherLogin : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );
        public TeacherLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Visible = true;
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Visible = true;
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentLogin sl = new StudentLogin();
            sl.Visible = true;
            this.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand check = new SqlCommand(
                "select * from TeacherPassword where NIC='"+txtnic.Text+"' and Password='"+txtpassword.Text+"';",connection
                );
            SqlDataReader readcheck = check.ExecuteReader();
            if (readcheck.Read())
            {
                connection.Close();
                TeacherLogedForm tlf = new TeacherLogedForm();
                tlf.Visible = true;
                this.Hide();
            }
            else {
                connection.Close();
                MessageBox.Show("Check your NIC and Password...");
            }

            
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
                    "select * from TeacherDetails where NIC='"+nic.Text+"';",connection
                    );
                SqlDataReader read = readNIC.ExecuteReader();
                if (read.Read())
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand readNIC2 = new SqlCommand(
                        "select * from TeacherPassword where NIC='"+nic.Text+"';",connection
                        );
                    SqlDataReader read2 = readNIC2.ExecuteReader();
                    if (read2.Read())
                    {
                        connection.Close();
                        MessageBox.Show("Already You have an account...");
                    }
                    else {
                        connection.Close();
                        connection.Open();
                        SqlCommand insert = new SqlCommand(
                            "insert into TeacherPassword values('"+nic.Text+"','"+password.Text+"');",connection
                            );
                        insert.ExecuteNonQuery();
                        connection.Close();
                        TeacherLogedForm teach = new TeacherLogedForm();
                        teach.Visible = true;
                        this.Hide();
                    }
                   
                }
                else {
                    connection.Close();
                    MessageBox.Show("There is no any Teacher NIC inter by admin.......");
                }
                
            }
            else
            {
                MessageBox.Show("confirm password != password");
            }
        }

    }
}
