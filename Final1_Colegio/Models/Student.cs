using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final1_Colegio.Models
{
    public class Student
    {
        [Key]
        public int IdStudent { get; set; }
        public string Full_Name { get; set; }
        public int DNI { get; set; }
        public int? Promedy { get; set; }
    }
}