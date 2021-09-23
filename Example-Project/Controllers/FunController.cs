using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Example_Project.Controllers
{
    public class FunController : ApiController
    {
        //create some methods
        //GET api/fun{id}
        //OUTPUT: Hello
        public string Get(int id) 
        {
            var half = id / 2;
            string message =  "Half of " + id.ToString() + " is " + half.ToString();
            return message;
        }
        //GET api/fun
        public string Post() 
        {
            return "Hello - you made a POST call";
        }
    }
}
