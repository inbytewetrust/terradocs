using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApp.Controllers
{
    public class DocumentsController : ApiController
    {
        [HttpPost]
        [Route("docs/register")]
        public HttpResponseMessage RegisterNewDocument(string document)
        {
            
            return Request.CreateResponse(HttpStatusCode.OK, "Документ зарегистрирован");
        }
    }
}
