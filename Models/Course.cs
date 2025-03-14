namespace StudentManagement.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // Navigation property: one course can have multiple enrollments
        public List<Enrollment> Enrollments { get; set; }
    }
}
