using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Techlanguages
{
    public class TechlanguagesViewComponent : ViewComponent
    {
        public TechlanguagesViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Techlanguages");
        }
    }
}
