using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using PassangerServices.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerServices.Controllers
{
    [System.Web.Mvc.Route("api/[controller]")]
    [ApiController]
    public class PassangerController : System.Web.Mvc.ControllerBase
    {
        

        public IEnumerable<Passanger> Get()
        {
            Passanger p1 = new Passanger();
            Passanger p2 = new Passanger();

            p1.PassangerId = 100;
            p1.PassangerName = "Ben Jones";
            p1.PickupLocation = "New Jersey";

            p1.PassangerId = 101;
            p1.PassangerName = "Joe";
            p1.PickupLocation = "Texas";

            List<Passanger> plist = new List<Passanger>();
            plist.Add(p1);
            plist.Add(p2);

            return plist;

        }

        [System.Web.Mvc.HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        [System.Web.Mvc.HttpPost]
        public void Post([Microsoft.AspNetCore.Mvc.FromBody] string value)
        {
        }

        // PUT api/<CustomersController>/5
        [System.Web.Mvc.HttpPut]
        public void Put(int id, [Microsoft.AspNetCore.Mvc.FromBody] string value)
        {
        }

        protected override void ExecuteCore()
        {
            throw new NotImplementedException();
        }
    }
}