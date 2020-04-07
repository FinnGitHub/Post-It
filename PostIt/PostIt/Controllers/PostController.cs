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
        private  PostContext db;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Posts()
        {
            return View();
        }

        public IActionResult PostCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostCreate(Post post)
        {
            if (ModelState.IsValid)
            {
                db.Posts.Add(post);
                db.SaveChanges();

                return View("PostCreateSuccess");
            }
            else
            {
                return View("PostCreateFailed");
            }
        }

    }
}