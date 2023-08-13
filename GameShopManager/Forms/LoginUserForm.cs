using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShopManager.Forms
{
    public partial class LoginUserForm : Form
    {
        NavigationForm navigationForm;
        public LoginUserForm()
        {
            InitializeComponent();
        }
        public LoginUserForm(NavigationForm navigationForm)
        {
            this.navigationForm = navigationForm;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                string userName = UsernameInput.Text.Trim();
                string password = PasswordInput.Text.Trim();
                UserObject user = UserDB.GetUser(userName, password);
                if (user != null)
                {
                    navigationForm.ActiveUser = user;
                    //Getting all items early to reduce ping time
                    navigationForm.Inventory = InventoryItemDB.GetUserInventory(user.UserID);
                    MessageBox.Show($"Successfully logged in as {user.UserName}");
                    navigationForm.SetActiveButtons();
                    Close();
                }
                else
                {
                    MessageBox.Show("No user with that username and password exists");
                }
            }
        }

        /// <summary>
        /// Checks if the inputs are valid, shows a messagebox with errors if they aren't
        /// </summary>
        /// <returns>Returns true if inputs are valid, false otherwise</returns>
        private bool ValidInput()
        {
            string userName = UsernameInput.Text.Trim();
            string password = PasswordInput.Text.Trim();
            string errorText = "";
            if (string.IsNullOrEmpty(userName))
            {
                errorText += "Username is empty \n";
            }
            if (string.IsNullOrEmpty(password))
            {
                errorText += "Password is empty \n";
            }
            if (!string.IsNullOrEmpty(errorText))
            {
                MessageBox.Show(errorText);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void RegisterAccount_Click(object sender, EventArgs e)
        {
            RegistrationUserForm form = new RegistrationUserForm(navigationForm);
            form.Show();
            Close();
        }
    }
}
