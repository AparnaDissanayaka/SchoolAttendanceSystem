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
    public partial class DeleteAdmin : Form
    {
        SqlConnection connection = new SqlConnection(
              @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
              );
        public DeleteAdmin()
        {
            InitializeComponent();
        }

        private void DeleteAdmin_Load(object sender, EventArgs e)
        {
            comborun();
        }
        public void comborun()
        {
            cmbox.Items.Clear();
            connection.Open();
            SqlCommand addData = new SqlCommand(
                "select * from AdminDetails;", connection
                );
            SqlDataReader readData = addData.ExecuteReader();
            while (readData.Read())
            {
                cmbox.Items.Add(readData["Name"]);
            }
            connection.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand searchAdmin = new SqlCommand(
                    "select * from AdminDetails where Name='" + cmbox.Text + "';", connection
                    );
                SqlDataReader readAdmin = searchAdmin.ExecuteReader();
                if (readAdmin.Read())
                {
                    txtname.Text = readAdmin["Name"].ToString();
                    txtnic.Text = readAdmin["NIC"].ToString();
                    txtposition.Text = readAdmin["Position"].ToString();
                    txtdate.Text = readAdmin["StartDate"].ToString();

                    connection.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(""+ex);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data will delete permanently..","",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            connection.Open();
            SqlCommand deleteAdmin = new SqlCommand(
              "delete from AdminDetails where Name='"+cmbox.Text+"'",connection
                );
            deleteAdmin.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand rdpassword = new SqlCommand(
                "select * from AdminPassword where AdminName='"+cmbox.Text+"'",connection
                );
            SqlDataReader rd = rdpassword.ExecuteReader();
            if (rd.Read())
            {
                connection.Close();
                connection.Open();
                SqlCommand delAd = new SqlCommand(
                    "delete from AdminPassword where AdminName='" + cmbox.Text + "'", connection
                    );
                delAd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sucessfully delete all " + cmbox.Text + "'s data... ","",MessageBoxButtons.OK,MessageBoxIcon.None);
                cmbox.Text = "";
                txtnic.Text = "";
                txtname.Text = "";
                txtposition.Text = "";
                txtdate.Text = "";
            }
            else
            {
                connection.Close();
                MessageBox.Show("There is nothing any Admin "+cmbox.Text+""," Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            
            }

            comborun();
        }
    }
}
