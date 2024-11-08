using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CacaoDuarteAPI.DATA;
using CacaoDuarteAPI.Models;

namespace CacaoDuarteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrecioCacaosController : ControllerBase
    {
        private readonly Contexto _context;

        public PrecioCacaosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/PrecioCacaos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrecioCacao>>> GetPreciosCacaos()
        {
            return await _context.PreciosCacaos.ToListAsync();
        }

        // GET: api/PrecioCacaos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PrecioCacao>> GetPrecioCacao(int id)
        {
            var precioCacao = await _context.PreciosCacaos.FindAsync(id);

            if (precioCacao == null)
            {
                return NotFound();
            }

            return precioCacao;
        }

        // PUT: api/PrecioCacaos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrecioCacao(int id, PrecioCacao precioCacao)
        {
            if (id != precioCacao.Id)
            {
                return BadRequest();
            }

            _context.Entry(precioCacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrecioCacaoExists(id))
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

        // POST: api/PrecioCacaos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PrecioCacao>> PostPrecioCacao(PrecioCacao precioCacao)
        {
            _context.PreciosCacaos.Add(precioCacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrecioCacao", new { id = precioCacao.Id }, precioCacao);
        }

        // DELETE: api/PrecioCacaos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrecioCacao(int id)
        {
            var precioCacao = await _context.PreciosCacaos.FindAsync(id);
            if (precioCacao == null)
            {
                return NotFound();
            }

            _context.PreciosCacaos.Remove(precioCacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrecioCacaoExists(int id)
        {
            return _context.PreciosCacaos.Any(e => e.Id == id);
        }
    }
}
