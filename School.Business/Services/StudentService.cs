using Escola.Escola.Business.DTOs;
using Escola.Escola.Business.Entities;
using Escola.Escola.Business.Interfaces.IRepositories;
using Escola.Escola.Business.Interfaces.IServices;

namespace Escola.Escola.Business.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;
        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public void Create(StudentDTO dto)
        {
            if (dto.FirstName == null || dto.FirstName == "")
            {
                throw new Exception("First name cannot be empty or null");
            }
            if (dto.FirstName.Length > 50)
            {
                throw new Exception("First name is too long");
            }
            if (dto == null)
            {
                throw new Exception("The students data cannot be empty or null");
            }
            if (dto.Email.Contains("@faculdade.edu"))
            {
                var emailExists = _repo.FindByEmail(dto.Email);
                if(emailExists == null)
                {
                    _repo.Create(dto);
                }
                else
                {
                    throw new Exception("The email provided is already in use");
                }
            }
            else
            {
                throw new Exception("The email is invalid");
            }
        }

        public void Delete(int Id)
        {
            var student = _repo.FindById(Id);
            if (student == null)  throw new Exception("Student not found.");
            _repo.Delete(Id);
        }

        public List<Student> FindAll()
        {
            return _repo.FindAll();
        }

        public Student FindById(int Id)
        {
            return _repo.FindById(Id);
        }

        public Student FindByEmail(string Email)
        {
            return _repo.FindByEmail(Email);
        }


        public void Update(int Id, StudentDTO dto)
        {
            var studentId = _repo.FindById(Id);
            if (studentId == null)
            {
                throw new Exception("Student not found.");
            }
            var student = new StudentDTO
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email
            };
            _repo.Update(studentId.Id, student);
        }
    }
}
