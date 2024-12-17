using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pratik_Survivor.Contexts;
using Pratik_Survivor.Dtos.Competitor;
using Pratik_Survivor.Entities;

namespace Pratik_Survivor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompetitorsController : ControllerBase
    {
        private readonly SurvivorDbContext _context;

        public CompetitorsController(SurvivorDbContext context)
        {
            _context = context;
        }

        // GET: api/competitors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCompetitorDto>>> GetCompetitors()
        {
            var competitors = await _context.Competitors
                .Where(c => !c.IsDeleted)
                .Select(c => new GetCompetitorDto
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName
                })
                .ToListAsync();

            return Ok(competitors);
        }

        // GET: api/competitors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCompetitorDto>> GetCompetitor(int id)
        {
            var competitor = await _context.Competitors
                .Where(c => !c.IsDeleted && c.Id == id)
                .Select(c => new GetCompetitorDto
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName
                })
                .FirstOrDefaultAsync();

            if (competitor == null)
            {
                return NotFound();
            }

            return Ok(competitor);
        }

        // GET: api/competitors/categories/5
        [HttpGet("categories/{categoryId}")]
        public async Task<ActionResult<IEnumerable<GetCompetitorDto>>> GetCompetitorsByCategory(int categoryId)
        {
            var competitors = await _context.Competitors
                .Where(c => !c.IsDeleted && c.CategoryId == categoryId)
                .Select(c => new GetCompetitorDto
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName
                })
                .ToListAsync();

            return Ok(competitors);
        }

        // POST: api/competitors
        [HttpPost]
        public async Task<ActionResult<GetCompetitorDto>> CreateCompetitor(CreateCompetitorDto createDto)
        {
            var competitor = new Competitor
            {
                FirstName = createDto.FirstName,
                LastName = createDto.LastName,
                CategoryId = createDto.CategoryId,
                IsDeleted = false
            };

            _context.Competitors.Add(competitor);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetCompetitor),
                new { id = competitor.Id },
                new GetCompetitorDto
                {
                    Id = competitor.Id,
                    FirstName = competitor.FirstName,
                    LastName = competitor.LastName
                });
        }

        // PUT: api/competitors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompetitor(int id, UpdateCompetitorDto updateDto)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor == null || competitor.IsDeleted)
            {
                return NotFound();
            }

            competitor.FirstName = updateDto.FirstName;
            competitor.LastName = updateDto.LastName;
            competitor.CategoryId = updateDto.CategoryId;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompetitorExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/competitors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompetitor(int id)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor == null || competitor.IsDeleted)
            {
                return NotFound();
            }

            competitor.IsDeleted = true;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompetitorExists(int id)
        {
            return _context.Competitors.Any(e => e.Id == id && !e.IsDeleted);
        }
    }
}