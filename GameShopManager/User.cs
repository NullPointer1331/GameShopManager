using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopManager
{
    internal class User
    {
        public int UserId { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public int Cash { get; set; }
        public Item[] Inventory { get; set; }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Cash = 0;
        }
        public User(string userName, string password, int cash)
        {
            UserName = userName;
            Password = password;
            Cash = cash;
        }
    }
}
