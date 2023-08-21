using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopManager
{
    [DebuggerDisplay("Name: {UserName} Password: {Password} Cash: {Cash}")]
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
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// Password for the user account
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Amount of cash the user has, can be used to purchase items
        /// </summary>
        public int Cash { get; set; }

        /// <summary>
        /// List of items the user owns
        /// </summary>
        public List<InventoryItem>? Inventory { get; set; }

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
            Inventory = new List<InventoryItem>();
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
            Inventory = new List<InventoryItem>();
        }

        public void AddItem(ItemObject item, int quantity)
        {
            InventoryItem? existingItem = GetItem(item.ItemID);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                InventoryItemDB.UpdateInventoryItem(existingItem);
            }
            else
            {
                InventoryItem newItem = new InventoryItem()
                {
                    ItemID = item.ItemID,
                    UserID = UserID,
                    Quantity = quantity,
                    LinkedObject = item
                };
                Inventory.Add(newItem);
                InventoryItemDB.AddInventoryItem(newItem);
            }
        }

        public InventoryItem GetItem(int itemID)
        {
            foreach (InventoryItem item in Inventory)
            {
                if (item.ItemID == itemID)
                {
                    return item;
                }
            }
            return null;
        }

        [PrimaryKey(nameof(UserID), nameof(ItemID))]
        internal class InventoryItem
        {
            /// <summary>
            /// The Id of the user who owns the item
            /// </summary>
            [ForeignKey(nameof(UserID))]
            public int UserID { get; set; }

            /// <summary>
            /// The Id of the item
            /// </summary>
            [ForeignKey(nameof(ItemID))] //This still doesn't generate a foreign key for some reason
            public int ItemID { get; set; }

            /// <summary>
            /// The quantity of the item
            /// </summary>
            public int Quantity { get; set; }


            /// <summary>
            /// The ItemObject that correpsonds with the id
            /// </summary>
            [NotMapped]
            public ItemObject? LinkedObject { get; set; }
        }
    }
}
