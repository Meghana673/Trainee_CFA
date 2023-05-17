namespace TE_CFA.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public string Section { get; set; }
    }
    public class StudentsLayer
    {
        public Student GetById(int StudentID)
        {
        
            Student student = new Student()
            {
                StudentID = StudentID,
                Name = "James",
                Gender = "Male",
                Branch = "CSE",
                Section = "A",
            };
            return student;
        }
    }
}
