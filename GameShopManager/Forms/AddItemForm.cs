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
    public partial class AddItemForm : Form
    {
        NavigationForm navigationForm;
        List<ItemObject> items = new List<ItemObject>();
        public AddItemForm()
        {
            InitializeComponent();
        }
        public AddItemForm(NavigationForm navigationForm)
        {
            this.navigationForm = navigationForm;
            InitializeComponent();
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
                else if (navigationForm.ActiveUser.Cash < items[itemsListBox.SelectedIndex].ItemPrice * q)
                {
                    errorMessages += $"You don't have enough cash to buy {q} of this item.\n";
                }
            }
            if (errorMessages != "")
            {
                MessageBox.Show(errorMessages);
                return false;
            }
            return true;
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                ItemObject selectedItem = items[itemsListBox.SelectedIndex];
                int quantity = int.Parse(quantityTextBox.Text);
                navigationForm.ActiveUser.BuyItem(selectedItem, quantity);
                cashLabel.Text = $"Cash: {navigationForm.ActiveUser.Cash}";
                MessageBox.Show("Item added to inventory.");
            }
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            List<ItemObject> list = ItemDB.GetAllItems();
            foreach (var item in list)
            {
                itemsListBox.Items.Add(item.ToString());
                items.Add(item);
            }
            cashLabel.Text = $"Cash: {navigationForm.ActiveUser.Cash}";
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex == -1)
            {
                AddItemBtn.Enabled = false;
            }
            else
            {
                AddItemBtn.Enabled = true;
            }
        }
    }
}
