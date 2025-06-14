﻿using BlogAppProject.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogAppProject.ViewComponents
{
    public class TagsMenu : ViewComponent
    {
        private ITagRepository _tagRepository;
       
        public TagsMenu(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var tags =await _tagRepository.Tags.ToListAsync();
            return View(tags);
        }
    }
}
