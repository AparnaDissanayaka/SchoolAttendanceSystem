using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SchoolAutomationSystem
{
    public partial class AddTeacherForm : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );

        String photo="";
        public AddTeacherForm()
        {
            InitializeComponent();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileEx = new OpenFileDialog();
            fileEx.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (fileEx.ShowDialog()== DialogResult.OK)
            {
                photo = fileEx.FileName.ToString();
                teacherPicture.ImageLocation = photo;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //get nic value and convert it into int
                String nicText = txtnic.Text;
                int nic = Convert.ToInt32(nicText);

                //get tel value and convert it in to int
                String telText = txttel.Text;
                int telno = Convert.ToInt32(telText);

                //get date and convrt it in to date format
                String dateText = this.dateTimePicker1.Text;
                DateTime date = Convert.ToDateTime(dateText.ToString());

                //get picture box 
                byte[] img = null;
                FileStream fs = new FileStream(photo, FileMode.Open, FileAccess.Read);
                BinaryReader picRead = new BinaryReader(fs);
                img = picRead.ReadBytes((int)fs.Length); 
                
                connection.Open();
                int id = Convert.ToInt32(txtnic.Text.ToString());

                SqlCommand checkTeacher = new SqlCommand(
                    "select* from TeacherDetails where NIC='"+id+"';",connection
                    );
                SqlDataReader readTeacher = checkTeacher.ExecuteReader();
                if (readTeacher.Read())
                {
                    connection.Close();
                    MessageBox.Show("Already exist this NIC in Teacher Details....","Warning..",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }
                else
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand addDetails = new SqlCommand(
                        "insert into TeacherDetails values('" + nic + "','" + cmbxsate.Text + "','" + txtname.Text + "','" + txtaddress.Text + "','" + telno + "','" + txtsubject.Text + "','" + date + "',@img);", connection
                        );
                    addDetails.Parameters.Add(new SqlParameter("@img", img));
                    addDetails.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Sucessfully insert data into table...","Sucessful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtnic.Text = "";
                    cmbxsate.Text = "";
                    txtname.Text = "";
                    txtaddress.Text = "";
                    txttel.Text = "";
                    txtsubject.Text = "";
                    teacherPicture.Image = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
       }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtnic.Text = "";
            cmbxsate.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txttel.Text = "";
            txtsubject.Text = "";
            teacherPicture.Image = null;
        }


        
    }
}
