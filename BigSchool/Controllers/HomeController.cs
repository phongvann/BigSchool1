﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BigSchool.Models;
using System.Data.Entity;
using BigSchool.ViewModels;

namespace BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbConText _dbConText;
       

        public HomeController()
        {
            _dbConText = new ApplicationDbConText();
        }
        public ActionResult Index()
        {
            var upcommingCourses = _dbConText.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);
          
            return View(upcommingCourses);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}