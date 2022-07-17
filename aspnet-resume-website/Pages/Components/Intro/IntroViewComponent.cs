using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Intro
{
    public class IntroViewComponent : ViewComponent
    {
        public IntroViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Intro");
        }
    }
}
