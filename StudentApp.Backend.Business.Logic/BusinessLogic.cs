using StudentApp.Backend.Business.Logic.Contracts;
using StudentApp.Backend.Common.Logic;
using StudentApp.Backend.Common.Logic.Contracts;
using StudentApp.Backend.Repository.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace StudentApp.Backend.Business.Logic
{
    public class BusinessLogic : IBusinessLogic
    {

        private readonly IMyLog logger;
        private readonly IStudentRepository studentRepo;

        public BusinessLogic(IMyLog logger, IStudentRepository studentRepo)
        {
            this.studentRepo = studentRepo;
            this.logger = logger;
            this.logger.Init(MethodBase.GetCurrentMethod().DeclaringType);
        }
        public Student Add(Student student)
        {
            try
            {
                return this.studentRepo.Add(student);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                this.studentRepo.Delete(id);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }

        public List<Student> GetAll()
        {
            try
            {
                return studentRepo.GetAll();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }

        public Student GetByGuid(Guid guid)
        {
            try
            {
                return this.studentRepo.GetByGuid(guid);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            try
            {
                return this.studentRepo.GetById(id);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }

        public Student Update(Student student)
        {
            try
            {
                return this.studentRepo.Update(student);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }
    }
}
