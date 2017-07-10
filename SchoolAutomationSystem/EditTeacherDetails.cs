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
    public partial class EditTeacherDetails : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\documents\visual studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );
        String photo = "";
        public EditTeacherDetails()
        {
            InitializeComponent();
        }

        private void EditTeacherDetails_Load(object sender, EventArgs e)
        {
            combox();
        }
        public void combox() {
            cmbox.Items.Clear();
            connection.Open();
            SqlCommand selectTeacher = new SqlCommand(
                "select * from TeacherDetails;",connection
                );
            SqlDataReader readTeacher = selectTeacher.ExecuteReader();
            while(readTeacher.Read()){
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
                if(readTeacher.HasRows)
                {
                    lbnic.Text = readTeacher["NIC"].ToString();
                    txtName.Text = readTeacher["Name"].ToString();
                    txtstate.Text = readTeacher["State"].ToString();
                    txtaddress.Text = readTeacher["Address"].ToString();
                    txttel.Text = readTeacher["TelNo"].ToString();
                    txtsubject.Text = readTeacher["Subject"].ToString();
                    txtdate.Text=readTeacher["Date"].ToString();

                    byte [] img=(byte[])(readTeacher[7]);
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
                MessageBox.Show(""+ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Visible = true;
            this.Hide();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtstate.Text = "";
            txtaddress.Text= "";
            txtsubject.Text = "";
            txttel.Text = "";
            txtdate.Text = "";
            teacherPic.Image = null;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
            String nic = lbnic.Text;
                //int ewa string walata convert karanna.  :-(
                int tel = Convert.ToInt32(txttel.Text.ToString());
                //convert date to DateTime Format
                String dateString = txtdate.Text;
                DateTime date = Convert.ToDateTime(dateString.ToString());

                //get picture
                byte[] img = null;
                FileStream fs = new FileStream(photo, FileMode.Open, FileAccess.Read);
                BinaryReader picRead = new BinaryReader(fs);
                img = picRead.ReadBytes((int)fs.Length); 

                connection.Open();
                SqlCommand update = new SqlCommand(
                    "update TeacherDetails set State='"+txtstate.Text+"',Name='"+txtName.Text+"',Address='"+txtaddress.Text+"',TelNo='"+tel+"',Subject='"+txtsubject.Text+"',Date='"+date+"',Photo=@img where NIC='"+nic+"';",connection
                    );
                update.Parameters.Add(new SqlParameter("@img", img));
                update.ExecuteNonQuery();
                connection.Close();

                lbnic.Text = "";
                txtName.Text = "";
                txtstate.Text = "";
                txttel.Text = "";
                txtaddress.Text = "";
                txtsubject.Text = "";
                txtdate.Text = "";
                teacherPic.Image = null;

                combox();
                MessageBox.Show("sucessfuly updated....");
            }
            catch (Exception ex) 
            {
                connection.Close();
                MessageBox.Show(""+ex);
            }
        }

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileEx = new OpenFileDialog();
            fileEx.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (fileEx.ShowDialog() == DialogResult.OK)
            {
                photo = fileEx.FileName.ToString();
                teacherPic.ImageLocation = photo;
            }
        }

    }
}
