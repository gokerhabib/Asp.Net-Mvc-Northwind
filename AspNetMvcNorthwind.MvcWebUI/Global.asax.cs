using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AspNetMvcNorthwind.Entities;
using AspNetMvcNorthwind.MvcWebUI.Infrastructure;
using AspNetMvcNorthwind.MvcWebUI.ModelBinders;

namespace AspNetMvcNorthwind.MvcWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Sabit Kodlar Her Projede kullanılabilir.
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
            
            System.Web.Mvc.ModelBinders.Binders.Add(typeof(Cart),new CartModelBinder());//ModelBinder Mvc ModelBindings
        }
    }
}
