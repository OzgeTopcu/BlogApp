﻿using BlogAppProject.Data.Abstract;
using BlogAppProject.Data.Concrete.EfCore;
using BlogAppProject.Entities;

namespace BlogAppProject.Data.Concrete
{
    public class EfPostRepository : IPostRepository
    {
        private BlogContext _context;
        public EfPostRepository(BlogContext context)
        {
            _context = context;
        }

        public IQueryable<Post> Posts  => _context.Posts;

        public void CreatePost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }
    }
}
