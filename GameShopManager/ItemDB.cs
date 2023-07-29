using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopManager
{
    internal static class ItemDB
    {
        public static List<ItemObject> GetAllItems()
        {
            using GameShopContext dbContext = new GameShopContext();
            List<ItemObject> items = dbContext.Items.ToList();
            return items;
        }
        public static ItemObject GetItem(int id)
        {
            using GameShopContext dbContext = new GameShopContext();
            ItemObject item = dbContext.Items.Where(i => i.ItemID == id).FirstOrDefault();
            return item;
        }
        public static void AddItem(ItemObject item)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.Items.Add(item);
            dbContext.SaveChanges();
        }
        public static void UpdateItem(ItemObject item)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.Items.Update(item);
            dbContext.SaveChanges();
        }
        public static void DeleteItem(ItemObject item)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.Items.Remove(item);
            dbContext.SaveChanges();
        }
        public static void DeleteItem(int id)
        {
            using GameShopContext dbContext = new GameShopContext();
            ItemObject item = dbContext.Items.Where(i => i.ItemID == id).FirstOrDefault();
            dbContext.Items.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
