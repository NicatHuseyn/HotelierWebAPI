using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.MainLayoutViewComponent
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
