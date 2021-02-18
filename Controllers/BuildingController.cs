using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using BuildingRestAPI.Modles;
using BuildingRestAPI.Context;
namespace BuildingRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly BuildingDbContext __context;

        public BuildingController(BuildingDbContext context)
        {
            __context = context;
        }

        [HttpGet]
        public IAsyncEnumerable<Building> GetBuildings()
        {
            return __context.Buildings;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBuilding(int id)
        {
            Building building = await __context.Buildings.FindAsync(id);
            if(building == null)
            {
                return NotFound();
            }
            return Ok(new { 
             BuildingId = building.BuildingId, Name = building.Name,
             Description = building.Description, Number = building.Number,
             Location = building.Location, ImageUrl = building.ImageUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> SaveBuilding(BuildingTargetBinding target)
        {
            if (ModelState.IsValid)
            {
                Building building = target.ToBuilding();
                await __context.Buildings.AddAsync(building);
                await __context.SaveChangesAsync();
                return Ok(building);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public async Task UpdateBuilding(Building building)
        {
             __context.Update(building);
           await __context.SaveChangesAsync();
        }

        [HttpDelete("{id}")]
        public async Task DeleteBuilding(int id)
        {
            __context.Buildings.Remove(new Building { BuildingId = id });
           await __context.SaveChangesAsync();
        }

        [HttpGet("redirect")]
        public IActionResult Redirect()
        {
            return RedirectToAction(nameof(GetBuilding), new { Id = 1 });
        }
    }
}
