using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagementSystem.Data.DTO
{
    public class StudentResultCsv
    {
        public int RollNumber { get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
        public string Grade { get; set; }
    }
}
