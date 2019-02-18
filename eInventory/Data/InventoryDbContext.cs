using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eInventory.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext() : base("InventoryContext")
        {
            Database.SetInitializer(new InventoryDbInitializer());
        }

        public DbSet<Models.Inventory> Inventories { get; set; }
    }
}