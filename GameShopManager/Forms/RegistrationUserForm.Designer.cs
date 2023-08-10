namespace GameShopManager.Forms
{
    partial class RegistrationUserForm
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
            PasswordError = new Label();
            UserError = new Label();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            GameTitle = new Label();
            RegisterButton = new Button();
            PasswordInput = new TextBox();
            UsernameInput = new TextBox();
            SuspendLayout();
            // 
            // PasswordError
            // 
            PasswordError.AutoSize = true;
            PasswordError.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordError.ForeColor = Color.Crimson;
            PasswordError.Location = new Point(314, 116);
            PasswordError.Name = "PasswordError";
            PasswordError.Size = new Size(0, 25);
            PasswordError.TabIndex = 16;
            // 
            // UserError
            // 
            UserError.AutoSize = true;
            UserError.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UserError.ForeColor = Color.Crimson;
            UserError.Location = new Point(314, 64);
            UserError.Name = "UserError";
            UserError.Size = new Size(0, 25);
            UserError.TabIndex = 15;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(65, 113);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(95, 25);
            PasswordLabel.TabIndex = 14;
            PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(65, 64);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(101, 25);
            UsernameLabel.TabIndex = 13;
            UsernameLabel.Text = "Username:";
            // 
            // GameTitle
            // 
            GameTitle.AutoSize = true;
            GameTitle.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            GameTitle.Location = new Point(171, 9);
            GameTitle.Name = "GameTitle";
            GameTitle.Size = new Size(99, 54);
            GameTitle.TabIndex = 12;
            GameTitle.Text = "Title";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(176, 163);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(91, 41);
            RegisterButton.TabIndex = 11;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(171, 118);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(100, 23);
            PasswordInput.TabIndex = 10;
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(171, 66);
            UsernameInput.Multiline = true;
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(100, 23);
            UsernameInput.TabIndex = 9;
            // 
            // RegistrationUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 251);
            Controls.Add(PasswordError);
            Controls.Add(UserError);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(GameTitle);
            Controls.Add(RegisterButton);
            Controls.Add(PasswordInput);
            Controls.Add(UsernameInput);
            Name = "RegistrationUserForm";
            Text = "RegistrationUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PasswordError;
        private Label UserError;
        private Label PasswordLabel;
        private Label UsernameLabel;
        private Label GameTitle;
        private Button RegisterButton;
        private TextBox PasswordInput;
        private TextBox UsernameInput;
    }
}