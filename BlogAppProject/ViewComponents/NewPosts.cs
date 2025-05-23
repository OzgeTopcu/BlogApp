using BlogAppProject.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogAppProject.ViewComponents
{
	public class NewPosts : ViewComponent
	{
		private IPostRepository _postRepository;

		public NewPosts(IPostRepository postRepository)
		{
			_postRepository = postRepository;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var posts = await _postRepository.Posts
			.OrderByDescending(p => p.PublishedOn)
			.Take(2)
			.ToListAsync(); // ✅ async çağrı

			return View(posts);

		}
	}
}
