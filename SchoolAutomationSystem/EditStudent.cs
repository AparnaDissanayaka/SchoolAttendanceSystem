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
    public partial class EditStudent : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );
        public EditStudent()
        {
            InitializeComponent();
        }
        public void comboxrun()
        {
            connection.Open();
            SqlCommand addData = new SqlCommand(
                "select * from StudentTable;",connection
                );
            SqlDataReader readData = addData.ExecuteReader();
            while (readData.Read())
            {
                regCombx.Items.Add(readData["RegNo"]);
            }
            connection.Close();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            comboxrun();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand searchStudent = new SqlCommand(
                "select * from StudentTable where RegNo='"+regCombx.Text+"';",connection
                );
            SqlDataReader readStudent = searchStudent.ExecuteReader();
            if (readStudent.Read())
            {
                txtregno.Text = readStudent["RegNo"].ToString();
                txtname.Text = readStudent["Name"].ToString();
                txtgrade.Text = readStudent["Grade"].ToString();
                txtaddress.Text = readStudent["Address"].ToString();
                txttel.Text = readStudent["Tel"].ToString();
                txtgender.Text = readStudent["Gender"].ToString();
                txtdob.Text = readStudent["DOB"].ToString();
                connection.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            regCombx.Text = "";
            txtregno.Text = "";
            txtname.Text = "";
            txtgrade.Text = "";
            txtaddress.Text = "";
            txttel.Text = "";
            txtgender.Text = "";
            txtdob.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //grade convert in to int
            String gradeText = txtgrade.Text;
            int grade = Convert.ToInt32(gradeText);

            //convert telno
            String telText = txttel.Text;
            int tel = Convert.ToInt32(telText);

            //get DOB
            
            DateTime dob = Convert.ToDateTime(txtdob.Text.ToString());

            connection.Open();
            SqlCommand update = new SqlCommand(
                "update StudentTable set RegNo='"+txtregno.Text+"',Name='"+txtname.Text+"',Grade='"+grade+"',Address='"+txtaddress.Text+"',Tel='"+tel+"',Gender='"+txtgender.Text+"',DOB='"+dob+"' where RegNo='"+regCombx.Text+"';",connection
                );
            update.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfully update data...");
            regCombx.Text = "";
            txtregno.Text = "";
            txtname.Text = "";
            txtgrade.Text = "";
            txtaddress.Text = "";
            txttel.Text = "";
            txtgender.Text = "";
            txtdob.Text = "";
        }



    }
}
