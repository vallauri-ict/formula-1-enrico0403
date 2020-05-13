using FormulaOneDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class scoresController : ApiController
    {
        DbTools db = new DbTools();

        public IEnumerable<Scores> GetAllScores()
        {
            db.GetScores();
            return db.Scores.Values;
        }
        public IHttpActionResult GetScore(int pos)
        {
            db.GetScores();
            if (db.Scores[pos] == null)
                return NotFound();

            return Ok(db.Scores[pos]);
        }
    }
}
