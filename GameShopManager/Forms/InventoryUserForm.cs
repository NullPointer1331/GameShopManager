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
            List<string> list = new List<string>();
            foreach (var itemObject in navigationForm.Inventory)
            {
                //Add each new item
                if (!listBox1.Items.Contains(itemObject))
                {
                    listBox1.Items.Add(itemObject.ItemName);
                }
                list.Add(itemObject.ItemName);
                
            }
            foreach (var itemName in list)
            {
                if (!list.Contains(itemName))
                {
                    listBox1.Items.Remove(itemName);
                }
            }
            //Remove refrences
            list = null;
            
        }
    }
}
