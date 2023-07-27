using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        /// </summary>
        public InventoryItem[]? Inventory { get; set; }

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

        [PrimaryKey(nameof(UserID), nameof(ItemID))]
        internal class InventoryItem
        {
            /// <summary>
            /// The Id of the user who owns the item
            /// </summary>
            [ForeignKey("UserID")]
            public int UserID { get; set; }
            /// <summary>
            /// The Id of the item
            /// </summary>
            [ForeignKey("ItemID")]
            public int ItemID { get; set; }
            /// <summary>
            /// The quantity of the item
            /// </summary>
            public int Quantity { get; set; }
        }
    }
}
