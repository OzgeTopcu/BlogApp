using BlogAppProject.Entities;

namespace BlogAppProject.Data.Abstract
{
    public interface IPostRepository
    {
        //Önce filtreleyip sonra veri tabanından alır. 
        //IEnumarable da kullanabiliriz ama o önce hepsini alıp sonra filtreleme yapar verimli değil.
        IQueryable<Post> Posts { get; }

        void CreatePost (Post post);
    }
}
