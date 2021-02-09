using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01397767_Assign1_WebApiController.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns a string when recieves a post request.
        ///<example>POST api/Greeting</example>
        /// </summary>
        /// <returns>"Hello World"</returns>
        public string Post()
        {
            return "Hello World!";
        }


        /// <summary>
        /// This method returns a string with the input parameter(integer) 
        /// when recieves a get request with an integer.
        /// <example>
        /// Get api/Greeting/3 ->"Greetings to 3 people!"
        /// Get api/Greeting/10 ->"Greetings to 10 people!"
        /// </example>
        /// </summary>
        /// <param name="id">This paramater is integer type</param>
        /// <returns>
        /// "Greeting to ${id} people!" where id = input parameter
        /// </returns>
        //
        public string Get(int id)
        {
            string msg = $"Greetings to {id} people!";
            return msg;
        }

    }
}
