using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2011068944_NguyenQuocAnh.Models
{
    public class Course
    {
        public int Id { get; set; }
        public bool IsCanceled { get; set; }
        public ApplicationUser Lectuner { get; set; }
        [Required]
        public string LectunerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }

    }

}