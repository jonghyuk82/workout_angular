using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        // Normal version
        // [HttpGet]
        // public ActionResult<IEnumerable<AppUsers>> GetUsers()
        // {
        //     var users = _context.Users.ToList();
        //     return users;
        // }

        // async and await version
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUsers>>> GetUsers()
        {
            var users = _context.Users.ToListAsync();
            return await users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUsers>> GetUser(int id)
        {
            var user = _context.Users.FindAsync(id);
            return await user;
        }
    }
}