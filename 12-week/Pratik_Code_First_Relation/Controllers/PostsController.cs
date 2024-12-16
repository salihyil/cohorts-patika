using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pratik_Code_First_Relation.Contexts;
using Pratik_Code_First_Relation.Dtos.PostDto;
using Pratik_Code_First_Relation.Entities;

namespace Pratik_Code_First_Relation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly PratikDbContext _context;

        public PostsController(PratikDbContext context)
        {
            _context = context;
        }

        // GET: api/Posts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostListDto>>> GetPosts()
        {
            var posts = await _context.Posts
                .Include(p => p.User)
                .Select(p => new PostListDto
                {
                    Id = p.Id,
                    Title = p.Title,
                    Username = p.User.Username
                })
                .ToListAsync();

            return Ok(posts);
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostDetailDto>> GetPost(int id)
        {
            var post = await _context.Posts
                .Include(p => p.User)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (post == null)
            {
                return NotFound("Post bulunamadı");
            }

            var postDetail = new PostDetailDto
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                UserId = post.UserId,
                Username = post.User.Username
            };

            return Ok(postDetail);
        }

        // POST: api/Posts
        [HttpPost]
        public async Task<ActionResult<PostCreateDto>> CreatePost(PostCreateDto postDto)
        {
            // Kullanıcı kontrolü
            var user = await _context.Users.FindAsync(postDto.UserId);
            if (user == null)
            {
                return BadRequest("Geçersiz kullanıcı ID");
            }

            var post = new PostEntity
            {
                Title = postDto.Title,
                Content = postDto.Content,
                UserId = postDto.UserId
            };

            _context.Posts.Add(post);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPost), new { id = post.Id }, post);
        }

        // PUT: api/Posts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePost(int id, PostUpdateDto postDto)
        {
            var post = await _context.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound("Post bulunamadı");
            }

            post.Title = postDto.Title;
            post.Content = postDto.Content;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var post = await _context.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound("Post bulunamadı");
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}