using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Hobbies
{
    public class HobbiesViewComponent : ViewComponent
    {
        public HobbiesViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Hobbies");
        }
    }
}
