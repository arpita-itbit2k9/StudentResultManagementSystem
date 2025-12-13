using StudentResultManagementSystem.BusinessLogic.Model;
using System.Collections.Generic;

namespace StudentResultManagementSystem.BusinessLogic.Operation
{
    public class ResultCalculator
    {
    
        public int CalculateTotalMarks(List<SubjectMarks> subjectsMarks)
        {
            int total = 0;

            foreach (var subject in subjectsMarks)
            {
                total += subject.MaxMarks;
            }
            return total;
        }

        public int CalculateObtainedMarks(List<SubjectMarks> subjectsMarks)
        {
            int obtained = 0;
            foreach (var subject in subjectsMarks)
            {
                obtained += subject.Marks;
            }
            return obtained;
        }

        public double CalculatePercentage(int totalMarks, int obtainedMarks)
        {
           
           if (totalMarks == 0) return 0;
           return (double)obtainedMarks / totalMarks * 100;
        }

        public string CalculateGrade(int percentage)
        {
                if (percentage >= 90) return "A+";
                if (percentage >= 80) return "A";
                if (percentage >= 70) return "B";
                if (percentage >= 60) return "C";
                if (percentage >= 50) return "D";
                return "Fail";
        }
    }
}
