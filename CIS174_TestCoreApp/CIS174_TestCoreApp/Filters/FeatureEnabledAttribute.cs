using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CIS174_TestCoreApp.Filters
{
    public class FeatureEnabledAttribute : Attribute, IResourceFilter
    {
        public bool IsEnabled { get; set; }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (!IsEnabled)
            {
                context.Result = new BadRequestResult();
            }

            // {673DF066-00F7-4E78-9A8C-945BB9753A22}
            Guid requestId = Guid.NewGuid();

            context.HttpContext.Items.Add("Request ID", requestId);
        }

        

        public void OnResourceExecuted(ResourceExecutedContext context) { }
    }
}
