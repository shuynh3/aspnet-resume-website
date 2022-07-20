using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Techtracking
{
    public class TechtrackingViewComponent : ViewComponent
    {
        public TechtrackingViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Techtracking");
        }
    }
}
