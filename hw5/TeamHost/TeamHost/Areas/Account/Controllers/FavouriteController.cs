using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Areas.Account.Controllers;
[Area("Account")]
public class FavouriteController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}