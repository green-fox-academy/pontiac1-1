using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reddit.Models;
using Reddit.Entities;

namespace Reddit.Services
{
    public class PostCrud : ICrud<Post>
    {
        RedditContext db;

        public PostCrud(RedditContext db)
        {
            this.db = db;
        }

        public Post Create(Post TtoCreate)
        {
            db.PostList.Add(TtoCreate);
            db.SaveChanges();
            return TtoCreate;
        }

        public string Delete(string title)
        {
            db.PostList.Remove(db.PostList.FirstOrDefault(p=>p.Title == title));
            db.SaveChanges();
            return $"{title} successfully deleted!";
        }

        public List<Post> Read()
        {
            return db.PostList.ToList();
        }

        public void Update(Post TtoUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
