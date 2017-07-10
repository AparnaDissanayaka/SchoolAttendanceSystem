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
    public partial class AddStudent : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                //grade convert in to int
                String gradeText = cmboxGrade.Text;
                int grade = Convert.ToInt32(gradeText);

                //convert telno
                String telText = txtTel.Text;
                int tel = Convert.ToInt32(telText);

                //get gender value
                String gender = "";
                if (rbMale.Checked == true)
                { gender = "Male"; }
                else if (rbFemale.Checked == true)
                { gender = "Female"; }
                else { MessageBox.Show("Slect the gender"); }

                //get DOB
                String dobText = this.dateTimePicker1.Text;
                DateTime dob = Convert.ToDateTime(dobText.ToString());
                connection.Open();
                SqlCommand checkRegno = new SqlCommand(
                    "select * from StudentTable where RegNo='"+txtRegn.Text+"';",connection
                    );
                SqlDataReader readRegno = checkRegno.ExecuteReader();
                if (readRegno.Read())
                {
                    MessageBox.Show("This RegNo Already Exist ","Waning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand addTeacher = new SqlCommand(
                        "insert into StudentTable values('" + txtRegn.Text + "','" + txtname.Text + "','" + grade + "','" + txtAddress.Text + "','" + tel + "','" + gender + "','" + dob + "');", connection
                        );
                    addTeacher.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Sucessfully insert data into table...", "Sucessfull", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

                    txtRegn.Text = "";
                    txtname.Text = "";
                    txtAddress.Text = "";
                    cmboxGrade.Text = "";
                    txtTel.Text = "";
                    if (rbMale.Checked == true || rbFemale.Checked == false)
                    {
                        rbMale.Checked = false;
                    }
                    else if (rbMale.Checked == false || rbFemale.Checked == true)
                    {
                        rbFemale.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }

        }
    }
}
