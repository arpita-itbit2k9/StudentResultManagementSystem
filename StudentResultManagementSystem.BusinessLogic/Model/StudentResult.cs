using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagementSystem.BusinessLogic.Model
{
    public class StudentResult
    {
        public int TotalMarks { get; set; }
        public int ObtainedMarks { get; set; }
        public double Percentage { get; set; }
        public string Grade { get; set; }
        public Student Student { get; set; }

    }
}
