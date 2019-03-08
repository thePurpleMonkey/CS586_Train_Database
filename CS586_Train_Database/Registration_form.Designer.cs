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
            this.Role_box = new System.Windows.Forms.CheckBox();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.PassConf_txt = new System.Windows.Forms.TextBox();
            this.Pass_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
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
            this.Phone_l.Location = new System.Drawing.Point(23, 258);
            this.Phone_l.Name = "Phone_l";
            this.Phone_l.Size = new System.Drawing.Size(76, 13);
            this.Phone_l.TabIndex = 0;
            this.Phone_l.Text = "Phone number";
            this.Phone_l.Click += new System.EventHandler(this.label1_Click);
            // 
            // Role_box
            // 
            this.Role_box.AutoSize = true;
            this.Role_box.Location = new System.Drawing.Point(26, 316);
            this.Role_box.Name = "Role_box";
            this.Role_box.Size = new System.Drawing.Size(55, 17);
            this.Role_box.TabIndex = 1;
            this.Role_box.Text = "Admin";
            this.Role_box.UseVisualStyleBackColor = true;
            this.Role_box.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.PassConf_txt.Size = new System.Drawing.Size(264, 20);
            this.PassConf_txt.TabIndex = 2;
            // 
            // Pass_txt
            // 
            this.Pass_txt.Location = new System.Drawing.Point(144, 142);
            this.Pass_txt.Name = "Pass_txt";
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
            // 
            // Registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 372);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.Pass_txt);
            this.Controls.Add(this.PassConf_txt);
            this.Controls.Add(this.Phone_txt);
            this.Controls.Add(this.Role_box);
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
        private System.Windows.Forms.CheckBox Role_box;
        private System.Windows.Forms.TextBox Phone_txt;
        private System.Windows.Forms.TextBox PassConf_txt;
        private System.Windows.Forms.TextBox Pass_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Button Submit_btn;
    }
}