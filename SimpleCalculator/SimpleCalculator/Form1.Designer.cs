namespace SimpleCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_results = new System.Windows.Forms.Button();
            this.txt_entry1 = new System.Windows.Forms.TextBox();
            this.txt_entry2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter #2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_result.Location = new System.Drawing.Point(207, 216);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(119, 33);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_results
            // 
            this.btn_results.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_results.Location = new System.Drawing.Point(12, 186);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(144, 93);
            this.btn_results.TabIndex = 3;
            this.btn_results.Text = "Click to get results";
            this.btn_results.UseVisualStyleBackColor = false;
            this.btn_results.Click += new System.EventHandler(this.btn_results_Click);
            // 
            // txt_entry1
            // 
            this.txt_entry1.Location = new System.Drawing.Point(207, 67);
            this.txt_entry1.Name = "txt_entry1";
            this.txt_entry1.Size = new System.Drawing.Size(98, 20);
            this.txt_entry1.TabIndex = 5;
            this.txt_entry1.TextChanged += new System.EventHandler(this.txt_entry1_TextChanged);
            // 
            // txt_entry2
            // 
            this.txt_entry2.Location = new System.Drawing.Point(207, 110);
            this.txt_entry2.Name = "txt_entry2";
            this.txt_entry2.Size = new System.Drawing.Size(98, 20);
            this.txt_entry2.TabIndex = 6;
            this.txt_entry2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.txt_entry2);
            this.Controls.Add(this.txt_entry1);
            this.Controls.Add(this.btn_results);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.TextBox txt_entry1;
        private System.Windows.Forms.TextBox txt_entry2;
    }
}

