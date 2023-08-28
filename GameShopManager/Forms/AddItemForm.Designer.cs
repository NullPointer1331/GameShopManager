namespace GameShopManager.Forms
{
    partial class AddItemForm
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
            itemsListBox = new ListBox();
            itemLabel = new Label();
            quantityTextBox = new TextBox();
            quantityLabel = new Label();
            AddItemBtn = new Button();
            cashLabel = new Label();
            SuspendLayout();
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.HorizontalScrollbar = true;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(12, 67);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(364, 229);
            itemsListBox.TabIndex = 0;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new Point(12, 49);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(39, 15);
            itemLabel.TabIndex = 1;
            itemLabel.Text = "Items:";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(402, 85);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(100, 23);
            quantityTextBox.TabIndex = 2;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(402, 67);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(83, 15);
            quantityLabel.TabIndex = 3;
            quantityLabel.Text = "Item Quantity:";
            // 
            // AddItemBtn
            // 
            AddItemBtn.Location = new Point(402, 155);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(100, 39);
            AddItemBtn.TabIndex = 4;
            AddItemBtn.Text = "Add Item to Inventory";
            AddItemBtn.UseVisualStyleBackColor = true;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // cashLabel
            // 
            cashLabel.AutoSize = true;
            cashLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cashLabel.Location = new Point(217, 25);
            cashLabel.Name = "cashLabel";
            cashLabel.Size = new Size(62, 28);
            cashLabel.TabIndex = 5;
            cashLabel.Text = "Cash: ";
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 308);
            Controls.Add(cashLabel);
            Controls.Add(AddItemBtn);
            Controls.Add(quantityLabel);
            Controls.Add(quantityTextBox);
            Controls.Add(itemLabel);
            Controls.Add(itemsListBox);
            Name = "AddItemForm";
            Text = "Shop Form";
            Load += AddItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox itemsListBox;
        private Label itemLabel;
        private TextBox quantityTextBox;
        private Label quantityLabel;
        private Button AddItemBtn;
        private Label cashLabel;
    }
}