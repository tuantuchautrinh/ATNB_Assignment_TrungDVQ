using System.Web;
using System.Web.Mvc;

namespace ATNB_Assignment_TrungDVQ
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
