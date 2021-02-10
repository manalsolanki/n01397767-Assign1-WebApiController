using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01397767_Assign1_WebApiController.Controllers
{
    // <objective>
    //      To calculate the hosting cost of a website which would 
    //      include number of days it is hosted , charge per day and
    //       a total with HST.
    //</objective>
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method returns string array when recieves a get request with a parameter(integer).
        ///STEP:1 The input parameter which is recieved are the number of days .
        ///STEP:2 We will calculate number of fortnight by Math.Ceiling(((decimal)days + 1) / 14).
        ///STEP:3 For 1 fortnight it cost 5.50$ so, we will calculate for number of fortnight got on step:2.
        ///STEP:4 HST is 13%, so calculate the hst with the help of ((result of Step:3)*13)/100.
        ///STEP:5 Total = STEP:3 + STEP:4.
        /// <example>
        /// GET api/HostingCost/14 =>
        /// 2 fortnights at $5.50/FN = $11.00 CAD
        /// HST 13% = $1.43 CAD
        /// Total = $12.43 CAD
        /// </example>
        /// </summary>
        /// <param name="id">This is an input integer for number of days.</param>
        /// <returns>3 strings describing the total cost of hosting.</returns>
       
        public IEnumerable<string> Get(int id)
        {
            int days = id;
            decimal basicCost = 5.50M;
            decimal hst = 13;
            decimal total;
            string[] result = new string[3];
            decimal fortnight = Math.Ceiling(((decimal)days + 1) / 14);
            decimal computedCost = basicCost * fortnight;
            decimal computedHst = Math.Round((computedCost * hst) / 100 , 2);
            total = computedCost + computedHst;

            result[0] = $"{fortnight} fortnights at ${basicCost}/FN = ${computedCost} CAD";
            result[1] = $"HST {hst}% = ${computedHst} CAD";
            result[2] = $"Total = ${total} CAD";
            return result;
        }
    }
}
