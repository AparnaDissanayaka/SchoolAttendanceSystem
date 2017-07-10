namespace SchoolAutomationSystem
{
    partial class EditTimeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTimeTable));
            this.dataGridViewTimeTable = new System.Windows.Forms.DataGridView();
            this.btnview = new System.Windows.Forms.Button();
            this.cmbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTimeTable
            // 
            this.dataGridViewTimeTable.AllowUserToOrderColumns = true;
            this.dataGridViewTimeTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimeTable.Location = new System.Drawing.Point(34, 68);
            this.dataGridViewTimeTable.Name = "dataGridViewTimeTable";
            this.dataGridViewTimeTable.Size = new System.Drawing.Size(658, 227);
            this.dataGridViewTimeTable.TabIndex = 103;
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(457, 34);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(95, 28);
            this.btnview.TabIndex = 102;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // cmbox
            // 
            this.cmbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox.FormattingEnabled = true;
            this.cmbox.Items.AddRange(new object[] {
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Eleven",
            "Twelve",
            "Thirteen"});
            this.cmbox.Location = new System.Drawing.Point(244, 34);
            this.cmbox.Name = "cmbox";
            this.cmbox.Size = new System.Drawing.Size(176, 28);
            this.cmbox.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Select the Grade";
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(496, 312);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 37);
            this.btnupdate.TabIndex = 104;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // EditTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 397);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dataGridViewTimeTable);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.cmbox);
            this.Controls.Add(this.label1);
            this.Name = "EditTimeTable";
            this.Text = "EditTimeTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTimeTable;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.ComboBox cmbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
    }
}