using Microsoft.AspNetCore.Mvc;


namespace FoodService.ViewComponents
{
    public class LoginLogoutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
