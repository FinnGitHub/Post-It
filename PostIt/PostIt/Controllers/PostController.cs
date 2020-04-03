using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PostIt.Data;
using PostIt.Models;

namespace PostIt.Controllers
{
    public class PostController : Controller
    {
        private PostContext db;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(Post post)
        {
            if (ModelState.IsValid)
            {
                db.Posts.Add(post);
                db.SaveChanges();

                return View("CreateSuccess");
            }
            else
            {
                return View("CreateFailed");
            }
        }

    }
}