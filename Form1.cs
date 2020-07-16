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
    public partial class Form1 : Form

    {
      private  OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Toshiba\Desktop\EmployeeInfo.accdb;Persist Security Info=False;";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try { 
           
            connection.Open();
            checkConnection.Text = "";
            connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnt_login_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select*from EmployeeData where Username=@txt_Username and password=@txt_Password";
            command.Parameters.Add("Username", OleDbType.LongVarChar).Value = txt_Username.Text;
            command.Parameters.Add("password", OleDbType.LongVarWChar).Value = txt_Password.Text;


            using (OleDbDataReader reader = command.ExecuteReader())
            {
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username and password is correct");
                    connection.Close();
                    connection.Dispose();
                    this.Hide();
                    Data f2 = new Data();
                    f2.ShowDialog();


                }
                else if (count > 1)
                {
                    MessageBox.Show("Username and password is not correct");
                }
                else
                {
                    MessageBox.Show("Username and password is not correct");
                }
            }



            connection.Close();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
