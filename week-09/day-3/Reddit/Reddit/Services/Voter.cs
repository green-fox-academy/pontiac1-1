using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reddit.Entities;
using Reddit.Models;

namespace Reddit.Services
{
    public class Voter : IVoter
    {
        RedditContext db;

        public Voter(RedditContext db)
        {
            this.db = db;
        }

        public object Down(int postid, int userid)
        {
            User voter = db.UserList.FirstOrDefault(u => u.ID == userid);
            Post toBeVoted = db.PostList.FirstOrDefault(p => p.ID == postid);
            if (toBeVoted.Voters.Contains(voter))
            {
                return "you already voted for the post";
            }
            else
            {
                --toBeVoted.Score;
                db.SaveChanges();
                return toBeVoted;
            }
        }

        public object Up(int postid, int userid)
        {
            User voter = db.UserList.FirstOrDefault(u => u.ID == userid);
            Post toBeVoted = db.PostList.FirstOrDefault(p => p.ID == postid);
            if (toBeVoted.Voters.Contains(voter))
            {
                return "you already voted for the post";
            }
            else
            {
                ++toBeVoted.Score;
                db.SaveChanges();
                return toBeVoted;
            }
        }
    }
}
