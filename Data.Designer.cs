namespace AccessloginApp
{
    partial class Data
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_eid = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bnr_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Arabic Typesetting", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Arabic Typesetting", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pay(Advance 132$)";
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(243, 108);
            this.txt_fname.Multiline = true;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(164, 25);
            this.txt_fname.TabIndex = 3;
            this.txt_fname.TextChanged += new System.EventHandler(this.txt_fname_TextChanged);
            // 
            // txt_pay
            // 
            this.txt_pay.Location = new System.Drawing.Point(243, 192);
            this.txt_pay.Multiline = true;
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.Size = new System.Drawing.Size(164, 25);
            this.txt_pay.TabIndex = 4;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(243, 148);
            this.txt_lname.Multiline = true;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(164, 25);
            this.txt_lname.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_save.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(94, 257);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 32);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save data";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Arabic Typesetting", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "EID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_eid
            // 
            this.txt_eid.Location = new System.Drawing.Point(243, 69);
            this.txt_eid.Multiline = true;
            this.txt_eid.Name = "txt_eid";
            this.txt_eid.Size = new System.Drawing.Size(164, 25);
            this.txt_eid.TabIndex = 8;
            this.txt_eid.TextChanged += new System.EventHandler(this.txt_eid_TextChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(194, 257);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(94, 32);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Edit data";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(294, 257);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 32);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delet data";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(424, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "All customer";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bnr_next
            // 
            this.bnr_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bnr_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnr_next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnr_next.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnr_next.Location = new System.Drawing.Point(424, 329);
            this.bnr_next.Name = "bnr_next";
            this.bnr_next.Size = new System.Drawing.Size(111, 39);
            this.bnr_next.TabIndex = 12;
            this.bnr_next.Text = "Next";
            this.bnr_next.UseVisualStyleBackColor = false;
            this.bnr_next.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AccessloginApp.Properties.Resources.dark_purple_;
            this.ClientSize = new System.Drawing.Size(592, 407);
            this.Controls.Add(this.bnr_next);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_eid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_pay);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_pay;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_eid;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bnr_next;
    }
}