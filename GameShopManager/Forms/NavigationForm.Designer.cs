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
            AddItem = new Button();
            DeleteItem = new Button();
            InventoryDisplay = new Button();
            AddItemQuantity = new Button();
            DeleteUser = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            CreateUser.Text = "Show Create Login Form";
            CreateUser.UseVisualStyleBackColor = true;
            CreateUser.Click += CreateUser_Click;
            // 
            // AddItem
            // 
            AddItem.Location = new Point(217, 61);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(100, 50);
            AddItem.TabIndex = 2;
            AddItem.Text = "Show Create Item Form";
            AddItem.UseVisualStyleBackColor = true;
            AddItem.Click += AddItem_Click;
            // 
            // DeleteItem
            // 
            DeleteItem.Location = new Point(217, 198);
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
            // AddItemQuantity
            // 
            AddItemQuantity.Location = new Point(217, 128);
            AddItemQuantity.Name = "AddItemQuantity";
            AddItemQuantity.Size = new Size(100, 50);
            AddItemQuantity.TabIndex = 5;
            AddItemQuantity.Text = "Show Add Quantity Form";
            AddItemQuantity.UseVisualStyleBackColor = true;
            AddItemQuantity.Click += AddItemQuantity_Click;
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
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DeleteUser);
            Controls.Add(AddItemQuantity);
            Controls.Add(InventoryDisplay);
            Controls.Add(DeleteItem);
            Controls.Add(AddItem);
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
        private Button AddItem;
        private Button DeleteItem;
        private Button InventoryDisplay;
        private Button AddItemQuantity;
        private Button DeleteUser;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}