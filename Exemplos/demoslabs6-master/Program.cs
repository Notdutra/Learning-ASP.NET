using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace demoslabs6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                /*
                var blog = new Blog { Url = "http://example.com" };
                db.Blogs.Add(blog);
                db.SaveChanges();
                */
                /*
                var blog = db.Blogs.First();
                var post = new Post {
                    Title = "Hello World!",
                    Content = "Hello from Entity Framework Core :-)"
                };
                blog.Posts.Add(post);
                db.SaveChanges();
                */
                var blog = db.Blogs.Include(b => b.Posts).First();
                Console.WriteLine(blog.BlogId);
                Console.WriteLine(blog.Url);
                //db.Entry(blog).Collection(b => b.Posts).Load();
                foreach (var p in blog.Posts)
                {
                    Console.WriteLine(p.Title);
                }
            }
        }
    }
}
