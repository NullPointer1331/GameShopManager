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
    public partial class InventoryUserForm : Form
    {
        NavigationForm navigationForm;
        List<UserObject.InventoryItem> inventory;
        public InventoryUserForm()
        {
            InitializeComponent();
        }
        public InventoryUserForm(NavigationForm navigationForm)
        {
            this.navigationForm = navigationForm;
            InitializeComponent();
        }
        private void InventoryUserForm_Load(object sender, EventArgs e)
        {
            PopulateInventory();
        }

        /// <summary>
        /// Populates the inventory listbox with the items in the user's inventory
        /// </summary>
        private void PopulateInventory()
        {
            inventory = navigationForm.ActiveUser.Inventory;
            inventoryListBox.Items.Clear();
            foreach (var ItemObject in navigationForm.ActiveUser.Inventory)
            {
                //Check since linkedobject could not be loaded yet
                if (ItemObject.LinkedObject != null)
                {
                    inventoryListBox.Items.Add(ItemObject.LinkedObject.ItemName + " Quantity: " + ItemObject.Quantity);
                }
            }
            removeItemsBtn.Enabled = false;
            cashLabel.Text = $"Cash: {navigationForm.ActiveUser.Cash}";
        }

        /// <summary>
        /// Checks if the inputs are valid, shows a messagebox with errors if they aren't
        /// </summary>
        /// <returns>Returns true if inputs are valid, false otherwise</returns>
        private bool ValidInput()
        {
            string errorMessages = "";
            if (quantityTextBox.Text == "")
            {
                errorMessages += "Please enter a quantity.\n";
            }
            else
            {
                if (!int.TryParse(quantityTextBox.Text, out int q) || q < 1)
                {
                    errorMessages += "Please enter a positive number.\n";
                }
                else if (inventory[inventoryListBox.SelectedIndex].Quantity < q)
                {
                    errorMessages += $"You don't have {q} of this item.\n";
                }
            }
            if (priceTextBox.Text == "")
            {
                errorMessages += "Please enter a price.\n";
            }
            else
            {
                if (!int.TryParse(priceTextBox.Text, out int p) || p < 1)
                {
                    errorMessages += "Please enter a positive number.\n";
                }
            }
            if (errorMessages != "")
            {
                MessageBox.Show(errorMessages);
                return false;
            }
            return true;
        }

        private void RemoveItemsBtn_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                UserObject.InventoryItem item = inventory[inventoryListBox.SelectedIndex];
                int quantity = int.Parse(quantityTextBox.Text);
                int price = int.Parse(priceTextBox.Text);
                navigationForm.ActiveUser.SellItem(item, quantity, price);
                priceTextBox.Text = inventory[inventoryListBox.SelectedIndex].LinkedObject.ItemPrice.ToString();
                PopulateInventory();
            }
        }

        private void SetQuantity1Btn_Click(object sender, EventArgs e)
        {
            quantityTextBox.Text = "1";
        }

        private void SetQuantityMaxBtn_Click(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedIndex != -1)
            {
                quantityTextBox.Text = inventory[inventoryListBox.SelectedIndex].Quantity.ToString();
            }
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedIndex == -1)
            {
                removeItemsBtn.Enabled = false;
            }
            else
            {
                removeItemsBtn.Enabled = true;
                priceTextBox.Text = inventory[inventoryListBox.SelectedIndex].LinkedObject.ItemPrice.ToString();
            }
        }
    }
}
