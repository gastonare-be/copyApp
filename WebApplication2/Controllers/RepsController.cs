using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace WebApplication2.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class RepsController : ControllerBase
    //{
    //    private readonly AplicationsDbContext _context;

    //    public RepsController(AplicationsDbContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/Reps
    //    [HttpGet]
    //    public IEnumerable<Rep> GetRep()
    //    {
    //        return _context.Rep;
    //    }

    //    // GET: api/Reps/5
    //    [HttpGet("{id}")]
    //    public async Task<IActionResult> GetRep([FromRoute] int id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        var reparaciones = from r in _context.Rep where r.MaquinasId == id select r;


    //        if (reparaciones == null)
    //        {
    //            return NotFound();
    //        }

    //        return Ok(reparaciones);
    //    }

    //    // PUT: api/Reps/5
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutRep([FromRoute] int id, [FromBody] Rep rep)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        if (id != rep.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(rep).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!RepExists(id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }

    //        return NoContent();
    //    }

    //    // POST: api/Reps
    //    [HttpPost]
    //    public async Task<IActionResult> PostRep([FromBody] Rep rep)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        _context.Rep.Add(rep);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetRep", new { id = rep.Id }, rep);
    //    }

    //    // DELETE: api/Reps/5
    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> DeleteRep([FromRoute] int id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var rep = await _context.Rep.FindAsync(id);
    //        if (rep == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.Rep.Remove(rep);
    //        await _context.SaveChangesAsync();

    //        return Ok(rep);
    //    }

    //    private bool RepExists(int id)
    //    {
    //        return _context.Rep.Any(e => e.Id == id);
    //    }
    //}
}