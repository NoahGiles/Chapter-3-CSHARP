namespace CarRentalInteractiveGUI
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
            this.lblDaysDriven = new System.Windows.Forms.Label();
            this.lblMilesDriven = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblFeeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDaysDriven
            // 
            this.lblDaysDriven.AutoSize = true;
            this.lblDaysDriven.Location = new System.Drawing.Point(67, 90);
            this.lblDaysDriven.Name = "lblDaysDriven";
            this.lblDaysDriven.Size = new System.Drawing.Size(72, 13);
            this.lblDaysDriven.TabIndex = 0;
            this.lblDaysDriven.Text = "Days driven : ";
            // 
            // lblMilesDriven
            // 
            this.lblMilesDriven.AutoSize = true;
            this.lblMilesDriven.Location = new System.Drawing.Point(67, 132);
            this.lblMilesDriven.Name = "lblMilesDriven";
            this.lblMilesDriven.Size = new System.Drawing.Size(72, 13);
            this.lblMilesDriven.TabIndex = 1;
            this.lblMilesDriven.Text = "Miles driven : ";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(145, 87);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 2;
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(145, 129);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(70, 155);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(175, 75);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert miles and days for rental fee";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblFeeOutput
            // 
            this.lblFeeOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFeeOutput.Location = new System.Drawing.Point(76, 248);
            this.lblFeeOutput.Name = "lblFeeOutput";
            this.lblFeeOutput.Size = new System.Drawing.Size(168, 45);
            this.lblFeeOutput.TabIndex = 5;
            this.lblFeeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.lblFeeOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblMilesDriven);
            this.Controls.Add(this.lblDaysDriven);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaysDriven;
        private System.Windows.Forms.Label lblMilesDriven;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblFeeOutput;
    }
}

