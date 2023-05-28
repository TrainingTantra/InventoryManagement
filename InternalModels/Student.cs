namespace InternalModels
{
    public class Student
    {
        public IEnumerable<StudentDetails>? StuDetails { get; set; }
    }
    public class StudentDetails
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}