namespace TestInteractiveGUI
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
            this.txtEntry1 = new System.Windows.Forms.TextBox();
            this.txtEntry4 = new System.Windows.Forms.TextBox();
            this.txtEntry2 = new System.Windows.Forms.TextBox();
            this.txtEntry3 = new System.Windows.Forms.TextBox();
            this.txtEntry5 = new System.Windows.Forms.TextBox();
            this.lblTestText = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntry1
            // 
            this.txtEntry1.Location = new System.Drawing.Point(106, 69);
            this.txtEntry1.Name = "txtEntry1";
            this.txtEntry1.Size = new System.Drawing.Size(64, 20);
            this.txtEntry1.TabIndex = 2;
            // 
            // txtEntry4
            // 
            this.txtEntry4.Location = new System.Drawing.Point(106, 147);
            this.txtEntry4.Name = "txtEntry4";
            this.txtEntry4.Size = new System.Drawing.Size(64, 20);
            this.txtEntry4.TabIndex = 3;
            // 
            // txtEntry2
            // 
            this.txtEntry2.Location = new System.Drawing.Point(106, 95);
            this.txtEntry2.Name = "txtEntry2";
            this.txtEntry2.Size = new System.Drawing.Size(64, 20);
            this.txtEntry2.TabIndex = 4;
            // 
            // txtEntry3
            // 
            this.txtEntry3.Location = new System.Drawing.Point(106, 121);
            this.txtEntry3.Name = "txtEntry3";
            this.txtEntry3.Size = new System.Drawing.Size(64, 20);
            this.txtEntry3.TabIndex = 5;
            // 
            // txtEntry5
            // 
            this.txtEntry5.Location = new System.Drawing.Point(106, 173);
            this.txtEntry5.Name = "txtEntry5";
            this.txtEntry5.Size = new System.Drawing.Size(64, 20);
            this.txtEntry5.TabIndex = 6;
            // 
            // lblTestText
            // 
            this.lblTestText.AutoSize = true;
            this.lblTestText.Location = new System.Drawing.Point(86, 38);
            this.lblTestText.Name = "lblTestText";
            this.lblTestText.Size = new System.Drawing.Size(98, 13);
            this.lblTestText.TabIndex = 7;
            this.lblTestText.Text = "Enter Test Scores :";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(89, 213);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(95, 23);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Get results!!!";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(44, 257);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(186, 64);
            this.lblResults.TabIndex = 9;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblTestText);
            this.Controls.Add(this.txtEntry5);
            this.Controls.Add(this.txtEntry3);
            this.Controls.Add(this.txtEntry2);
            this.Controls.Add(this.txtEntry4);
            this.Controls.Add(this.txtEntry1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Tests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntry1;
        private System.Windows.Forms.TextBox txtEntry4;
        private System.Windows.Forms.TextBox txtEntry2;
        private System.Windows.Forms.TextBox txtEntry3;
        private System.Windows.Forms.TextBox txtEntry5;
        private System.Windows.Forms.Label lblTestText;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResults;
    }
}

