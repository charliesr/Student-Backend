using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentApp.Backend.Common.Logic;
using StudentApp.Backend.Repository.Logic;
using StudentApp.Backend.Repository.Logic.Contracts;
using StudentApp.Backend.Repository.Logic.DataBaseContexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkTest
{
    [TestClass]
    public class EntityFrameworkTest
    {
        private IStudentRepository repositrory;

        [TestInitialize]
        public void Init()
        {
            this.repositrory = new StudentRepository(new StudentContext(), new Log4NetLogger());
        }

        public static IEnumerable<object[]> StudentData()
        {
            yield return new object[] { new Student(Guid.NewGuid(), "45687654h", "Daniel", "Madrigal", 28, Convert.ToDateTime("24/06/1990"), Convert.ToDateTime("05/09/2017")) };
            yield return new object[] { new Student(Guid.NewGuid(), "46546546h", "Rebeca", "Barreira", 29, Convert.ToDateTime("24/06/1989"), Convert.ToDateTime("07/11/2016")) };
        }
        [DataTestMethod]
        [DynamicData(nameof(StudentData), DynamicDataSourceType.Method)]
        public void SqlDaoTest(Student alumno)
        {

            var alumno_devuelto = repositrory.Add(alumno);

            Assert.IsTrue(alumno.Equals(alumno_devuelto));
            Assert.IsTrue(alumno.ID > 0);

        }


        [DataTestMethod]
        [DynamicData(nameof(StudentData), DynamicDataSourceType.Method)]
        public void GetAllTest(Student alumno)
        {
            repositrory.Add(alumno);
            repositrory = new StudentRepository(new StudentContext(), new Log4NetLogger());
            var alumnos = repositrory.GetAll();

            Assert.IsTrue(alumnos.Count > 0);

        }
    }
}
