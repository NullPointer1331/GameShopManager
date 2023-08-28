namespace GameShopManager.Forms
{
    partial class InventoryUserForm
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
            inventoryListBox = new ListBox();
            quantityLabel = new Label();
            groupBox1 = new GroupBox();
            cashLabel = new Label();
            priceTextBox = new TextBox();
            priceLabel = new Label();
            removeItemsBtn = new Button();
            setQuantityMaxBtn = new Button();
            setQuantity1Btn = new Button();
            quantityTextBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 15;
            inventoryListBox.Items.AddRange(new object[] { "Not", "Loaded", "Yet" });
            inventoryListBox.Location = new Point(6, 22);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(610, 394);
            inventoryListBox.TabIndex = 0;
            inventoryListBox.SelectedIndexChanged += inventoryListBox_SelectedIndexChanged;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(666, 50);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(53, 15);
            quantityLabel.TabIndex = 1;
            quantityLabel.Text = "Quantity";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cashLabel);
            groupBox1.Controls.Add(priceTextBox);
            groupBox1.Controls.Add(priceLabel);
            groupBox1.Controls.Add(removeItemsBtn);
            groupBox1.Controls.Add(setQuantityMaxBtn);
            groupBox1.Controls.Add(setQuantity1Btn);
            groupBox1.Controls.Add(quantityTextBox);
            groupBox1.Controls.Add(quantityLabel);
            groupBox1.Controls.Add(inventoryListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventory";
            // 
            // cashLabel
            // 
            cashLabel.AutoSize = true;
            cashLabel.Location = new Point(666, 22);
            cashLabel.Name = "cashLabel";
            cashLabel.Size = new Size(39, 15);
            cashLabel.TabIndex = 8;
            cashLabel.Text = "Cash: ";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(622, 141);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(140, 23);
            priceTextBox.TabIndex = 7;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(676, 123);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(33, 15);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Price";
            // 
            // removeItemsBtn
            // 
            removeItemsBtn.Location = new Point(622, 170);
            removeItemsBtn.Name = "removeItemsBtn";
            removeItemsBtn.Size = new Size(140, 57);
            removeItemsBtn.TabIndex = 5;
            removeItemsBtn.Text = "Sell Items";
            removeItemsBtn.UseVisualStyleBackColor = true;
            removeItemsBtn.Click += RemoveItemsBtn_Click;
            // 
            // setQuantityMaxBtn
            // 
            setQuantityMaxBtn.Location = new Point(695, 97);
            setQuantityMaxBtn.Name = "setQuantityMaxBtn";
            setQuantityMaxBtn.Size = new Size(67, 23);
            setQuantityMaxBtn.TabIndex = 4;
            setQuantityMaxBtn.Text = "All";
            setQuantityMaxBtn.UseVisualStyleBackColor = true;
            setQuantityMaxBtn.Click += SetQuantityMaxBtn_Click;
            // 
            // setQuantity1Btn
            // 
            setQuantity1Btn.Location = new Point(622, 97);
            setQuantity1Btn.Name = "setQuantity1Btn";
            setQuantity1Btn.Size = new Size(67, 23);
            setQuantity1Btn.TabIndex = 3;
            setQuantity1Btn.Text = "One";
            setQuantity1Btn.UseVisualStyleBackColor = true;
            setQuantity1Btn.Click += SetQuantity1Btn_Click;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(622, 68);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(140, 23);
            quantityTextBox.TabIndex = 2;
            // 
            // InventoryUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 450);
            Controls.Add(groupBox1);
            Name = "InventoryUserForm";
            Text = "InventoryUserForm";
            Load += InventoryUserForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox inventoryListBox;
        private Label quantityLabel;
        private GroupBox groupBox1;
        private Button removeItemsBtn;
        private Button setQuantityMaxBtn;
        private Button setQuantity1Btn;
        private TextBox quantityTextBox;
        private TextBox priceTextBox;
        private Label priceLabel;
        private Label cashLabel;
    }
}