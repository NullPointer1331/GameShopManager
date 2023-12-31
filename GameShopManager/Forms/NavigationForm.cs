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
    public partial class NavigationForm : Form
    {
        internal UserObject ActiveUser { get; set; }
        internal List<UserObject.InventoryItem> InventoryItems { get; set; }
        public NavigationForm()
        {
            InitializeComponent();
            SetActiveButtons();
        }

        /// <summary>
        /// Checks if a user is logged in and sets the buttons accordingly
        /// </summary>
        public void SetActiveButtons()
        {
            if (ActiveUser != null)
            {
                DeleteUser.Enabled = true;
                BuyItem.Enabled = true;
                InventoryDisplay.Enabled = true;
                LogOut.Enabled = true;
                activeUserLabel.Text = "Logged in as " + ActiveUser.UserName;
            }
            else
            {
                DeleteUser.Enabled = false;
                BuyItem.Enabled = false;
                InventoryDisplay.Enabled = false;
                LogOut.Enabled = false;
                activeUserLabel.Text = "Not logged in";
            }
        }

        private void InventoryDisplay_Click(object sender, EventArgs e)
        {
            InventoryUserForm form = new InventoryUserForm(this);
            form.Show();
        }

        private void CreateItem_Click(object sender, EventArgs e)
        {
            CreateItemForm form = new CreateItemForm(this);
            form.Show();
        }

        private void BuyItem_Click(object sender, EventArgs e)
        {
            AddItemForm form = new AddItemForm(this);
            form.Show();
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItemForm form = new DeleteItemForm(this);
            form.Show();
        }

        private void LoginUser_Click(object sender, EventArgs e)
        {
            LoginUserForm form = new LoginUserForm(this);
            form.Show();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to do this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //delete active object
                UserDB.DeleteUser(ActiveUser);
                ActiveUser = null;
                SetActiveButtons();
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            ActiveUser = null;
            SetActiveButtons();
        }
    }
}
