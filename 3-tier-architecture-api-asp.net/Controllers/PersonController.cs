using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _3_tier_architecture_api_asp.net.Controllers
{
    public class PersonController : ApiController
    {
        //get person api
        [HttpGet]
        [Route("api/demo")]
        public HttpResponseMessage Get()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

    }
}
