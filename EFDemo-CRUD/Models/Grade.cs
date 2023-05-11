using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo_CRUD.Models
{

    public class Grade
    {
        
        public int GradeCode { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

    }
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public Batch  Batch { get; set; }
    }
}
