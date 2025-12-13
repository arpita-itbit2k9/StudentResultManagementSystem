using StudentResultManagementSystem.BusinessLogic.Model;

namespace StudentResultManagementSystem.BusinessLogic.Operation
{
    public class StudentResult
    {
        public int TotalMarks { get; set; }
        public int ObtainedMarks { get; set; }
        public double percentage { get; set; }
        public string Grade { get; set; }

        public Student Student { get; set; }

        public int CalculateTotalMarks()
        {

            int total = 0;

            foreach (var subject in Student.Subjects)
            {
                total += subject.MaxMarks;
            }
            TotalMarks = total;
            return total;
        }

        public int CalculateObtainedMarks()
        {
            int obtained = 0;
            foreach (var subject in Student.Subjects)
            {
                obtained += subject.Marks;
            }
            ObtainedMarks = obtained;
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
