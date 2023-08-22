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
        }

        private bool ValidInput()
        {
            string errorMessages = "";
            if (inventoryListBox.SelectedIndex == -1)
            {
                errorMessages += "Please select an item to remove from your inventory.\n";
            }
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
            if(ValidInput())
            {
                UserObject.InventoryItem item = inventory[inventoryListBox.SelectedIndex];
                int quantity = int.Parse(quantityTextBox.Text);
                navigationForm.ActiveUser.RemoveItem(item, quantity);
                PopulateInventory();
            }
        }

        private void SetQuantity1Btn_Click(object sender, EventArgs e)
        {
            quantityTextBox.Text = "1";
        }

        private void SetQuantityMaxBtn_Click(object sender, EventArgs e)
        {
            if(inventoryListBox.SelectedIndex != -1)
            {
                quantityTextBox.Text = inventory[inventoryListBox.SelectedIndex].Quantity.ToString();
            }
        }
    }
}
