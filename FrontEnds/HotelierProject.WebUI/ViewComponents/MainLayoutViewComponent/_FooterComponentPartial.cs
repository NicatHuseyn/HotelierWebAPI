using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.MainLayoutViewComponent
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
