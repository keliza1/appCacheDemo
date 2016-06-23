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

            Random rg = new Random(); 
            double n = rg.NextDouble(); 
            if (n <= 0.5)
            {
                v.v = true;
            }
            else
            {
                v.v = false;
            }

            //v.v = true;
            return v;
        }

    }

}
