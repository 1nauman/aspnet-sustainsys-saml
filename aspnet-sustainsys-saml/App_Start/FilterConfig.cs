using System.Web;
using System.Web.Mvc;

namespace aspnet_sustainsys_saml
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
