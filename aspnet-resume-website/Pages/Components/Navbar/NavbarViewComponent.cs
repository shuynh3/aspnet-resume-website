using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Navbar
{
    public class NavbarViewComponent : ViewComponent
    {
        public NavbarViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View("Navbar");
        }
    }
}
