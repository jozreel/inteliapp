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
using inteliapp.DAL;
using inteliapp.Models;

namespace inteliapp.Controllers
{
    public class EquipmentCollectionsController : ApiController
    {
        private IntelicoContex db = new IntelicoContex();

        // GET: api/EquipmentCollections
        public IQueryable<EquipmentCollection> GetEquipmentCollection()
        {
            return db.EquipmentCollection;
        }

        // GET: api/EquipmentCollections/5
        [ResponseType(typeof(EquipmentCollection))]
        public IHttpActionResult GetEquipmentCollection(int id)
        {
            EquipmentCollection equipmentCollection = db.EquipmentCollection.Find(id);
            if (equipmentCollection == null)
            {
                return NotFound();
            }

            return Ok(equipmentCollection);
        }

        // PUT: api/EquipmentCollections/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEquipmentCollection(int id, EquipmentCollection equipmentCollection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != equipmentCollection.EquipmentCollectionID)
            {
                return BadRequest();
            }

            db.Entry(equipmentCollection).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipmentCollectionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/EquipmentCollections
        [ResponseType(typeof(EquipmentCollection))]
        public IHttpActionResult PostEquipmentCollection(EquipmentCollection equipmentCollection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EquipmentCollection.Add(equipmentCollection);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = equipmentCollection.EquipmentCollectionID }, equipmentCollection);
        }

        // DELETE: api/EquipmentCollections/5
        [ResponseType(typeof(EquipmentCollection))]
        public IHttpActionResult DeleteEquipmentCollection(int id)
        {
            EquipmentCollection equipmentCollection = db.EquipmentCollection.Find(id);
            if (equipmentCollection == null)
            {
                return NotFound();
            }

            db.EquipmentCollection.Remove(equipmentCollection);
            db.SaveChanges();

            return Ok(equipmentCollection);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EquipmentCollectionExists(int id)
        {
            return db.EquipmentCollection.Count(e => e.EquipmentCollectionID == id) > 0;
        }
    }
}