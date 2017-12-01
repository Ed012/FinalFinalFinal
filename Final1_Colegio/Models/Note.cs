using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final1_Colegio.Models
{
    public class Note
    {
        [Key]
        public int IdNote { get; set; }
        public int Note1 { get; set; }
        public int Note2 { get; set; }
        public int? Promedy { get; set; }


        public int IdStudent { get; set; }
        public Student Student { get; set; }
    }
}