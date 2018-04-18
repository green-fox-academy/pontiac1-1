using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using Reddit.Services;
using Reddit.DTOs;

namespace Reddit.Controllers
{
    [Route("post")]
    public class PostController : Controller
    {
        ICrud<Post> pc;
        IVoter voter;

        public PostController(ICrud<Post> pc, IVoter voter)
        {
            this.pc = pc;
            this.voter = voter;
        }

        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody]PostDTO newPost)
        {
            return Json(pc.Create(new Post { Title = newPost.Title, URL = newPost.URL }));
        }

        [Route("read")]
        [HttpGet]
        public IActionResult Read()
        {
            return Json(pc.Read());
        }

        [Route("update/")]
        [HttpPost]
        public IActionResult Update(int id, string what)
        {
            if (what == "upvote")
            {
                return Json(voter.Up());
            }
            if (what == "downvote")
            {
                return Json(voter.Down());
            }
            return View();
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult Delete(string title)
        {
            return Json(pc.Delete(title));
        }

        
    }
}