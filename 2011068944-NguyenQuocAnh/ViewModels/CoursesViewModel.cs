using _2011068944_NguyenQuocAnh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2011068944_NguyenQuocAnh.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}