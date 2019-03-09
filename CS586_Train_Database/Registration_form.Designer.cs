namespace CS586_Train_Database
{
    partial class Registration_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_form));
            this.Name_l = new System.Windows.Forms.Label();
            this.email_l = new System.Windows.Forms.Label();
            this.Pass_l = new System.Windows.Forms.Label();
            this.PassConf_l = new System.Windows.Forms.Label();
            this.Phone_l = new System.Windows.Forms.Label();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.PassConf_txt = new System.Windows.Forms.TextBox();
            this.Pass_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.User_Rbtn = new System.Windows.Forms.RadioButton();
            this.Admin_Rbtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Name_l
            // 
            this.Name_l.AutoSize = true;
            this.Name_l.Location = new System.Drawing.Point(23, 48);
            this.Name_l.Name = "Name_l";
            this.Name_l.Size = new System.Drawing.Size(35, 13);
            this.Name_l.TabIndex = 0;
            this.Name_l.Text = "Name";
            this.Name_l.Click += new System.EventHandler(this.label1_Click);
            // 
            // email_l
            // 
            this.email_l.AutoSize = true;
            this.email_l.Location = new System.Drawing.Point(23, 96);
            this.email_l.Name = "email_l";
            this.email_l.Size = new System.Drawing.Size(75, 13);
            this.email_l.TabIndex = 0;
            this.email_l.Text = "E-mail address";
            this.email_l.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pass_l
            // 
            this.Pass_l.AutoSize = true;
            this.Pass_l.Location = new System.Drawing.Point(23, 146);
            this.Pass_l.Name = "Pass_l";
            this.Pass_l.Size = new System.Drawing.Size(53, 13);
            this.Pass_l.TabIndex = 0;
            this.Pass_l.Text = "Password";
            this.Pass_l.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassConf_l
            // 
            this.PassConf_l.AutoSize = true;
            this.PassConf_l.Location = new System.Drawing.Point(23, 200);
            this.PassConf_l.Name = "PassConf_l";
            this.PassConf_l.Size = new System.Drawing.Size(113, 13);
            this.PassConf_l.TabIndex = 0;
            this.PassConf_l.Text = "Password confirmation";
            this.PassConf_l.Click += new System.EventHandler(this.label1_Click);
            // 
            // Phone_l
            // 
            this.Phone_l.AutoSize = true;
            this.Phone_l.Location = new System.Drawing.Point(23, 257);
            this.Phone_l.Name = "Phone_l";
            this.Phone_l.Size = new System.Drawing.Size(76, 13);
            this.Phone_l.TabIndex = 0;
            this.Phone_l.Text = "Phone number";
            this.Phone_l.Click += new System.EventHandler(this.label1_Click);
            // 
            // Phone_txt
            // 
            this.Phone_txt.Location = new System.Drawing.Point(144, 254);
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Size = new System.Drawing.Size(264, 20);
            this.Phone_txt.TabIndex = 2;
            // 
            // PassConf_txt
            // 
            this.PassConf_txt.Location = new System.Drawing.Point(144, 196);
            this.PassConf_txt.Name = "PassConf_txt";
            this.PassConf_txt.PasswordChar = '*';
            this.PassConf_txt.Size = new System.Drawing.Size(264, 20);
            this.PassConf_txt.TabIndex = 2;
            // 
            // Pass_txt
            // 
            this.Pass_txt.Location = new System.Drawing.Point(144, 142);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.PasswordChar = '*';
            this.Pass_txt.Size = new System.Drawing.Size(264, 20);
            this.Pass_txt.TabIndex = 2;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(144, 92);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(264, 20);
            this.email_txt.TabIndex = 2;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(144, 44);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(264, 20);
            this.Name_txt.TabIndex = 2;
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(340, 305);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(68, 37);
            this.Submit_btn.TabIndex = 3;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(6, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(6, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "*";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "*";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "*";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "*";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // User_Rbtn
            // 
            this.User_Rbtn.AutoSize = true;
            this.User_Rbtn.Location = new System.Drawing.Point(144, 315);
            this.User_Rbtn.Name = "User_Rbtn";
            this.User_Rbtn.Size = new System.Drawing.Size(47, 17);
            this.User_Rbtn.TabIndex = 4;
            this.User_Rbtn.TabStop = true;
            this.User_Rbtn.Text = "User";
            this.User_Rbtn.UseVisualStyleBackColor = true;
            this.User_Rbtn.CheckedChanged += new System.EventHandler(this.User_Rbtn_CheckedChanged);
            // 
            // Admin_Rbtn
            // 
            this.Admin_Rbtn.AutoSize = true;
            this.Admin_Rbtn.Location = new System.Drawing.Point(197, 315);
            this.Admin_Rbtn.Name = "Admin_Rbtn";
            this.Admin_Rbtn.Size = new System.Drawing.Size(54, 17);
            this.Admin_Rbtn.TabIndex = 4;
            this.Admin_Rbtn.TabStop = true;
            this.Admin_Rbtn.Text = "Admin";
            this.Admin_Rbtn.UseVisualStyleBackColor = true;
            this.Admin_Rbtn.CheckedChanged += new System.EventHandler(this.Admin_Rbtn_CheckedChanged);
            // 
            // Registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 372);
            this.Controls.Add(this.Admin_Rbtn);
            this.Controls.Add(this.User_Rbtn);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.Pass_txt);
            this.Controls.Add(this.PassConf_txt);
            this.Controls.Add(this.Phone_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phone_l);
            this.Controls.Add(this.PassConf_l);
            this.Controls.Add(this.Pass_l);
            this.Controls.Add(this.email_l);
            this.Controls.Add(this.Name_l);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration_form";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_l;
        private System.Windows.Forms.Label email_l;
        private System.Windows.Forms.Label Pass_l;
        private System.Windows.Forms.Label PassConf_l;
        private System.Windows.Forms.Label Phone_l;
        private System.Windows.Forms.TextBox Phone_txt;
        private System.Windows.Forms.TextBox PassConf_txt;
        private System.Windows.Forms.TextBox Pass_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton User_Rbtn;
        private System.Windows.Forms.RadioButton Admin_Rbtn;
    }
}