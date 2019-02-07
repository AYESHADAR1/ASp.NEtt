using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProjectSp.Models;
using Newtonsoft.Json;

namespace MyProjectSp.Controllers
{
    [Route("api/[controller]")]
    public class assignmentController : ControllerBase
    {
        public readonly MyDbContext db;
        public assignmentController(MyDbContext mydbcontext)
        {
            db = mydbcontext;
        }

        //  api/<controller> for GET (ret. List)
        [HttpGet]
        public IEnumerable<string> Get()
        {
            IEnumerable<Course> course = from v in db.course
                                         select v;
            course.ToList();
            String result = JsonConvert.SerializeObject(course.ToList());
            yield return result;

        }

        // GET api/<controller>/5 for one item
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Assignment assignment)
        {
            db.assignment.Add(assignment);

        }

        // PUT api/<controller>/5 
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Assignment assignment)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}