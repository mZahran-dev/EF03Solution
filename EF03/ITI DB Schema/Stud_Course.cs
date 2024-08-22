using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.ITI_DB_Schema
{
    internal class Student_Course
    {
        [Key ,Column(Order = 0)]
        public int StudentId { get; set; }

        [Key ,Column(Order = 1)]
        public int CourseId { get; set; }
        public double Grade { get; set; }

        //Navigation Property
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
