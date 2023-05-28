using InternalModels;

namespace CommonData
{
    public class StudentMock
    {
        public static Student StudentMockData()
        {
            Student student = new Student()
            {
                StuDetails = new List<StudentDetails>()
                {
                    new StudentDetails()
                    {
                        Id= 1,
                        Name="mani"
                    },
                    new StudentDetails()
                    {
                        Id= 2,
                        Name="manoj"
                    }
                }
            };
            return student;
        }
    }
}