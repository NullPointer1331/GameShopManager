﻿using Microsoft.EntityFrameworkCore;
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
        /// Creates a new user with a username and password, and sets cash to 1000
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public UserObject(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Cash = 1000;
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

        /// <summary>
        /// If the user has enough cash, it will buy an item and add it to the user's inventory
        /// </summary>
        /// <param name="item"></param>
        /// <param name="quantity"></param>
        public void BuyItem(ItemObject item, int quantity)
        {
            if (Cash >= item.ItemPrice * quantity)
            {
                Cash -= item.ItemPrice * quantity;
                UserDB.UpdateUser(this);
                AddItem(item, quantity);
            }
        }

        /// <summary>
        /// Removes items from the user's inventory, 
        /// and adds the appropriate amount of cash to the user's account
        /// </summary>
        /// <param name="item"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        public void SellItem(InventoryItem item, int quantity, int price)
        {
            if (item.Quantity >= quantity)
            {
                Cash += price * quantity;
                UserDB.UpdateUser(this);
                RemoveItem(item, quantity);
            }
        }

        /// <summary>
        /// Adds an item to the user's inventory, if the item already exists in the inventory, it will increase the quantity
        /// Updates the database appropriately.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="quantity"></param>
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

        /// <summary>
        /// Reduces the quantity of an item in the user's inventory, 
        /// if the quantity reaches 0, it will remove the item from the inventory.
        /// Updates the database appropriately.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="quantity"></param>
        public void RemoveItem(InventoryItem item, int quantity)
        {
            if (item.Quantity > quantity)
            {
                item.Quantity -= quantity;
                InventoryItemDB.UpdateInventoryItem(item);
            }
            else
            {
                Inventory.Remove(item);
                InventoryItemDB.DeleteInventoryItem(item);
            }
        }

        /// <summary>
        /// If an item exists in the user's inventory, it returns it
        /// otherwise it returns null
        /// </summary>
        /// <param name="itemID"></param>
        /// <returns>The inventory item with a corresponding itemID, or null if no such item exists</returns>
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
            [ForeignKey(nameof(UserObject))]
            public int UserID { get; set; }

            /// <summary>
            /// The Id of the item
            /// </summary>
            [ForeignKey(nameof(ItemObject))]
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
