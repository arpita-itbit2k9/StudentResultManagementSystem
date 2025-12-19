namespace StudentResultManagementSystem.Contracts.Model
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
