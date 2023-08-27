using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            try
            {
                using GameShopContext dbContext = new GameShopContext();
                List<ItemObject> items = dbContext.Items.ToList();
                return items;
            } catch (Exception ex)
            {
                Trace.WriteLine($"{ex.Message}");
                return new List<ItemObject>(); 
            }
        }

        /// <summary>
        /// Gets a specific ItemObject from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the ItemObject to retrieve.</param>
        /// <returns>The ItemObject with the specified ID, or null if it is not found.</returns>
        public static ItemObject? GetItem(int id)
        {
            try
            {
                using GameShopContext dbContext = new GameShopContext();
                ItemObject? item = dbContext.Items.Find(id);
                return item;
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"{ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Adds a new ItemObject to the database.
        /// </summary>
        /// <param name="item">The ItemObject to add.</param>
        public static void AddItem(ItemObject item)
        {
            try
            {
                using GameShopContext dbContext = new GameShopContext();
                dbContext.Items.Add(item);
                dbContext.SaveChanges();
            } catch(Exception ex)
            {
                Trace.WriteLine($"{ex.Message}");
            }
        }

        /// <summary>
        /// Updates an existing ItemObject in the database.
        /// </summary>
        /// <param name="item">The ItemObject to update.</param>
        public static void UpdateItem(ItemObject item)
        {
            try
            {
                using GameShopContext dbContext = new GameShopContext();
                dbContext.Items.Update(item);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"{ex.Message}");
            }
            
        }

        /// <summary>
        /// Deletes an ItemObject from the database. If any InventoryItems reference the ItemObject, they will also be deleted.
        /// </summary>
        /// <param name="item">The ItemObject to delete.</param>
        public static void DeleteItem(ItemObject item)
        {
            try
            {
                using GameShopContext dbContext = new GameShopContext();
                InventoryItemDB.DeleteAllOfItem(item.ItemID);
                dbContext.Items.Remove(item);
                dbContext.SaveChanges();
            } catch (Exception ex)
            {
                Trace.WriteLine($"{ex.Message}");
            }
            
        }

        /// <summary>
        /// Deletes an ItemObject from the database by ID. If any InventoryItems reference the ItemObject, they will also be deleted.
        /// </summary>
        /// <param name="id">The ID of the ItemObject to delete.</param>
        public static void DeleteItem(int id)
        {
            try
            {
                using GameShopContext dbContext = new GameShopContext();
                ItemObject? item = dbContext.Items.Find(id);
                if (item != null)
                {
                    InventoryItemDB.DeleteAllOfItem(item.ItemID);
                    dbContext.Items.Remove(item);
                    dbContext.SaveChanges();
                }
            } catch (Exception ex)
            {
                Trace.WriteLine($"{ex.Message}");
            }
        }
    }
}
