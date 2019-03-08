namespace CS586_Train_Database
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.email_l = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.password_l = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.CS586 = new System.Windows.Forms.Label();
            this.NewUser_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_l
            // 
            this.email_l.AutoSize = true;
            this.email_l.Location = new System.Drawing.Point(68, 46);
            this.email_l.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_l.Name = "email_l";
            this.email_l.Size = new System.Drawing.Size(35, 13);
            this.email_l.TabIndex = 0;
            this.email_l.Text = "E-mail";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(70, 74);
            this.email_txt.Margin = new System.Windows.Forms.Padding(2);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(160, 20);
            this.email_txt.TabIndex = 1;
            // 
            // password_l
            // 
            this.password_l.AutoSize = true;
            this.password_l.Location = new System.Drawing.Point(68, 115);
            this.password_l.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_l.Name = "password_l";
            this.password_l.Size = new System.Drawing.Size(53, 13);
            this.password_l.TabIndex = 2;
            this.password_l.Text = "Password";
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(70, 146);
            this.Password_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(160, 20);
            this.Password_txt.TabIndex = 3;
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(70, 209);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(51, 25);
            this.Login_btn.TabIndex = 5;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // CS586
            // 
            this.CS586.AutoSize = true;
            this.CS586.Font = new System.Drawing.Font("Mistral", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CS586.Location = new System.Drawing.Point(290, 106);
            this.CS586.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CS586.Name = "CS586";
            this.CS586.Size = new System.Drawing.Size(114, 46);
            this.CS586.TabIndex = 6;
            this.CS586.Text = "CS 586";
            this.CS586.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // NewUser_btn
            // 
            this.NewUser_btn.Location = new System.Drawing.Point(160, 209);
            this.NewUser_btn.Margin = new System.Windows.Forms.Padding(2);
            this.NewUser_btn.Name = "NewUser_btn";
            this.NewUser_btn.Size = new System.Drawing.Size(70, 25);
            this.NewUser_btn.TabIndex = 5;
            this.NewUser_btn.Text = "New user";
            this.NewUser_btn.UseVisualStyleBackColor = true;
            this.NewUser_btn.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 272);
            this.Controls.Add(this.CS586);
            this.Controls.Add(this.NewUser_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.password_l);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.email_l);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login_form";
            this.Text = "Welcome to Amtrak project";
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_l;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label password_l;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label CS586;
        private System.Windows.Forms.Button NewUser_btn;
    }
}