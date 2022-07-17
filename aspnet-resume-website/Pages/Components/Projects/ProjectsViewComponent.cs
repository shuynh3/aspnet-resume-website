using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Projects
{
    public class ProjectsViewComponent : ViewComponent
    {
        public ProjectsViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Projects");
        }
    }
}
