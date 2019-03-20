namespace CS586_Train_Database
{
    partial class AlertDialog
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
            this.email_radioButton = new System.Windows.Forms.RadioButton();
            this.text_radioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.minutes_before = new System.Windows.Forms.NumericUpDown();
            this.create_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_before)).BeginInit();
            this.SuspendLayout();
            // 
            // email_radioButton
            // 
            this.email_radioButton.AutoSize = true;
            this.email_radioButton.Checked = true;
            this.email_radioButton.Location = new System.Drawing.Point(12, 12);
            this.email_radioButton.Name = "email_radioButton";
            this.email_radioButton.Size = new System.Drawing.Size(73, 24);
            this.email_radioButton.TabIndex = 0;
            this.email_radioButton.TabStop = true;
            this.email_radioButton.Text = "Email";
            this.email_radioButton.UseVisualStyleBackColor = true;
            // 
            // text_radioButton
            // 
            this.text_radioButton.AutoSize = true;
            this.text_radioButton.Location = new System.Drawing.Point(12, 42);
            this.text_radioButton.Name = "text_radioButton";
            this.text_radioButton.Size = new System.Drawing.Size(64, 24);
            this.text_radioButton.TabIndex = 1;
            this.text_radioButton.Text = "Text";
            this.text_radioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minutes before arrival:";
            // 
            // minutes_before
            // 
            this.minutes_before.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.minutes_before.Location = new System.Drawing.Point(12, 122);
            this.minutes_before.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.minutes_before.Name = "minutes_before";
            this.minutes_before.Size = new System.Drawing.Size(120, 26);
            this.minutes_before.TabIndex = 3;
            this.minutes_before.ThousandsSeparator = true;
            this.minutes_before.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // create_button
            // 
            this.create_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.create_button.Location = new System.Drawing.Point(12, 152);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(105, 45);
            this.create_button.TabIndex = 4;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(123, 152);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(103, 45);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // AlertDialog
            // 
            this.AcceptButton = this.create_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(245, 209);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.minutes_before);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_radioButton);
            this.Controls.Add(this.email_radioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertDialog";
            this.ShowInTaskbar = false;
            this.Text = "Create Alert";
            ((System.ComponentModel.ISupportInitialize)(this.minutes_before)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton email_radioButton;
        private System.Windows.Forms.RadioButton text_radioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown minutes_before;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button cancel_button;
    }
}