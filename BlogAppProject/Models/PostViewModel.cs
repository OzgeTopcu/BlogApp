using BlogAppProject.Entities;

namespace BlogAppProject.Models
{
    public class PostViewModel
    {
        public List<Post> Posts { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
