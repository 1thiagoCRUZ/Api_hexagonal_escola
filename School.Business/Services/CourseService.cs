using Escola.Escola.Business.DTOs;
using Escola.Escola.Business.Entities;
using Escola.Escola.Business.Interfaces.IRepositories;
using Escola.Escola.Business.Interfaces.IServices;

namespace Escola.Escola.Business.Services
{
    public class CourseService: ICourseService
    {
        private readonly ICourseRepository _repo;
        public CourseService(ICourseRepository repo)
        {
            _repo = repo;
        }

        public void Create(CourseDTO dto)
        {
            if (dto == null)
            {
                throw new ArgumentException("The courses data cannot be empty or null");
            }
            _repo.Create(dto);
        }

        public void Delete(int Id)
        {
            var course = _repo.FindById(Id);
            if (course == null)
            {
                throw new Exception("Course not found.");
            }
            _repo.Delete(Id);
        }

        public List<Course> FindAll()
        {
            return _repo.FindAll();
        }

        public Course FindById(int Id)
        {
            return _repo.FindById(Id);
        }

        public void Update(int Id, CourseDTO dto)
        {
            var courseId = _repo.FindById(Id);
            if (courseId == null)
            {
                throw new Exception("Course not found.");
            }
            var course = new CourseDTO

            {
                Name = dto.Name
            };
            _repo.Update(courseId.Id, course);
        }
    }
}
