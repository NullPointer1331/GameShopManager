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
    public partial class DeleteItemForm : Form
    {
        NavigationForm navigationForm;
        //Optimize loading by only accessing db once
        List<ItemObject> items;
        public DeleteItemForm()
        {
            InitializeComponent();
        }
        public DeleteItemForm(NavigationForm navigationForm)
        {
            this.navigationForm = navigationForm;
            InitializeComponent();
        }

        /// <summary>
        /// Refreshes the list
        /// </summary>
        private void refreshList()
        {
            item_listbox.Items.Clear();
            foreach (ItemObject item in items)
            {
                item_listbox.Items.Add(item.ToString());
            }
        }

        /// <summary>
        /// Check if the listbox has a item selected and toggle the button accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (item_listbox.SelectedItem != null)
            {
                delete_button.Enabled = true;
            }
            else
            {
                delete_button.Enabled = false;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (item_listbox.SelectedItem != null)
            {
                //Confirmation
                DialogResult result = MessageBox.Show("Do you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ItemObject item = items[item_listbox.SelectedIndex];
                    ItemDB.DeleteItem(item);
                    items.Remove(item);
                    refreshList();
                }
            }
        }

        //Load all items and refresh list
        private void DeleteItemForm_Load(object sender, EventArgs e)
        {
            items = ItemDB.GetAllItems();
            refreshList();
        }
    }
}
