using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Photographyproject
{
    public class PhotographyprojectViewComponent : ViewComponent
    {
        public PhotographyprojectViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Photographyproject");
        }
    }
}
