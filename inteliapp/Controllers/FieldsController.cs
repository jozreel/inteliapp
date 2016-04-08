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
    public class FieldsController : ApiController
    {
        private IntelicoContex db = new IntelicoContex();

        // GET: api/Fields
        public IQueryable<Field> GetFields()
        {
            return db.Fields;
        }

        // GET: api/Fields/5
        [ResponseType(typeof(Field))]
        public IHttpActionResult GetField(int id)
        {
            Field field = db.Fields.Find(id);
            if (field == null)
            {
                return NotFound();
            }

            return Ok(field);
        }

        // PUT: api/Fields/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutField(int id, Field field)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != field.FieldID)
            {
                return BadRequest();
            }

            db.Entry(field).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FieldExists(id))
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

        // POST: api/Fields
        [ResponseType(typeof(Field))]
        public IHttpActionResult PostField(Field field)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Fields.Add(field);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = field.FieldID }, field);
        }

        // DELETE: api/Fields/5
        [ResponseType(typeof(Field))]
        public IHttpActionResult DeleteField(int id)
        {
            Field field = db.Fields.Find(id);
            if (field == null)
            {
                return NotFound();
            }

            db.Fields.Remove(field);
            db.SaveChanges();

            return Ok(field);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FieldExists(int id)
        {
            return db.Fields.Count(e => e.FieldID == id) > 0;
        }
    }
}