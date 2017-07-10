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
    public partial class EditAdmin : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );
        public EditAdmin()
        {
            InitializeComponent();
        }

        private void EditAdmin_Load(object sender, EventArgs e)
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
            connection.Open();
            SqlCommand searchAdmin = new SqlCommand(
                "select * from AdminDetails where Name='" +cmbox.Text + "';", connection
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

        private void btnedit_Click(object sender, EventArgs e)
        {
            cmbox.Text = "";
            txtname.Text = "";
            txtnic.Text = "";
            txtposition.Text = "";
            txtdate.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = Convert.ToDateTime(txtdate.Text.ToString());
                int id = Convert.ToInt32(txtnic.Text.ToString());

                connection.Open();
                SqlCommand update = new SqlCommand(
                    "update AdminDetails set Name='" + txtname.Text + "',Position='" + txtposition.Text + "',StartDate='" + date + "' where NIC='" + id + "'"
                    );
                update.ExecuteNonQuery();
                MessageBox.Show("update is sucessfully complete....");
                connection.Close();
                comborun();
            }
            catch (Exception ex) {
                MessageBox.Show(""+ex);
            }
        }
    }
}
