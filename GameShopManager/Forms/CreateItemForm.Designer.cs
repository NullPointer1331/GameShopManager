namespace GameShopManager.Forms
{
    partial class CreateItemForm
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
            ItemPriceLabel = new Label();
            ItemNameLabel = new Label();
            FormTitle = new Label();
            CreateButton = new Button();
            ItemPriceInput = new TextBox();
            ItemNameInput = new TextBox();
            ItemDescriptionLabel = new Label();
            ItemDescriptionInput = new TextBox();
            SuspendLayout();
            // 
            // ItemPriceLabel
            // 
            ItemPriceLabel.AutoSize = true;
            ItemPriceLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ItemPriceLabel.Location = new Point(80, 117);
            ItemPriceLabel.Name = "ItemPriceLabel";
            ItemPriceLabel.Size = new Size(100, 25);
            ItemPriceLabel.TabIndex = 20;
            ItemPriceLabel.Text = "Item Price:";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ItemNameLabel.Location = new Point(72, 69);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(108, 25);
            ItemNameLabel.TabIndex = 19;
            ItemNameLabel.Text = "Item Name:";
            // 
            // FormTitle
            // 
            FormTitle.AutoSize = true;
            FormTitle.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            FormTitle.Location = new Point(186, 9);
            FormTitle.Name = "FormTitle";
            FormTitle.Size = new Size(229, 54);
            FormTitle.TabIndex = 18;
            FormTitle.Text = "Create Item";
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(252, 216);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(100, 41);
            CreateButton.TabIndex = 17;
            CreateButton.Text = "Create Item";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // ItemPriceInput
            // 
            ItemPriceInput.Location = new Point(186, 117);
            ItemPriceInput.Name = "ItemPriceInput";
            ItemPriceInput.Size = new Size(100, 23);
            ItemPriceInput.TabIndex = 16;
            // 
            // ItemNameInput
            // 
            ItemNameInput.Location = new Point(186, 69);
            ItemNameInput.Multiline = true;
            ItemNameInput.Name = "ItemNameInput";
            ItemNameInput.Size = new Size(100, 23);
            ItemNameInput.TabIndex = 15;
            // 
            // ItemDescriptionLabel
            // 
            ItemDescriptionLabel.AutoSize = true;
            ItemDescriptionLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ItemDescriptionLabel.Location = new Point(26, 165);
            ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            ItemDescriptionLabel.Size = new Size(154, 25);
            ItemDescriptionLabel.TabIndex = 22;
            ItemDescriptionLabel.Text = "Item Description:";
            // 
            // ItemDescriptionInput
            // 
            ItemDescriptionInput.Location = new Point(186, 165);
            ItemDescriptionInput.Name = "ItemDescriptionInput";
            ItemDescriptionInput.Size = new Size(229, 23);
            ItemDescriptionInput.TabIndex = 21;
            // 
            // CreateItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 315);
            Controls.Add(ItemDescriptionLabel);
            Controls.Add(ItemDescriptionInput);
            Controls.Add(ItemPriceLabel);
            Controls.Add(ItemNameLabel);
            Controls.Add(FormTitle);
            Controls.Add(CreateButton);
            Controls.Add(ItemPriceInput);
            Controls.Add(ItemNameInput);
            Name = "CreateItemForm";
            Text = "CreateItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ItemPriceLabel;
        private Label ItemNameLabel;
        private Label FormTitle;
        private Button CreateButton;
        private TextBox ItemPriceInput;
        private TextBox ItemNameInput;
        private Label ItemDescriptionLabel;
        private TextBox ItemDescriptionInput;
    }
}