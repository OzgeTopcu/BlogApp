using BlogAppProject.Entities;

namespace BlogAppProject.Data.Abstract
{
    public interface ITagRepository
    {
        IQueryable<Tag> Tags { get; }

        void CreatePost(Tag tag);
    }
}
