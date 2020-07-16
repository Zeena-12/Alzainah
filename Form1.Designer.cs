namespace AccessloginApp
{
    partial class Form1
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
            this.checkConnection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnt_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkConnection.Location = new System.Drawing.Point(106, 280);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(0, 26);
            this.checkConnection.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(124, 31);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(180, 32);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(123, 91);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(180, 32);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bnt_login);
            this.groupBox1.Controls.Add(this.txt_Username);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(94, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 189);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // bnt_login
            // 
            this.bnt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bnt_login.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnt_login.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bnt_login.Location = new System.Drawing.Point(123, 144);
            this.bnt_login.Name = "bnt_login";
            this.bnt_login.Size = new System.Drawing.Size(66, 39);
            this.bnt_login.TabIndex = 0;
            this.bnt_login.Text = "Login";
            this.bnt_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnt_login.UseVisualStyleBackColor = false;
            this.bnt_login.Click += new System.EventHandler(this.bnt_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Kunstler Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 52);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcom to Hotel Del Luna";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AccessloginApp.Properties.Resources.dark_purple_;
            this.ClientSize = new System.Drawing.Size(519, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bnt_login;
        private System.Windows.Forms.Label label3;
    }
}

