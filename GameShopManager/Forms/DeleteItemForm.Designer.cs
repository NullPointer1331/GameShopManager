namespace GameShopManager.Forms
{
    partial class DeleteItemForm
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
            list_holder = new GroupBox();
            item_listbox = new ListBox();
            delete_button = new Button();
            list_holder.SuspendLayout();
            SuspendLayout();
            // 
            // list_holder
            // 
            list_holder.Controls.Add(item_listbox);
            list_holder.Location = new Point(12, 12);
            list_holder.Name = "list_holder";
            list_holder.Size = new Size(613, 414);
            list_holder.TabIndex = 0;
            list_holder.TabStop = false;
            list_holder.Text = "Items";
            // 
            // item_listbox
            // 
            item_listbox.FormattingEnabled = true;
            item_listbox.ItemHeight = 15;
            item_listbox.Items.AddRange(new object[] { "not", "loaded", "yet" });
            item_listbox.Location = new Point(12, 24);
            item_listbox.Name = "item_listbox";
            item_listbox.Size = new Size(583, 379);
            item_listbox.TabIndex = 0;
            item_listbox.SelectedIndexChanged += item_listbox_SelectedIndexChanged;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(653, 38);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(135, 48);
            delete_button.TabIndex = 1;
            delete_button.Text = "Delete Item";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // DeleteItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete_button);
            Controls.Add(list_holder);
            Name = "DeleteItemForm";
            Text = "DeleteItemForm";
            Load += DeleteItemForm_Load;
            list_holder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox list_holder;
        private ListBox item_listbox;
        private Button delete_button;
    }
}