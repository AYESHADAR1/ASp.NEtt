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
    public class CourseController : ControllerBase
    {
        public readonly MyDbContext db;
        public CourseController(MyDbContext mydbcontext)
        {
            db = mydbcontext;
        }



        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {

            IEnumerable<Course> course = from v in db.course
                                         select v;
            course.ToList();
            String result = JsonConvert.SerializeObject(course.ToList());
            yield return result;

            //Course c = new Course();

            // return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public String Get(int id)
        {
            IEnumerable<Course> course = from v in db.course

                                         select v;


            course.ToList();
            String result = JsonConvert.SerializeObject(course.ToList());
            // string result1 = result;


             return "value";

            }
        }
}