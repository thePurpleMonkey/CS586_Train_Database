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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.routes_listBox = new System.Windows.Forms.ListBox();
            this.stations_group = new System.Windows.Forms.GroupBox();
            this.station_select = new System.Windows.Forms.Button();
            this.stations_listBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.route_select = new System.Windows.Forms.Button();
            this.trains_group = new System.Windows.Forms.GroupBox();
            this.train_select = new System.Windows.Forms.Button();
            this.trains_listBox = new System.Windows.Forms.ListBox();
            this.details_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.estimated_arrival_label = new System.Windows.Forms.Label();
            this.updated_last_label = new System.Windows.Forms.Label();
            this.speed_label = new System.Windows.Forms.Label();
            this.direction_label = new System.Windows.Forms.Label();
            this.coordinates_label = new System.Windows.Forms.Label();
            this.miles_travelled_label = new System.Windows.Forms.Label();
            this.route_name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.route_number_label = new System.Windows.Forms.Label();
            this.stations_group.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.trains_group.SuspendLayout();
            this.details_groupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // routes_listBox
            // 
            this.routes_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routes_listBox.FormattingEnabled = true;
            this.routes_listBox.Location = new System.Drawing.Point(4, 16);
            this.routes_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.routes_listBox.Name = "routes_listBox";
            this.routes_listBox.Size = new System.Drawing.Size(175, 173);
            this.routes_listBox.TabIndex = 7;
            // 
            // stations_group
            // 
            this.stations_group.Controls.Add(this.station_select);
            this.stations_group.Controls.Add(this.stations_listBox);
            this.stations_group.Location = new System.Drawing.Point(192, 8);
            this.stations_group.Margin = new System.Windows.Forms.Padding(2);
            this.stations_group.Name = "stations_group";
            this.stations_group.Padding = new System.Windows.Forms.Padding(2);
            this.stations_group.Size = new System.Drawing.Size(180, 215);
            this.stations_group.TabIndex = 9;
            this.stations_group.TabStop = false;
            this.stations_group.Text = "Stations";
            this.stations_group.Visible = false;
            // 
            // station_select
            // 
            this.station_select.Location = new System.Drawing.Point(65, 192);
            this.station_select.Margin = new System.Windows.Forms.Padding(2);
            this.station_select.Name = "station_select";
            this.station_select.Size = new System.Drawing.Size(50, 19);
            this.station_select.TabIndex = 9;
            this.station_select.Text = "Select";
            this.station_select.UseVisualStyleBackColor = true;
            this.station_select.Click += new System.EventHandler(this.station_select_Click);
            // 
            // stations_listBox
            // 
            this.stations_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stations_listBox.FormattingEnabled = true;
            this.stations_listBox.Location = new System.Drawing.Point(4, 16);
            this.stations_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.stations_listBox.MaximumSize = new System.Drawing.Size(173, 173);
            this.stations_listBox.MinimumSize = new System.Drawing.Size(173, 173);
            this.stations_listBox.Name = "stations_listBox";
            this.stations_listBox.Size = new System.Drawing.Size(173, 173);
            this.stations_listBox.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.route_select);
            this.groupBox2.Controls.Add(this.routes_listBox);
            this.groupBox2.Location = new System.Drawing.Point(7, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(181, 215);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Routes";
            // 
            // route_select
            // 
            this.route_select.Location = new System.Drawing.Point(62, 192);
            this.route_select.Margin = new System.Windows.Forms.Padding(2);
            this.route_select.Name = "route_select";
            this.route_select.Size = new System.Drawing.Size(50, 19);
            this.route_select.TabIndex = 8;
            this.route_select.Text = "Select";
            this.route_select.UseVisualStyleBackColor = true;
            this.route_select.Click += new System.EventHandler(this.route_select_Click);
            // 
            // trains_group
            // 
            this.trains_group.Controls.Add(this.train_select);
            this.trains_group.Controls.Add(this.trains_listBox);
            this.trains_group.Location = new System.Drawing.Point(376, 8);
            this.trains_group.Margin = new System.Windows.Forms.Padding(2);
            this.trains_group.Name = "trains_group";
            this.trains_group.Padding = new System.Windows.Forms.Padding(2);
            this.trains_group.Size = new System.Drawing.Size(180, 215);
            this.trains_group.TabIndex = 10;
            this.trains_group.TabStop = false;
            this.trains_group.Text = "Trains";
            this.trains_group.Visible = false;
            // 
            // train_select
            // 
            this.train_select.Location = new System.Drawing.Point(65, 192);
            this.train_select.Margin = new System.Windows.Forms.Padding(2);
            this.train_select.Name = "train_select";
            this.train_select.Size = new System.Drawing.Size(50, 19);
            this.train_select.TabIndex = 9;
            this.train_select.Text = "Select";
            this.train_select.UseVisualStyleBackColor = true;
            this.train_select.Click += new System.EventHandler(this.train_select_Click);
            // 
            // trains_listBox
            // 
            this.trains_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trains_listBox.FormattingEnabled = true;
            this.trains_listBox.HorizontalScrollbar = true;
            this.trains_listBox.Location = new System.Drawing.Point(4, 16);
            this.trains_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.trains_listBox.Name = "trains_listBox";
            this.trains_listBox.Size = new System.Drawing.Size(173, 173);
            this.trains_listBox.TabIndex = 8;
            // 
            // details_groupBox
            // 
            this.details_groupBox.Controls.Add(this.tableLayoutPanel1);
            this.details_groupBox.Location = new System.Drawing.Point(561, 8);
            this.details_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.details_groupBox.Name = "details_groupBox";
            this.details_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.details_groupBox.Size = new System.Drawing.Size(228, 214);
            this.details_groupBox.TabIndex = 11;
            this.details_groupBox.TabStop = false;
            this.details_groupBox.Text = "Train details";
            this.details_groupBox.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.94529F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.05471F));
            this.tableLayoutPanel1.Controls.Add(this.estimated_arrival_label, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.updated_last_label, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.speed_label, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.direction_label, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.coordinates_label, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.miles_travelled_label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.route_name_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.route_number_label, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 17);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(219, 194);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // estimated_arrival_label
            // 
            this.estimated_arrival_label.AutoSize = true;
            this.estimated_arrival_label.Location = new System.Drawing.Point(93, 91);
            this.estimated_arrival_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.estimated_arrival_label.Name = "estimated_arrival_label";
            this.estimated_arrival_label.Size = new System.Drawing.Size(41, 13);
            this.estimated_arrival_label.TabIndex = 20;
            this.estimated_arrival_label.Text = "label10";
            // 
            // updated_last_label
            // 
            this.updated_last_label.AutoSize = true;
            this.updated_last_label.Location = new System.Drawing.Point(93, 78);
            this.updated_last_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.updated_last_label.Name = "updated_last_label";
            this.updated_last_label.Size = new System.Drawing.Size(41, 13);
            this.updated_last_label.TabIndex = 19;
            this.updated_last_label.Text = "label10";
            // 
            // speed_label
            // 
            this.speed_label.AutoSize = true;
            this.speed_label.Location = new System.Drawing.Point(93, 65);
            this.speed_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(41, 13);
            this.speed_label.TabIndex = 18;
            this.speed_label.Text = "label10";
            // 
            // direction_label
            // 
            this.direction_label.AutoSize = true;
            this.direction_label.Location = new System.Drawing.Point(93, 52);
            this.direction_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.direction_label.Name = "direction_label";
            this.direction_label.Size = new System.Drawing.Size(41, 13);
            this.direction_label.TabIndex = 17;
            this.direction_label.Text = "label10";
            // 
            // coordinates_label
            // 
            this.coordinates_label.AutoSize = true;
            this.coordinates_label.Location = new System.Drawing.Point(93, 39);
            this.coordinates_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coordinates_label.Name = "coordinates_label";
            this.coordinates_label.Size = new System.Drawing.Size(41, 13);
            this.coordinates_label.TabIndex = 16;
            this.coordinates_label.Text = "label10";
            // 
            // miles_travelled_label
            // 
            this.miles_travelled_label.AutoSize = true;
            this.miles_travelled_label.Location = new System.Drawing.Point(93, 26);
            this.miles_travelled_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.miles_travelled_label.Name = "miles_travelled_label";
            this.miles_travelled_label.Size = new System.Drawing.Size(41, 13);
            this.miles_travelled_label.TabIndex = 14;
            this.miles_travelled_label.Text = "label10";
            // 
            // route_name_label
            // 
            this.route_name_label.AutoSize = true;
            this.route_name_label.Location = new System.Drawing.Point(93, 0);
            this.route_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.route_name_label.Name = "route_name_label";
            this.route_name_label.Size = new System.Drawing.Size(41, 13);
            this.route_name_label.TabIndex = 12;
            this.route_name_label.Text = "label10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Route name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Route number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miles travelled:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Coordinates:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direction:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Speed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Updated last:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estimated arrival:";
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Location = new System.Drawing.Point(2, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 19);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Alert";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // route_number_label
            // 
            this.route_number_label.AutoSize = true;
            this.route_number_label.Location = new System.Drawing.Point(93, 13);
            this.route_number_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.route_number_label.Name = "route_number_label";
            this.route_number_label.Size = new System.Drawing.Size(41, 13);
            this.route_number_label.TabIndex = 13;
            this.route_number_label.Text = "label10";
            // 
            // Main_form
            // 
            this.AcceptButton = this.route_select;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 248);
            this.Controls.Add(this.details_groupBox);
            this.Controls.Add(this.trains_group);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stations_group);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 287);
            this.MinimumSize = new System.Drawing.Size(820, 287);
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CS586 Train Database Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.stations_group.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.trains_group.ResumeLayout(false);
            this.details_groupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox routes_listBox;
        private System.Windows.Forms.GroupBox stations_group;
        private System.Windows.Forms.ListBox stations_listBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button route_select;
        private System.Windows.Forms.Button station_select;
        private System.Windows.Forms.GroupBox trains_group;
        private System.Windows.Forms.Button train_select;
        private System.Windows.Forms.ListBox trains_listBox;
        private System.Windows.Forms.GroupBox details_groupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label estimated_arrival_label;
        private System.Windows.Forms.Label updated_last_label;
        private System.Windows.Forms.Label speed_label;
        private System.Windows.Forms.Label direction_label;
        private System.Windows.Forms.Label coordinates_label;
        private System.Windows.Forms.Label miles_travelled_label;
        private System.Windows.Forms.Label route_name_label;
        private System.Windows.Forms.Label route_number_label;
    }
}

