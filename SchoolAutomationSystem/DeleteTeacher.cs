using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace SchoolAutomationSystem
{
    public partial class DeleteTeacher : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\documents\visual studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );
        //String photo = "";

        public DeleteTeacher()
        {
            InitializeComponent();
        }

        private void DeleteTeacher_Load(object sender, EventArgs e)
        {
            combox();

        }
        public void combox()
        {
            cmbox.Items.Clear();
            connection.Open();
            SqlCommand selectTeacher = new SqlCommand(
                "select * from TeacherDetails;", connection
                );
            SqlDataReader readTeacher = selectTeacher.ExecuteReader();
            while (readTeacher.Read())
            {
                cmbox.Items.Add(readTeacher["Name"].ToString());
            }
            connection.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand searchTeacher = new SqlCommand(
                    "select * from TeacherDetails where Name='" + cmbox.Text + "';", connection
                    );
                SqlDataReader readTeacher = searchTeacher.ExecuteReader();
                readTeacher.Read();
                if (readTeacher.HasRows)
                {
                    txtnic.Text = readTeacher[0].ToString();
                    txtName.Text = readTeacher[1].ToString();
                    txtstate.Text = readTeacher[2].ToString();
                    txtaddress.Text = readTeacher[3].ToString();
                    txttel.Text = readTeacher[4].ToString();
                    txtsubject.Text = readTeacher[5].ToString();
                    txtdate.Text = readTeacher[6].ToString();

                    byte[] img = (byte[])(readTeacher[7]);
                    if (img == null)
                    {
                        teacherPic.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        teacherPic.Image = Image.FromStream(ms);
                    }
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("there is no any deails....");
                 }
           }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand delTea = new SqlCommand(
                "delete from TeacherDetails where Name='"+cmbox.Text+"';",connection
                );
            delTea.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Sucessfully delete data.....");
            txtnic.Text = "";
            txtName.Text = "";
            txtstate.Text = "";
            txtaddress.Text = "";
            txtsubject.Text = "";
            txttel.Text = "";
            txtdate.Text = "";
            cmbox.Text = "";
            teacherPic.Image = null;
            combox();
            
        }

    }
}
