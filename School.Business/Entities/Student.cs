namespace Escola.Escola.Business.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public int IdCourse { get; set; }
        public Course Course { get; set; }
    }
}
