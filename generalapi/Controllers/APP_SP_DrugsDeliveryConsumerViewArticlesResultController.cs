using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using generalapi.Models;
using System.Text.Json.Nodes;
using NuGet.Protocol;

namespace generalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APP_SP_DrugsDeliveryConsumerViewArticlesResultController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public APP_SP_DrugsDeliveryConsumerViewArticlesResultController(SISMEDICAERPContext context)
        {
            _context = context;
        }
        /*
        // GET: api/APP_SP_DrugsDeliveryConsumerViewArticlesResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<APP_SP_DrugsDeliveryConsumerViewArticlesResult>>> GetAPP_SP_DrugsDeliveryConsumerViewArticlesResult()
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
          {
              return NotFound();
          }
            //return await _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.ToListAsync();
            return _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult
                  .FromSqlRaw($"exec APP_SP_DrugsDeliveryConsumerViewArticles 'admin'")
                  .ToList();
        }

        // GET: api/APP_SP_DrugsDeliveryConsumerViewArticlesResult/5
        [HttpGet("{id}")]
        public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewArticlesResult>> GetAPP_SP_DrugsDeliveryConsumerViewArticlesResult(string id)
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
          {
              return NotFound();
          }
            var aPP_SP_DrugsDeliveryConsumerViewArticlesResult = await _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.FindAsync(id);

            if (aPP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
            {
                return NotFound();
            }

            return aPP_SP_DrugsDeliveryConsumerViewArticlesResult;
        }

        // PUT: api/APP_SP_DrugsDeliveryConsumerViewArticlesResult/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAPP_SP_DrugsDeliveryConsumerViewArticlesResult(string id, APP_SP_DrugsDeliveryConsumerViewArticlesResult aPP_SP_DrugsDeliveryConsumerViewArticlesResult)
        {
            if (id != aPP_SP_DrugsDeliveryConsumerViewArticlesResult.ArticleCode)
            {
                return BadRequest();
            }

            _context.Entry(aPP_SP_DrugsDeliveryConsumerViewArticlesResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!APP_SP_DrugsDeliveryConsumerViewArticlesResultExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        */








        /*

        [HttpPost]
        //public IActionResult InsertConsumibles(List<generalapi.Models.Consumible> consumibles)
        //public IActionResult InsertConsumibles([FromBody] Consumible[] consumibles)
        //{
        public async Task<ActionResult<Consumible>> PostAPP_SP_DrugsDeliveryConsumerViewArticlesResult([FromBody] Consumible[] jsonArray)
        {
            var algunacosa = jsonArray.ToList<generalapi.Models.Consumible>;
            var algunacosa2 = algunacosa;
            var algunastring = algunacosa.ToString;
            var contador = algunastring.ToJson;
            var nuevoJson = contador.ToString;


            try
            {
                // Agregar la lista de consumibles a la base de datos
                //_context.Consumibles.AddRange(consumibles);
                //_context.Consumible.AddRange(jsonArray);
                foreach (var consum in jsonArray)
                {
                    _context.Consumible.Add(consum);
                    _context.SaveChanges();
                }

                

                return Ok("Lista de consumibles insertada correctamente.");
            }
            catch (Exception ex)
            {
                return BadRequest("Error al insertar la lista de consumibles: " + ex.Message);
            }
        }
        */

        /*
        private List<Models.Employee> SortEmployees(List<Models.Employee> employees)
        {
        }
        */

            /*

            // POST: api/APP_SP_DrugsDeliveryConsumerViewArticlesResult
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
            //public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewArticlesResult>> PostAPP_SP_DrugsDeliveryConsumerViewArticlesResult(APP_SP_DrugsDeliveryConsumerViewArticlesResult aPP_SP_DrugsDeliveryConsumerViewArticlesResult)
            public async Task<ActionResult<Consumible>> PostAPP_SP_DrugsDeliveryConsumerViewArticlesResult([FromBody] Consumible[] jsonArray)
            {
                var algunacosa = jsonArray; 
                var algunacosa2 = algunacosa;
                var algunastring = algunacosa.ToString;
                var contador = algunastring.ToJson;
                var nuevoJson = contador.ToString;


                foreach (var item in algunacosa)
                {
                    var jeje = _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult
                      //.FromSqlRaw($"INSERT INTO GlappDrugsDeliveryConsumptionDet (ConsumptionID,ArticleCode,Quantity,UnitOfMeasure,CreationDate) VALUES(1,'MOV-ASEO-020',1,'UND','2023-01-14 09:15:07.760')")
                      .FromSqlRaw($"SELECT * FROM GlappDrugsDeliveryConsumptionDet")
                      .ToList();
                }

                var loquevino = algunacosa2.GetEnumerator;
                if (_context.APP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
              {
                  return Problem("Entity set 'SISMEDICAERPContext.APP_SP_DrugsDeliveryConsumerViewArticlesResult'  is null.");
              }
                //_context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.Add(aPP_SP_DrugsDeliveryConsumerViewArticlesResult);




            ///////////////
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                    if (APP_SP_DrugsDeliveryConsumerViewArticlesResultExists(aPP_SP_DrugsDeliveryConsumerViewArticlesResult.ArticleCode))
                    {
                        return Conflict();
                    }
                    else
                    {
                        throw;
                    }
                }


                return CreatedAtAction("GetAPP_SP_DrugsDeliveryConsumerViewArticlesResult", new { id = aPP_SP_DrugsDeliveryConsumerViewArticlesResult.ArticleCode }, aPP_SP_DrugsDeliveryConsumerViewArticlesResult);
                /////////////////
                ///
                return NoContent();
            }
            */
            /*
            // DELETE: api/APP_SP_DrugsDeliveryConsumerViewArticlesResult/5
            [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAPP_SP_DrugsDeliveryConsumerViewArticlesResult(string id)
        {
            if (_context.APP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
            {
                return NotFound();
            }
            var aPP_SP_DrugsDeliveryConsumerViewArticlesResult = await _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.FindAsync(id);
            if (aPP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
            {
                return NotFound();
            }

            _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.Remove(aPP_SP_DrugsDeliveryConsumerViewArticlesResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool APP_SP_DrugsDeliveryConsumerViewArticlesResultExists(string id)
        {
            return (_context.APP_SP_DrugsDeliveryConsumerViewArticlesResult?.Any(e => e.ArticleCode == id)).GetValueOrDefault();
        }
        */
    }
}
