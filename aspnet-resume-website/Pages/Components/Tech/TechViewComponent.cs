using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Tech
{
    public class TechViewComponent : ViewComponent
    {
        public TechViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Tech");
        }
    }
}
