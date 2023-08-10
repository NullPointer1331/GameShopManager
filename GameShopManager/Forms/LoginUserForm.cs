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

        List<UserObject>? users;

        private void LoginUserForm_Load(object sender, EventArgs e)
        {
            users = UserDB.GetAllUsers();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = UsernameInput.Text.Trim();
            string password = PasswordInput.Text.Trim();
            if (!string.IsNullOrEmpty(user))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    if (users == null)
                    {
                        //Edge case if db is empty
                        return;
                    }
                    foreach (UserObject item in users)
                    {
                        if (item.UserName == user && item.Password == password)
                        {
                            navigationForm.ActiveUser = item;
                            MessageBox.Show($"Successfully Logged in as {item.UserName}");
                            navigationForm.SetActiveButtons();
                            Close();
                        }
                    }
                }
                else
                {
                    PasswordError.Text = "Password is empty";
                }
            }
            else
            {
                UserError.Text = "Username is empty";
            }
        }


        private void RegisterAccount_Click(object sender, EventArgs e)
        {
            RegistrationUserForm form = new RegistrationUserForm();
            form.ShowDialog();
        }
    }
}
