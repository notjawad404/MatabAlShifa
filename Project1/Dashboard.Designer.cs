namespace Project1
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(375, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Location = new System.Drawing.Point(375, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Medicines";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Location = new System.Drawing.Point(375, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cart";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.Location = new System.Drawing.Point(375, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(309, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "السلام عليكم ورحمة الله وبركاته";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(170, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(593, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "شفاء تو صرف اللہ ہی کے ہاتھ میں ہے اور وہ بڑا مہربان ہے";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(564, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 100);
            this.label4.TabIndex = 7;
            this.label4.Text = "For Online Check-up and advice\r\n\r\nHakeem Tariq Rizwan\r\nContact: 030xxxxxx44 (What" +
    "sApp)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Linen;
            this.button4.Location = new System.Drawing.Point(375, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 47);
            this.button4.TabIndex = 8;
            this.button4.Text = "Order Status";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Project1.Properties.Resources.bck2;
            this.ClientSize = new System.Drawing.Size(882, 558);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button4;
    }
}