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
    public partial class CreateItemForm : Form
    {
        NavigationForm navigationForm;
        public CreateItemForm()
        {
            InitializeComponent();
        }
        public CreateItemForm(NavigationForm navigationForm)
        {
            this.navigationForm = navigationForm;
            InitializeComponent();
        }
    }
}
