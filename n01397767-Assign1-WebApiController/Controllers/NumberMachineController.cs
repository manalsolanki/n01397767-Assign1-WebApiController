using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01397767_Assign1_WebApiController.Controllers
{
   /// <objective>
   /// Apply different mathematical operations to the number and return the result.
   /// </objective>
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method returns a decimal number(rounded up by 3 decimals) when 
        /// recieves a get reqest with paramter(integer).
        /// We would convert the integer data type to decimal 
        /// by assiging it to the variable having data type decimal.
        /// Different operations that are performed on the parameter are:
        /// 1. Division -> value/value
        /// 2. Multiplication -> value*value
        /// 3. Addtion -> Step 1 + Step 2
        /// 4. Substraction -> Step 3 - value
        /// 5. Divison -> Step 4 /value
        /// <example>GET api/numberMachine/7 -> 6.143 </example>
        /// <example>GET api/numberMachine/4 -> 3.25 </example>
        /// </summary>
        /// <param name="id">This is the input integer</param>
        /// <returns>The result(decimal) computed on step-5 will return.</returns>
        //
        public decimal Get(int id)
        {
            decimal value = id;
            decimal result = Math.Round(((((value / value) + value * value) - value) / value),3);
            return result ;
        }
    }
}
