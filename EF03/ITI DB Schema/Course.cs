using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.ITI_DB_Schema
{
    internal class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public ICollection<Student_Course> student_Courses { get; set; } = new HashSet<Student_Course>();
        
        public ICollection<Topic> topic_Courses { get; set; } = new HashSet<Topic>();
    }
}
