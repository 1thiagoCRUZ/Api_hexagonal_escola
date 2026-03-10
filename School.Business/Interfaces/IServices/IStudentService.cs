using Escola.Escola.Business.DTOs;
using Escola.Escola.Business.Entities;

namespace Escola.Escola.Business.Interfaces.IServices
{
    public interface IStudentService
    {
        public Student FindById(int Id);

        public Student FindByEmail(string Email);

        public List<Student> FindAll();

        public void Create(StudentDTO dto);

        public void Update(int Id, StudentDTO dto);
        public void Delete(int Id);
    }
}
