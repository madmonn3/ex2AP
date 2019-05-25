﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ex3.Controllers
{
    public class DisplayController : ApiController
    {
        // GET: api/Display
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Display/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Display
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Display/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Display/5
        public void Delete(int id)
        {
        }
    }
}
