using System.Security.Claims;
using WiseProject.Business.Abstract;

namespace WiseProject.Business.Concrete
{
    public class CurrentUserManager : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CurrentUserManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private string GetClaim(string claim)
        {
            var userType = _httpContextAccessor.HttpContext.User.FindFirst(claim);

            if (userType == null || !userType.Subject.IsAuthenticated)
                return "";
            return userType.Value;
        }

        public string UserId()
        {
            return GetClaim(ClaimTypes.NameIdentifier);
        }
    }
}
