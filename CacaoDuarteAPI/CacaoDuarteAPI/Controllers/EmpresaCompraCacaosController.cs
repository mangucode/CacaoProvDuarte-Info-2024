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
    public class EmpresaCompraCacaosController : ControllerBase
    {
        private readonly Contexto _context;

        public EmpresaCompraCacaosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/EmpresaCompraCacaos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpresaCompraCacao>>> GetEmpresaCompraCacaos()
        {
            return await _context.EmpresaCompraCacaos.ToListAsync();
        }

        // GET: api/EmpresaCompraCacaos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpresaCompraCacao>> GetEmpresaCompraCacao(int id)
        {
            var empresaCompraCacao = await _context.EmpresaCompraCacaos.FindAsync(id);

            if (empresaCompraCacao == null)
            {
                return NotFound();
            }

            return empresaCompraCacao;
        }

        // PUT: api/EmpresaCompraCacaos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpresaCompraCacao(int id, EmpresaCompraCacao empresaCompraCacao)
        {
            if (id != empresaCompraCacao.Id)
            {
                return BadRequest();
            }

            _context.Entry(empresaCompraCacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaCompraCacaoExists(id))
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

        // POST: api/EmpresaCompraCacaos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmpresaCompraCacao>> PostEmpresaCompraCacao(EmpresaCompraCacao empresaCompraCacao)
        {
            _context.EmpresaCompraCacaos.Add(empresaCompraCacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpresaCompraCacao", new { id = empresaCompraCacao.Id }, empresaCompraCacao);
        }

        // DELETE: api/EmpresaCompraCacaos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpresaCompraCacao(int id)
        {
            var empresaCompraCacao = await _context.EmpresaCompraCacaos.FindAsync(id);
            if (empresaCompraCacao == null)
            {
                return NotFound();
            }

            _context.EmpresaCompraCacaos.Remove(empresaCompraCacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpresaCompraCacaoExists(int id)
        {
            return _context.EmpresaCompraCacaos.Any(e => e.Id == id);
        }
    }
}
