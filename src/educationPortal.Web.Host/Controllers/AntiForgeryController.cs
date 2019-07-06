using Microsoft.AspNetCore.Antiforgery;
using educationPortal.Controllers;

namespace educationPortal.Web.Host.Controllers
{
    public class AntiForgeryController : educationPortalControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
