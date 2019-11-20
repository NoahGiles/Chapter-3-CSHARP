namespace ProjectedRaisesGUI
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
            this.btnConvertSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblRaiseText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertSalary
            // 
            this.btnConvertSalary.Location = new System.Drawing.Point(42, 129);
            this.btnConvertSalary.Name = "btnConvertSalary";
            this.btnConvertSalary.Size = new System.Drawing.Size(197, 42);
            this.btnConvertSalary.TabIndex = 0;
            this.btnConvertSalary.Text = "Convert salary";
            this.btnConvertSalary.UseVisualStyleBackColor = true;
            this.btnConvertSalary.Click += new System.EventHandler(this.btnConvertSalary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your salary : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(139, 103);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 2;
            // 
            // lblRaiseText
            // 
            this.lblRaiseText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRaiseText.Location = new System.Drawing.Point(42, 188);
            this.lblRaiseText.Name = "lblRaiseText";
            this.lblRaiseText.Size = new System.Drawing.Size(197, 31);
            this.lblRaiseText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 318);
            this.Controls.Add(this.lblRaiseText);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblRaiseText;
    }
}

