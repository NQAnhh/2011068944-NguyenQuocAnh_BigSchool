using System.Web;
using System.Web.Mvc;

namespace _2011068944_NguyenQuocAnh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
