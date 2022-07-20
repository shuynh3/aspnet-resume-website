using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Techweb
{
    public class TechwebViewComponent : ViewComponent
    {
        public TechwebViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Techweb");
        }
    }
}
