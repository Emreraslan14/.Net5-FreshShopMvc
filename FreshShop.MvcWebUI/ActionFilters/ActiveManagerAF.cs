using FreshShop.Model.Entity;
using FreshShop.MvcWebUI.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FreshShop.MvcWebUI.ActionFilters
{
    public class ActiveManagerAF : ActionFilterAttribute
    {   
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Manager activeManager = context.HttpContext.Session.GetObject<Manager>("ActiveManager");

            if (activeManager != null)
                return;
            context.Result = new RedirectResult("/AdminPanel");

        }
    }
}
