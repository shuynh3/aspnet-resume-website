using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Techtracking
{
    public class TechtrackingViewComponent : ViewComponent
    {
        public TechtrackingViewComponent()
        {
        }

        public IViewComponentResult Invoke(bool mobile = false)
        {
            if (mobile == true)
                return View("TechTrackingMobile");
            return View("TechTracking");
        }
    }
}
