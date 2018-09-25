using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationApi.Controllers
{
    //public class student_values
    //{
    //    public string username { get; set; }
    //    public string Password { get; set; }
    //    public string Dob { get; set; }
    //    public string Department { get; set; }
    //    public int mark1 { get; set; }
    //    public int mark2 { get; set; }
    //}
    public class sampleController : ApiController
    {
        //List<student_values> sv1 = new List<student_values>();
        Student_recordsEntities sdb = new Student_recordsEntities();


        [HttpGet]
        [Route("api/sample/getrecord")]
        public IHttpActionResult GetRecord()
        {
            return Ok("hello");
        }


    }
}
