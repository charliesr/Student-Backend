using StudentApp.Backend.Common.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Backend.Repository.Logic.Contracts
{
    public interface IStudentRepository
    {
        Student Add(Student student);
        Student GetById(int id);
        Student GetByGuid(Guid guid);
        List<Student> GetAll();
        Student Update(Student student);
        void Delete(int id);
        void DeleteAll();
    }
}
