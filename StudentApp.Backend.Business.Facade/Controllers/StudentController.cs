using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Backend.Business.Logic.Contracts;
using StudentApp.Backend.Common.Logic;
using StudentApp.Backend.Common.Logic.Contracts;

namespace StudentApp.Backend.Business.Facade.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IBusinessLogic businessLogic;
        private readonly IMyLog logger;

        public StudentController(IBusinessLogic businessLogic, IMyLog logger)
        {
            this.businessLogic = businessLogic;
            this.logger = logger;
            this.logger.Init(MethodBase.GetCurrentMethod().DeclaringType);
        }

        // GET api/Student
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(businessLogic.GetAll());
        }

        // GET api/Student/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(this.businessLogic.GetById(id));
        }

        // POST api/Student
        [HttpPost]
        public IActionResult Post([FromBody]Student student)
        {
            return Ok(this.businessLogic.Add(student));
        }

        // DELETE api/Student/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this.businessLogic.Delete(id);
            return Ok();
        }
    }
}
