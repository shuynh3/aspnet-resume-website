using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Interests
{
    public class InterestsViewComponent : ViewComponent
    {
        public InterestsViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Interests");
        }
    }
}
