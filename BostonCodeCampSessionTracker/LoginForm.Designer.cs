namespace BostonCodeCampSessionTracker
{
    partial class LoginForm
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
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExitApp = new Button();
            btnLoginPrompt = new Label();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(45, 56);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(130, 53);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(255, 29);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(263, 88);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 31);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExitApp
            // 
            btnExitApp.AutoSize = true;
            btnExitApp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExitApp.Location = new Point(12, 115);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(126, 31);
            btnExitApp.TabIndex = 3;
            btnExitApp.Text = "Exit Application";
            btnExitApp.UseVisualStyleBackColor = true;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // btnLoginPrompt
            // 
            btnLoginPrompt.AutoSize = true;
            btnLoginPrompt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoginPrompt.Location = new Point(3, 9);
            btnLoginPrompt.Name = "btnLoginPrompt";
            btnLoginPrompt.Size = new Size(373, 21);
            btnLoginPrompt.TabIndex = 4;
            btnLoginPrompt.Text = "Please, enter the password that was provided to you.";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 155);
            Controls.Add(btnLoginPrompt);
            Controls.Add(btnExitApp);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExitApp;
        private Label btnLoginPrompt;
    }
}