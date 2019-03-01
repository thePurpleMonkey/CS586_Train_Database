namespace CS586_Train_Database
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
            this.label1 = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.load_stations_button = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.find_button = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(78, 9);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(117, 20);
            this.status_label.TabIndex = 1;
            this.status_label.Text = "Not connected.";
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(12, 32);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(134, 34);
            this.connect_button.TabIndex = 2;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // load_stations_button
            // 
            this.load_stations_button.Enabled = false;
            this.load_stations_button.Location = new System.Drawing.Point(12, 125);
            this.load_stations_button.Name = "load_stations_button";
            this.load_stations_button.Size = new System.Drawing.Size(134, 34);
            this.load_stations_button.TabIndex = 3;
            this.load_stations_button.Text = "Load Stations";
            this.load_stations_button.UseVisualStyleBackColor = true;
            this.load_stations_button.Click += new System.EventHandler(this.load_stations_button_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 166);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 28;
            this.grid.Size = new System.Drawing.Size(505, 268);
            this.grid.TabIndex = 4;
            // 
            // find_button
            // 
            this.find_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.find_button.Enabled = false;
            this.find_button.Location = new System.Drawing.Point(391, 126);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(126, 34);
            this.find_button.TabIndex = 5;
            this.find_button.Text = "Find";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_box
            // 
            this.search_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box.Enabled = false;
            this.search_box.Location = new System.Drawing.Point(242, 130);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(143, 26);
            this.search_box.TabIndex = 6;
            this.search_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_box_KeyDown);
            this.search_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_box_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 446);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.load_stations_button);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CS586 Train Database Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Button load_stations_button;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.TextBox search_box;
    }
}

