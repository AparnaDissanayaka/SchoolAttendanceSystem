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
    public partial class TimeTableScheduling : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );

        public TimeTableScheduling()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (cmbox.Text == "Six")
            {
                connection.Open();
                SqlCommand AddTimeTable = new SqlCommand(
                    "insert into Time_Table_6 values('" + lb1.Text + "','" + mon1.Text + "','" + tue1.Text + "','" + wed1.Text + "','" + thu1.Text + "','" + fri1.Text + "'),('" + lb2.Text + "','" + mon2.Text + "','" + tue2.Text + "','" + wed2.Text + "','" + thu2.Text + "','" + fri2.Text + "'),('" + lb3.Text + "','" + mon3.Text + "','" + tue3.Text + "','" + wed3.Text + "','" + thu3.Text + "','" + fri3.Text + "'),('" + lb4.Text + "','" + mon4.Text + "','" + tue4.Text + "','" + wed4.Text + "','" + thu4.Text + "','" + fri4.Text + "'),('" + lb5.Text + "','" + mon5.Text + "','" + tue5.Text + "','" + wed5.Text + "','" + thu5.Text + "','" + fri5.Text + "'),('" + lb6.Text + "','" + mon6.Text + "','" + tue6.Text + "','" + wed6.Text + "','" + thu6.Text + "','" + fri6.Text + "'),('" + lb7.Text + "','" + mon7.Text + "','" + tue7.Text + "','" + wed7.Text + "','" + thu7.Text + "','" + fri7.Text + "'),('" + lb8.Text + "','" + mon8.Text + "','" + tue8.Text + "','" + wed8.Text + "','" + thu8.Text + "','" + fri8.Text + "');", connection
                    );
                AddTimeTable.ExecuteNonQuery();
                MessageBox.Show("Sucessfully insert Grade Six Time Table...");
                connection.Close();

                Clear_table();

            }
            else if (cmbox.Text == "Seven")
            {
                connection.Open();
                SqlCommand AddTimeTable = new SqlCommand(
                    "insert into SEVEN_Time_Table values('" + mon1.Text + "','" + tue1.Text + "','" + wed1.Text + "','" + thu1.Text + "','" + fri1.Text + "'),('" + mon2.Text + "','" + tue2.Text + "','" + wed2.Text + "','" + thu2.Text + "','" + fri2.Text + "'),('" + mon3.Text + "','" + tue3.Text + "','" + wed3.Text + "','" + thu3.Text + "','" + fri3.Text + "'),('" + mon4.Text + "','" + tue4.Text + "','" + wed4.Text + "','" + thu4.Text + "','" + fri4.Text + "'),('" + mon5.Text + "','" + tue5.Text + "','" + wed5.Text + "','" + thu5.Text + "','" + fri5.Text + "'),('" + mon6.Text + "','" + tue6.Text + "','" + wed6.Text + "','" + thu6.Text + "','" + fri6.Text + "'),('" + mon7.Text + "','" + tue7.Text + "','" + wed7.Text + "','" + thu7.Text + "','" + fri7.Text + "'),('" + mon8.Text + "','" + tue8.Text + "','" + wed8.Text + "','" + thu8.Text + "','" + fri8.Text + "');", connection
                    );
                AddTimeTable.ExecuteNonQuery();
                MessageBox.Show("Sucessfully insert Grade Seven Time Table...");
                connection.Close();

                Clear_table();

            }
            else if (cmbox.Text == "Eight")
            {
                connection.Open();
                SqlCommand AddTimeTable = new SqlCommand(
                    "insert into EIGHT_Time_Table values('" + mon1.Text + "','" + tue1.Text + "','" + wed1.Text + "','" + thu1.Text + "','" + fri1.Text + "'),('" + mon2.Text + "','" + tue2.Text + "','" + wed2.Text + "','" + thu2.Text + "','" + fri2.Text + "'),('" + mon3.Text + "','" + tue3.Text + "','" + wed3.Text + "','" + thu3.Text + "','" + fri3.Text + "'),('" + mon4.Text + "','" + tue4.Text + "','" + wed4.Text + "','" + thu4.Text + "','" + fri4.Text + "'),('" + mon5.Text + "','" + tue5.Text + "','" + wed5.Text + "','" + thu5.Text + "','" + fri5.Text + "'),('" + mon6.Text + "','" + tue6.Text + "','" + wed6.Text + "','" + thu6.Text + "','" + fri6.Text + "'),('" + mon7.Text + "','" + tue7.Text + "','" + wed7.Text + "','" + thu7.Text + "','" + fri7.Text + "'),('" + mon8.Text + "','" + tue8.Text + "','" + wed8.Text + "','" + thu8.Text + "','" + fri8.Text + "');", connection
                    );
                AddTimeTable.ExecuteNonQuery();
                MessageBox.Show("Sucessfully insert Grade Eight Time Table...");
                connection.Close();

                Clear_table();

            }
            else if (cmbox.Text == "Nine")
            {
                connection.Open();
                SqlCommand AddTimeTable = new SqlCommand(
                    "insert into NINE_Time_Table values('" + mon1.Text + "','" + tue1.Text + "','" + wed1.Text + "','" + thu1.Text + "','" + fri1.Text + "'),('" + mon2.Text + "','" + tue2.Text + "','" + wed2.Text + "','" + thu2.Text + "','" + fri2.Text + "'),('" + mon3.Text + "','" + tue3.Text + "','" + wed3.Text + "','" + thu3.Text + "','" + fri3.Text + "'),('" + mon4.Text + "','" + tue4.Text + "','" + wed4.Text + "','" + thu4.Text + "','" + fri4.Text + "'),('" + mon5.Text + "','" + tue5.Text + "','" + wed5.Text + "','" + thu5.Text + "','" + fri5.Text + "'),('" + mon6.Text + "','" + tue6.Text + "','" + wed6.Text + "','" + thu6.Text + "','" + fri6.Text + "'),('" + mon7.Text + "','" + tue7.Text + "','" + wed7.Text + "','" + thu7.Text + "','" + fri7.Text + "'),('" + mon8.Text + "','" + tue8.Text + "','" + wed8.Text + "','" + thu8.Text + "','" + fri8.Text + "');", connection
                    );
                AddTimeTable.ExecuteNonQuery();
                MessageBox.Show("Sucessfully insert Grade Nine Time Table...");
                connection.Close();

                Clear_table();

            }
          else  if (cmbox.Text == "Ten")
            {
                connection.Open();
                SqlCommand AddTimeTable = new SqlCommand(
                    "insert into TEN_Time_Table values('" + mon1.Text + "','" + tue1.Text + "','" + wed1.Text + "','" + thu1.Text + "','" + fri1.Text + "'),('" + mon2.Text + "','" + tue2.Text + "','" + wed2.Text + "','" + thu2.Text + "','" + fri2.Text + "'),('" + mon3.Text + "','" + tue3.Text + "','" + wed3.Text + "','" + thu3.Text + "','" + fri3.Text + "'),('" + mon4.Text + "','" + tue4.Text + "','" + wed4.Text + "','" + thu4.Text + "','" + fri4.Text + "'),('" + mon5.Text + "','" + tue5.Text + "','" + wed5.Text + "','" + thu5.Text + "','" + fri5.Text + "'),('" + mon6.Text + "','" + tue6.Text + "','" + wed6.Text + "','" + thu6.Text + "','" + fri6.Text + "'),('" + mon7.Text + "','" + tue7.Text + "','" + wed7.Text + "','" + thu7.Text + "','" + fri7.Text + "'),('" + mon8.Text + "','" + tue8.Text + "','" + wed8.Text + "','" + thu8.Text + "','" + fri8.Text + "');", connection
                    );
                AddTimeTable.ExecuteNonQuery();
                MessageBox.Show("Sucessfully insert Grade Ten Time Table...");
                connection.Close();

                Clear_table();

            }
            else if (cmbox.Text == "Eleven")
            {
                connection.Open();
                SqlCommand AddTimeTable = new SqlCommand(
                    "insert into TEN_Time_Table values('" + mon1.Text + "','" + tue1.Text + "','" + wed1.Text + "','" + thu1.Text + "','" + fri1.Text + "'),('" + mon2.Text + "','" + tue2.Text + "','" + wed2.Text + "','" + thu2.Text + "','" + fri2.Text + "'),('" + mon3.Text + "','" + tue3.Text + "','" + wed3.Text + "','" + thu3.Text + "','" + fri3.Text + "'),('" + mon4.Text + "','" + tue4.Text + "','" + wed4.Text + "','" + thu4.Text + "','" + fri4.Text + "'),('" + mon5.Text + "','" + tue5.Text + "','" + wed5.Text + "','" + thu5.Text + "','" + fri5.Text + "'),('" + mon6.Text + "','" + tue6.Text + "','" + wed6.Text + "','" + thu6.Text + "','" + fri6.Text + "'),('" + mon7.Text + "','" + tue7.Text + "','" + wed7.Text + "','" + thu7.Text + "','" + fri7.Text + "'),('" + mon8.Text + "','" + tue8.Text + "','" + wed8.Text + "','" + thu8.Text + "','" + fri8.Text + "');", connection
                    );
                AddTimeTable.ExecuteNonQuery();
                MessageBox.Show("Sucessfully insert Grade Eleven Time Table...");
                connection.Close();

                Clear_table();

            }
            else if (cmbox.Text == "Twelve")
            {
                connection.Open();
                SqlCommand AddTimeTable = new SqlCommand(
                    "insert into TEN_Time_Table values('" + mon1.Text + "','" + tue1.Text + "','" + wed1.Text + "','" + thu1.Text + "','" + fri1.Text + "'),('" + mon2.Text + "','" + tue2.Text + "','" + wed2.Text + "','" + thu2.Text + "','" + fri2.Text + "'),('" + mon3.Text + "','" + tue3.Text + "','" + wed3.Text + "','" + thu3.Text + "','" + fri3.Text + "'),('" + mon4.Text + "','" + tue4.Text + "','" + wed4.Text + "','" + thu4.Text + "','" + fri4.Text + "'),('" + mon5.Text + "','" + tue5.Text + "','" + wed5.Text + "','" + thu5.Text + "','" + fri5.Text + "'),('" + mon6.Text + "','" + tue6.Text + "','" + wed6.Text + "','" + thu6.Text + "','" + fri6.Text + "'),('" + mon7.Text + "','" + tue7.Text + "','" + wed7.Text + "','" + thu7.Text + "','" + fri7.Text + "'),('" + mon8.Text + "','" + tue8.Text + "','" + wed8.Text + "','" + thu8.Text + "','" + fri8.Text + "');", connection
                    );
                AddTimeTable.ExecuteNonQuery();
                MessageBox.Show("Sucessfully insert Grade Twelve Time Table...");
                connection.Close();

                Clear_table();

            }
            else if (cmbox.Text == "Thirteen")
            {
                connection.Open();
                SqlCommand AddTimeTable = new SqlCommand(
                    "insert into TEN_Time_Table values('" + mon1.Text + "','" + tue1.Text + "','" + wed1.Text + "','" + thu1.Text + "','" + fri1.Text + "'),('" + mon2.Text + "','" + tue2.Text + "','" + wed2.Text + "','" + thu2.Text + "','" + fri2.Text + "'),('" + mon3.Text + "','" + tue3.Text + "','" + wed3.Text + "','" + thu3.Text + "','" + fri3.Text + "'),('" + mon4.Text + "','" + tue4.Text + "','" + wed4.Text + "','" + thu4.Text + "','" + fri4.Text + "'),('" + mon5.Text + "','" + tue5.Text + "','" + wed5.Text + "','" + thu5.Text + "','" + fri5.Text + "'),('" + mon6.Text + "','" + tue6.Text + "','" + wed6.Text + "','" + thu6.Text + "','" + fri6.Text + "'),('" + mon7.Text + "','" + tue7.Text + "','" + wed7.Text + "','" + thu7.Text + "','" + fri7.Text + "'),('" + mon8.Text + "','" + tue8.Text + "','" + wed8.Text + "','" + thu8.Text + "','" + fri8.Text + "');", connection
                    );
                AddTimeTable.ExecuteNonQuery();
                MessageBox.Show("Sucessfully insert Grade Thirteen Time Table...");
                connection.Close();

                Clear_table();

            }
            
            else {
                MessageBox.Show("Select the grade..","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        void Clear_table()
        {
            mon1.Text = ""; mon2.Text = ""; mon3.Text = ""; mon4.Text = ""; mon5.Text = ""; mon6.Text = ""; mon7.Text = ""; mon8.Text = "";
            tue1.Text = ""; tue2.Text = ""; tue3.Text = ""; tue4.Text = ""; tue5.Text = ""; tue6.Text = ""; tue7.Text = ""; tue8.Text = "";
            wed1.Text = ""; wed2.Text = ""; wed3.Text = ""; wed4.Text = ""; wed5.Text = ""; wed6.Text = ""; wed7.Text = ""; wed8.Text = "";
            thu1.Text = ""; thu2.Text = ""; thu3.Text = ""; thu4.Text = ""; thu5.Text = ""; thu6.Text = ""; thu7.Text = ""; thu8.Text = "";
            fri1.Text = ""; fri2.Text = ""; fri3.Text = ""; fri4.Text = ""; fri5.Text = ""; fri6.Text = ""; fri7.Text = ""; fri8.Text = "";
        
        }

       
    }
}
