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
    public class TiposCacaosController : ControllerBase
    {
        private readonly Contexto _context;

        public TiposCacaosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/TiposCacaos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposCacao>>> GetTiposCacaos()
        {
            return await _context.TiposCacaos.ToListAsync();
        }

        // GET: api/TiposCacaos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TiposCacao>> GetTiposCacao(int id)
        {
            var tiposCacao = await _context.TiposCacaos.FindAsync(id);

            if (tiposCacao == null)
            {
                return NotFound();
            }

            return tiposCacao;
        }

        // PUT: api/TiposCacaos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiposCacao(int id, TiposCacao tiposCacao)
        {
            if (id != tiposCacao.Id)
            {
                return BadRequest();
            }

            _context.Entry(tiposCacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiposCacaoExists(id))
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

        // POST: api/TiposCacaos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TiposCacao>> PostTiposCacao(TiposCacao tiposCacao)
        {
            _context.TiposCacaos.Add(tiposCacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTiposCacao", new { id = tiposCacao.Id }, tiposCacao);
        }

        // DELETE: api/TiposCacaos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTiposCacao(int id)
        {
            var tiposCacao = await _context.TiposCacaos.FindAsync(id);
            if (tiposCacao == null)
            {
                return NotFound();
            }

            _context.TiposCacaos.Remove(tiposCacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TiposCacaoExists(int id)
        {
            return _context.TiposCacaos.Any(e => e.Id == id);
        }
    }
}
