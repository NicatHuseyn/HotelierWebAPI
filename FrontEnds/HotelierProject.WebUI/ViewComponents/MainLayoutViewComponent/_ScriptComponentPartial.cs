using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.MainLayoutViewComponent
{
    public class _ScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
