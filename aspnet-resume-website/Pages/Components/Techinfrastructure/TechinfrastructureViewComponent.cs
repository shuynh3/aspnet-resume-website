using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Techinfrastructure
{
    public class TechinfrastructureViewComponent : ViewComponent
    {
        public TechinfrastructureViewComponent()
        {
        }

        public IViewComponentResult Invoke(bool mobile = false)
        {
            if (mobile == true)
                return View("TechInfrastructureMobile");
            return View("TechInfrastructure");
        }
    }
}
