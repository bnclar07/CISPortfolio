namespace Lab2
{
    partial class Lab2
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
            this.EnterLabelTB = new System.Windows.Forms.Label();
            this.UserText = new System.Windows.Forms.TextBox();
            this.TipRateLowTB = new System.Windows.Forms.Label();
            this.TipRateMiddleTB = new System.Windows.Forms.Label();
            this.TipRateHighTB = new System.Windows.Forms.Label();
            this.TipRateLowOP = new System.Windows.Forms.Label();
            this.TipRateMiddleOP = new System.Windows.Forms.Label();
            this.TipRateHighOP = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterLabelTB
            // 
            this.EnterLabelTB.AutoSize = true;
            this.EnterLabelTB.Location = new System.Drawing.Point(258, 86);
            this.EnterLabelTB.Name = "EnterLabelTB";
            this.EnterLabelTB.Size = new System.Drawing.Size(98, 13);
            this.EnterLabelTB.TabIndex = 0;
            this.EnterLabelTB.Text = "Enter price of meal:";
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(363, 86);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(100, 20);
            this.UserText.TabIndex = 1;
            // 
            // TipRateLowTB
            // 
            this.TipRateLowTB.AutoSize = true;
            this.TipRateLowTB.Location = new System.Drawing.Point(329, 132);
            this.TipRateLowTB.Name = "TipRateLowTB";
            this.TipRateLowTB.Size = new System.Drawing.Size(27, 13);
            this.TipRateLowTB.TabIndex = 2;
            this.TipRateLowTB.Text = "Low";
            // 
            // TipRateMiddleTB
            // 
            this.TipRateMiddleTB.AutoSize = true;
            this.TipRateMiddleTB.Location = new System.Drawing.Point(329, 172);
            this.TipRateMiddleTB.Name = "TipRateMiddleTB";
            this.TipRateMiddleTB.Size = new System.Drawing.Size(38, 13);
            this.TipRateMiddleTB.TabIndex = 3;
            this.TipRateMiddleTB.Text = "Middle";
            // 
            // TipRateHighTB
            // 
            this.TipRateHighTB.AutoSize = true;
            this.TipRateHighTB.Location = new System.Drawing.Point(329, 216);
            this.TipRateHighTB.Name = "TipRateHighTB";
            this.TipRateHighTB.Size = new System.Drawing.Size(29, 13);
            this.TipRateHighTB.TabIndex = 4;
            this.TipRateHighTB.Text = "High";
            // 
            // TipRateLowOP
            // 
            this.TipRateLowOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TipRateLowOP.Location = new System.Drawing.Point(363, 132);
            this.TipRateLowOP.Name = "TipRateLowOP";
            this.TipRateLowOP.Size = new System.Drawing.Size(100, 23);
            this.TipRateLowOP.TabIndex = 5;
            // 
            // TipRateMiddleOP
            // 
            this.TipRateMiddleOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TipRateMiddleOP.Location = new System.Drawing.Point(363, 171);
            this.TipRateMiddleOP.Name = "TipRateMiddleOP";
            this.TipRateMiddleOP.Size = new System.Drawing.Size(100, 23);
            this.TipRateMiddleOP.TabIndex = 6;
            // 
            // TipRateHighOP
            // 
            this.TipRateHighOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TipRateHighOP.Location = new System.Drawing.Point(363, 215);
            this.TipRateHighOP.Name = "TipRateHighOP";
            this.TipRateHighOP.Size = new System.Drawing.Size(100, 23);
            this.TipRateHighOP.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(332, 274);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(91, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate Tip";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Lab2
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TipRateHighOP);
            this.Controls.Add(this.TipRateMiddleOP);
            this.Controls.Add(this.TipRateLowOP);
            this.Controls.Add(this.TipRateHighTB);
            this.Controls.Add(this.TipRateMiddleTB);
            this.Controls.Add(this.TipRateLowTB);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.EnterLabelTB);
            this.Name = "Lab2";
            this.Text = "Lab 2";
            this.Load += new System.EventHandler(this.Lab2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterLabelTB;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.Label TipRateLowTB;
        private System.Windows.Forms.Label TipRateMiddleTB;
        private System.Windows.Forms.Label TipRateHighTB;
        private System.Windows.Forms.Label TipRateLowOP;
        private System.Windows.Forms.Label TipRateMiddleOP;
        private System.Windows.Forms.Label TipRateHighOP;
        private System.Windows.Forms.Button CalculateButton;
    }
}

