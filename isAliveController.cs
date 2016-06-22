using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppCacheDemo_1.Controllers
{
    public class T_t
    {
        public Boolean v;
    }
    public class isAliveController : ApiController
    {
        public T_t Get()
        {
            //throw new Exception("isAlive Exception");
            var v = new T_t();
            v.v = true;
            return v;
        }

        /*need random number generator to randomize true/false response
         * generate random integer from 1-10
         * for (i<6) { v = true }
         * else { v = false }
         * can change percentage of time v is equal to true and false
        */

    }

    
}
