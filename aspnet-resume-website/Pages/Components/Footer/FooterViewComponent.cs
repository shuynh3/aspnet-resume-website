using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        public FooterViewComponent()
        {

        }
        public IViewComponentResult Invoke(bool mobile = false)
        {
            if (mobile == true)
                return View("FooterMobile");
            return View("Footer");
        }
    }
}
