using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Paypalproject
{
    public class PaypalprojectViewComponent : ViewComponent
    {
        public PaypalprojectViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Paypalproject");
        }
    }
}
