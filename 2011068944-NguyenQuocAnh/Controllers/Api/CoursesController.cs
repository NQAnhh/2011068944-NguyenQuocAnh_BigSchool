using _2011068944_NguyenQuocAnh.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Data.Entity;


namespace _2011068944_NguyenQuocAnh.Controllers.Api
{
    public class CoursesController : ApiController
    {
        public ApplicationDbContext _dbContext { get; set; }
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [System.Web.Http.HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var course = _dbContext.Courses.Single(c => c.Id == id && c.LectunerId == userId);
            if (course.IsCanceled)
            {
                return NotFound();
            }
            course.IsCanceled = true;
            _dbContext.SaveChanges();
            return Ok();
        }
        // GET: Courses
    }
}