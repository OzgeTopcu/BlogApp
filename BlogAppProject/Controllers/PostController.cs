using BlogAppProject.Data.Abstract;
using BlogAppProject.Data.Concrete.EfCore;
using BlogAppProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogAppProject.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository _postRepository;
        private ITagRepository _tagRepository;
      
        public PostController(IPostRepository postRepository, ITagRepository tagRepository)
        {
            _postRepository = postRepository;
            _tagRepository = tagRepository;
        }
        public IActionResult Index()
        {

            return View(
                new PostViewModel
                {
                    Posts = _postRepository.Posts.ToList(),
                    Tags = _tagRepository.Tags.ToList(),
                }
                
                );
        }
    }
}
