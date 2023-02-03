namespace Project1
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.ibtn1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ibtn1
            // 
            this.ibtn1.BackColor = System.Drawing.Color.Linen;
            this.ibtn1.Location = new System.Drawing.Point(461, 752);
            this.ibtn1.Name = "ibtn1";
            this.ibtn1.Size = new System.Drawing.Size(113, 53);
            this.ibtn1.TabIndex = 3;
            this.ibtn1.Text = "Continue";
            this.ibtn1.UseVisualStyleBackColor = false;
            this.ibtn1.Click += new System.EventHandler(this.ibtn1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(387, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 49);
            this.label4.TabIndex = 4;
            this.label4.Text = "Matab Al Shifa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project1.Properties.Resources.HawanDasta;
            this.pictureBox1.Image = global::Project1.Properties.Resources.HawanDasta;
            this.pictureBox1.Location = new System.Drawing.Point(311, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(421, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "مطب الشفاء";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(311, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dedicated to Hakeem Rizwan Tariq";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(403, 673);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "حکیم رضوان طارق کے نام";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Location = new System.Drawing.Point(789, 714);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 100);
            this.label5.TabIndex = 9;
            this.label5.Text = "Developed By:\r\nJawad Ali\r\nMuhammad Waleed\r\nAbdullah Umar \r\n";
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Project1.Properties.Resources.bck2;
            this.ClientSize = new System.Drawing.Size(973, 823);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ibtn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Intro";
            this.Text = "Matab Al Shifa";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Intro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button ibtn1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}