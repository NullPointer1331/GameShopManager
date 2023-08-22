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

        private void RemoveItemsBtn_Click(object sender, EventArgs e)
        {

        }

        private void SetQuantity1Btn_Click(object sender, EventArgs e)
        {

        }

        private void SetQuantityMaxBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
