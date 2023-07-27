using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopManager
{
    internal class UserObject
    {
        /// <summary>
        /// Reference ID for database
        /// </summary>
        [Key]
        public int UserID { get; set; }

        /// <summary>
        /// Display name for the user account
        /// </summary>
        public required string UserName { get; set; }

        /// <summary>
        /// Password for the user account
        /// </summary>
        public required string Password { get; set; }

        /// <summary>
        /// Amount of cash the user has, can be used to purchase items
        /// </summary>
        public int Cash { get; set; }

        /// <summary>
        /// List of items the user owns
        /// Stores the ItemID as the key 
        /// and the quantity of that item as the value
        /// </summary>
        public Dictionary<int, int>? Inventory { get; set; }

        /// <summary>
        /// Creates a new user with a username and password, and sets cash to 0
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public UserObject(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Cash = 0;
        }

        /// <summary>
        /// Creates a new user with a username, password, and cash
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="cash"></param>
        public UserObject(string userName, string password, int cash)
        {
            UserName = userName;
            Password = password;
            Cash = cash;
        }
    }
}
