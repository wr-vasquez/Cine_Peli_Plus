using System.Web;
using System.Web.Mvc;

namespace App_Cine_Peli_Plus
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
