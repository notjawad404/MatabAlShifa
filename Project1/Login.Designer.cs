namespace Project1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lUname1 = new System.Windows.Forms.TextBox();
            this.lPass1 = new System.Windows.Forms.TextBox();
            this.btnLogin1 = new System.Windows.Forms.Button();
            this.lSignup1 = new System.Windows.Forms.Button();
            this.lAdmin1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(118, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(269, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lUname1
            // 
            this.lUname1.Location = new System.Drawing.Point(232, 141);
            this.lUname1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lUname1.Name = "lUname1";
            this.lUname1.Size = new System.Drawing.Size(154, 23);
            this.lUname1.TabIndex = 3;
            // 
            // lPass1
            // 
            this.lPass1.Location = new System.Drawing.Point(232, 186);
            this.lPass1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lPass1.Name = "lPass1";
            this.lPass1.Size = new System.Drawing.Size(154, 23);
            this.lPass1.TabIndex = 4;
            // 
            // btnLogin1
            // 
            this.btnLogin1.BackColor = System.Drawing.Color.Linen;
            this.btnLogin1.Location = new System.Drawing.Point(267, 259);
            this.btnLogin1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(78, 32);
            this.btnLogin1.TabIndex = 5;
            this.btnLogin1.Text = "Login";
            this.btnLogin1.UseVisualStyleBackColor = false;
            this.btnLogin1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lSignup1
            // 
            this.lSignup1.BackColor = System.Drawing.Color.Linen;
            this.lSignup1.Location = new System.Drawing.Point(122, 305);
            this.lSignup1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lSignup1.Name = "lSignup1";
            this.lSignup1.Size = new System.Drawing.Size(152, 32);
            this.lSignup1.TabIndex = 6;
            this.lSignup1.Text = "Create a new Account";
            this.lSignup1.UseVisualStyleBackColor = false;
            this.lSignup1.Click += new System.EventHandler(this.button2_Click);
            // 
            // lAdmin1
            // 
            this.lAdmin1.BackColor = System.Drawing.Color.Linen;
            this.lAdmin1.Location = new System.Drawing.Point(332, 305);
            this.lAdmin1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lAdmin1.Name = "lAdmin1";
            this.lAdmin1.Size = new System.Drawing.Size(153, 32);
            this.lAdmin1.TabIndex = 7;
            this.lAdmin1.Text = "Login as Admin";
            this.lAdmin1.UseVisualStyleBackColor = false;
            this.lAdmin1.Click += new System.EventHandler(this.lAdmin1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Project1.Properties.Resources.bck2;
            this.ClientSize = new System.Drawing.Size(599, 410);
            this.Controls.Add(this.lAdmin1);
            this.Controls.Add(this.lSignup1);
            this.Controls.Add(this.btnLogin1);
            this.Controls.Add(this.lPass1);
            this.Controls.Add(this.lUname1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox lUname1;
        private TextBox lPass1;
        private Button btnLogin1;
        private Button lSignup1;
        private Button lAdmin1;
    }
}