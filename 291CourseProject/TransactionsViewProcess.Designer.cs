namespace _291CourseProject
{
    partial class TransactionsViewProcess
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmedTransactions = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pendingTransactions = new System.Windows.Forms.CheckedListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(16, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 31);
            this.button2.TabIndex = 24;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.label1.TabIndex = 23;
            this.label1.Text = "CMB Rentals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Pending transaction IDs";
            // 
            // confirmedTransactions
            // 
            this.confirmedTransactions.FormattingEnabled = true;
            this.confirmedTransactions.ItemHeight = 16;
            this.confirmedTransactions.Location = new System.Drawing.Point(452, 178);
            this.confirmedTransactions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmedTransactions.Name = "confirmedTransactions";
            this.confirmedTransactions.Size = new System.Drawing.Size(295, 308);
            this.confirmedTransactions.TabIndex = 28;
            this.confirmedTransactions.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(447, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Comfirmed Transaction IDs";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(16, 505);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 62);
            this.button1.TabIndex = 47;
            this.button1.Text = "Confirm Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pendingTransactions
            // 
            this.pendingTransactions.FormattingEnabled = true;
            this.pendingTransactions.Location = new System.Drawing.Point(16, 178);
            this.pendingTransactions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pendingTransactions.Name = "pendingTransactions";
            this.pendingTransactions.Size = new System.Drawing.Size(284, 310);
            this.pendingTransactions.TabIndex = 48;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(168, 505);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 62);
            this.button3.TabIndex = 49;
            this.button3.Text = "Delete Selected";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TransactionsViewProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 752);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pendingTransactions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmedTransactions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TransactionsViewProcess";
            this.Text = "View/Process Transactions";
            this.Load += new System.EventHandler(this.vp_transactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox confirmedTransactions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox pendingTransactions;
        private System.Windows.Forms.Button button3;
    }
}