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
    //public class RepuestosController : ControllerBase
    //{
    //    private readonly AplicationsDbContext _context;

    //    public RepuestosController(AplicationsDbContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/Repuestos
    //    [HttpGet]
    //    public IEnumerable<Repuesto> GetRepuesto()
    //    {
    //        return _context.Repuesto;
    //    }

    //    // GET: api/Repuestos/5
    //    [HttpGet("{id}")]
    //    public async Task<IActionResult> GetRepuesto([FromRoute] int id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var repuesto = await _context.Repuesto.FindAsync(id);

    //        if (repuesto == null)
    //        {
    //            return NotFound();
    //        }

    //        return Ok(repuesto);
    //    }

    //    // PUT: api/Repuestos/5
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutRepuesto([FromRoute] int id, [FromBody] Repuesto repuesto)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        if (id != repuesto.ID)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(repuesto).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!RepuestoExists(id))
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

    //    // POST: api/Repuestos
    //    [HttpPost]
    //    public async Task<IActionResult> PostRepuesto([FromBody] Repuesto repuesto)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        _context.Repuesto.Add(repuesto);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetRepuesto", new { id = repuesto.ID }, repuesto);
    //    }

    //    // DELETE: api/Repuestos/5
    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> DeleteRepuesto([FromRoute] int id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var repuesto = await _context.Repuesto.FindAsync(id);
    //        if (repuesto == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.Repuesto.Remove(repuesto);
    //        await _context.SaveChangesAsync();

    //        return Ok(repuesto);
    //    }

    //    private bool RepuestoExists(int id)
    //    {
    //        return _context.Repuesto.Any(e => e.ID == id);
    //    }
    //}
}