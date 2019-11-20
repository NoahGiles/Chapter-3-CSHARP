namespace EggsInteractiveGUI
{
    partial class EggsInteractive
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
            this.btnConvertEggs = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtEggs4 = new System.Windows.Forms.TextBox();
            this.txtEggs1 = new System.Windows.Forms.TextBox();
            this.txtEggs2 = new System.Windows.Forms.TextBox();
            this.txtEggs3 = new System.Windows.Forms.TextBox();
            this.txtEggs5 = new System.Windows.Forms.TextBox();
            this.lblEggsEntry = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertEggs
            // 
            this.btnConvertEggs.Location = new System.Drawing.Point(111, 219);
            this.btnConvertEggs.Name = "btnConvertEggs";
            this.btnConvertEggs.Size = new System.Drawing.Size(106, 23);
            this.btnConvertEggs.TabIndex = 1;
            this.btnConvertEggs.Text = "Click to calculate!";
            this.btnConvertEggs.UseVisualStyleBackColor = true;
            this.btnConvertEggs.Click += new System.EventHandler(this.btnConvertEggs_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 20);
            this.textBox2.TabIndex = 2;
            // 
            // txtEggs4
            // 
            this.txtEggs4.Location = new System.Drawing.Point(57, 179);
            this.txtEggs4.Name = "txtEggs4";
            this.txtEggs4.Size = new System.Drawing.Size(50, 20);
            this.txtEggs4.TabIndex = 4;
            // 
            // txtEggs1
            // 
            this.txtEggs1.Location = new System.Drawing.Point(57, 135);
            this.txtEggs1.Name = "txtEggs1";
            this.txtEggs1.Size = new System.Drawing.Size(50, 20);
            this.txtEggs1.TabIndex = 6;
            // 
            // txtEggs2
            // 
            this.txtEggs2.Location = new System.Drawing.Point(138, 135);
            this.txtEggs2.Name = "txtEggs2";
            this.txtEggs2.Size = new System.Drawing.Size(50, 20);
            this.txtEggs2.TabIndex = 7;
            // 
            // txtEggs3
            // 
            this.txtEggs3.Location = new System.Drawing.Point(219, 135);
            this.txtEggs3.Name = "txtEggs3";
            this.txtEggs3.Size = new System.Drawing.Size(50, 20);
            this.txtEggs3.TabIndex = 8;
            // 
            // txtEggs5
            // 
            this.txtEggs5.Location = new System.Drawing.Point(138, 179);
            this.txtEggs5.Name = "txtEggs5";
            this.txtEggs5.Size = new System.Drawing.Size(50, 20);
            this.txtEggs5.TabIndex = 9;
            // 
            // lblEggsEntry
            // 
            this.lblEggsEntry.AutoSize = true;
            this.lblEggsEntry.Location = new System.Drawing.Point(55, 81);
            this.lblEggsEntry.Name = "lblEggsEntry";
            this.lblEggsEntry.Size = new System.Drawing.Size(214, 13);
            this.lblEggsEntry.TabIndex = 10;
            this.lblEggsEntry.Text = "Enter eggs produced by each of 5 chickens";
            this.lblEggsEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(58, 262);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(211, 34);
            this.lblResult.TabIndex = 11;
            // 
            // EggsInteractive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblEggsEntry);
            this.Controls.Add(this.txtEggs5);
            this.Controls.Add(this.txtEggs3);
            this.Controls.Add(this.txtEggs2);
            this.Controls.Add(this.txtEggs1);
            this.Controls.Add(this.txtEggs4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnConvertEggs);
            this.Name = "EggsInteractive";
            this.Text = "Eggs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertEggs;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtEggs4;
        private System.Windows.Forms.TextBox txtEggs1;
        private System.Windows.Forms.TextBox txtEggs2;
        private System.Windows.Forms.TextBox txtEggs3;
        private System.Windows.Forms.TextBox txtEggs5;
        private System.Windows.Forms.Label lblEggsEntry;
        private System.Windows.Forms.Label lblResult;
    }
}

