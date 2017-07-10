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
    
    public partial class StudentLogin : Form
    {
        public static String passar="";

        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );
        public StudentLogin()
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
            al.Visible=true;
            this.Hide();

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            TeacherLogin tl = new TeacherLogin();
            tl.Visible = true;
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            passar = txtregno.Text;

            connection.Open();
            SqlCommand check = new SqlCommand(
                "select * from StudentPassword where RegNo='" +txtregno.Text+ "' and Password='" +txtpassword.Text+ "';", connection
                );
            SqlDataReader readcheck = check.ExecuteReader();
            if (readcheck.Read())
            {
                connection.Close();
                StudentLogedForm stu = new StudentLogedForm();
                stu.Visible = true;
                this.Hide();
            }
            else
            {
                connection.Close();
                MessageBox.Show("Check your RegNo and Password...");
               txtregno.Text= "";
                txtpassword.Text = "";
            }
            

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (password.Text == confirmpassword.Text)
            {
                connection.Open();

                SqlCommand readNIC = new SqlCommand(
                    "select * from StudentTable where RegNo='" +txtpassword.Text+ "';", connection
                    );
                SqlDataReader read = readNIC.ExecuteReader();
                if (read.Read())
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand readNIC2 = new SqlCommand(
                        "select * from StudentPassword where RegNo='" +txtpassword.Text+ "';", connection
                        );
                    SqlDataReader read2 = readNIC2.ExecuteReader();
                    if (read2.Read())
                    {
                        connection.Close();
                        MessageBox.Show("Already You have an Student account...");
                        txtpassword.Text = "";
                        password.Text = "";
                        confirmpassword.Text = "";
                    }
                    else
                    {
                        connection.Close();
                        connection.Open();
                        SqlCommand insert = new SqlCommand(
                            "insert into StudentPassword values('" + txtpassword.Text + "','" + password.Text + "');", connection
                            );
                        insert.ExecuteNonQuery();
                        connection.Close();
                        StudentLogedForm stu = new StudentLogedForm();
                        stu.Visible = true;
                        this.Hide();
                    }

                }
                else
                {
                    connection.Close();
                    MessageBox.Show("There is no any RegNo insert by admin.......");
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

        private void no_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newAccount.Visible = true;
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
