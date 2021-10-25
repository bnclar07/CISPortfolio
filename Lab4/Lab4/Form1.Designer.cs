namespace Lab4
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
            this.gpaLB = new System.Windows.Forms.Label();
            this.TestScoreLB = new System.Windows.Forms.Label();
            this.gpaTB = new System.Windows.Forms.TextBox();
            this.TestScoreTB = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.DecisionLB = new System.Windows.Forms.Label();
            this.AcceptedLB = new System.Windows.Forms.Label();
            this.RejectedLB = new System.Windows.Forms.Label();
            this.AcceptedOP = new System.Windows.Forms.Label();
            this.RejectedOP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaLB
            // 
            this.gpaLB.AutoSize = true;
            this.gpaLB.Location = new System.Drawing.Point(71, 79);
            this.gpaLB.Name = "gpaLB";
            this.gpaLB.Size = new System.Drawing.Size(63, 13);
            this.gpaLB.TabIndex = 0;
            this.gpaLB.Text = "GPA Score:";
            // 
            // TestScoreLB
            // 
            this.TestScoreLB.AutoSize = true;
            this.TestScoreLB.Location = new System.Drawing.Point(74, 127);
            this.TestScoreLB.Name = "TestScoreLB";
            this.TestScoreLB.Size = new System.Drawing.Size(62, 13);
            this.TestScoreLB.TabIndex = 1;
            this.TestScoreLB.Text = "Test Score:";
            // 
            // gpaTB
            // 
            this.gpaTB.Location = new System.Drawing.Point(141, 79);
            this.gpaTB.Name = "gpaTB";
            this.gpaTB.Size = new System.Drawing.Size(100, 20);
            this.gpaTB.TabIndex = 2;
            // 
            // TestScoreTB
            // 
            this.TestScoreTB.Location = new System.Drawing.Point(141, 127);
            this.TestScoreTB.Name = "TestScoreTB";
            this.TestScoreTB.Size = new System.Drawing.Size(100, 20);
            this.TestScoreTB.TabIndex = 3;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(144, 185);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 23);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // DecisionLB
            // 
            this.DecisionLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecisionLB.Location = new System.Drawing.Point(138, 239);
            this.DecisionLB.Name = "DecisionLB";
            this.DecisionLB.Size = new System.Drawing.Size(100, 23);
            this.DecisionLB.TabIndex = 5;
            // 
            // AcceptedLB
            // 
            this.AcceptedLB.AutoSize = true;
            this.AcceptedLB.Location = new System.Drawing.Point(71, 290);
            this.AcceptedLB.Name = "AcceptedLB";
            this.AcceptedLB.Size = new System.Drawing.Size(56, 13);
            this.AcceptedLB.TabIndex = 6;
            this.AcceptedLB.Text = "Accepted:";
            // 
            // RejectedLB
            // 
            this.RejectedLB.AutoSize = true;
            this.RejectedLB.Location = new System.Drawing.Point(74, 324);
            this.RejectedLB.Name = "RejectedLB";
            this.RejectedLB.Size = new System.Drawing.Size(53, 13);
            this.RejectedLB.TabIndex = 7;
            this.RejectedLB.Text = "Rejected:";
            // 
            // AcceptedOP
            // 
            this.AcceptedOP.AutoSize = true;
            this.AcceptedOP.Location = new System.Drawing.Point(133, 290);
            this.AcceptedOP.Name = "AcceptedOP";
            this.AcceptedOP.Size = new System.Drawing.Size(13, 13);
            this.AcceptedOP.TabIndex = 8;
            this.AcceptedOP.Text = "0";
            // 
            // RejectedOP
            // 
            this.RejectedOP.AutoSize = true;
            this.RejectedOP.Location = new System.Drawing.Point(133, 324);
            this.RejectedOP.Name = "RejectedOP";
            this.RejectedOP.Size = new System.Drawing.Size(13, 13);
            this.RejectedOP.TabIndex = 9;
            this.RejectedOP.Text = "0";
            // 
            // Form1
            // 
            this.AcceptButton = this.EnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.RejectedOP);
            this.Controls.Add(this.AcceptedOP);
            this.Controls.Add(this.RejectedLB);
            this.Controls.Add(this.AcceptedLB);
            this.Controls.Add(this.DecisionLB);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.TestScoreTB);
            this.Controls.Add(this.gpaTB);
            this.Controls.Add(this.TestScoreLB);
            this.Controls.Add(this.gpaLB);
            this.Name = "Form1";
            this.Text = "Admission Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaLB;
        private System.Windows.Forms.Label TestScoreLB;
        private System.Windows.Forms.TextBox gpaTB;
        private System.Windows.Forms.TextBox TestScoreTB;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label DecisionLB;
        private System.Windows.Forms.Label AcceptedLB;
        private System.Windows.Forms.Label RejectedLB;
        private System.Windows.Forms.Label AcceptedOP;
        private System.Windows.Forms.Label RejectedOP;
    }
}

