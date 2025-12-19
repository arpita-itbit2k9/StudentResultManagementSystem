namespace StudentResultManagementSystem.Contracts.Model
{
    public class SubjectMarks
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public int MaxMarks { get; set; }
        public int MinMarks { get; set; }

        public int Marks { get; set; }
    }
}
