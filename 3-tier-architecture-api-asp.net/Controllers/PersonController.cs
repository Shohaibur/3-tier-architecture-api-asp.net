using BLL.Services;
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
        [HttpGet]
        [Route("api/name/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
              var data =  PersonService.GetName(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

    }
}
