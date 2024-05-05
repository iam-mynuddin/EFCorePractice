using EFCorePractice.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolDataController : ControllerBase
    {
        private readonly SchoolDbContext _schlDb;

        public SchoolDataController(SchoolDbContext schlDb)
        {
            _schlDb = schlDb;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _schlDb.Students.ToListAsync());
        }
    }
}
