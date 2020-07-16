namespace AccessloginApp
{
    partial class Service
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textboxfood = new System.Windows.Forms.TextBox();
            this.btn_Total = new System.Windows.Forms.Button();
            this.check_Out = new System.Windows.Forms.DateTimePicker();
            this.check_in = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Eval = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txt_Laundry = new System.Windows.Forms.TextBox();
            this.txt_Taxi = new System.Windows.Forms.TextBox();
            this.txt_bed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Bill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_BedType = new System.Windows.Forms.ComboBox();
            this.chk_Evaluation = new System.Windows.Forms.ComboBox();
            this.chk_Taxi = new System.Windows.Forms.ComboBox();
            this.chk_Laundry = new System.Windows.Forms.ComboBox();
            this.chk_food = new System.Windows.Forms.ComboBox();
            this.chk_Pay = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.textboxfood);
            this.panel1.Controls.Add(this.btn_Total);
            this.panel1.Controls.Add(this.check_Out);
            this.panel1.Controls.Add(this.check_in);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Eval);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.txt_Laundry);
            this.panel1.Controls.Add(this.txt_Taxi);
            this.panel1.Controls.Add(this.txt_bed);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.txt_Bill);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chk_BedType);
            this.panel1.Controls.Add(this.chk_Evaluation);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.chk_Taxi);
            this.panel1.Controls.Add(this.chk_Laundry);
            this.panel1.Controls.Add(this.chk_food);
            this.panel1.Controls.Add(this.chk_Pay);
            this.panel1.Location = new System.Drawing.Point(12, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 449);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textboxfood
            // 
            this.textboxfood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textboxfood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxfood.ForeColor = System.Drawing.SystemColors.Info;
            this.textboxfood.Location = new System.Drawing.Point(84, 349);
            this.textboxfood.Name = "textboxfood";
            this.textboxfood.Size = new System.Drawing.Size(100, 19);
            this.textboxfood.TabIndex = 27;
            this.textboxfood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxfood.TextChanged += new System.EventHandler(this.txt_FoodTotal_TextChanged);
            // 
            // btn_Total
            // 
            this.btn_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Total.Location = new System.Drawing.Point(59, 383);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(75, 27);
            this.btn_Total.TabIndex = 25;
            this.btn_Total.Text = "Total";
            this.btn_Total.UseVisualStyleBackColor = true;
            this.btn_Total.Click += new System.EventHandler(this.btn_Bill_Click);
            // 
            // check_Out
            // 
            this.check_Out.Location = new System.Drawing.Point(310, 100);
            this.check_Out.Name = "check_Out";
            this.check_Out.Size = new System.Drawing.Size(200, 20);
            this.check_Out.TabIndex = 24;
            // 
            // check_in
            // 
            this.check_in.Location = new System.Drawing.Point(35, 100);
            this.check_in.Name = "check_in";
            this.check_in.Size = new System.Drawing.Size(200, 20);
            this.check_in.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(316, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "check out :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "check in :";
            // 
            // txt_Eval
            // 
            this.txt_Eval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Eval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Eval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Eval.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_Eval.Location = new System.Drawing.Point(365, 346);
            this.txt_Eval.Name = "txt_Eval";
            this.txt_Eval.Size = new System.Drawing.Size(100, 22);
            this.txt_Eval.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox6.Location = new System.Drawing.Point(228, 346);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 15;
            // 
            // txt_Laundry
            // 
            this.txt_Laundry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Laundry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Laundry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Laundry.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_Laundry.Location = new System.Drawing.Point(228, 228);
            this.txt_Laundry.Name = "txt_Laundry";
            this.txt_Laundry.Size = new System.Drawing.Size(100, 19);
            this.txt_Laundry.TabIndex = 14;
            this.txt_Laundry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Taxi
            // 
            this.txt_Taxi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Taxi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Taxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Taxi.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_Taxi.Location = new System.Drawing.Point(365, 228);
            this.txt_Taxi.Name = "txt_Taxi";
            this.txt_Taxi.Size = new System.Drawing.Size(100, 19);
            this.txt_Taxi.TabIndex = 13;
            this.txt_Taxi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_bed
            // 
            this.txt_bed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_bed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bed.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_bed.Location = new System.Drawing.Point(84, 228);
            this.txt_bed.Name = "txt_bed";
            this.txt_bed.Size = new System.Drawing.Size(100, 19);
            this.txt_bed.TabIndex = 11;
            this.txt_bed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(406, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Exit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Bill
            // 
            this.txt_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bill.Location = new System.Drawing.Point(150, 380);
            this.txt_Bill.Multiline = true;
            this.txt_Bill.Name = "txt_Bill";
            this.txt_Bill.Size = new System.Drawing.Size(131, 31);
            this.txt_Bill.TabIndex = 7;
            this.txt_Bill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kunstler Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(147, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "how can i help you?";
            // 
            // chk_BedType
            // 
            this.chk_BedType.FormattingEnabled = true;
            this.chk_BedType.Location = new System.Drawing.Point(93, 201);
            this.chk_BedType.Name = "chk_BedType";
            this.chk_BedType.Size = new System.Drawing.Size(100, 21);
            this.chk_BedType.TabIndex = 17;
            this.chk_BedType.Text = "Bed Type?";
            this.chk_BedType.SelectedIndexChanged += new System.EventHandler(this.chk_BedType_SelectedIndexChanged);
            // 
            // chk_Evaluation
            // 
            this.chk_Evaluation.FormattingEnabled = true;
            this.chk_Evaluation.Location = new System.Drawing.Point(374, 319);
            this.chk_Evaluation.Name = "chk_Evaluation";
            this.chk_Evaluation.Size = new System.Drawing.Size(100, 21);
            this.chk_Evaluation.TabIndex = 20;
            this.chk_Evaluation.Text = "Evaluation?";
            this.chk_Evaluation.SelectedIndexChanged += new System.EventHandler(this.chk_Evaluation_SelectedIndexChanged);
            // 
            // chk_Taxi
            // 
            this.chk_Taxi.FormattingEnabled = true;
            this.chk_Taxi.Location = new System.Drawing.Point(374, 201);
            this.chk_Taxi.Name = "chk_Taxi";
            this.chk_Taxi.Size = new System.Drawing.Size(100, 21);
            this.chk_Taxi.TabIndex = 19;
            this.chk_Taxi.Text = "Required Time?";
            this.chk_Taxi.SelectedIndexChanged += new System.EventHandler(this.chk_Taxi_SelectedIndexChanged);
            // 
            // chk_Laundry
            // 
            this.chk_Laundry.FormattingEnabled = true;
            this.chk_Laundry.Location = new System.Drawing.Point(238, 201);
            this.chk_Laundry.Name = "chk_Laundry";
            this.chk_Laundry.Size = new System.Drawing.Size(100, 21);
            this.chk_Laundry.TabIndex = 18;
            this.chk_Laundry.Text = "Laundry Size?";
            this.chk_Laundry.SelectedIndexChanged += new System.EventHandler(this.chk_Laundry_SelectedIndexChanged);
            // 
            // chk_food
            // 
            this.chk_food.FormattingEnabled = true;
            this.chk_food.Location = new System.Drawing.Point(93, 319);
            this.chk_food.Name = "chk_food";
            this.chk_food.Size = new System.Drawing.Size(100, 21);
            this.chk_food.TabIndex = 26;
            this.chk_food.Text = "Food Type?";
            this.chk_food.SelectedIndexChanged += new System.EventHandler(this.chk_food_SelectedIndexChanged);
            // 
            // chk_Pay
            // 
            this.chk_Pay.FormattingEnabled = true;
            this.chk_Pay.Location = new System.Drawing.Point(238, 319);
            this.chk_Pay.Name = "chk_Pay";
            this.chk_Pay.Size = new System.Drawing.Size(100, 21);
            this.chk_Pay.TabIndex = 28;
            this.chk_Pay.Text = "Paiment";
            this.chk_Pay.SelectedIndexChanged += new System.EventHandler(this.chk_Pay_SelectedIndexChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::AccessloginApp.Properties.Resources.Exit;
            this.pictureBox7.Location = new System.Drawing.Point(461, 378);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AccessloginApp.Properties.Resources.face;
            this.pictureBox6.Location = new System.Drawing.Point(374, 263);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(85, 77);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AccessloginApp.Properties.Resources.bed;
            this.pictureBox5.Location = new System.Drawing.Point(93, 145);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(85, 77);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AccessloginApp.Properties.Resources.laundry;
            this.pictureBox4.Location = new System.Drawing.Point(238, 145);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AccessloginApp.Properties.Resources.cash;
            this.pictureBox2.Location = new System.Drawing.Point(238, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccessloginApp.Properties.Resources.food;
            this.pictureBox1.Location = new System.Drawing.Point(93, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AccessloginApp.Properties.Resources.depositphotos_31491681_stock_photo_taxi_icon1;
            this.pictureBox3.Location = new System.Drawing.Point(374, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 465);
            this.Controls.Add(this.panel1);
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txt_Bill;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox chk_Evaluation;
        private System.Windows.Forms.ComboBox chk_Taxi;
        private System.Windows.Forms.ComboBox chk_Laundry;
        private System.Windows.Forms.ComboBox chk_BedType;
        private System.Windows.Forms.TextBox txt_Eval;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txt_Laundry;
        private System.Windows.Forms.TextBox txt_Taxi;
        private System.Windows.Forms.TextBox txt_bed;
        private System.Windows.Forms.DateTimePicker check_Out;
        private System.Windows.Forms.DateTimePicker check_in;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Total;
        private System.Windows.Forms.ComboBox chk_food;
        private System.Windows.Forms.TextBox textboxfood;
        private System.Windows.Forms.ComboBox chk_Pay;
    }
}