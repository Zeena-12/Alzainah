namespace AccessloginApp
{
    partial class FoodMenu
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
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_Chiness = new System.Windows.Forms.RadioButton();
            this.rbtn_fastFood = new System.Windows.Forms.RadioButton();
            this.rbtn_Arabc = new System.Windows.Forms.RadioButton();
            this.btn_price = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.btn_qty = new System.Windows.Forms.Button();
            this.txt_Totalprice = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_subTotal = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.rbtn_Drink = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_item
            // 
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Location = new System.Drawing.Point(106, 124);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(228, 21);
            this.cmb_item.TabIndex = 0;
            this.cmb_item.SelectedIndexChanged += new System.EventHandler(this.cmb_item_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Item";
            // 
            // rbtn_Chiness
            // 
            this.rbtn_Chiness.AutoSize = true;
            this.rbtn_Chiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtn_Chiness.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Chiness.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtn_Chiness.Location = new System.Drawing.Point(132, 80);
            this.rbtn_Chiness.Name = "rbtn_Chiness";
            this.rbtn_Chiness.Size = new System.Drawing.Size(89, 35);
            this.rbtn_Chiness.TabIndex = 2;
            this.rbtn_Chiness.TabStop = true;
            this.rbtn_Chiness.Text = "Chiness";
            this.rbtn_Chiness.UseVisualStyleBackColor = false;
            this.rbtn_Chiness.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_fastFood
            // 
            this.rbtn_fastFood.AutoSize = true;
            this.rbtn_fastFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtn_fastFood.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_fastFood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtn_fastFood.Location = new System.Drawing.Point(241, 80);
            this.rbtn_fastFood.Name = "rbtn_fastFood";
            this.rbtn_fastFood.Size = new System.Drawing.Size(99, 35);
            this.rbtn_fastFood.TabIndex = 3;
            this.rbtn_fastFood.TabStop = true;
            this.rbtn_fastFood.Text = "FastFood";
            this.rbtn_fastFood.UseVisualStyleBackColor = false;
            this.rbtn_fastFood.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtn_Arabc
            // 
            this.rbtn_Arabc.AutoSize = true;
            this.rbtn_Arabc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtn_Arabc.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Arabc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtn_Arabc.Location = new System.Drawing.Point(36, 80);
            this.rbtn_Arabc.Name = "rbtn_Arabc";
            this.rbtn_Arabc.Size = new System.Drawing.Size(80, 35);
            this.rbtn_Arabc.TabIndex = 4;
            this.rbtn_Arabc.TabStop = true;
            this.rbtn_Arabc.Text = "Arabic";
            this.rbtn_Arabc.UseVisualStyleBackColor = false;
            this.rbtn_Arabc.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btn_price
            // 
            this.btn_price.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_price.Location = new System.Drawing.Point(15, 168);
            this.btn_price.Name = "btn_price";
            this.btn_price.Size = new System.Drawing.Size(65, 39);
            this.btn_price.TabIndex = 5;
            this.btn_price.Text = "Price ";
            this.btn_price.UseVisualStyleBackColor = true;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(85, 169);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(77, 37);
            this.txt_price.TabIndex = 6;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.Location = new System.Drawing.Point(239, 168);
            this.txt_qty.Multiline = true;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(75, 39);
            this.txt_qty.TabIndex = 8;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // btn_qty
            // 
            this.btn_qty.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qty.Location = new System.Drawing.Point(168, 167);
            this.btn_qty.Name = "btn_qty";
            this.btn_qty.Size = new System.Drawing.Size(65, 40);
            this.btn_qty.TabIndex = 7;
            this.btn_qty.Text = "Qty";
            this.btn_qty.UseVisualStyleBackColor = true;
            // 
            // txt_Totalprice
            // 
            this.txt_Totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Totalprice.Location = new System.Drawing.Point(396, 168);
            this.txt_Totalprice.Multiline = true;
            this.txt_Totalprice.Name = "txt_Totalprice";
            this.txt_Totalprice.Size = new System.Drawing.Size(75, 36);
            this.txt_Totalprice.TabIndex = 10;
            this.txt_Totalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Totalprice.TextChanged += new System.EventHandler(this.txt_Totalprice_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(325, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Total Price ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(477, 167);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(74, 37);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 223);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(454, 168);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 75;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sub Total ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_subTotal
            // 
            this.txt_subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subTotal.Location = new System.Drawing.Point(168, 416);
            this.txt_subTotal.Multiline = true;
            this.txt_subTotal.Name = "txt_subTotal";
            this.txt_subTotal.Size = new System.Drawing.Size(77, 32);
            this.txt_subTotal.TabIndex = 14;
            this.txt_subTotal.Text = "0";
            this.txt_subTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_subTotal.TextChanged += new System.EventHandler(this.txt_subTotal_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(206, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 25);
            this.label22.TabIndex = 15;
            // 
            // rbtn_Drink
            // 
            this.rbtn_Drink.AutoSize = true;
            this.rbtn_Drink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtn_Drink.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Drink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtn_Drink.Location = new System.Drawing.Point(350, 80);
            this.rbtn_Drink.Name = "rbtn_Drink";
            this.rbtn_Drink.Size = new System.Drawing.Size(76, 35);
            this.rbtn_Drink.TabIndex = 16;
            this.rbtn_Drink.TabStop = true;
            this.rbtn_Drink.Text = "Drink";
            this.rbtn_Drink.UseVisualStyleBackColor = false;
            this.rbtn_Drink.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(284, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 34);
            this.button3.TabIndex = 17;
            this.button3.Text = "Submit ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::AccessloginApp.Properties.Resources.ww;
            this.ClientSize = new System.Drawing.Size(619, 488);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rbtn_Drink);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txt_subTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_Totalprice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.btn_qty);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.btn_price);
            this.Controls.Add(this.rbtn_Arabc);
            this.Controls.Add(this.rbtn_fastFood);
            this.Controls.Add(this.rbtn_Chiness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_item);
            this.Name = "FoodMenu";
            this.Text = "FoodMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_Chiness;
        private System.Windows.Forms.RadioButton rbtn_fastFood;
        private System.Windows.Forms.RadioButton rbtn_Arabc;
        private System.Windows.Forms.Button btn_price;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Button btn_qty;
        private System.Windows.Forms.TextBox txt_Totalprice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton rbtn_Drink;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txt_subTotal;
    }
}