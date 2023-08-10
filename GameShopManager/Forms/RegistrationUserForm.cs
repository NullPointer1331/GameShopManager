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
            
        }

        private bool ValidInput()
        {
            string user = UsernameInput.Text.Trim();
            string password = PasswordInput.Text.Trim();
            bool valid = true;
            if (!string.IsNullOrEmpty(user))
            {
                UserError.Text = "Username is empty";
                valid = false;
            }
            else
            {
                UserError.Text = "";
            }
            if (!string.IsNullOrEmpty(password))
            {
                PasswordError.Text = "Password is empty";
                valid = false;
            }
            else
            {
                PasswordError.Text = "";
            }
            return valid;
        }
    }
}
