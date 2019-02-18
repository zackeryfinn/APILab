using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eInventory.Data;
using eInventory.Models;

namespace eInventory.Controllers.Api
{
    public class OrdersController : ApiController
    {
        private InventoryDbContext db = new InventoryDbContext();
        
        // POST: api/Orders
        [ResponseType(typeof(Inventory))]
        public IHttpActionResult PostInventory(Inventory inventory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Inventories.Add(inventory);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = inventory.ID }, inventory);
           
        }
        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InventoryExists(int id)
        {
            return db.Inventories.Count(e => e.ID == id) > 0;
        }
    }
}