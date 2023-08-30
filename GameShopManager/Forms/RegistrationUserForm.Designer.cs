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
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            GameTitle = new Label();
            RegisterButton = new Button();
            PasswordInput = new TextBox();
            UsernameInput = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(58, 155);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(202, 30);
            PasswordLabel.TabIndex = 14;
            PasswordLabel.Text = "Create an Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(58, 75);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(210, 30);
            UsernameLabel.TabIndex = 13;
            UsernameLabel.Text = "Create an Username";
            // 
            // GameTitle
            // 
            GameTitle.AutoSize = true;
            GameTitle.BackColor = Color.Transparent;
            GameTitle.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            GameTitle.Location = new Point(8, 9);
            GameTitle.Name = "GameTitle";
            GameTitle.Size = new Size(323, 54);
            GameTitle.TabIndex = 12;
            GameTitle.Text = "Register Account";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Transparent;
            RegisterButton.BackgroundImage = Properties.Resources.Gradient;
            RegisterButton.FlatAppearance.BorderColor = Color.LightGreen;
            RegisterButton.FlatAppearance.BorderSize = 2;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterButton.Location = new Point(102, 237);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(114, 51);
            RegisterButton.TabIndex = 11;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // PasswordInput
            // 
            PasswordInput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordInput.Location = new Point(58, 188);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(210, 34);
            PasswordInput.TabIndex = 10;
            // 
            // UsernameInput
            // 
            UsernameInput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameInput.Location = new Point(58, 108);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(210, 34);
            UsernameInput.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(80, 294);
            button1.Name = "button1";
            button1.Size = new Size(158, 40);
            button1.TabIndex = 15;
            button1.Text = "Return to Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegistrationUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(338, 346);
            Controls.Add(button1);
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
        private Label PasswordLabel;
        private Label UsernameLabel;
        private Label GameTitle;
        private Button RegisterButton;
        private TextBox PasswordInput;
        private TextBox UsernameInput;
        private Button button1;
    }
}