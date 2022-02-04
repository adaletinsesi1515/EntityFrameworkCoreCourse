using EfCore.Query.Data.Context;
using EfCore.Query.Data.Entities;
using System;
using System.Linq;

namespace EfCore.Query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            //context.Add(new Blog
            //{
            //    Title= "Blog - 1",
            //    Url="memduh.com/blog-1"
            //});
            //context.Add(new Blog
            //{
            //    Title = "Blog - 2",
            //    Url = "memduh.com/blog-2"
            //});
            //context.Add(new Blog
            //{
            //    Title = "Blog - 3",
            //    Url = "memduh.com/blog-3"
            //});
            //context.Add(new Blog
            //{
            //    Title = "Blog - 4",
            //    Url = "memduh.com/blog-4"
            //});

            //context.SaveChanges();

            var query= context.Blogs.AsQueryable();

            var blogs = query.Where(x => x.Title.Contains("Blog-1") || x.Title.Contains("Blog-2")).ToList();

            foreach (var blog in blogs)
            {
                Console.WriteLine(blog.Title);
            }

            Console.WriteLine("Kayıtlar listelendi");
        }
    }
}
