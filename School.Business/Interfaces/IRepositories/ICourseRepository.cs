using Escola.Escola.Business.DTOs;
using Escola.Escola.Business.Entities;

namespace Escola.Escola.Business.Interfaces.IRepositories
{
    public interface ICourseRepository
    {
        public Course FindById(int Id);
        public List<Course> FindAll();
        public void Create(CourseDTO dto);
        public void Update(int Id, CourseDTO dto);
        public void Delete(int Id);
    }
}
