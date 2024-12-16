using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pratik_Code_First_Relation.Contexts;
using Pratik_Code_First_Relation.Dtos.UserDto;
using Pratik_Code_First_Relation.Entities;

namespace Pratik_Code_First_Relation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly PratikDbContext _context;

        public UsersController(PratikDbContext context)
        {
            _context = context;
        }

        // GET: api/Users
        // Tüm kullanıcıları listeler ve her kullanıcının post sayısını döner
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserListDto>>> GetUsers()
        {
            var users = await _context.Users
                .Select(u => new UserListDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    PostCount = u.Posts.Count
                })
                .ToListAsync();

            return Ok(users);
        }

        // GET: api/Users/5
        // Belirli bir kullanıcının detaylarını ve postlarını getirir
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDetailDto>> GetUser(int id)
        {
            var user = await _context.Users
                .Include(u => u.Posts)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound("Kullanıcı bulunamadı");
            }

            var userDetail = new UserDetailDto
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                Posts = user.Posts.Select(p => new Dtos.PostDto.PostDetailDto
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                    UserId = p.UserId,
                    Username = user.Username
                }).ToList()
            };

            return Ok(userDetail);
        }

        // POST: api/Users
        // Yeni bir kullanıcı oluşturur
        [HttpPost]
        public async Task<ActionResult<UserCreateDto>> CreateUser(UserCreateDto userDto)
        {
            // Email kontrolü
            if (await _context.Users.AnyAsync(u => u.Email == userDto.Email))
            {
                return BadRequest("Bu email adresi zaten kullanımda");
            }

            var user = new UserEntity
            {
                Username = userDto.Username,
                Email = userDto.Email
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        // PUT: api/Users/5
        // Var olan bir kullanıcıyı günceller
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserUpdateDto userDto)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound("Kullanıcı bulunamadı");
            }

            // Email değişmişse ve yeni email başka bir kullanıcı tarafından kullanılıyorsa
            if (user.Email != userDto.Email && await _context.Users.AnyAsync(u => u.Email == userDto.Email))
            {
                return BadRequest("Bu email adresi zaten kullanımda");
            }

            user.Username = userDto.Username;
            user.Email = userDto.Email;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Users/5
        // Kullanıcıyı ve ilişkili tüm postlarını siler
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound("Kullanıcı bulunamadı");
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}