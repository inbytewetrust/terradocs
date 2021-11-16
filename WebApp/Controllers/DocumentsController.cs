using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

using WebApp.mine.ModelBinders;
using WebApp.mine.ActionFilters;
using Core.Domain.Documents.Common;

namespace WebApp.Controllers
{
    public class DocumentsController : ApiController
    {
        [HttpPost]
        [Route("docs/register")]
        [DocumentValidationFilter]
        public HttpResponseMessage RegisterNewDocument([ModelBinder(typeof(DocumentBinder))] Документ document)
        {
            if (document == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Неизвестный вид документа");

            return Request.CreateResponse(HttpStatusCode.OK, "Документ зарегистрирован");
        }
    }
}
