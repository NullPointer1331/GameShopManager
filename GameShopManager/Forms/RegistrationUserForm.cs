using Microsoft.IdentityModel.Tokens;
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
    public partial class RegistrationUserForm : Form
    {
        NavigationForm navigationForm;
        public RegistrationUserForm()
        {
            InitializeComponent();
        }
        public RegistrationUserForm(NavigationForm navigationForm)
        {
            this.navigationForm = navigationForm;
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                string userName = UsernameInput.Text.Trim();
                string password = PasswordInput.Text.Trim();
                UserObject user = new UserObject(userName, password);
                UserDB.AddUser(user);
                navigationForm.ActiveUser = user;
                MessageBox.Show($"Successfully created account and logged in as {user.UserName}");
                navigationForm.SetActiveButtons();
                Close();
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
            if (UserDB.GetUser(userName, password) != null)
            {
                errorText += "A user with that username and password already exists";
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoginUserForm loginUserForm = new LoginUserForm();
            loginUserForm.Show();
            this.Close();
        }
    }
}
