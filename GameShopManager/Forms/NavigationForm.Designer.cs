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
            CreateUser = new Button();
            CreateItem = new Button();
            DeleteItem = new Button();
            InventoryDisplay = new Button();
            BuyItem = new Button();
            DeleteUser = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LogOut = new Button();
            SuspendLayout();
            // 
            // LoginUser
            // 
            LoginUser.Location = new Point(12, 61);
            LoginUser.Name = "LoginUser";
            LoginUser.Size = new Size(100, 50);
            LoginUser.TabIndex = 0;
            LoginUser.Text = "Show Login Form";
            LoginUser.UseVisualStyleBackColor = true;
            LoginUser.Click += LoginUser_Click;
            // 
            // CreateUser
            // 
            CreateUser.Location = new Point(12, 128);
            CreateUser.Name = "CreateUser";
            CreateUser.Size = new Size(100, 50);
            CreateUser.TabIndex = 1;
            CreateUser.Text = "Show Register User Form";
            CreateUser.UseVisualStyleBackColor = true;
            CreateUser.Click += CreateUser_Click;
            // 
            // CreateItem
            // 
            CreateItem.Location = new Point(217, 61);
            CreateItem.Name = "CreateItem";
            CreateItem.Size = new Size(100, 50);
            CreateItem.TabIndex = 2;
            CreateItem.Text = "Show Create Item Form";
            CreateItem.UseVisualStyleBackColor = true;
            CreateItem.Click += CreateItem_Click;
            // 
            // DeleteItem
            // 
            DeleteItem.Location = new Point(217, 128);
            DeleteItem.Name = "DeleteItem";
            DeleteItem.Size = new Size(100, 50);
            DeleteItem.TabIndex = 3;
            DeleteItem.Text = "Show Delete Item Form";
            DeleteItem.UseVisualStyleBackColor = true;
            DeleteItem.Click += DeleteItem_Click;
            // 
            // InventoryDisplay
            // 
            InventoryDisplay.Location = new Point(432, 61);
            InventoryDisplay.Name = "InventoryDisplay";
            InventoryDisplay.Size = new Size(100, 50);
            InventoryDisplay.TabIndex = 4;
            InventoryDisplay.Text = "Show Inventory Form";
            InventoryDisplay.UseVisualStyleBackColor = true;
            InventoryDisplay.Click += InventoryDisplay_Click;
            // 
            // BuyItem
            // 
            BuyItem.Location = new Point(217, 198);
            BuyItem.Name = "BuyItem";
            BuyItem.Size = new Size(100, 50);
            BuyItem.TabIndex = 5;
            BuyItem.Text = "Show Buy Item Form";
            BuyItem.UseVisualStyleBackColor = true;
            BuyItem.Click += BuyItem_Click;
            // 
            // DeleteUser
            // 
            DeleteUser.Location = new Point(12, 198);
            DeleteUser.Name = "DeleteUser";
            DeleteUser.Size = new Size(100, 50);
            DeleteUser.TabIndex = 6;
            DeleteUser.Text = "Delete Active User";
            DeleteUser.UseVisualStyleBackColor = true;
            DeleteUser.Click += DeleteUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 7;
            label1.Text = "Login Forms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 26);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 8;
            label2.Text = "Item Actions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 26);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 9;
            label3.Text = "User Actions";
            // 
            // LogOut
            // 
            LogOut.Location = new Point(12, 269);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(100, 50);
            LogOut.TabIndex = 10;
            LogOut.Text = "Log Out";
            LogOut.UseVisualStyleBackColor = true;
            LogOut.Click += LogOut_Click;
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 450);
            Controls.Add(LogOut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DeleteUser);
            Controls.Add(BuyItem);
            Controls.Add(InventoryDisplay);
            Controls.Add(DeleteItem);
            Controls.Add(CreateItem);
            Controls.Add(CreateUser);
            Controls.Add(LoginUser);
            Name = "NavigationForm";
            Text = "NavigationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginUser;
        private Button CreateUser;
        private Button CreateItem;
        private Button DeleteItem;
        private Button InventoryDisplay;
        private Button BuyItem;
        private Button DeleteUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button LogOut;
    }
}