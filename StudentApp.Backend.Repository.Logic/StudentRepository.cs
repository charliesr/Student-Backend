
using StudentApp.Backend.Common.Logic;
using StudentApp.Backend.Common.Logic.Contracts;
using StudentApp.Backend.Repository.Logic.Contracts;
using StudentApp.Backend.Repository.Logic.DataBaseContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace StudentApp.Backend.Repository.Logic
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext studentContext;
        private readonly IMyLog logger;

        public StudentRepository(StudentContext studentContext, IMyLog logger)
        {
            this.studentContext = studentContext;
            this.logger = logger;
            this.logger.Init(MethodBase.GetCurrentMethod().DeclaringType);
        }

        public Student Add(Student student)
        {
            this.logger.Debug("Adding a Student");
            using (var context = this.studentContext)
            {
                context.Students.Add(student);
                context.SaveChanges();
                return GetByGuid(student.Guid);
            }
            
        }

        public List<Student> GetAll()
        {
            this.logger.Debug("Listing all Student");

            using (var context = this.studentContext)
            {
                var result = new List<Student>();
                foreach (var student in context.Students)
                {
                    result.Add(student);
                }
                return result;
            }
        }

        public Student GetByGuid(Guid guid)
        {
            using (var context = this.studentContext)
            {
                return context.Students
                    .Where(stu => stu.Guid == guid)
                    .FirstOrDefault();
            }
        }

        public Student GetById(int id)
        {
            this.logger.Debug("Obtaining student by id");

            using (var context = this.studentContext)
            {
                return context.Students
                .Find(id);
            }

        }

        public Student Update(Student student)
        {
            logger.Debug("Editing student");
            using (var context = this.studentContext)
            {
                var studentToUpdate = context.Students
                    .Find(student.ID);
                studentToUpdate.Apellidos = student.Apellidos;
                studentToUpdate.Nombre = student.Nombre;
                studentToUpdate.FechaDeNacimiento = student.FechaDeNacimiento;
                studentToUpdate.FechaHoraRegistro = student.FechaHoraRegistro;
                studentToUpdate.DNI = student.DNI;
                studentToUpdate.Edad = student.Edad;
                context.SaveChanges();
                return GetById(student.ID);
            }

        }
        public void Delete(int id)
        {
            logger.Debug("Deleting student");
            using (var context = this.studentContext)
            {
                var studentToDelete = context.Students
                    .Find(id);
                context.Students.Remove(studentToDelete);
                context.SaveChanges();
            }
        }
    }
}
