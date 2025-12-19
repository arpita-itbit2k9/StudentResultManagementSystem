namespace StudentResultManagementSystem.Data.DTO
{
    public class StudentResultCsv
    {
        public int RollNumber { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public int Marks { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
        public string Grade { get; set; }
    }
}
