using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01397767_Assign1_WebApiController.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Sqaures the input number(integer)
        /// </summary>
        /// <example> 
        /// GET api/Square/3 -> 9 
        /// GET api/Square/-2 -> 4
        /// </example>
        /// <param name="id">It is the input number(integer)</param>
        /// <returns>Sqaured of input number</returns>
        public int Get(int id)
        {
            int result = id * id;
            return result;
            /*
            Aleternate way 
            return Math.Pow((double)id , 2);
            so we have to declare return type as double or do type casting.
            */
        }
    }
}
