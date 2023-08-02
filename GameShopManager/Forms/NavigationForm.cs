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
    public partial class NavigationForm : Form
    {
        public NavigationForm()
        {
            InitializeComponent();
        }

        private void InventoryDisplay_Click(object sender, EventArgs e)
        {
            InventoryUserForm form = new InventoryUserForm();
            form.Show();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            CreateItemForm form = new CreateItemForm();
            form.Show();
        }

        private void AddItemQuantity_Click(object sender, EventArgs e)
        {
            AddItemForm form = new AddItemForm();
            form.Show();
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItemForm form = new DeleteItemForm();
            form.Show();
        }

        private void LoginUser_Click(object sender, EventArgs e)
        {
            LoginUserForm form = new LoginUserForm();
            form.Show();
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            RegistrationUserForm form = new RegistrationUserForm();
            form.Show();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to do this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //delete active object
                throw new NotImplementedException();
            }
        }
    }
}
