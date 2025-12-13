using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagementSystem.BusinessLogic.Model
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public int MaxMarks { get; set; }
        public int MinMarks { get; set; }

        public int Marks { get; set; }
    }
}
