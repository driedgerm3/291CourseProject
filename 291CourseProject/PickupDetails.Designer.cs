namespace _291CourseProject
{
    partial class PickupDetails
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.branches = new System.Windows.Forms.ComboBox();
            this.pickupDate = new System.Windows.Forms.DateTimePicker();
            this.dropoffDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pickupTime = new System.Windows.Forms.DateTimePicker();
            this.dropoffTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // branches
            // 
            this.branches.FormattingEnabled = true;
            this.branches.Location = new System.Drawing.Point(16, 266);
            this.branches.Margin = new System.Windows.Forms.Padding(4);
            this.branches.Name = "branches";
            this.branches.Size = new System.Drawing.Size(160, 24);
            this.branches.TabIndex = 8;
            // 
            // pickupDate
            // 
            this.pickupDate.Location = new System.Drawing.Point(16, 368);
            this.pickupDate.Margin = new System.Windows.Forms.Padding(4);
            this.pickupDate.Name = "pickupDate";
            this.pickupDate.Size = new System.Drawing.Size(265, 22);
            this.pickupDate.TabIndex = 9;
            // 
            // dropoffDate
            // 
            this.dropoffDate.Location = new System.Drawing.Point(16, 471);
            this.dropoffDate.Margin = new System.Windows.Forms.Padding(4);
            this.dropoffDate.Name = "dropoffDate";
            this.dropoffDate.Size = new System.Drawing.Size(265, 22);
            this.dropoffDate.TabIndex = 10;
            this.dropoffDate.Value = new System.DateTime(2020, 3, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Cambria", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "CMB Rentals";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(11, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(688, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Looking to rent a vehicle? Fill in the information below and get an instant quote" +
    ".";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(898, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 62);
            this.button1.TabIndex = 15;
            this.button1.Text = "Find a vehicle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backButton.Location = new System.Drawing.Point(16, 69);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 31);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(16, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pick-up Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(16, 443);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Drop-off Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(16, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Pick-up Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(396, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Pick-up Time";
            // 
            // pickupTime
            // 
            this.pickupTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickupTime.Location = new System.Drawing.Point(401, 368);
            this.pickupTime.Name = "pickupTime";
            this.pickupTime.Size = new System.Drawing.Size(140, 22);
            this.pickupTime.TabIndex = 25;
            // 
            // dropoffTime
            // 
            this.dropoffTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dropoffTime.Location = new System.Drawing.Point(401, 471);
            this.dropoffTime.Name = "dropoffTime";
            this.dropoffTime.Size = new System.Drawing.Size(140, 22);
            this.dropoffTime.TabIndex = 26;
            this.dropoffTime.Value = new System.DateTime(2020, 3, 28, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(396, 443);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Drop-off Time";
            // 
            // PickupDetails
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 752);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dropoffTime);
            this.Controls.Add(this.pickupTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropoffDate);
            this.Controls.Add(this.pickupDate);
            this.Controls.Add(this.branches);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PickupDetails";
            this.Text = "Enter Information";
            this.Load += new System.EventHandler(this.PickupDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox branches;
        private System.Windows.Forms.DateTimePicker pickupDate;
        private System.Windows.Forms.DateTimePicker dropoffDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker pickupTime;
        private System.Windows.Forms.DateTimePicker dropoffTime;
        private System.Windows.Forms.Label label7;
    }
}

