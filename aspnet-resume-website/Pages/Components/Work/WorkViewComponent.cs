using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Skills
{
    public class WorkViewComponent : ViewComponent
    {
        public WorkViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Work");
        }
    }
}
