using EFCorePractice.Context;
using EFCorePractice.Models.CollegeEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EFCorePractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private readonly CollegeManagementContext _clgDb;
        public SchoolDbContext _schlDb { get; }

        public CommonController(CollegeManagementContext clgDb,SchoolDbContext schlDb)
        {
            _clgDb = clgDb;
            _schlDb = schlDb;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> Get()
        {
            var SchlStudents = _schlDb.Students.ToList();
            var ClgStudents = _clgDb.Students.ToList();
            var data = new
            {
                ClgStudents,
                SchlStudents
            };
            string jsonRes = await Task.Run(() => JsonConvert.SerializeObject(data));

            return Ok(jsonRes);
        }
        [HttpGet("getallwithinclude")]
        public async Task<IActionResult> GetAllWithInclude()
        {
            var SchlStudents = _schlDb.IncludeAll<Models.SchoolEntities.Student>().ToList();
            var ClgStudents = _clgDb.IncludeAll<Models.CollegeEntities.Student>().ToList();
            var data = new
            {
                ClgStudents,
                SchlStudents
            };
            string jsonRes = await Task.Run(() => JsonConvert.SerializeObject(data));

            return Ok(jsonRes);
        }
    }
}
