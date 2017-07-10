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
    public partial class TeacherLogedForm : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );
        public TeacherLogedForm()
        {
            InitializeComponent();
           
        }

        public void comborun()
        {
            connection.Open();
            SqlCommand dr = new SqlCommand(
                "select * from StudentTable;", connection
                );
            SqlDataReader ddr = dr.ExecuteReader();
            while (ddr.Read())
            {
                cmbox.Items.Add(ddr["RegNo"]);
                regCombx.Items.Add(ddr["RegNo"]);

            }
            connection.Close();
        }
        
        private void TeacherLogedForm_Load(object sender, EventArgs e)
        {
            combox();
            comborun();
          //  this.WindowState = FormWindowState.Maximized;
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand ck = new SqlCommand(
               "select * from StudentTable where RegNo='" + cmbox.Text + "';", connection
                );
            SqlDataReader ckread = ck.ExecuteReader();
            if (ckread.Read())
            {
                setName.Text = ckread["Name"].ToString();
                setGrade.Text = ckread["Grade"].ToString();
                connection.Close();

            }
            else
            {
                setName.Text = "Check the RegNo";
                connection.Close();
            }
            
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            String dateString = this.dateTimePicker1.Text;
            DateTime date = Convert.ToDateTime(dateString.ToString());

            String attend = "";

            if (rbPresent.Checked == true)
            {
                attend = "Present";
            }
            else if (rbAbsent.Checked == true)
            {
                attend = "Absent";
            }
            else
            {
                MessageBox.Show("Are you sure Mark the attendance ?");
            }
            connection.Open();
            SqlCommand check = new SqlCommand(
                "select * from Attendance where Date='" + date + "' and RegNo='" + cmbox.Text+ "';", connection
                );
            SqlDataReader readDate = check.ExecuteReader();
            if (readDate.Read())
            {
                MessageBox.Show("Already Mark Attendance...","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                connection.Close();
            }
            else
            {
                connection.Close();
                connection.Open();
                SqlCommand add = new SqlCommand(
                    "insert into Attendance values('" + cmbox.Text + "','" + date + "','" + attend + "');", connection
                    );
                add.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sucessfully mak Attendance......");
                cmbox.Text = "";
                setName.Text = "";
                setGrade.Text = "";

                //set empty radio buttons.............

                if (rbAbsent.Checked == true || rbPresent.Checked == false)
                {
                    rbAbsent.Checked = false;
                }
                else if (rbAbsent.Checked == false || rbPresent.Checked == true)
                {
                    rbPresent.Checked = false;
                }
            }

        }

        private void btnview_Click(object sender, EventArgs e)
        {
                 table_load();
        }
        public void combox()
        {
            try
            {
                cmbox.Items.Clear();
                connection.Open();
                SqlCommand selectTeacher = new SqlCommand(
                    "select * from TeacherDetails;", connection
                    );
                SqlDataReader readTeacher = selectTeacher.ExecuteReader();
                while (readTeacher.Read())
                {
                    comboBox1.Items.Add(readTeacher["Name"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand searchTeacher = new SqlCommand(
                    "select * from TeacherDetails where Name='" + comboBox1.Text + "';", connection
                    );
                SqlDataReader readTeacher = searchTeacher.ExecuteReader();
                readTeacher.Read();
                if (readTeacher.HasRows)
                {
                    lbnic.Text = readTeacher["NIC"].ToString();
                    txtName.Text = readTeacher["Name"].ToString();
                    txtstate.Text = readTeacher["State"].ToString();
                    txtaddress.Text = readTeacher["Address"].ToString();
                    txttel.Text = readTeacher["TelNo"].ToString();
                    txtsubject.Text = readTeacher["Subject"].ToString();
                    txtdate.Text = readTeacher["Date"].ToString();

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
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
              connection.Open();
            SqlCommand searchStudent = new SqlCommand(
                "select * from StudentTable where RegNo='" + regCombx.Text + "';", connection
                );
            SqlDataReader readStudent = searchStudent.ExecuteReader();
            if (readStudent.Read())
            {
                txtregno.Text = readStudent["RegNo"].ToString();
                nametxt.Text = readStudent["Name"].ToString();
                txtgrade.Text = readStudent["Grade"].ToString();
                textBox1.Text = readStudent["Address"].ToString();
                textBox2.Text = readStudent["Tel"].ToString();
                txtgender.Text = readStudent["Gender"].ToString();
                txtdob.Text = readStudent["DOB"].ToString();
                connection.Close();
            }
            else {
                connection.Close();
                MessageBox.Show("there is no any student...");
            }
        }

        private void h_Click(object sender, EventArgs e)
        {

        }

        private void cmboxgrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void la_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        public void table_load()
        {
            try
            {

                String dateString = this.dateTimePicker2.Text;
                DateTime date = Convert.ToDateTime(dateString.ToString());

                //String gradeText = cmboxgrade.Text;
                //int grade = Convert.ToInt32(gradeText);

               
                    connection.Open();
                    SqlCommand viewattendance = new SqlCommand(
                        "select Attendance.Regno,StudentTable.Name,StudentTable.Grade,Attendance.Attendance,Attendance.Date from Attendance,StudentTable where Attendance.RegNo=StudentTable.RegNo and Attendance.Date='"+date+"';",connection
                        );
                    SqlDataAdapter viewadapter = new SqlDataAdapter();
                    viewadapter.SelectCommand = viewattendance;
                    DataTable table1 = new DataTable();

                    viewadapter.Fill(table1);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = table1;
                    dataGridView1.DataSource = bSource;
                    viewadapter.Update(table1);
                    connection.Close();    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void view_Click(object sender, EventArgs e)
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
                    "select * from ELEVEN_Time_Table; ", connection
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

        private void dataGridViewTimeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectgrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Visible = true;
            this.Hide();
        }

   }
    
}

       
    
    

