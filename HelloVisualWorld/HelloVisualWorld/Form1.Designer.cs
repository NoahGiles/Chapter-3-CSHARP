namespace HelloVisualWorld
{
    partial class HelloVisualWorld
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
            this.helloLabel = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.ButtonGoodbye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Location = new System.Drawing.Point(92, 153);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(93, 13);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "Hello Visual World";
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(95, 188);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 1;
            this.buttonResult.Text = "CLICK ME";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonGoodbye
            // 
            this.ButtonGoodbye.Location = new System.Drawing.Point(95, 239);
            this.ButtonGoodbye.Name = "ButtonGoodbye";
            this.ButtonGoodbye.Size = new System.Drawing.Size(75, 23);
            this.ButtonGoodbye.TabIndex = 2;
            this.ButtonGoodbye.Text = "Goodbye!";
            this.ButtonGoodbye.UseVisualStyleBackColor = true;
            this.ButtonGoodbye.Click += new System.EventHandler(this.ButtonGoodbye_Click);
            // 
            // HelloVisualWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.ButtonGoodbye);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.helloLabel);
            this.Name = "HelloVisualWorld";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button ButtonGoodbye;
    }
}

