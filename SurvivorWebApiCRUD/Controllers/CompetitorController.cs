using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurvivorWebApiCRUD.Context;
using SurvivorWebApiCRUD.DTO;
using SurvivorWebApiCRUD.Entities;

namespace SurvivorWebApiCRUD.Controllers
{
    [Route("api/competitors")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        // Dependency injection ile context aldım

        private readonly SurvivorDbContext _context;
        public CompetitorController(SurvivorDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<CompetitorEntity>> Get()
        { 
            // listedeki silinmemiş verileri aldım
            
            var competitor = await _context.Competitors.Where(x => x.IsDeleted == false).ToListAsync();
            return Ok(competitor);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompetitorEntity>> Get(int id)
        {
            // competitors listesindeki id uyuşursa geriye o competitor döner eğer listede yoksa NotFound silinmiş bir nesne ise geriye BadRequest döner.

            var competitor = await _context.Competitors.FirstOrDefaultAsync(x => x.Id == id);
            if (competitor is null)
                return NotFound();

            if (competitor.IsDeleted is true)
                return BadRequest();

            return Ok(competitor);
        }

               

        [HttpPost]
        public async Task<ActionResult<CompetitorDTO>> Post([FromBody] CompetitorDTO request)
        {
            // competitors listesine yeni bir nesne eklenir 

            var competitor = new CompetitorEntity();

            competitor.FirstName = request.FirstName;
            competitor.LastName = request.LastName;
            competitor.CategoryId = request.CategoryId;
            competitor.ModifiedDate = DateTime.Now;
           
            await _context.Competitors.AddAsync(competitor);
            
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = competitor.Id }, request);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CompetitorEntity request)
        {
            // competitors listesindeki id uyuşursa veriler request üzerinden değişir ve o competitor döner eğer listede yoksa NotFound
            // request id ile id eşleşmezse veya request null ise geriye BadRequest döner.

            if (request is null || id != request.Id)
                return BadRequest();

            var competitor = await _context.Competitors.FirstOrDefaultAsync(x => x.Id == id);

            if (competitor is null)
                return NotFound();

            competitor.IsDeleted = request.IsDeleted;
            competitor.ModifiedDate = DateTime.Now;
            competitor.FirstName = request.FirstName;
            competitor.LastName = request.LastName;
            competitor.CategoryId = request.CategoryId;

            await _context.SaveChangesAsync();

            return Ok(competitor);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            // listedeki id eşleşirse silinir eşleşmezse NotFound döner

            var competitor = await _context.Competitors.FirstOrDefaultAsync(x =>x.Id == id);
            
            if (competitor is null)
                return NotFound();

            competitor.IsDeleted = true;

            return Ok(competitor);
        }


    }
}
