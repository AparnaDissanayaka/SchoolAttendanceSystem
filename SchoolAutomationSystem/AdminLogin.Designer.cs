namespace SchoolAutomationSystem
{
    partial class AdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadminname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newAccount = new System.Windows.Forms.GroupBox();
            this.login = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.txtadmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.LinkLabel();
            this.no = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnstudentlogin = new System.Windows.Forms.Button();
            this.btnteacherlogin = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.newAccount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(25, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 200);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Name";
            // 
            // txtadminname
            // 
            this.txtadminname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadminname.Location = new System.Drawing.Point(363, 86);
            this.txtadminname.Name = "txtadminname";
            this.txtadminname.Size = new System.Drawing.Size(145, 26);
            this.txtadminname.TabIndex = 1;
            this.txtadminname.Text = "Dhammika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pass Word";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(363, 136);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(145, 26);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Text = "456";
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(389, 175);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(119, 33);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.newAccount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.yes);
            this.groupBox1.Controls.Add(this.no);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtadminname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 468);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // newAccount
            // 
            this.newAccount.Controls.Add(this.login);
            this.newAccount.Controls.Add(this.password);
            this.newAccount.Controls.Add(this.confirmpassword);
            this.newAccount.Controls.Add(this.txtadmin);
            this.newAccount.Controls.Add(this.label5);
            this.newAccount.Controls.Add(this.label6);
            this.newAccount.Controls.Add(this.label7);
            this.newAccount.Location = new System.Drawing.Point(43, 295);
            this.newAccount.Name = "newAccount";
            this.newAccount.Size = new System.Drawing.Size(465, 163);
            this.newAccount.TabIndex = 12;
            this.newAccount.TabStop = false;
            this.newAccount.Visible = false;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Hobo Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(284, 130);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(87, 30);
            this.login.TabIndex = 3;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Hobo Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(195, 68);
            this.password.Name = "password";
            this.password.PasswordChar = '0';
            this.password.Size = new System.Drawing.Size(175, 25);
            this.password.TabIndex = 1;
            // 
            // confirmpassword
            // 
            this.confirmpassword.Font = new System.Drawing.Font("Hobo Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassword.Location = new System.Drawing.Point(195, 99);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.PasswordChar = '0';
            this.confirmpassword.Size = new System.Drawing.Size(175, 25);
            this.confirmpassword.TabIndex = 1;
            // 
            // txtadmin
            // 
            this.txtadmin.Font = new System.Drawing.Font("Hobo Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmin.Location = new System.Drawing.Point(196, 38);
            this.txtadmin.Name = "txtadmin";
            this.txtadmin.Size = new System.Drawing.Size(175, 25);
            this.txtadmin.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hobo Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "PassWord";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hobo Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Admin Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hobo Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "ConfirmPassword";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "/";
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.Location = new System.Drawing.Point(283, 269);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(38, 23);
            this.yes.TabIndex = 10;
            this.yes.TabStop = true;
            this.yes.Text = "Yes";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(327, 269);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(34, 23);
            this.no.TabIndex = 9;
            this.no.TabStop = true;
            this.no.Text = "NO";
            this.no.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.no_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hobo Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Have You An Account?";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.btnstudentlogin);
            this.groupBox2.Controls.Add(this.btnteacherlogin);
            this.groupBox2.Controls.Add(this.btnback);
            this.groupBox2.Location = new System.Drawing.Point(544, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 468);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnstudentlogin
            // 
            this.btnstudentlogin.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudentlogin.Location = new System.Drawing.Point(27, 259);
            this.btnstudentlogin.Name = "btnstudentlogin";
            this.btnstudentlogin.Size = new System.Drawing.Size(138, 45);
            this.btnstudentlogin.TabIndex = 0;
            this.btnstudentlogin.Text = "Student Login";
            this.btnstudentlogin.UseVisualStyleBackColor = true;
            this.btnstudentlogin.Click += new System.EventHandler(this.btnstudentlogin_Click);
            // 
            // btnteacherlogin
            // 
            this.btnteacherlogin.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteacherlogin.Location = new System.Drawing.Point(27, 175);
            this.btnteacherlogin.Name = "btnteacherlogin";
            this.btnteacherlogin.Size = new System.Drawing.Size(138, 45);
            this.btnteacherlogin.TabIndex = 0;
            this.btnteacherlogin.Text = "Teacher Login";
            this.btnteacherlogin.UseVisualStyleBackColor = true;
            this.btnteacherlogin.Click += new System.EventHandler(this.btnteacherlogin_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(27, 97);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(138, 45);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(743, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.newAccount.ResumeLayout(false);
            this.newAccount.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadminname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnstudentlogin;
        private System.Windows.Forms.Button btnteacherlogin;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel yes;
        private System.Windows.Forms.LinkLabel no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox newAccount;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confirmpassword;
        private System.Windows.Forms.TextBox txtadmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

    }
}