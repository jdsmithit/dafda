using System;
using System.Threading.Tasks;

namespace Outbox.Domain
{
    public interface IStudentRepository
    {
        ValueTask<Student> FindById(Guid studentId);
        Task Save(Student student);
    }
}