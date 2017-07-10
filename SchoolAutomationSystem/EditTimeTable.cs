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
    public partial class EditTimeTable : Form
    {
        SqlConnection connection = new SqlConnection(
               @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Visual Studio 2010\Projects\SchoolAutomationSystem\SchoolAutomationSystem\SchoolDB.mdf;Integrated Security=True;User Instance=True"
               );

        public EditTimeTable()
        {
            InitializeComponent();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (cmbox.Text == "Six")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_6; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable6 = new DataTable();
                dataadapter.Fill(TimeTable6);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable6;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable6);
                connection.Close();

            }
            else if (cmbox.Text == "Seven")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_7; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable7 = new DataTable();
                dataadapter.Fill(TimeTable7);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable7;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable7);
                connection.Close();


            }
            else if (cmbox.Text == "Eight")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_8; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable8 = new DataTable();
                dataadapter.Fill(TimeTable8);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable8;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable8);
                connection.Close();


            }
            else if (cmbox.Text == "Nine")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_9; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable9 = new DataTable();
                dataadapter.Fill(TimeTable9);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable9;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable9);
                connection.Close();


            }
            else if (cmbox.Text == "Ten")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_10; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable10 = new DataTable();
                dataadapter.Fill(TimeTable10);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable10;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable10);
                connection.Close();



            }
            else if (cmbox.Text == "Eleven")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_11; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable11 = new DataTable();
                dataadapter.Fill(TimeTable11);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable11;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable11);
                connection.Close();


            }
            else if (cmbox.Text == "Twelve")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_12; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable12 = new DataTable();
                dataadapter.Fill(TimeTable12);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable12;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable12);
                connection.Close();



            }
            else if (cmbox.Text == "Thirteen")
            {
                connection.Open();
                SqlCommand ViewTimeTable = new SqlCommand(
                    "select * from Time_Table_13; ", connection
                    );
                SqlDataAdapter dataadapter = new SqlDataAdapter();
                dataadapter.SelectCommand = ViewTimeTable;
                DataTable TimeTable13 = new DataTable();
                dataadapter.Fill(TimeTable13);

                BindingSource source = new BindingSource();
                source.DataSource = TimeTable13;
                dataGridViewTimeTable.DataSource = source;
                dataadapter.Update(TimeTable13);
                connection.Close();


            }

            else
            {
                MessageBox.Show("Select the grade..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cmbox.Text == "Six")
            {
                String val0 = dataGridViewTimeTable[0, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val1 = dataGridViewTimeTable[1, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val2 = dataGridViewTimeTable[2, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val3 = dataGridViewTimeTable[3, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val4 = dataGridViewTimeTable[4, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val5 = dataGridViewTimeTable[5, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();

                connection.Open();
                SqlCommand update = new SqlCommand(
                    "update Time_Table_6 set Monday='" + val1 + "',Tuesday='" + val2 + "',Wednsday='" + val3 + "',Thursday='" + val4 + "',Friday='" + val5 + "' where Period='" + val0 + "'", connection
                    );
                update.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sucessful update...");
            }
            if (cmbox.Text == "Seven")
            {
                String val0 = dataGridViewTimeTable[0, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val1 = dataGridViewTimeTable[1, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val2 = dataGridViewTimeTable[2, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val3 = dataGridViewTimeTable[3, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val4 = dataGridViewTimeTable[4, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val5 = dataGridViewTimeTable[5, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();

                connection.Open();
                SqlCommand update = new SqlCommand(
                    "update Time_Table_7 set Monday='" + val1 + "',Tuesday='" + val2 + "',Wednsday='" + val3 + "',Thursday='" + val4 + "',Friday='" + val5 + "' where Period='" + val0 + "'", connection
                    );
                update.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sucessful update...");
            }
            if (cmbox.Text == "Eight")
            {
                String val0 = dataGridViewTimeTable[0, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val1 = dataGridViewTimeTable[1, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val2 = dataGridViewTimeTable[2, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val3 = dataGridViewTimeTable[3, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val4 = dataGridViewTimeTable[4, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val5 = dataGridViewTimeTable[5, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();

                connection.Open();
                SqlCommand update = new SqlCommand(
                    "update Time_Table_8 set Monday='" + val1 + "',Tuesday='" + val2 + "',Wednsday='" + val3 + "',Thursday='" + val4 + "',Friday='" + val5 + "' where Period='" + val0 + "'", connection
                    );
                update.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sucessful update...");
            }
            if (cmbox.Text == "Nine")
            {
                String val0 = dataGridViewTimeTable[0, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val1 = dataGridViewTimeTable[1, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val2 = dataGridViewTimeTable[2, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val3 = dataGridViewTimeTable[3, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val4 = dataGridViewTimeTable[4, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val5 = dataGridViewTimeTable[5, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();

                connection.Open();
                SqlCommand update = new SqlCommand(
                    "update Time_Table_9 set Monday='" + val1 + "',Tuesday='" + val2 + "',Wednsday='" + val3 + "',Thursday='" + val4 + "',Friday='" + val5 + "' where Period='" + val0 + "'", connection
                    );
                update.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sucessful update...");
            }
            if (cmbox.Text == "Ten")
            {
                String val0 = dataGridViewTimeTable[0, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val1 = dataGridViewTimeTable[1, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val2 = dataGridViewTimeTable[2, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val3 = dataGridViewTimeTable[3, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val4 = dataGridViewTimeTable[4, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val5 = dataGridViewTimeTable[5, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();

                connection.Open();
                SqlCommand update = new SqlCommand(
                    "update Time_Table_10 set Monday='" + val1 + "',Tuesday='" + val2 + "',Wednsday='" + val3 + "',Thursday='" + val4 + "',Friday='" + val5 + "' where Period='" + val0 + "'", connection
                    );
                update.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sucessful update...");
            }
            if (cmbox.Text == "Eleven")
            {
                String val0 = dataGridViewTimeTable[0, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val1 = dataGridViewTimeTable[1, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val2 = dataGridViewTimeTable[2, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val3 = dataGridViewTimeTable[3, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val4 = dataGridViewTimeTable[4, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val5 = dataGridViewTimeTable[5, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();

                connection.Open();
                SqlCommand update = new SqlCommand(
                    "update Time_Table_11 set Monday='" + val1 + "',Tuesday='" + val2 + "',Wednsday='" + val3 + "',Thursday='" + val4 + "',Friday='" + val5 + "' where Period='" + val0 + "'", connection
                    );
                update.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sucessful update...");
            }
            if (cmbox.Text == "Twelve")
            {
                String val0 = dataGridViewTimeTable[0, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val1 = dataGridViewTimeTable[1, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val2 = dataGridViewTimeTable[2, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val3 = dataGridViewTimeTable[3, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val4 = dataGridViewTimeTable[4, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val5 = dataGridViewTimeTable[5, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();

                connection.Open();
                SqlCommand update = new SqlCommand(
                    "update Time_Table_12 set Monday='" + val1 + "',Tuesday='" + val2 + "',Wednsday='" + val3 + "',Thursday='" + val4 + "',Friday='" + val5 + "' where Period='" + val0 + "'", connection
                    );
                update.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sucessful update...");
            }
            if (cmbox.Text == "Thirteen")

            {
                String val0 = dataGridViewTimeTable[0, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val1 = dataGridViewTimeTable[1, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val2 = dataGridViewTimeTable[2, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val3 = dataGridViewTimeTable[3, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val4 = dataGridViewTimeTable[4, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();
                String val5 = dataGridViewTimeTable[5, dataGridViewTimeTable.CurrentCell.RowIndex].Value.ToString();

                connection.Open();
                SqlCommand update = new SqlCommand(
                    "update Time_Table_13 set Monday='" + val1 + "',Tuesday='" + val2 + "',Wednsday='" + val3 + "',Thursday='" + val4 + "',Friday='" + val5 + "' where Period='" + val0 + "'", connection
                    );
                update.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sucessful update...");
            }
        }
    }
}
