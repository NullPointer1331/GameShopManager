using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopManager
{
    internal class GameShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = the name of the database
            // Server = the server we're connecting to. LocalDB is included with VS
            // Trusted_Connection = true means our windows account should be used
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GameShopManager;Trusted_Connection=True;");
        }
        public DbSet<UserObject> Users { get; set; }
        public DbSet<ItemObject> Items { get; set; }
    }
}
