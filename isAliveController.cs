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
            var v = new T_t();
            v.v = true;
            return v;
        }
    }

    
}
