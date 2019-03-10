namespace CS586_Train_Database
{
    partial class Main_form
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
            this.load_stations_button = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.find_button = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.routes_listBox = new System.Windows.Forms.ListBox();
            this.stations_group = new System.Windows.Forms.GroupBox();
            this.stations_listBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.route_select = new System.Windows.Forms.Button();
            this.station_select = new System.Windows.Forms.Button();
            this.trains_group = new System.Windows.Forms.GroupBox();
            this.train_select = new System.Windows.Forms.Button();
            this.trains_listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.stations_group.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.trains_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // load_stations_button
            // 
            this.load_stations_button.Location = new System.Drawing.Point(10, 361);
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
            this.grid.Location = new System.Drawing.Point(12, 410);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 28;
            this.grid.Size = new System.Drawing.Size(974, 170);
            this.grid.TabIndex = 4;
            // 
            // find_button
            // 
            this.find_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.find_button.Location = new System.Drawing.Point(858, 362);
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
            this.search_box.Location = new System.Drawing.Point(240, 366);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(612, 26);
            this.search_box.TabIndex = 6;
            this.search_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_box_KeyDown);
            this.search_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_box_KeyUp);
            // 
            // routes_listBox
            // 
            this.routes_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routes_listBox.FormattingEnabled = true;
            this.routes_listBox.ItemHeight = 20;
            this.routes_listBox.Location = new System.Drawing.Point(6, 25);
            this.routes_listBox.Name = "routes_listBox";
            this.routes_listBox.Size = new System.Drawing.Size(260, 264);
            this.routes_listBox.TabIndex = 7;
            // 
            // stations_group
            // 
            this.stations_group.Controls.Add(this.station_select);
            this.stations_group.Controls.Add(this.stations_listBox);
            this.stations_group.Location = new System.Drawing.Point(288, 12);
            this.stations_group.Name = "stations_group";
            this.stations_group.Size = new System.Drawing.Size(270, 331);
            this.stations_group.TabIndex = 9;
            this.stations_group.TabStop = false;
            this.stations_group.Text = "Stations";
            this.stations_group.Visible = false;
            // 
            // stations_listBox
            // 
            this.stations_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stations_listBox.FormattingEnabled = true;
            this.stations_listBox.ItemHeight = 20;
            this.stations_listBox.Location = new System.Drawing.Point(6, 25);
            this.stations_listBox.Name = "stations_listBox";
            this.stations_listBox.Size = new System.Drawing.Size(258, 264);
            this.stations_listBox.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.route_select);
            this.groupBox2.Controls.Add(this.routes_listBox);
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 331);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Routes";
            // 
            // route_select
            // 
            this.route_select.Location = new System.Drawing.Point(93, 295);
            this.route_select.Name = "route_select";
            this.route_select.Size = new System.Drawing.Size(75, 30);
            this.route_select.TabIndex = 8;
            this.route_select.Text = "Select";
            this.route_select.UseVisualStyleBackColor = true;
            this.route_select.Click += new System.EventHandler(this.route_select_Click);
            // 
            // station_select
            // 
            this.station_select.Location = new System.Drawing.Point(98, 295);
            this.station_select.Name = "station_select";
            this.station_select.Size = new System.Drawing.Size(75, 30);
            this.station_select.TabIndex = 9;
            this.station_select.Text = "Select";
            this.station_select.UseVisualStyleBackColor = true;
            this.station_select.Click += new System.EventHandler(this.station_select_Click);
            // 
            // trains_group
            // 
            this.trains_group.Controls.Add(this.train_select);
            this.trains_group.Controls.Add(this.trains_listBox);
            this.trains_group.Location = new System.Drawing.Point(564, 12);
            this.trains_group.Name = "trains_group";
            this.trains_group.Size = new System.Drawing.Size(270, 331);
            this.trains_group.TabIndex = 10;
            this.trains_group.TabStop = false;
            this.trains_group.Text = "Trains";
            this.trains_group.Visible = false;
            // 
            // train_select
            // 
            this.train_select.Location = new System.Drawing.Point(98, 295);
            this.train_select.Name = "train_select";
            this.train_select.Size = new System.Drawing.Size(75, 30);
            this.train_select.TabIndex = 9;
            this.train_select.Text = "Select";
            this.train_select.UseVisualStyleBackColor = true;
            // 
            // trains_listBox
            // 
            this.trains_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trains_listBox.FormattingEnabled = true;
            this.trains_listBox.ItemHeight = 20;
            this.trains_listBox.Location = new System.Drawing.Point(6, 25);
            this.trains_listBox.Name = "trains_listBox";
            this.trains_listBox.Size = new System.Drawing.Size(258, 264);
            this.trains_listBox.TabIndex = 8;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 592);
            this.Controls.Add(this.trains_group);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stations_group);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.load_stations_button);
            this.Name = "Main_form";
            this.Text = "CS586 Train Database Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.stations_group.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.trains_group.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button load_stations_button;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.ListBox routes_listBox;
        private System.Windows.Forms.GroupBox stations_group;
        private System.Windows.Forms.ListBox stations_listBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button route_select;
        private System.Windows.Forms.Button station_select;
        private System.Windows.Forms.GroupBox trains_group;
        private System.Windows.Forms.Button train_select;
        private System.Windows.Forms.ListBox trains_listBox;
    }
}

