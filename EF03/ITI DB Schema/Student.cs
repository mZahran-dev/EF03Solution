using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.ITI_DB_Schema
{
    internal class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string? LName { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }
    }
}
