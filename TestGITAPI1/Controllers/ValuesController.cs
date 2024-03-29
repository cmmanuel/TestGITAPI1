﻿using System.Collections.Generic;
using System.Web.Http;


namespace TestGITAPI1.Controllers
{
    public class ValuesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public string Get(int id)
        {
            return $"value: {id}";
        }
    }
}