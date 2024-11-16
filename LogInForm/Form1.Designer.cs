namespace LogInForm
{
    partial class Form1
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
            btnLogin = new Button();
            user = new Label();
            pass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(214, 300);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(272, 55);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // user
            // 
            user.AutoSize = true;
            user.Location = new Point(88, 127);
            user.Name = "user";
            user.Size = new Size(95, 25);
            user.TabIndex = 1;
            user.Text = "Username:";
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(88, 218);
            pass.Name = "pass";
            pass.Size = new Size(91, 25);
            pass.TabIndex = 2;
            pass.Text = "Password:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(214, 127);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(272, 31);
            txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(214, 212);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(272, 31);
            txtPass.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(pass);
            Controls.Add(user);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "SimpleLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label user;
        private Label pass;
        private TextBox txtUser;
        private TextBox txtPass;
    }
}
