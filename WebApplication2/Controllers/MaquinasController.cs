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
    //public class MaquinasController : ControllerBase
    //{
    //    private readonly AplicationsDbContext _context;

    //    public MaquinasController(AplicationsDbContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/Maquinas
    //    [HttpGet]
    //    public IEnumerable<Maquinas> GetMaquinas()
    //    {
    //        return _context.Maquinas;
    //    }

    //    // GET: api/Maquinas/5
    //    [HttpGet("{id}")]
    //    public async Task<IActionResult> GetMaquinas([FromRoute] int id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var maquinas =  from m in _context.Maquinas where m.ClienteId == id select m;
            
    //        //var maquinas = await _context.Maquinas.
    //        //maquinas= await _context.Maquinas.Include(x => x.ClienteId).SingleOrDefaultAsync(m => m.ClienteId == id);


    //        if (maquinas == null)
    //        {
    //            return NotFound();
    //        }

    //        return Ok(maquinas);
    //    }

    //    // PUT: api/Maquinas/5
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutMaquinas([FromRoute] int id, [FromBody] Maquinas maquinas)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        if (id != maquinas.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(maquinas).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!MaquinasExists(id))
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

    //    // POST: api/Maquinas
    //    [HttpPost]
    //    public async Task<IActionResult> PostMaquinas([FromBody] Maquinas maquinas)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        _context.Maquinas.Add(maquinas);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetMaquinas", new { id = maquinas.Id }, maquinas);
    //    }

    //    [HttpPost("delete/list")]
    //    public IActionResult DeleteList([FromBody] List<int> ids)
    //    {
    //        try
    //        {
    //            List<Maquinas> maquinas = ids.Select(id => new Maquinas() { Id = id }).ToList();
    //            _context.RemoveRange(maquinas);
    //            _context.SaveChanges();
    //        }
    //        catch (Exception ex)
    //        {
    //            return BadRequest(ex.Message);
    //        }
    //        return Ok();
    //    }

    //    // DELETE: api/Maquinas/5
    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> DeleteMaquinas([FromRoute] int id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var maquinas = await _context.Maquinas.FindAsync(id);
    //        if (maquinas == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.Maquinas.Remove(maquinas);
    //        await _context.SaveChangesAsync();

    //        return Ok(maquinas);
    //    }

    //    private bool MaquinasExists(int id)
    //    {
    //        return _context.Maquinas.Any(e => e.Id == id);
    //    }
    //}
}