namespace PayrollGUI
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtHoursPay = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblHoursPay = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnGiveResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(129, 157);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(133, 20);
            this.txtSSN.TabIndex = 1;
            // 
            // txtHoursPay
            // 
            this.txtHoursPay.Location = new System.Drawing.Point(129, 183);
            this.txtHoursPay.Name = "txtHoursPay";
            this.txtHoursPay.Size = new System.Drawing.Size(133, 20);
            this.txtHoursPay.TabIndex = 2;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(129, 209);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(133, 20);
            this.txtHoursWorked.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(79, 134);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name : ";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(27, 160);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(96, 13);
            this.lblSSN.TabIndex = 6;
            this.lblSSN.Text = "Social Security # : ";
            // 
            // lblHoursPay
            // 
            this.lblHoursPay.AutoSize = true;
            this.lblHoursPay.Location = new System.Drawing.Point(57, 186);
            this.lblHoursPay.Name = "lblHoursPay";
            this.lblHoursPay.Size = new System.Drawing.Size(66, 13);
            this.lblHoursPay.TabIndex = 7;
            this.lblHoursPay.Text = "Hourly pay : ";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(41, 212);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(82, 13);
            this.lblHoursWorked.TabIndex = 8;
            this.lblHoursWorked.Text = "Hours worked : ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(99, 92);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 13);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Enter your sensitive information below!";
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(102, 281);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(180, 83);
            this.lblResults.TabIndex = 10;
            // 
            // btnGiveResults
            // 
            this.btnGiveResults.Location = new System.Drawing.Point(129, 235);
            this.btnGiveResults.Name = "btnGiveResults";
            this.btnGiveResults.Size = new System.Drawing.Size(133, 23);
            this.btnGiveResults.TabIndex = 11;
            this.btnGiveResults.Text = "Give me my data!";
            this.btnGiveResults.UseVisualStyleBackColor = true;
            this.btnGiveResults.Click += new System.EventHandler(this.btnGiveResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.btnGiveResults);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblHoursPay);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtHoursPay);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtHoursPay;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblHoursPay;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnGiveResults;
    }
}

