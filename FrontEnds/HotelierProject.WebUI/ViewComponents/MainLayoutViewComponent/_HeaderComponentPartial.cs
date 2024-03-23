using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.MainLayoutViewComponent
{
    public class _HeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
