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
    public partial class AddAdmin : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
            );
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String dateText = this.dateTimePicker1.Text;
            DateTime date = Convert.ToDateTime(dateText.ToString());

            connection.Open();
            SqlCommand checkNIC = new SqlCommand(
                "select * from AdminDetails where NIC='"+txtnic.Text+";'",connection
                );
            SqlDataReader readNIC = checkNIC.ExecuteReader();
            if (readNIC.Read())
            {
                connection.Close();
                MessageBox.Show("This admin already exist...","",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            else {
                connection.Close();
                connection.Open();
                SqlCommand addAdmin = new SqlCommand(
                    "insert into AdminDetails values('"+txtnic.Text+"','"+txtname.Text+"','"+txtposition.Text+"','"+date+"');",connection
                    );
                addAdmin.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("sucessfully add admin Details....","",MessageBoxButtons.OKCancel,MessageBoxIcon.None);
                txtnic.Text = "";
                txtname.Text = "";
                txtposition.Text = "";
            
            }
        }
    }
}
