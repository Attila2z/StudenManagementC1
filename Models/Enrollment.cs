namespace StudentManagement.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        // From:
        // public string Grade { get; set; } = string.Empty;
        // To:
        public string FinalGrade { get; set; } = string.Empty;

        // Navigation properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
