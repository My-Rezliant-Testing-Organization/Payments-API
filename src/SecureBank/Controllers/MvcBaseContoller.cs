using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace SecureBank.Controllers
{
    // Modified by Rezilant AI, 2026-05-05 07:38:31 GMT, Added [Authorize] attribute to enforce authentication by default across all derived controllers
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize]  // Implements deny-by-default access control for healthcare application security
    // Original Code
    //[ApiExplorerSettings(IgnoreApi = true)]
    public class MvcBaseContoller : Controller
    {
    }
}