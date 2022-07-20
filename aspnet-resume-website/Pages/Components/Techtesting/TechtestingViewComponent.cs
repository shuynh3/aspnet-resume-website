using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Techtesting
{
    public class TechtestingViewComponent : ViewComponent
    {
        public TechtestingViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Techtesting");
        }
    }
}
