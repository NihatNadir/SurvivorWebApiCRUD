using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurvivorWebApiCRUD.Context;
using SurvivorWebApiCRUD.DTO;
using SurvivorWebApiCRUD.Entities;

namespace SurvivorWebApiCRUD.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // Dependency injection ile context aldım

        private readonly SurvivorDbContext _context;

        public CategoryController(SurvivorDbContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<CategoryEntity>> GetAll()
        {
            // listedeki silinmemiş verileri aldım

            var category = await _context.Category.Where(x => x.IsDeleted == false).ToListAsync();
            
            return Ok(category);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryEntity>> Get(int id)
        {
            // category listesindeki id uyuşursa geriye o competitor döner eğer listede yoksa NotFound silinmiş bir nesne ise geriye BadRequest döner.

            var category = await _context.Category.FirstOrDefaultAsync(ca => ca.Id == id);

            if (category is null)
                return NotFound();

            if (category.IsDeleted is true)
                return BadRequest();


            return Ok(category);
        }


        [HttpPost]
        public async Task<ActionResult<CategoryDTO>> Post(CategoryDTO categoryDTO)
        {
            // category listesine yeni bir nesne eklenir 

            var newCategory = new CategoryEntity();                          
            newCategory.Name = categoryDTO.Name;
            newCategory.ModifiedDate = newCategory.CreatedDate;            

            await _context.Category.AddAsync(newCategory);
            await _context.SaveChangesAsync();            
                       
            return CreatedAtAction(nameof(Get),new { id = newCategory.Id }, categoryDTO);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id)
        {
            // category listesinde id bulunmazsa NotFound döner bulunursa isDeleted değişir ve güncellenme tarihi yenilenir

            var category = await _context.Category.FirstOrDefaultAsync(x => x.Id == id);
            if (category is null)
                return NotFound();
            category.IsDeleted = !category.IsDeleted;
            category.ModifiedDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok(category);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CategoryEntity request)
        {
            // category listesindeki id uyuşursa veriler request üzerinden değişir ve o category döner eğer listede yoksa NotFound
            // request id ile id eşleşmezse veya request null ise geriye BadRequest döner.

            if (request is null || id != request.Id)
                return BadRequest();

            var category = await _context.Category.FirstOrDefaultAsync(x => x.Id == id);

            if (category is null)
                return NotFound();

            category.Name = request.Name;
            category.IsDeleted = request.IsDeleted;
            category.Competitors = request.Competitors;
            category.ModifiedDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok(category);
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            // listedeki id eşleşirse silinir eşleşmezse NotFound döner

            var category = await _context.Category.FirstOrDefaultAsync(x => x.Id == id);
            if (category is null)
                return NotFound();

            category.IsDeleted = true;
            await _context.SaveChangesAsync();
            return Ok(category);
        }




    }
}
