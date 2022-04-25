using ConsoleApp33.Data.BlogDBContext;
using System;

using ConsoleApp33.Service;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            Services service = new Services();
            BlogDbContext dbContext = new BlogDbContext();
            //service.AddPost("title1", "content1");
            //service.AddPost("title2", "content2");
            //service.EditPostTitle(1, "newTitle");
            //Console.WriteLine(service.GetPostById(2).Content);
            //foreach (var item in service.GetAllPosts())
            //{
            //    Console.WriteLine(item.Id +" "+item.Title +" "+item.Content );  
            //}
            //service.DeletePost(2);


        }
    }
}
