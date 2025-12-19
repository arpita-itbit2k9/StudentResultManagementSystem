using System.Collections.Generic;

namespace StudentResultManagementSystem.Contracts.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public List<SubjectMarks> SubjectsMarks { get; set; }
    }
}
