using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.ITI_DB_Schema
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }

        //Navigation Property To Studnent Table
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        
        [InverseProperty("Dept")]
        public ICollection<Instructor> Instructors { get; set; }  = new HashSet<Instructor>();

        [InverseProperty("department")]
        [ForeignKey("InsID")]
        public Instructor instructor { get; set; }
    }
}
