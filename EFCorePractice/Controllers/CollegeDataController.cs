using EFCorePractice.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeDataController : ControllerBase
    {
        private readonly CollegeManagementContext _clgDb;

        public CollegeDataController(CollegeManagementContext clgDb)
        {
            _clgDb = clgDb;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _clgDb.Students.ToListAsync());
        }
    }
}
