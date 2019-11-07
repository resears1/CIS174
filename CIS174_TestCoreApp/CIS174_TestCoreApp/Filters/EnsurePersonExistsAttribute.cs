using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CIS174_TestCoreApp.Filters
{
    public class EnsurePersonExistsAttribute : TypeFilterAttribute
    {
        public EnsurePersonExistsAttribute() : base(typeof(EnsurePersonExistsFilter)) {}

        public class EnsurePersonExistsFilter : IActionFilter
        {
            private readonly PersonService _service;
            public EnsurePersonExistsFilter(PersonService service)
            {
                _service = service;
            }

            public void OnActionExecuting(ActionExecutingContext context)
            {
                var personId = (int) context.ActionArguments["id"];
                var personFirst = (string) context.ActionArguments["FirstName"];
                var personLast = (string) context.ActionArguments["LastName"];

                if (!_service.DoesPersonExist(personId))
                {
                    context.Result = new NotFoundResult();
                } else if (!_service.IsNameCorrect(personFirst, personLast))
                {
                    // I chose Bad Request for a completely arbitrary reason
                    // makes more sense because you're requesting a name that is different from what
                    // has been sent
                    context.Result = new BadRequestResult();
                }
            }

            public void OnActionExecuted(ActionExecutedContext context) { }
        }
    }
}
