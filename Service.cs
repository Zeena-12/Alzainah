using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessloginApp
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
           

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Service_Load(object sender, EventArgs e)
        {
           
            chk_BedType.Items.Add("Single");
            chk_BedType.Items.Add("Double");
            chk_BedType.Items.Add("Family");

           
            chk_Evaluation.Items.Add("Excellent");
            chk_Evaluation.Items.Add("Good");
            chk_Evaluation.Items.Add("Bad");

            chk_Laundry.Items.Add("One Person");
            chk_Laundry.Items.Add("Two Person");
            chk_Laundry.Items.Add("More");

            chk_Taxi.Items.Add("12 Hours");
            chk_Taxi.Items.Add("1 Day");
            chk_Taxi.Items.Add("More");

            chk_food.Items.Add("Go To menu?");
            
           


            chk_Pay.Items.Add("Do you want to pay");


        }

        private void chk_BedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chk_BedType.Text == "Single")
            {
                txt_bed.Text = "70 $";
            }
           else if (chk_BedType.Text == "Double")
            {
                txt_bed.Text = "130 $";
            }
            else if (chk_BedType.Text == "Family")
            {
                txt_bed.Text = "160 $";
            }


           
        }

        private void chk_Evaluation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chk_Evaluation.Text == "Excellent")
            {
                txt_Eval.Text = "Thank you";
            }

            else if (chk_Evaluation.Text == "Good")
            {
                txt_Eval.Text = "Thank you";
            }
            else if (chk_Evaluation.Text == "Bad")
            {
                txt_Eval.Text = "Why?";
            }
        }

        private void chk_Laundry_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (chk_Laundry.Text == "One Person")
            {
                txt_Laundry.Text = "5$";
            }
           else  if (chk_Laundry.Text == "Two Person")
            {
                txt_Laundry.Text = "10$";
            }
            else if (chk_Laundry.Text == "More")
            {
                txt_Laundry.Text = "20$";
            }


        }

        private void chk_Taxi_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (chk_Taxi.Text == "12 Hours")
            {
                txt_Taxi.Text = "20$";
            }
           else if (chk_Taxi.Text == "1 Day")
            {
                txt_Taxi.Text = "50$";
            }
            else if (chk_Taxi.Text == "More")
            {
                txt_Taxi.Text = "70$";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            DateTime DateIn, DateOut;
            int TotalDays,meal,laundry=0,Taxi=0 ;
            int singleroom, doubleroom, familyroom,TotalCost;
            int onePerson, twoPerson, more;
            int halfDay, oneDay, More;

            singleroom = 70;
            doubleroom = 130;
            familyroom = 160;

           

           
            if(chk_Laundry.Text=="One Person")
            {
                laundry = 5;
            }
           else if (chk_Laundry.Text == "Two Person")
            {
                laundry = 10;
            }
            else if (chk_Laundry.Text == "More")
            {
                laundry = 20;
            }



            if(chk_Taxi.Text=="12 Hourse")
            {
                Taxi = 20;
            }
            else if (chk_Taxi.Text == "1 Day")
            {
                Taxi = 50;
            }
            else if (chk_Taxi.Text == "More")
            {
                Taxi = 70;
            }





            DateIn = Convert.ToDateTime(check_in.Value);
            DateOut = Convert.ToDateTime(check_Out.Value);


            TotalDays =( DateOut - DateIn).Days;
            meal = System.Convert.ToInt32(textboxfood.Text);
            
           
               
                

            if (chk_BedType.Text == "Single")
            {
                TotalCost = (singleroom * TotalDays)+meal+laundry+Taxi;
            

            txt_Bill.Text = System.Convert.ToString(TotalCost)+"$";
            }
           else if (chk_BedType.Text == "Double")
            {
                TotalCost = (doubleroom * TotalDays) + meal+laundry+Taxi;


                txt_Bill.Text = System.Convert.ToString(TotalCost)+"$";
            }
            else if (chk_BedType.Text == "Family")
            {
                TotalCost = (familyroom * TotalDays) + meal+laundry+Taxi;


                txt_Bill.Text = System.Convert.ToString(TotalCost)+"$";
            }


        }






        private void chk_FoodType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_food_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_food_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chk_food.Text == "Go To menu?")
            {
                
                FoodMenu f2 = new FoodMenu();
                f2.ShowDialog();
                textboxfood.Text = f2.txt_subTotal.Text;
            }
        }

        private void chk_Pay_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            payAndFinish f2 = new payAndFinish();
            f2.ShowDialog();
        }

        private void txt_FoodTotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnget_Click(object sender, EventArgs e)
        {
           
        }
    }
}
