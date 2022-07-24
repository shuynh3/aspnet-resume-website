using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Techlanguages
{
    public class TechlanguagesViewComponent : ViewComponent
    {
        public TechlanguagesViewComponent()
        {
        }

        public IViewComponentResult Invoke(bool mobile = false)
        {
            if (mobile == true)
                return View("TechLanguagesMobile");
            return View("TechLanguages");
        }
    }
}
