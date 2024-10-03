using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioBackend.Context;
using PortfolioBackend.Models;
using PortfolioBackend.Interfaces;

namespace PortfolioBackend.Controllers
{
    [Route("api/professional-experiences")]
    [ApiController]
    public class ProfessionalExperiencesController : ControllerBase
    {
        private readonly PortfolioDbContext _context;

        public ProfessionalExperiencesController(PortfolioDbContext context)
        {
            _context = context;
        }

        // GET: api/professional-experiences
        [HttpGet]
        public async Task<ActionResult<ApiResponse<IEnumerable<ProfessionalExperience>>>> GetProfessionalExperiences()
        {
            List<ProfessionalExperience>? professionalExperiences = null;
            
            try
            {
                professionalExperiences = await _context.ProfessionalExperiences
                       .Include(pe => pe.Responsabilities)
                       .Include(te => te.TechnologieExperiences)
                       .ThenInclude(te => te.Technologie)
                       .ToListAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error interno del servidor", detail = ex.Message });
            }
       
            return StatusCode(200, new { data = professionalExperiences });
        }

        // GET: api/ProfessionalExperiences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProfessionalExperience>> GetProfessionalExperience(int id)
        {
            var professionalExperience = await _context.ProfessionalExperiences.FindAsync(id);

            if (professionalExperience == null)
            {
                return NotFound();
            }

            return professionalExperience;
        }

        // PUT: api/ProfessionalExperiences/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfessionalExperience(int id, ProfessionalExperience professionalExperience)
        {
            if (id != professionalExperience.Id)
            {
                return BadRequest();
            }

            _context.Entry(professionalExperience).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessionalExperienceExists(id))
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

        // POST: api/ProfessionalExperiences
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProfessionalExperience>> PostProfessionalExperience(ProfessionalExperience professionalExperience)
        {
            _context.ProfessionalExperiences.Add(professionalExperience);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfessionalExperience", new { id = professionalExperience.Id }, professionalExperience);
        }

        // DELETE: api/ProfessionalExperiences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfessionalExperience(int id)
        {
            var professionalExperience = await _context.ProfessionalExperiences.FindAsync(id);
            if (professionalExperience == null)
            {
                return NotFound();
            }

            _context.ProfessionalExperiences.Remove(professionalExperience);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProfessionalExperienceExists(int id)
        {
            return _context.ProfessionalExperiences.Any(e => e.Id == id);
        }
    }
}

