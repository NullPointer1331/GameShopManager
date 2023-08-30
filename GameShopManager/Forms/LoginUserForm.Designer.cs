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
            PasswordInput = new TextBox();
            LoginButton = new Button();
            RegisterAccount = new Button();
            GameTitle = new Label();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UsernameInput = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PasswordInput
            // 
            PasswordInput.BackColor = SystemColors.MenuBar;
            PasswordInput.Cursor = Cursors.IBeam;
            PasswordInput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordInput.Location = new Point(65, 155);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(252, 34);
            PasswordInput.TabIndex = 1;
            // 
            // LoginButton
            // 
            LoginButton.BackgroundImage = Properties.Resources.Gradient;
            LoginButton.FlatAppearance.BorderColor = Color.LightGreen;
            LoginButton.FlatAppearance.BorderSize = 2;
            LoginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(65, 210);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(117, 51);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterAccount
            // 
            RegisterAccount.BackgroundImage = Properties.Resources.Gradient;
            RegisterAccount.FlatAppearance.BorderColor = Color.PaleTurquoise;
            RegisterAccount.FlatAppearance.BorderSize = 3;
            RegisterAccount.FlatStyle = FlatStyle.Flat;
            RegisterAccount.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterAccount.Location = new Point(196, 210);
            RegisterAccount.Name = "RegisterAccount";
            RegisterAccount.Size = new Size(121, 51);
            RegisterAccount.TabIndex = 3;
            RegisterAccount.Text = "Register";
            RegisterAccount.UseVisualStyleBackColor = true;
            RegisterAccount.Click += RegisterAccount_Click;
            // 
            // GameTitle
            // 
            GameTitle.AutoSize = true;
            GameTitle.BackColor = Color.Transparent;
            GameTitle.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            GameTitle.Location = new Point(-3, 9);
            GameTitle.Name = "GameTitle";
            GameTitle.Size = new Size(396, 54);
            GameTitle.TabIndex = 4;
            GameTitle.Text = "Game Shop Manager";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(65, 66);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(97, 25);
            UsernameLabel.TabIndex = 5;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(65, 127);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(91, 25);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
            // 
            // UsernameInput
            // 
            UsernameInput.BackColor = SystemColors.MenuBar;
            UsernameInput.Cursor = Cursors.IBeam;
            UsernameInput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameInput.Location = new Point(65, 94);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(252, 34);
            UsernameInput.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.UserIcon;
            pictureBox1.Location = new Point(29, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.PasswordIcon;
            pictureBox2.Location = new Point(29, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // LoginUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BackgroundImage = Properties.Resources.backgroundTransparency;
            ClientSize = new Size(390, 297);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(UsernameInput);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(GameTitle);
            Controls.Add(RegisterAccount);
            Controls.Add(LoginButton);
            Controls.Add(PasswordInput);
            Name = "LoginUserForm";
            Text = "LoginUserForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox PasswordInput;
        private Button LoginButton;
        private Button RegisterAccount;
        private Label GameTitle;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox UsernameInput;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}