using Avensell.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Avensell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TEntity> : ControllerBase where TEntity : class
    {
        protected readonly AvensellContext _context;
        protected readonly DbSet<TEntity> _entities;

        protected BaseController(AvensellContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> GetEntities()
        {
            return await _entities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> GetEntity(int id)
        {
            var entity = await _entities.FindAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            return entity;
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> PostEntity(TEntity entity)
        {
            _entities.Add(entity);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEntity), new { id = (int)typeof(TEntity).GetProperty("Id").GetValue(entity) }, entity);
        }






        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntity(int id, TEntity entity)
        {
            if (id != (int)typeof(TEntity).GetProperty("Id").GetValue(entity))
            {
                return BadRequest();
            }

            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntity(int id)
        {
            var entity = await _entities.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _entities.Remove(entity);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

}
