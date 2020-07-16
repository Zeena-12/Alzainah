using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccessloginApp
{
    public partial class Data : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private object txt_subTotal;

        public Data()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Toshiba\Desktop\EmployeeInfo.accdb;Persist Security Info=False;";

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "insert into EmployeeData (EID,FirstName,LastName,Pay) values('"+txt_eid.Text+"','"+ txt_fname.Text + "','" + txt_lname.Text + "','" + txt_pay.Text + "')";
           


                command.ExecuteNonQuery();
                MessageBox.Show("Data saved");
                connection.Close();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update EmployeeData set FirstName='"+ txt_fname.Text + "',LastName='"+ txt_lname.Text + "',Pay='"+txt_pay.Text+"'where EID="+ txt_eid.Text + "";
                MessageBox.Show(query);
                command.CommandText = query;



                command.ExecuteNonQuery();
                MessageBox.Show("Data Edit Successful");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_eid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from EmployeeData where EID="+txt_eid.Text+"";
                
                command.CommandText = query;



                command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successful");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        private void Data_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from EmployeeData";

                command.CommandText = query;



              OleDbDataReader reader=  command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["FirstName"].ToString()+"  "+ reader["LastName"].ToString());
                }
               
               
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Service f2 = new Service();
            f2.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

