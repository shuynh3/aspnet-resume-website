using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        public FooterViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View("Footer");
        }
    }
}
