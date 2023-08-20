using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShopManager.Forms
{
    public partial class CreateItemForm : Form
    {
        NavigationForm navigationForm;
        public CreateItemForm()
        {
            InitializeComponent();
        }
        public CreateItemForm(NavigationForm navigationForm)
        {
            this.navigationForm = navigationForm;
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                string itemName = ItemNameInput.Text.Trim();
                string itemDescription = ItemDescriptionInput.Text.Trim();
                int itemPrice = int.Parse(ItemPriceInput.Text.Trim());
                ItemObject item = new ItemObject(itemName, itemDescription, itemPrice);
                ItemDB.AddItem(item);
                MessageBox.Show($"Successfully created item {item.ItemName}");
                ClearInputs();
            }
        }

        /// <summary>
        /// Sets all inputs to a blank string
        /// </summary>
        private void ClearInputs()
        {
            ItemNameInput.Text = "";
            ItemDescriptionInput.Text = "";
            ItemPriceInput.Text = "";
        }

        /// <summary>
        /// Checks if the inputs are valid, shows a messagebox with errors if they aren't
        /// </summary>
        /// <returns>Returns true if inputs are valid, false otherwise</returns>
        private bool ValidInput()
        {
            string itemName = ItemNameInput.Text.Trim();
            string itemPrice = ItemPriceInput.Text.Trim();
            string itemDescription = ItemDescriptionInput.Text.Trim();
            string errorText = "";
            if (string.IsNullOrEmpty(itemName))
            {
                errorText += "Item name is empty \n";
            }
            if (string.IsNullOrEmpty(itemDescription))
            {
                errorText += "Item quantity is empty \n";
            }
            if (string.IsNullOrEmpty(itemPrice))
            {
                errorText += "Item price is empty \n";
            }
            else if (!int.TryParse(itemPrice, out _))
            {
                errorText += "Item price must be a number \n";
            }
            if (errorText != "")
            {
                MessageBox.Show(errorText);
                return false;
            }
            return true;
        }
    }
}
