using FormulaOneDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class racesController : ApiController
    {
        DbTools db = new DbTools();

        public IEnumerable<Race> GetAllRaces()
        {
            db.GetRaces();
            return db.Races.Values;
        }
        public IHttpActionResult GetRace(int id)
        {
            db.GetRaces();
            if (db.Races[id] == null)
                return NotFound();

            return Ok(db.Races[id]);
        }
    }
}
