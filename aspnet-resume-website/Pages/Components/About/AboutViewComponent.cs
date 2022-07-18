using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Skills
{
    public class AboutViewComponent : ViewComponent
    {
        public AboutViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("About");
        }
    }
}
