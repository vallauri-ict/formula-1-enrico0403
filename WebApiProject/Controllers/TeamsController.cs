using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneDll;

namespace WebApiProject.Controllers
{
    public class TeamsController : ApiController
    {
        DbTools db = new DbTools();

        public IEnumerable<Team> GetAllTeams()
        {
            db.GetTeams();
            return db.Teams.Values;
        }
        public IHttpActionResult GetTeam(int id)
        {
            db.GetTeams();
            if (db.Teams[id] == null)
                return NotFound();

            return Ok(db.Teams[id]);
        }
    }
}
