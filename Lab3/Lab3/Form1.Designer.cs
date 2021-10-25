namespace Lab3
{
    partial class Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3));
            this.RadiusLB = new System.Windows.Forms.Label();
            this.SphereTB = new System.Windows.Forms.TextBox();
            this.DiameterLB = new System.Windows.Forms.Label();
            this.SurfaceAreaLB = new System.Windows.Forms.Label();
            this.VolumeLB = new System.Windows.Forms.Label();
            this.DiameterOP = new System.Windows.Forms.Label();
            this.SurfaceAreaOP = new System.Windows.Forms.Label();
            this.VolumeOP = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RadiusLB
            // 
            this.RadiusLB.AutoSize = true;
            this.RadiusLB.Location = new System.Drawing.Point(431, 76);
            this.RadiusLB.Name = "RadiusLB";
            this.RadiusLB.Size = new System.Drawing.Size(90, 13);
            this.RadiusLB.TabIndex = 0;
            this.RadiusLB.Text = "Radius of sphere:";
            // 
            // SphereTB
            // 
            this.SphereTB.Location = new System.Drawing.Point(528, 68);
            this.SphereTB.Name = "SphereTB";
            this.SphereTB.Size = new System.Drawing.Size(100, 20);
            this.SphereTB.TabIndex = 1;
            // 
            // DiameterLB
            // 
            this.DiameterLB.AutoSize = true;
            this.DiameterLB.Location = new System.Drawing.Point(253, 199);
            this.DiameterLB.Name = "DiameterLB";
            this.DiameterLB.Size = new System.Drawing.Size(52, 13);
            this.DiameterLB.TabIndex = 2;
            this.DiameterLB.Text = "Diameter:";
            // 
            // SurfaceAreaLB
            // 
            this.SurfaceAreaLB.AutoSize = true;
            this.SurfaceAreaLB.Location = new System.Drawing.Point(233, 239);
            this.SurfaceAreaLB.Name = "SurfaceAreaLB";
            this.SurfaceAreaLB.Size = new System.Drawing.Size(72, 13);
            this.SurfaceAreaLB.TabIndex = 3;
            this.SurfaceAreaLB.Text = "Surface Area:";
            // 
            // VolumeLB
            // 
            this.VolumeLB.AutoSize = true;
            this.VolumeLB.Location = new System.Drawing.Point(260, 284);
            this.VolumeLB.Name = "VolumeLB";
            this.VolumeLB.Size = new System.Drawing.Size(45, 13);
            this.VolumeLB.TabIndex = 4;
            this.VolumeLB.Text = "Volume:";
            // 
            // DiameterOP
            // 
            this.DiameterOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiameterOP.Location = new System.Drawing.Point(312, 198);
            this.DiameterOP.Name = "DiameterOP";
            this.DiameterOP.Size = new System.Drawing.Size(100, 23);
            this.DiameterOP.TabIndex = 5;
            // 
            // SurfaceAreaOP
            // 
            this.SurfaceAreaOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurfaceAreaOP.Location = new System.Drawing.Point(312, 239);
            this.SurfaceAreaOP.Name = "SurfaceAreaOP";
            this.SurfaceAreaOP.Size = new System.Drawing.Size(100, 23);
            this.SurfaceAreaOP.TabIndex = 6;
            // 
            // VolumeOP
            // 
            this.VolumeOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VolumeOP.Location = new System.Drawing.Point(312, 284);
            this.VolumeOP.Name = "VolumeOP";
            this.VolumeOP.Size = new System.Drawing.Size(100, 23);
            this.VolumeOP.TabIndex = 7;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(538, 110);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(480, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Lab3
            // 
            this.AcceptButton = this.Calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.VolumeOP);
            this.Controls.Add(this.SurfaceAreaOP);
            this.Controls.Add(this.DiameterOP);
            this.Controls.Add(this.VolumeLB);
            this.Controls.Add(this.SurfaceAreaLB);
            this.Controls.Add(this.DiameterLB);
            this.Controls.Add(this.SphereTB);
            this.Controls.Add(this.RadiusLB);
            this.Name = "Lab3";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RadiusLB;
        private System.Windows.Forms.TextBox SphereTB;
        private System.Windows.Forms.Label DiameterLB;
        private System.Windows.Forms.Label SurfaceAreaLB;
        private System.Windows.Forms.Label VolumeLB;
        private System.Windows.Forms.Label DiameterOP;
        private System.Windows.Forms.Label SurfaceAreaOP;
        private System.Windows.Forms.Label VolumeOP;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

