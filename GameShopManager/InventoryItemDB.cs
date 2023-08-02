using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopManager
{
    internal class InventoryItemDB
    {
        public static List<UserObject.InventoryItem> GetUserInventory(int userID)
        {
            using GameShopContext dbContext = new GameShopContext();
            List<UserObject.InventoryItem> inventory = dbContext.InventoryItems.Where(i => i.UserID == userID).ToList();
            return inventory;
        }

        public static UserObject.InventoryItem GetInventoryItem(int userID, int itemID)
        {
            using GameShopContext dbContext = new GameShopContext();
            UserObject.InventoryItem inventoryItem = dbContext.InventoryItems.Where(i => i.UserID == userID && i.ItemID == itemID).FirstOrDefault();
            return inventoryItem;
        }

        public static void AddInventory(List<UserObject.InventoryItem> inventory)
        {
            foreach (UserObject.InventoryItem item in inventory)
            {
                AddInventoryItem(item);
            }
        }

        public static void AddInventoryItem(UserObject.InventoryItem item)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.InventoryItems.Add(item);
            dbContext.SaveChanges();
        }

        public static void DeleteUserInventory(List<UserObject.InventoryItem> inventory)
        {
            foreach (UserObject.InventoryItem item in inventory)
            {
                DeleteInventoryItem(item);
            }
        }

        public static void DeleteInventoryItem(UserObject.InventoryItem item)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.InventoryItems.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
