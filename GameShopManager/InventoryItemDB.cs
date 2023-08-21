using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopManager
{
    /// <summary>
    /// Represents the database for all inventory items in the game.
    /// </summary>
    internal class InventoryItemDB
    {
        /// <summary>
        /// Retrieves all inventory items belonging to a specific user.
        /// </summary>
        /// <param name="userID">The ID of the user to retrieve inventory items for.</param>
        /// <returns>A list of InventoryItem objects representing the user's inventory.</returns>
        public static List<UserObject.InventoryItem> GetUserInventory(int userID)
        {
            using GameShopContext dbContext = new GameShopContext();
            List<UserObject.InventoryItem> inventory = dbContext.InventoryItems.Where(i => i.UserID == userID).ToList();
            foreach (UserObject.InventoryItem item in inventory)
            {
                item.LinkedObject = dbContext.Items.Where(i => i.ItemID == item.ItemID).FirstOrDefault();
            }
            return inventory;
        }

        /// <summary>
        /// Retrieves a specific inventory item from the database.
        /// </summary>
        /// <param name="userID">The ID of the user that the item belongs to.</param>
        /// <param name="itemID">The ID of the item to retrieve.</param>
        /// <returns>An InventoryItem object representing the requested inventory item, or null if not found.</returns>
        public static UserObject.InventoryItem GetInventoryItem(int userID, int itemID)
        {
            using GameShopContext dbContext = new GameShopContext();
            UserObject.InventoryItem inventoryItem = dbContext.InventoryItems.Where(i => i.UserID == userID && i.ItemID == itemID).FirstOrDefault();
            inventoryItem.LinkedObject = dbContext.Items.Where(i => i.ItemID == inventoryItem.ItemID).FirstOrDefault();
            return inventoryItem;
        }

        /// <summary>
        /// Adds a list of inventory items to the database.
        /// </summary>
        /// <param name="inventory">A list of InventoryItem objects to add to the database.</param>
        public static void AddInventory(List<UserObject.InventoryItem> inventory)
        {
            if (inventory != null)
            {
                foreach (UserObject.InventoryItem item in inventory)
                {
                    AddInventoryItem(item);
                }
            }
        }

        /// <summary>
        /// Adds a single inventory item to the database.
        /// </summary>
        /// <param name="item">The InventoryItem object to add to the database.</param>
        public static void AddInventoryItem(UserObject.InventoryItem item)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.InventoryItems.Add(item);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Deletes a list of inventory items from the database.
        /// </summary>
        /// <param name="inventory">A list of InventoryItem objects to delete from the database.</param>
        public static void DeleteInventoryItems(List<UserObject.InventoryItem> inventory)
        {
            if (inventory != null)
            {
                foreach (UserObject.InventoryItem item in inventory)
                {
                    DeleteInventoryItem(item);
                }
            }
        }

        /// <summary>
        /// Deletes all inventory items of a specific item from the database.
        /// </summary>
        /// <param name="itemID"></param>
        public static void DeleteAllOfItem(int itemID)
        {
            using GameShopContext dbContext = new GameShopContext();
            List<UserObject.InventoryItem> inventory = dbContext.InventoryItems.Where(i => i.ItemID == itemID).ToList();
            DeleteInventoryItems(inventory);
        }

        /// <summary>
        /// Deletes a single inventory item from the database.
        /// </summary>
        /// <param name="item">The InventoryItem object to delete from the database.</param>
        public static void DeleteInventoryItem(UserObject.InventoryItem item)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.InventoryItems.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
