using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProjectSp.Models;

namespace MyProjectSp.Controllers
{
    [Route("api/[controller]")]
    public class joinController : ControllerBase
    {
        public readonly MyDbContext db;
        public joinController(MyDbContext mydbcontext)
        {
            db = mydbcontext;
        }
        [HttpPost]
        public String Post([FromBody]Join join) {
            db.joins.Add(join);
            return "Created User Successfully!!!";
        }


    }
}