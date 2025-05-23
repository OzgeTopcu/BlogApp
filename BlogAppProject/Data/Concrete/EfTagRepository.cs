using BlogAppProject.Data.Abstract;
using BlogAppProject.Data.Concrete.EfCore;
using BlogAppProject.Entities;

namespace BlogAppProject.Data.Concrete
{
    public class EfTagRepositroy : ITagRepository
    {
        private BlogContext _context;
        public EfTagRepositroy(BlogContext context)
        {
            _context = context;
        }

        public IQueryable<Tag> Tags  => _context.Tags;

        public void CreatePost(Tag tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
        }
    }
}
