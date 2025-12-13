using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagementSystem.BusinessLogic.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
