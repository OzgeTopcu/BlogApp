using BlogAppProject.Data.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogAppProject.ViewComponents
{
    public class TagsMenu : ViewComponent
    {
        private ITagRepository _tagRepository;
       
        public TagsMenu(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public IViewComponentResult Invoke()
        {
            var tags = _tagRepository.Tags.ToList();
            return View(tags);
        }
    }
}
