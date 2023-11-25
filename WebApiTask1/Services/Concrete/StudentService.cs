using WebApiTask1.Entities;
using WebApiTask1.Repositories.Abstract;
using WebApiTask1.Services.Abstract;

namespace WebApiTask1.Services.Concrete
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Add(Student entity)
        {
            _studentRepository.Add(entity); 
        }

        public void Delete(int id)
        {
           var item = _studentRepository.Get(id);
            _studentRepository.Delete(item);    
        }

        public IEnumerable<Student> GatAll()
        {
           return _studentRepository.GetAll();      
        }

        public Student Get(int id)
        {
            return _studentRepository.Get(id);  
        }

        public void Update(Student entity)
        {
            _studentRepository.Update(entity);  
        }
    }
}
