using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopManager
{
    /// <summary>
    /// Provides CRUD operations for users in the database.
    /// </summary>
    internal static class UserDB
    {
        /// <summary>
        /// Gets all users from the database.
        /// </summary>
        /// <returns>A list of UserObject containing all the users in the database.</returns>
        public static List<UserObject> GetAllUsers()
        {
            using GameShopContext dbContext = new GameShopContext();
            List<UserObject> users = dbContext.Users.ToList();
            return users;
        }

        /// <summary>
        /// Gets a specific user from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>A UserObject containing the user with the given ID, or null if not found.</returns>
        public static UserObject GetUser(int id)
        {
            using GameShopContext dbContext = new GameShopContext();
            UserObject user = dbContext.Users.Where(u => u.UserID == id).FirstOrDefault();
            return user;
        }

        /// <summary>
        /// Adds a new user to the database.
        /// </summary>
        /// <param name="user">The user to add to the database.</param>
        public static void AddUser(UserObject user)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Updates an existing user in the database.
        /// </summary>
        /// <param name="user">The user to update.</param>
        public static void UpdateUser(UserObject user)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.Users.Update(user);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Deletes a specified user from the database.
        /// </summary>
        /// <param name="user">The user to delete from the database.</param>
        public static void DeleteUser(UserObject user)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Deletes a specified user from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the user to delete from the database.</param>
        public static void DeleteUser(int id)
        {
            using GameShopContext dbContext = new GameShopContext();
            UserObject user = dbContext.Users.Where(u => u.UserID == id).FirstOrDefault();
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }
    }
}
