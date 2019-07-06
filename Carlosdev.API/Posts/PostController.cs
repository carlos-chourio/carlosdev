using Carlosdev.Application.Posts.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Carlosdev.API.Posts {
    [ApiController]
    [Route("api/post")]
    public class PostController : ControllerBase {
        private readonly IGetPostQuery getPostsQuery;

        public PostController(IGetPostQuery getPostsQuery) {
            this.getPostsQuery = getPostsQuery;
        }

        [HttpGet]
        public IActionResult GetAllPosts() {
            var posts = getPostsQuery.Execute().ToList();
            if (posts != null && posts.Count>0) {
                return Ok(posts);
            }
            return NotFound();
        }
    }
}
