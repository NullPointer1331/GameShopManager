namespace GameShopManager.Forms
{
    partial class NavigationForm
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
            LoginUser = new Button();
            CreateItem = new Button();
            DeleteItem = new Button();
            InventoryDisplay = new Button();
            BuyItem = new Button();
            DeleteUser = new Button();
            LogOut = new Button();
            activeUserLabel = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginUser
            // 
            LoginUser.BackColor = Color.DarkGreen;
            LoginUser.FlatAppearance.BorderColor = Color.Green;
            LoginUser.FlatAppearance.BorderSize = 3;
            LoginUser.FlatStyle = FlatStyle.Flat;
            LoginUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LoginUser.Location = new Point(3, 5);
            LoginUser.Name = "LoginUser";
            LoginUser.Size = new Size(100, 38);
            LoginUser.TabIndex = 0;
            LoginUser.Text = "Login";
            LoginUser.UseVisualStyleBackColor = false;
            LoginUser.Click += LoginUser_Click;
            // 
            // CreateItem
            // 
            CreateItem.BackColor = Color.SeaShell;
            CreateItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CreateItem.Location = new Point(6, 22);
            CreateItem.Name = "CreateItem";
            CreateItem.Size = new Size(183, 50);
            CreateItem.TabIndex = 2;
            CreateItem.Text = "+Create Item";
            CreateItem.UseVisualStyleBackColor = false;
            CreateItem.Click += CreateItem_Click;
            // 
            // DeleteItem
            // 
            DeleteItem.BackColor = Color.SeaShell;
            DeleteItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteItem.Location = new Point(6, 99);
            DeleteItem.Name = "DeleteItem";
            DeleteItem.Size = new Size(183, 50);
            DeleteItem.TabIndex = 3;
            DeleteItem.Text = "-Delete Item";
            DeleteItem.UseVisualStyleBackColor = false;
            DeleteItem.Click += DeleteItem_Click;
            // 
            // InventoryDisplay
            // 
            InventoryDisplay.BackColor = Color.SeaShell;
            InventoryDisplay.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            InventoryDisplay.FlatAppearance.BorderSize = 3;
            InventoryDisplay.FlatStyle = FlatStyle.Flat;
            InventoryDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            InventoryDisplay.Location = new Point(20, 95);
            InventoryDisplay.Name = "InventoryDisplay";
            InventoryDisplay.Size = new Size(232, 50);
            InventoryDisplay.TabIndex = 4;
            InventoryDisplay.Text = "Inventory";
            InventoryDisplay.UseVisualStyleBackColor = false;
            InventoryDisplay.Click += InventoryDisplay_Click;
            // 
            // BuyItem
            // 
            BuyItem.BackColor = Color.SeaShell;
            BuyItem.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            BuyItem.FlatAppearance.BorderSize = 3;
            BuyItem.FlatStyle = FlatStyle.Flat;
            BuyItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BuyItem.Location = new Point(20, 22);
            BuyItem.Name = "BuyItem";
            BuyItem.Size = new Size(232, 50);
            BuyItem.TabIndex = 5;
            BuyItem.Text = "Buy Items";
            BuyItem.UseVisualStyleBackColor = false;
            BuyItem.Click += BuyItem_Click;
            // 
            // DeleteUser
            // 
            DeleteUser.BackColor = Color.SeaShell;
            DeleteUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteUser.Location = new Point(11, 406);
            DeleteUser.Name = "DeleteUser";
            DeleteUser.Size = new Size(156, 32);
            DeleteUser.TabIndex = 6;
            DeleteUser.Text = "Delete Active User";
            DeleteUser.UseVisualStyleBackColor = false;
            DeleteUser.Click += DeleteUser_Click;
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.Maroon;
            LogOut.FlatAppearance.BorderColor = Color.Red;
            LogOut.FlatAppearance.BorderSize = 3;
            LogOut.FlatStyle = FlatStyle.Flat;
            LogOut.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LogOut.ForeColor = Color.Black;
            LogOut.Location = new Point(109, 5);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(100, 38);
            LogOut.TabIndex = 10;
            LogOut.Text = "Log Out";
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += LogOut_Click;
            // 
            // activeUserLabel
            // 
            activeUserLabel.AutoSize = true;
            activeUserLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            activeUserLabel.Location = new Point(215, 8);
            activeUserLabel.Name = "activeUserLabel";
            activeUserLabel.Size = new Size(168, 32);
            activeUserLabel.TabIndex = 11;
            activeUserLabel.Text = "Not Logged In";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(LoginUser);
            panel1.Controls.Add(activeUserLabel);
            panel1.Controls.Add(LogOut);
            panel1.Location = new Point(11, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 53);
            panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CreateItem);
            groupBox1.Controls.Add(DeleteItem);
            groupBox1.Location = new Point(16, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(195, 318);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Actions";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(BuyItem);
            groupBox2.Controls.Add(InventoryDisplay);
            groupBox2.Location = new Point(276, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 314);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Actions";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.shoppinhCart;
            pictureBox2.Location = new Point(24, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.backpack;
            pictureBox1.Location = new Point(24, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(561, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(DeleteUser);
            Name = "NavigationForm";
            Text = "NavigationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button LoginUser;
        private Button CreateItem;
        private Button DeleteItem;
        private Button InventoryDisplay;
        private Button BuyItem;
        private Button DeleteUser;
        private Button LogOut;
        private Label activeUserLabel;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}