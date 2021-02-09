using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01397767_Assign1_WebApiController.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adds 10 more to the input number(integer)
        /// result variable stores the value of 10 added to the input.
        /// <example>
        /// GET api/AddTen/10 -> 20
        /// GET api/AddTen/-1 -> 9
        /// </example>
        /// </summary>
        /// <param name="id">The input integer</param>
        /// <returns>10 Added to the input</returns>
        // 
        public int Get(int id)
        {
            int result = id + 10;
            return result;
        }
    }
}
