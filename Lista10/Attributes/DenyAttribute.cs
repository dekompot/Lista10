using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lista10.Attributes
{
    public class DenyRoleAttribute : TypeFilterAttribute
    {
        public DenyRoleAttribute(string roleName) : base(typeof(DenyRoleFilter))
        {
            Arguments = new object[] { roleName };
        }
    }

    public class DenyRoleFilter : IAuthorizationFilter
    {
        private readonly string _roleName;

        public DenyRoleFilter(string roleName)
        {
            _roleName = roleName;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var isUserInRole = context.HttpContext.User.IsInRole(_roleName);

            if (isUserInRole)
            {
                context.Result = new ForbidResult();
            }
        }
    }
}
