using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.ITI_DB_Schema
{
    internal class Course_Inst
    {
        [Key, Column(Order = 0)]
        public int InstructorId { get; set; }

        [Key, Column(Order = 1)]
        public int CourseId { get; set; }
        public double Evaluate { get; set; }

        //Navigation Property
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }

    }
}
