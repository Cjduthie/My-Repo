using System.Web;
using System.Web.Mvc;

namespace UniversityofContoso
{
    public class FilterConfig // Used to specify & or create the object "FilterConfig" //
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) //Creates a public class that can be acessed by, //
            //RegisterGlobalFilter & any Assemly which references this. // //Static in this case is used to prevent it from being instanced. //
            //(put simply it means that it and its members cannot be externally instanced, or use the variable of the class type (RegisterGloablFilters). //
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
