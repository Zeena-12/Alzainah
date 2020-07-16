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
    public partial class FoodMenu : Form
    {
      private  OleDbConnection connection2 = new OleDbConnection();
        public FoodMenu()
        {
            InitializeComponent();
            connection2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Toshiba\Desktop\FoodItemFin.accdb;Persist Security Info=False;";
        }

       

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cmb_item.Items.Clear();

            try
            {
                connection2.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection2;
                string query = "select * from Arabic";

                command.CommandText = query;



                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmb_item.Items.Add(reader["FoodName"].ToString());
                }
                connection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmb_item.Items.Clear();
            try
            {
                connection2.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection2;
                string query = "select * from Chiness";

                command.CommandText = query;



                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmb_item.Items.Add(reader["FoodName"].ToString());
                }
                connection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cmb_item.Items.Clear();
            try
            {
                connection2.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection2;
                string query = "select * from FastFood";

                command.CommandText = query;



                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmb_item.Items.Add(reader["FoodName"].ToString());
                }
                connection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            cmb_item.Items.Clear();
            cmb_item.Items.Clear();
            try
            {
                connection2.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection2;
                string query = "select * from Drink";

                command.CommandText = query;



                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmb_item.Items.Add(reader["FoodName"].ToString());
                }
                connection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        private void cmb_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string TableName="";

                if (rbtn_Arabc.Checked==true)
            {
                TableName = "Arabic";
            }
            if (rbtn_Chiness.Checked==true)
            {
                TableName = "Chiness";
            }
            if (rbtn_Drink.Checked==true)
            {
                TableName = "Drink";
            }
            if (rbtn_fastFood.Checked==true)
            {
                TableName = "FastFood";
            }


                connection2.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection2;

                string query = "select * from "+ TableName + " where  FoodName ='"+ cmb_item.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmb_item.Text = reader["FoodName"].ToString();

                    txt_price.Text = reader["FoodPrice"].ToString();
                }
                connection2.Close();
                txt_Totalprice.Text="";
                txt_qty.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_Totalprice.Text =(Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_qty.Text)).ToString();
            }
        }

        private void txt_Totalprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string[]arr= new string[4];
            arr[0] = cmb_item.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_Totalprice.Text;

            ListViewItem Lvi = new ListViewItem(arr);
            listView1.Items.Add(Lvi);
            txt_subTotal.Text = (Convert.ToInt32(txt_subTotal.Text) + Convert.ToInt32(txt_Totalprice.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();



        }

        private void txt_subTotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
