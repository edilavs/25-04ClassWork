using ConsoleApp33.Data.BlogDBContext;
using ConsoleApp33.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp33.Service
{
    public class Services
    {
        public BlogDbContext dbContext = new BlogDbContext();
        public void AddPost(string title,string content)
        {
            Post post = new Post()
            {
                Title = title,
                Content=content
            };
            dbContext.Posts.Add(post);
            dbContext.SaveChanges();
        }


        public void EditPostTitle(int id,string title)
        {
            var data = dbContext.Posts.FirstOrDefault(x => x.Id == id);

            data.Title = title;
            dbContext.SaveChanges();
        }

        public Post GetPostById(int id)
        {
            return dbContext.Posts.Where(x => x.Id == id).FirstOrDefault();
           
        }

        public List<Post> GetAllPosts()
        {
            List<Post> posts = dbContext.Posts.ToList();
            return posts;
        }

        public void DeletePost(int id)
        {
            var data = dbContext.Posts.Find(id);
            dbContext.Posts.Remove(data);
            dbContext.SaveChanges();
        }
    }
}
