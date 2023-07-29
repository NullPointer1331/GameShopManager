using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopManager
{
    internal static class UserDB
    {
        public static List<UserObject> GetAllUsers()
        {
            using GameShopContext dbContext = new GameShopContext();
            List<UserObject> users = dbContext.Users.ToList();
            return users;
        }
        public static UserObject GetUser(int id)
        {
            using GameShopContext dbContext = new GameShopContext();
            UserObject user = dbContext.Users.Where(u => u.UserID == id).FirstOrDefault();
            return user;
        }
        public static void AddUser(UserObject user)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
        public static void UpdateUser(UserObject user)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.Users.Update(user);
            dbContext.SaveChanges();
        }
        public static void DeleteUser(UserObject user)
        {
            using GameShopContext dbContext = new GameShopContext();
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }
        public static void DeleteUser(int id)
        {
            using GameShopContext dbContext = new GameShopContext();
            UserObject user = dbContext.Users.Where(u => u.UserID == id).FirstOrDefault();
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }
    }
}
