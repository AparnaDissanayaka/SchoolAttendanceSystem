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
    public partial class AdminLogedForm : Form
    {
        private int childFormNumber = 0;

        public AdminLogedForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

     
        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacher = new AddTeacherForm();
            addTeacher.WindowState = FormWindowState.Maximized;
            addTeacher.MdiParent = this;
            addTeacher.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addstudent = new AddStudent();
            addstudent.WindowState = FormWindowState.Maximized;
            addstudent.MdiParent = this;
            addstudent.Show();
        }

        private void mainLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 exit = new Form1();
            exit.Visible = true;
            this.Hide();
        }

        private void teacherDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTeacherDetails editteacherdetails = new EditTeacherDetails();
            editteacherdetails.WindowState = FormWindowState.Maximized;
            editteacherdetails.MdiParent = this;
            editteacherdetails.Show();
           
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudent editDetail = new EditStudent();
            editDetail.WindowState = FormWindowState.Maximized;
            editDetail.MdiParent = this;
            editDetail.Show();

        }

        private void studentDetailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteStudent delStu = new DeleteStudent();
            delStu.WindowState = FormWindowState.Maximized;
            delStu.MdiParent = this;
            delStu.Show();
        }

        private void teacherDetailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteTeacher delTea = new DeleteTeacher();
            delTea.WindowState = FormWindowState.Maximized;
            delTea.MdiParent = this;
            delTea.Show();
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdmin addadmin = new AddAdmin();
            addadmin.WindowState = FormWindowState.Maximized;
            addadmin.MdiParent = this;
            addadmin.Show();
        }

        private void adminDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAdmin editadmin =new EditAdmin();
            editadmin.WindowState = FormWindowState.Maximized;
            editadmin.MdiParent =this;
            editadmin.Show();

        }

        private void AdminLogedForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            AddTeacherForm add = new AddTeacherForm();
            add.WindowState = FormWindowState.Maximized;
            add.MdiParent = this;
            add.Show();
        }

        private void adminDetailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteAdmin delAdmin = new DeleteAdmin();
            delAdmin.WindowState = FormWindowState.Maximized;
            delAdmin.MdiParent = this;
            delAdmin.Show();
        }

        private void viewAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherLogedForm lf = new TeacherLogedForm();
            lf.WindowState = FormWindowState.Normal;
            lf.MdiParent = this;
            lf.Show();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeTableScheduling table = new TimeTableScheduling();
            table.WindowState = FormWindowState.Maximized;
            table.MdiParent = this;
            table.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewTimeTable timeTable = new ViewTimeTable();
            timeTable.WindowState = FormWindowState.Maximized;
            timeTable.MdiParent = this;
            timeTable.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTimeTable edit = new EditTimeTable();
            edit.WindowState = FormWindowState.Maximized;
            edit.MdiParent = this;
            edit.Show();
        }

        private void mainLoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Visible = true;
            this.Hide();

        }

        private void teacherLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherLogin logout = new TeacherLogin();
            logout.Visible = true;
            this.Hide();
        }

        private void studenLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentLogin logout = new StudentLogin();
            logout.Visible = true;
            this.Hide();
        }

       
        
    }
}
