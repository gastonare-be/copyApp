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
    //public class ProveedoresController : ControllerBase
    //{
    //    private readonly AplicationsDbContext _context;

    //    public ProveedoresController(AplicationsDbContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/Proveedores
    //    [HttpGet]
    //    public IEnumerable<Proveedor> GetProveedor()
    //    {
    //        return _context.Proveedor;
    //    }

    //    // GET: api/Proveedores/5
    //    [HttpGet("{id}")]
    //    public async Task<IActionResult> GetProveedor([FromRoute] int id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var proveedor = await _context.Proveedor.FindAsync(id);

    //        if (proveedor == null)
    //        {
    //            return NotFound();
    //        }

    //        return Ok(proveedor);
    //    }

    //    // PUT: api/Proveedores/5
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutProveedor([FromRoute] int id, [FromBody] Proveedor proveedor)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        if (id != proveedor.ID)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(proveedor).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!ProveedorExists(id))
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

    //    // POST: api/Proveedores
    //    [HttpPost]
    //    public async Task<IActionResult> PostProveedor([FromBody] Proveedor proveedor)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        _context.Proveedor.Add(proveedor);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetProveedor", new { id = proveedor.ID }, proveedor);
    //    }

    //    // DELETE: api/Proveedores/5
    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> DeleteProveedor([FromRoute] int id)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        var proveedor = await _context.Proveedor.FindAsync(id);
    //        if (proveedor == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.Proveedor.Remove(proveedor);
    //        await _context.SaveChangesAsync();

    //        return Ok(proveedor);
    //    }

    //    private bool ProveedorExists(int id)
    //    {
    //        return _context.Proveedor.Any(e => e.ID == id);
    //    }
    //}
}