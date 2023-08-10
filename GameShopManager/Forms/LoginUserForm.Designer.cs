namespace GameShopManager.Forms
{
    partial class LoginUserForm
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
            UsernameInput = new TextBox();
            PasswordInput = new TextBox();
            LoginButton = new Button();
            RegisterAccount = new Button();
            GameTitle = new Label();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            SuspendLayout();
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(182, 70);
            UsernameInput.Multiline = true;
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(100, 23);
            UsernameInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(182, 122);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(100, 23);
            PasswordInput.TabIndex = 1;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(187, 165);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(91, 41);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterAccount
            // 
            RegisterAccount.Location = new Point(195, 226);
            RegisterAccount.Name = "RegisterAccount";
            RegisterAccount.Size = new Size(75, 23);
            RegisterAccount.TabIndex = 3;
            RegisterAccount.Text = "Register";
            RegisterAccount.UseVisualStyleBackColor = true;
            RegisterAccount.Click += RegisterAccount_Click;
            // 
            // GameTitle
            // 
            GameTitle.AutoSize = true;
            GameTitle.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            GameTitle.Location = new Point(183, 9);
            GameTitle.Name = "GameTitle";
            GameTitle.Size = new Size(99, 54);
            GameTitle.TabIndex = 4;
            GameTitle.Text = "Title";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(75, 68);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(101, 25);
            UsernameLabel.TabIndex = 5;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(75, 117);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(95, 25);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password:";
            // 
            // LoginUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 277);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(GameTitle);
            Controls.Add(RegisterAccount);
            Controls.Add(LoginButton);
            Controls.Add(PasswordInput);
            Controls.Add(UsernameInput);
            Name = "LoginUserForm";
            Text = "LoginUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameInput;
        private TextBox PasswordInput;
        private Button LoginButton;
        private Button RegisterAccount;
        private Label GameTitle;
        private Label UsernameLabel;
        private Label PasswordLabel;
    }
}