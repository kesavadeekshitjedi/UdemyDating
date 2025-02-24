using Microsoft.AspNetCore.Mvc;

using UdemyDating.WebAPI.Models;
using System.Linq;
using UdemyDating.WebAPI.Data;

namespace UdemyDating.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        private readonly ILogger<UsersController> logger;

        public UsersController(AppDbContext dbContext, ILogger<UsersController> logger) // Injecting our AppDbContext class here since it is already instantiated in the Program.cs file. The AppDbContext file is under the Data folder.
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            logger.LogInformation("Getting all users");
            var users = dbContext.Users.ToList();

            return Ok(users);

        }
        [HttpGet("{Id}")]
        public ActionResult<AppUser> GetUser(int Id)
        {
            logger.LogInformation("Getting user " +Id);
            var user = dbContext.Users.FirstOrDefault(x => x.Id == Id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(user);
            }

        }

    }
}
