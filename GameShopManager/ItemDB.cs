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
    }
}
