using System.Web;
using System.Web.Mvc;

namespace SummativeAssessment_PRG522_7595_DuncanBarnard
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
