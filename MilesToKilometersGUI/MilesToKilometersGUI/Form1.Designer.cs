namespace MilesToKilometersGUI
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
            this.txt_miles = new System.Windows.Forms.Label();
            this.lbl_miles = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.lbl_ToKilos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_miles
            // 
            this.txt_miles.AutoSize = true;
            this.txt_miles.Location = new System.Drawing.Point(33, 173);
            this.txt_miles.Name = "txt_miles";
            this.txt_miles.Size = new System.Drawing.Size(40, 13);
            this.txt_miles.TabIndex = 0;
            this.txt_miles.Text = "Miles : ";
            this.txt_miles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_miles
            // 
            this.lbl_miles.Location = new System.Drawing.Point(79, 170);
            this.lbl_miles.Name = "lbl_miles";
            this.lbl_miles.Size = new System.Drawing.Size(100, 20);
            this.lbl_miles.TabIndex = 3;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(79, 196);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(100, 85);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "Convert to Kilometers";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // lbl_ToKilos
            // 
            this.lbl_ToKilos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ToKilos.Location = new System.Drawing.Point(79, 298);
            this.lbl_ToKilos.Name = "lbl_ToKilos";
            this.lbl_ToKilos.Size = new System.Drawing.Size(100, 26);
            this.lbl_ToKilos.TabIndex = 5;
            this.lbl_ToKilos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 450);
            this.Controls.Add(this.lbl_ToKilos);
            this.Controls.Add(this.lbl_miles);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_miles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_miles;
        private System.Windows.Forms.TextBox lbl_miles;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label lbl_ToKilos;
    }
}

