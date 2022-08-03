Using System;
Using System.Collections.Generic;
Using System.Linq;
Using System.Net;
Using System.Net.Http;
Using System.Web.Http;

Namespace WebApplication1.Controllers
{
    Public Class ValuesController :  ApiController
    {
        // GET api/values
        Public IEnumerable<String> Get()
        {
            Return New String[] { "value1", "value2" };
        }

        // GET api/values/5
        Public String Get(int id)
        {
            Return "value";
        }

        // POST api/values
        Public void Post([FromBody] String value)
        {
        }

        // PUT api/values/5
        Public void Put(int id, [FromBody] String value)
        {
        }

        // DELETE api/values/5
        Public void Delete(int id)
        {
        }
    }
}