namespace Multi_Tool
{
    partial class login_page
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(63, 122);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(245, 22);
            this.Username.TabIndex = 2;
            this.Username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(63, 195);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(245, 22);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.LawnGreen;
            this.login.Location = new System.Drawing.Point(136, 261);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(105, 33);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "New user? Create a new account.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Signup
            // 
            this.Signup.Location = new System.Drawing.Point(136, 346);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(105, 33);
            this.Signup.TabIndex = 7;
            this.Signup.Text = "Signup";
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "This Project is Created by: Muhammad Umar Siddiqui";
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "login_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi_Tool Project";
            this.Load += new System.EventHandler(this.login_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Label label5;
    }
}

