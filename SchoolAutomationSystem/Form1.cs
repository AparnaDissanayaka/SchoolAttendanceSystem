using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolAutomationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Hiiiii.... You are login to Admin");
            AdminLogin ad = new AdminLogin();
            ad.Visible = true;
            this.Hide();
        }

        private void btnteacher_Click(object sender, EventArgs e)
        {
            TeacherLogin tl = new TeacherLogin();
            tl.Visible = true;
            this.Hide();

        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            StudentLogin sl = new StudentLogin();
            sl.Visible = true;
            this.Hide();
        }
    }
}
