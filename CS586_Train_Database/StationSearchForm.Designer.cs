namespace CS586_Train_Database
{
    partial class StationSearchForm
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
            this.search_box = new System.Windows.Forms.TextBox();
            this.find_button = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // search_box
            // 
            this.search_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box.Location = new System.Drawing.Point(14, 35);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(936, 26);
            this.search_box.TabIndex = 0;
            // 
            // find_button
            // 
            this.find_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.find_button.Location = new System.Drawing.Point(956, 31);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(126, 34);
            this.find_button.TabIndex = 1;
            this.find_button.Text = "Search";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(14, 70);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 28;
            this.grid.Size = new System.Drawing.Size(1070, 490);
            this.grid.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please enter a station code, name, city, or state to search for below:";
            // 
            // StationSearchForm
            // 
            this.AcceptButton = this.find_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.grid);
            this.Name = "StationSearchForm";
            this.Text = "Find a station";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label1;
    }
}