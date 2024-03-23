using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.MainLayoutViewComponent
{
    public class _NavHeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
