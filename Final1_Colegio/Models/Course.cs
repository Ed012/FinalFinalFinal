using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final1_Colegio.Models
{
    public class Course
    {
        [Key]
        public int IdCourse { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int IdStudent { get; set; }
        public Student Student { get; set; }

    }
}