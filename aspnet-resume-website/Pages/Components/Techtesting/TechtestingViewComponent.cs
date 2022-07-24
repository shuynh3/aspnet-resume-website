using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Techtesting
{
    public class TechtestingViewComponent : ViewComponent
    {
        public TechtestingViewComponent()
        {
        }

        public IViewComponentResult Invoke(bool mobile = false)
        {
            if (mobile == true)
                return View("TechTestingMobile");
            return View("TechTesting");
        }
    }
}
