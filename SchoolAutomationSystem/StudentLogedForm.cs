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

    public partial class StudentLogedForm : Form
    {
        //public var
        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );

        public String passar2 = StudentLogin.passar;

        public StudentLogedForm()
        {
            InitializeComponent();
        }

        private void StudentLogedForm_Load(object sender, EventArgs e)
        {
            comTea();
            lbregno.Text = StudentLogin.passar;
            regno.Text = StudentLogin.passar;
            My_Details();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Visible = true;
            this.Hide();
        }
        void My_Details() 
        {
            connection.Open();
            SqlCommand check = new SqlCommand(
                "select * from StudentTable where RegNo='" + lbregno.Text + "';", connection
                );
            SqlDataReader read = check.ExecuteReader();
            if (read.Read())
            {
                getName.Text = read["Name"].ToString();
                getGrade.Text = read["Grade"].ToString();
                getAddress.Text = read["Address"].ToString();
                getTel.Text = read["Tel"].ToString();
                getGender.Text = read["Gender"].ToString();
                getDOB.Text = read["DOB"].ToString();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Incorrect RegNo...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        
        }

       

        private void view_Click(object sender, EventArgs e)
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

                    name.Text = readTeacher[1].ToString();
                    state.Text = readTeacher[2].ToString();
                    address.Text = readTeacher[3].ToString();
                    tel.Text = readTeacher[4].ToString();
                    subject.Text = readTeacher[5].ToString();
                    date.Text = readTeacher[6].ToString();

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
                    MessageBox.Show("There is no any deails....", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        public void comTea()
        {
            connection.Open();
            SqlCommand check = new SqlCommand(
                "select * from TeacherDetails;", connection
                );
            SqlDataReader readTea = check.ExecuteReader();
            while (readTea.Read())
            {
                cmbox.Items.Add(readTea["Name"]);
            }
            connection.Close();


        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                String dateString = this.dateTimePicker1.Text;
                DateTime date = Convert.ToDateTime(dateString);

                connection.Open();
                SqlCommand read = new SqlCommand(
                    "select * from Attendance where Date='" + date + "'and RegNo='" + regno.Text + "'", connection
                    );
                SqlDataReader readed = read.ExecuteReader();
                if (readed.Read())
                {
                    txtattendance.Text = readed["Attendance"].ToString();
                    connection.Close();

                }
                else
                {
                    connection.Close();
                    txtattendance.Text = " can not read attendance";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't read Attendance..."+ex, "Something going to wrong", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (selectgrade.Text == "Six")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_6; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable6 = new DataTable();
                dataadapter.Fill(TimeTable6);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable6;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable6);
                connection.Close();

            }
            else if (selectgrade.Text == "Seven")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_7; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable7 = new DataTable();
                dataadapter.Fill(TimeTable7);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable7;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable7);
                connection.Close();


            }
            else if (selectgrade.Text == "Eight")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_8; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable8 = new DataTable();
                dataadapter.Fill(TimeTable8);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable8;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable8);
                connection.Close();


            }
            else if (selectgrade.Text == "Nine")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_9; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable9 = new DataTable();
                dataadapter.Fill(TimeTable9);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable9;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable9);
                connection.Close();


            }
            else if (selectgrade.Text == "Ten")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_10; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable10 = new DataTable();
                dataadapter.Fill(TimeTable10);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable10;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable10);
                connection.Close();



            }
            else if (selectgrade.Text == "Eleven")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_11; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable11 = new DataTable();
                dataadapter.Fill(TimeTable11);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable11;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable11);
                connection.Close();


            }
            else if (selectgrade.Text == "Twelve")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_12; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable12 = new DataTable();
                dataadapter.Fill(TimeTable12);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable12;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable12);
                connection.Close();



            }
            else if (selectgrade.Text == "Thirteen")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_13; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable13 = new DataTable();
                dataadapter.Fill(TimeTable13);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable13;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable13);
                connection.Close();


            }

            else
            {
                MessageBox.Show("Select the grade..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
