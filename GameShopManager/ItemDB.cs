using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopManager
{
    /// <summary>
    /// Provides CRUD operations for ItemObjects in the database.
    /// </summary>
    internal static class ItemDB
    {
        /// <summary>
        /// Gets all the ItemObjects from the database.
        /// </summary>
        /// <returns>A list of all the ItemObjects in the database.</returns>
        public static List<ItemObject> GetAllItems()
        {
            using GameShopContext dbContext = new GameShopContext();
            List<ItemObject> items = dbContext.Items.ToList();
            return items;
        }

        /// <summary>
        /// Gets a specific ItemObject from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the ItemObject to retrieve.</param>
        /// <returns>The ItemObject with the specified ID, or null if it is not found.</returns>
        public static ItemObject GetItem(int id)
        {
            using GameShopContext dbContext = new GameShopContext();
            ItemObject item = dbContext.Items.Where(i => i.ItemID == id).FirstOrDefault();
            return item;
        }

        /// <summary>
        /// Adds a new ItemObject to the database.
        /// </summary>
        /// <param name="item">The ItemObject to add.</param>
        public static void AddItem(ItemObject item)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.Items.Add(item);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Updates an existing ItemObject in the database.
        /// </summary>
        /// <param name="item">The ItemObject to update.</param>
        public static void UpdateItem(ItemObject item)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.Items.Update(item);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Deletes an ItemObject from the database.
        /// </summary>
        /// <param name="item">The ItemObject to delete.</param>
        public static void DeleteItem(ItemObject item)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.Items.Remove(item);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Deletes an ItemObject from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the ItemObject to delete.</param>
        public static void DeleteItem(int id)
        {
            using GameShopContext dbContext = new GameShopContext();
            ItemObject item = dbContext.Items.Where(i => i.ItemID == id).FirstOrDefault();
            dbContext.Items.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
