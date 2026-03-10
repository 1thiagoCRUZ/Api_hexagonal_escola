using Escola.Escola.Business.DTOs;
using Escola.Escola.Business.Entities;
using Escola.Escola.Business.Interfaces.IRepositories;
using Escola.Escola.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Escola.Escola.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _context;
        public CourseRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(CourseDTO dto)
        {
            var courseDto = new Course
            {
                Name = dto.Name
            };
            _context.Courses.Add(courseDto);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var course = FindById(Id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }

        public List<Course> FindAll()
        {
            return _context.Courses.ToList();
        }

        public Course FindById(int Id)
        {
            return _context.Courses.Select(c => new Course
            {
                Id = c.Id,
                Name = c.Name,
                Students = c.Students.Select(s => new Student
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Email = s.Email,
                    IdCourse = s.IdCourse,
                }).ToList()
            }).FirstOrDefault(c => c.Id == Id);
        }

        public void Update(int Id, CourseDTO dto)
        {
            var course = FindById(Id);
            if (course != null)
            {
                course.Name = dto.Name;
                _context.Courses.Update(course);
                _context.SaveChanges();
            }
        }
    }
}
