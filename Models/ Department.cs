namespace StudentManagement.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }

        // Relationship: a Department has one DepartmentHead (which is an Instructor)
        public int? DepartmentHeadId { get; set; }
        public Instructor? DepartmentHead { get; set; }
    }
}
