using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Net.Http;
using System.Net;
using System.Linq;

namespace WebApp.mine.ActionFilters
{
    public class DocumentValidationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                var error = actionContext.ModelState.Values
                    .SelectMany(e => e.Errors.Select(i => i.ErrorMessage))
                    .First();

                actionContext.Response = actionContext.Request.CreateResponse(
                    HttpStatusCode.BadRequest,
                    error);
            }
        }
    }
}