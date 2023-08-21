﻿using System;
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

        private bool ValidInput()
        {
            string errorMessages = "";
            if (itemsListBox.SelectedIndex == -1)
            {
                errorMessages += "Please select an item to add to your inventory.\n";
            }
            if (quantityTextBox.Text == "")
            {
                errorMessages += "Please enter a quantity.\n";
            }
            else
            {
                if (!int.TryParse(quantityTextBox.Text, out _))
                {
                    errorMessages += "Please enter a valid quantity.\n";
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
            if(ValidInput())
            {
                ItemObject selectedItem = items[itemsListBox.SelectedIndex];
                int quantity = int.Parse(quantityTextBox.Text);
                navigationForm.ActiveUser.AddItem(selectedItem, quantity);
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
        }
    }
}
