using BlogAppProject.Entities;
using BlogAppProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogAppProject.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Tag { Text = "web programlama", Url="web-programlama" },
                        new Tag { Text = "backend", Url="backend" },
                        new Tag { Text = "frontend", Url = "frontend" },
                        new Tag { Text = "fullstack", Url = "fullstack" },
                        new Tag { Text = "php", Url = "php" }
                    );
                    context.SaveChanges();
                }

                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { UserName = "ozgetopcu"},
                        new User { UserName = "fatimesevilgen"}
                    );
                    context.SaveChanges();
                }

                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post
                        {
                            Title = "Asp.net core",
                            Content = "Asp.net core dersleri",
                            Url="aspnet-core",
                            Image = "aspnet.jpg",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            UserId = 1,
                            Comments = new List<Comment> {
                                new Comment { Text = "iyi bir kurs", PublishedOn = DateTime.Now.AddDays(-20), UserId = 1},
                                new Comment { Text = "çok faydalandığım bir kurs", PublishedOn = DateTime.Now.AddDays(-10), UserId = 2},
                            }
                        },
                        new Post
                        {
                            Title = "Php",
                            Content = "Php core dersleri",
							Url = "php",
							IsActive = true,
                            Image = "php.jpg",
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            UserId = 1
                        },
                        new Post
                        {
                            Title = "Django",
                            IsActive = true,
							Url = "django",
							Content = "Django dersleri",
                            Image = "django.jpg",
                            PublishedOn = DateTime.Now.AddDays(-30),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                        ,
                        new Post
                        {
                            Title = "React Dersleri",
                            Content = "React dersleri",
							Url = "react-dersleri",
							IsActive = true,
                            Image = "react.png",
                            PublishedOn = DateTime.Now.AddDays(-40),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                        ,
                        new Post
                        {
                            Title = "Angular",
                            Content = "Angular dersleri",
							Url = "angular-dersleri",
							IsActive = true,
                            Image = "angular.jpg",
                            PublishedOn = DateTime.Now.AddDays(-50),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                        ,
                        new Post
                        {
                            Title = "Web Tasarım",
                            Content = "Web tasarım dersleri",
							Url = "web-tasarım",
							Image = "web.jpg",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-60),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}