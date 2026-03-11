using Escola.Escola.Business.DTOs;
using Escola.Escola.Business.Entities;
using Escola.Escola.Business.Interfaces.IRepositories;
using Escola.Escola.Data.Contexts;

namespace Escola.Escola.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }
        public Student FindByEmail(string Email)
        {
            return _context.Students.FirstOrDefault(s => s.Email == Email);
        }

        public void Create(StudentDTO dto)
        {
            var studentDto = new Student
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                IdCourse = dto.IdCourse
            };
            _context.Students.Add(studentDto);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var student = FindById(Id);
            if (student != null) {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }

        public List<Student> FindAll()
        {
            return _context.Students
                .Select(s => new Student
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Email = s.Email,
                    IdCourse = s.IdCourse,
                    Course = new Course
                    {
                        Id = s.Id,
                        Name = s.Course.Name
                    }
                }).ToList();
        }

        public Student FindById(int Id)
        {
            return _context.Students.Select(s => new Student
            {
                Id = s.Id,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Email = s.Email,
                IdCourse = s.IdCourse,
                Course = new Course
                {
                    Name = s.Course.Name
                }
            }).FirstOrDefault(c => c.Id == Id);

        }

        public void Update(int Id, StudentDTO dto)
        {
            var student = FindById(Id);
            if (student != null)
            {
                student.FirstName = dto.FirstName;
                student.LastName = dto.LastName;
                student.Email = dto.Email;
                _context.Students.Update(student);
                _context.SaveChanges();
            }
        }
    }
}